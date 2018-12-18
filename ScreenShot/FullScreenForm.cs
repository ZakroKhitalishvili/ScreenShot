using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenShot
{
    public partial class FullScreenForm : Form
    {

        private bool isSnipping = false;

        private Panel selectedArea;

        private Form callerForm;

        public FullScreenForm(Form callerForm)
        {
            InitializeComponent();
            Opacity = 0.5;
            this.callerForm = callerForm;
        }

        private void FullScreenForm_Load(object sender, EventArgs e)
        {
            var bounds = Screen.PrimaryScreen.Bounds;
            Location = new Point(0,0);
            FormBorderStyle = FormBorderStyle.None;
            Width = bounds.Width;
            Height = bounds.Height;
        }


        private void MouseDown_Callback(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isSnipping = true;
                selectedArea = new Panel();
                // TransparencyKey for this form is Black, that makes this panel transparent
                // hence a snipping area looks clear
                selectedArea.BackColor = Color.Black;
                this.Controls.Add(selectedArea);
                selectedArea.Location = e.Location;
                selectedArea.Size = new Size(0, 0);
            }
            else
            {
                BackToStartForm();
            }
        }

        private void MouseUp_Callback(object sender, MouseEventArgs e)
        {
            isSnipping = false;
            if (e.Button == MouseButtons.Left)
            {             
                if (selectedArea.Size.Height != 0 && selectedArea.Size.Width != 0)
                {
                    var bitMap = GenerateImage();
                    ImageReadyForm imageReadyForm = new ImageReadyForm(bitMap);
                    imageReadyForm.Show();
                    this.Close();
                }
                else
                {
                    selectedArea = null;
                }
            }
            else
            {
                selectedArea = null;
            }
        }

        private void MouseMove_Callback(object sender, MouseEventArgs e)
        {
            if(isSnipping)
            {

                if (e.Location.X > selectedArea.Location.X || e.Location.Y > selectedArea.Location.Y)
                {
                    int width = e.Location.X - selectedArea.Location.X;
                    int height = e.Location.Y - selectedArea.Location.Y;
                    selectedArea.Size = new Size(width, height);
                }
            }
        }

        private bool ImageThumbnailAbortCallback()
        {
            MessageBox.Show("error while generating image");
            return false;
        }


        private void BackToStartForm()
        {
            this.Close();
            callerForm.Show();
        }

        private Bitmap GenerateImage()
        {
            Bitmap bitMap = new Bitmap(selectedArea.Size.Width, selectedArea.Size.Height);

            Graphics graphics = Graphics.FromImage(bitMap);
            graphics.CopyFromScreen(
                selectedArea.Location.X,
                selectedArea.Location.Y,
                0,
                0,
                selectedArea.Size);

            return bitMap;
        }

    }
}
