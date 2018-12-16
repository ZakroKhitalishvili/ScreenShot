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
        public ImageReadyForm()
        {
            InitializeComponent();
        }

        public ImageReadyForm(Bitmap snippedImage)
        {
            InitializeComponent();
            this.snippedImage = snippedImage;
            pictureBox1.Image = snippedImage;
        }

        private void ImageReadyForm_Load(object sender, EventArgs e)
        {
            this.FormClosed += ImageReadyForm_FormClosed;
        }

        private void ImageReadyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
