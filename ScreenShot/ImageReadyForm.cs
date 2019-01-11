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
        private Color brushColor;
        private bool isDrawing = false;
        private Point startingPoint;
        private string[] fileFilters = { "PNG|*.png;", "JPG|*.jpg;", "JPEG|*.jpeg;" , "All files |*.*" };
        //private Graphics temporaryGraphics;

        public ImageReadyForm()
        {
            InitializeComponent();
        }

        public ImageReadyForm(Bitmap snippedImage)
        {
            InitializeComponent();
            this.snippedImage = snippedImage;
            pictureBox1.Image = snippedImage;
            imageGraphics = Graphics.FromImage(snippedImage);
            brushColor = Color.Red;
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
                    if (startingPoint == Point.Empty)
                    {
                        startingPoint = e.Location;
                    }
                    else
                    {
                        if (!startingPoint.Equals(e.Location))
                        {
                            var brush = new SolidBrush(brushColor);
                            var pen = new Pen(brushColor);

                            pen.Width = (int)brushSizeInput.Value;
                            imageGraphics.DrawLine(pen, startingPoint, e.Location);
                            pictureBox1.Invalidate();
                            startingPoint = e.Location;
                        }
                    }

                }
                //if(rectangleRadioButton.Checked)
                //{
                //    if (e.Location.X > startingPoint.X && e.Location.Y > startingPoint.Y)
                //    {
                //        var width = e.Location.X - startingPoint.X;
                //        var height = e.Location.Y - startingPoint.Y;
                //        temporaryGraphics.DrawRectangle(
                //            new Pen(brushColor),
                //            new Rectangle(startingPoint, new Size(width, height)));
                //    }
                //}
            }
        }

        private void EndDrawing(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            startingPoint = Point.Empty;

        }

        private void StartDrawing(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            //if (rectangleRadioButton.Checked)
            //{
            //    startingPoint = e.Location;
            //    temporaryGraphics = Graphics.FromImage(snippedImage);

            //}
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(snippedImage, 0, 0, snippedImage.Width, snippedImage.Height);
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
    }
}
