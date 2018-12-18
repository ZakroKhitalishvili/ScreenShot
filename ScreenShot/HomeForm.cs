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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            printScreenButton.Text = FormResource.printScreenButtonText;
        }

        private void printScreenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FullScreenForm fullScreenForm = new FullScreenForm(this);

            fullScreenForm.Show();
            this.Hide();
        }
    }
}
