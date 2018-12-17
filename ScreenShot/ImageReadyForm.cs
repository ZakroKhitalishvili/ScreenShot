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
    public partial class ImageReadyForm : Form
    {

        private Bitmap snippedImage;
        private Graphics imageGraphics;
        private Color brushColor;

        public ImageReadyForm()
        {
            InitializeComponent();
        }

        public ImageReadyForm(Bitmap snippedImage)
        {
            InitializeComponent();
            this.snippedImage = snippedImage;
            pictureBox1.Image = snippedImage;
            imageGraphics = pictureBox1.CreateGraphics();
            brushColor = Color.Red;
            colorButton.BackColor = Color.Red;
        }

        private void ImageReadyForm_Load(object sender, EventArgs e)
        {
            this.FormClosed += ImageReadyForm_FormClosed;
        }

        private void ImageReadyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            var dialogResult=colorDialog.ShowDialog();
            if(dialogResult==DialogResult.OK)
            {
                brushColor = colorDialog.Color;
                colorButton.BackColor = brushColor;
            }
        }

        private void ImageReadyForm_ResizeEnd(object sender, EventArgs e)
        {
            //panel1.Size = new Size(panel1.Size.Width,Convert.ToInt32(this.Size.Height * 0.8));
        }
    }
}
