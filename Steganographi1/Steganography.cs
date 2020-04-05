using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganographi1
{
    public partial class Steganography : Form
    {
        public Steganography()
        {
            InitializeComponent();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All files(*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK) 
            {
                pictureBoxImage.Image = Image.FromFile(op.FileName);
            }
        }


        private void buttonUpload2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All files(*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImageLoad.Image = Image.FromFile(op.FileName);
            }
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {

        }
    }
}
