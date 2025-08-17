using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 天天記帳
{
    public partial class ImageDialog: Form
    {
        public ImageDialog(string imagePath)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void ImageDialog_Load(object sender, EventArgs e)
        {

        }

        private void ImageDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureBox1.Image.Dispose();
            GC.Collect();
        }
    }
}
