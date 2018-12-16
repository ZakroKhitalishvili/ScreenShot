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

        public FullScreenForm()
        {
            InitializeComponent();
            Opacity = 0.5;
        }

        private void FullScreenForm_Load(object sender, EventArgs e)
        {
            var bounds = Screen.PrimaryScreen.Bounds;
            Location = new Point(0,0);
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;
            Width = bounds.Width;
            Height = bounds.Height;
        }


        private void MouseDown_Callback(object sender, MouseEventArgs e)
        {
            isSnipping = true;
            selectedArea = new Panel();
            selectedArea.BackColor = Color.Black;
            this.Controls.Add(selectedArea);
            selectedArea.Location = e.Location;
            selectedArea.Size = new Size(0, 0);
        }

        private void MouseUp_Callback(object sender, MouseEventArgs e)
        {
            isSnipping = false;
            Bitmap bitMap = new Bitmap(selectedArea.Size.Width, selectedArea.Size.Height);

            Graphics graphics =  Graphics.FromImage(bitMap);
            graphics.CopyFromScreen(
                selectedArea.Location.X,
                selectedArea.Location.Y,
                0,
                0,
                selectedArea.Size);

            ImageReadyForm imageReadyForm = new ImageReadyForm(bitMap);
            imageReadyForm.Show();
            this.Close();
            
        }

        private void MouseMove_Callback(object sender, MouseEventArgs e)
        {
            if(isSnipping)
            {
                //MessageBox.Show(
                //    string.Format("selected area ({0},{1}) \n mouse move ({2},{3})",
                //    selectedArea.Location.X, selectedArea.Location.Y,
                //    e.Location.X, e.Location.Y));

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
        

    }
}
