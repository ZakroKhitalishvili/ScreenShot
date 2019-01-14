using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenShot
{
    public partial class ImageReadyForm : Form
    {
        private Bitmap snippedImage;
        private Graphics imageGraphics;
        private Bitmap temporaryImage;
        private Color brushColor;
        private Color markerColor;
        private bool isDrawing = false;
        private Point startingPoint;
        private string[] fileFilters = { "PNG|*.png;", "JPG|*.jpg;", "JPEG|*.jpeg;", "All files |*.*" };
        private List<Bitmap> history;
        private int currentHistoryIndex;

        public ImageReadyForm()
        {
            InitializeComponent();
        }

        public ImageReadyForm(Bitmap snippedImage)
        {
            InitializeComponent();

            history = new List<Bitmap>();
            history.Add((Bitmap)snippedImage.Clone());
            currentHistoryIndex = 0;

            this.snippedImage = snippedImage;
            pictureBox1.Image = snippedImage;
            imageGraphics = Graphics.FromImage(snippedImage);
            brushColor = Color.Red;
            markerColor = Color.FromArgb(120, Color.Yellow);
            colorButton.BackColor = Color.Red;

            saveFileDialog1.AddExtension = true;
            saveFileDialog1.CreatePrompt = false;
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.FileName = "Capture";
            saveFileDialog1.Filter = string.Join("|", fileFilters);

            saveButton.Text = FormResource.saveButtonText;
            paintRadioButton.Text = FormResource.paintRadioButtonText;
        }

        private void ImageReadyForm_Load(object sender, EventArgs e)
        {
            this.FormClosed += ImageReadyForm_FormClosed;
            paintRadioButton.Checked = true;
        }

        private void ImageReadyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            var dialogResult = colorDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                brushColor = colorDialog.Color;
                colorButton.BackColor = brushColor;
            }
        }

        private void ImageReadyForm_ResizeEnd(object sender, EventArgs e)
        {
            //panel1.Size = new Size(panel1.Size.Width,Convert.ToInt32(this.Size.Height * 0.8));
        }

        private void Drawing(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                if (paintRadioButton.Checked)
                {
                    if (Distance(startingPoint, e.Location) >= 10)
                    {
                        var pen = new Pen(brushColor);
                        var size = (float)brushSizeInput.Value;
                        pen.Width = size;

                        var ellipseLocation = e.Location;
                        ellipseLocation.Offset(-((int)size / 2), -(int)size / 2);
                        imageGraphics.FillEllipse(new SolidBrush(brushColor), ellipseLocation.X, ellipseLocation.Y, pen.Width, pen.Width);
                        imageGraphics.DrawLine(pen, startingPoint, e.Location);

                        pictureBox1.Invalidate();
                        startingPoint = e.Location;
                    }
                }

                if (markerRadioButton.Checked)
                {
                    if (Distance(startingPoint, e.Location) >= 10)
                    {
                        var pen = new Pen(markerColor);
                        var size = (float)brushSizeInput.Value;
                        pen.Width = size;
                        var ellipseLocation = e.Location;
                        ellipseLocation.Offset(-((int)size / 2), -(int)size / 2);
                        imageGraphics.FillEllipse(new SolidBrush(Color.FromArgb(5, Color.Yellow)), ellipseLocation.X, ellipseLocation.Y, pen.Width, pen.Width);
                        imageGraphics.DrawLine(pen, startingPoint, e.Location);

                        pictureBox1.Invalidate();
                        startingPoint = e.Location;
                    }
                }

                if (rectangleRadioButton.Checked)
                {
                    if (e.Location.X > startingPoint.X && e.Location.Y > startingPoint.Y)
                    {
                        var width = e.Location.X - startingPoint.X;
                        var height = e.Location.Y - startingPoint.Y;
                        var pen = new Pen(brushColor, (float)brushSizeInput.Value);
                        temporaryImage = (Bitmap)snippedImage.Clone();
                        pictureBox1.Image = temporaryImage;
                        var temporaryGraphics = Graphics.FromImage(temporaryImage);
                        temporaryGraphics.DrawRectangle(pen, new Rectangle(startingPoint, new Size(width, height)));

                        pictureBox1.Invalidate();
                    }
                }

                if (ellipseRadioButton.Checked)
                {
                    if (e.Location.X > startingPoint.X && e.Location.Y > startingPoint.Y)
                    {
                        var width = e.Location.X - startingPoint.X;
                        var height = e.Location.Y - startingPoint.Y;
                        var pen = new Pen(brushColor, (float)brushSizeInput.Value);
                        temporaryImage = (Bitmap)snippedImage.Clone();
                        pictureBox1.Image = temporaryImage;
                        var temporaryGraphics = Graphics.FromImage(temporaryImage);
                        temporaryGraphics.DrawEllipse(pen, new Rectangle(startingPoint, new Size(width, height)));

                        pictureBox1.Invalidate();
                    }
                }
            }
        }

        private void EndDrawing(object sender, MouseEventArgs e)
        {
            EndDrawing();
        }

        private void EndDrawing()
        {
            if (isDrawing)
            {
                isDrawing = false;
                startingPoint = Point.Empty;
                if (rectangleRadioButton.Checked || ellipseRadioButton.Checked)
                {
                    if (temporaryImage != null)
                    {
                        UpdateView(temporaryImage);
                        temporaryImage = null;
                    }
                }
                if(currentHistoryIndex<history.Count-1)
                {
                    history.RemoveRange(currentHistoryIndex + 1, history.Count - currentHistoryIndex - 1);
                }
                history.Add((Bitmap)snippedImage.Clone());
                currentHistoryIndex++;
            }
        }

        private void StartDrawing(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            startingPoint = e.Location;
            if (rectangleRadioButton.Checked || ellipseRadioButton.Checked)
            {
                startingPoint = e.Location;
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (temporaryImage != null)
            {
                e.Graphics.DrawImage(temporaryImage, 0, 0, snippedImage.Width, snippedImage.Height);
            }
            else
            {
                e.Graphics.DrawImage(snippedImage, 0, 0, snippedImage.Width, snippedImage.Height);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var dialogResult = saveFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.Yes || dialogResult == DialogResult.OK)
            {
                var filterIndex = saveFileDialog1.FilterIndex;
                var extension = Path.GetExtension(saveFileDialog1.FileName);

                snippedImage.Save(saveFileDialog1.FileName);
            }
        }

        private double Distance(Point first, Point second)
        {
            return Math.Sqrt(Math.Pow(first.X - second.X, 2) + Math.Pow(first.Y - second.Y, 2));
        }

        private void EndDrawing(object sender, EventArgs e)
        {
            EndDrawing();
        }

        private void forwardHistoryButton_Click(object sender, EventArgs e)
        {
            if(history.Count>currentHistoryIndex+1)
            {
                currentHistoryIndex++;
                UpdateView(history[currentHistoryIndex]);
            }
        }

        private void backHistoryButton_Click(object sender, EventArgs e)
        {
            if (currentHistoryIndex > 0)
            {
                currentHistoryIndex--;
                UpdateView(history[currentHistoryIndex]);
                
            }
        }

        private void UpdateView(Bitmap image)
        {
            snippedImage = image;
            pictureBox1.Image = snippedImage;
            imageGraphics = Graphics.FromImage(snippedImage);
            pictureBox1.Invalidate();
        }
    }
}
