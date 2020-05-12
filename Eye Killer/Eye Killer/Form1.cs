using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

using Emgu.CV;
using Emgu.CV.Structure;

namespace Eye_Killer
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> imgInput;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fileName = @"D:\The Gibbon\Documents\Pictures\Funny Pictures\mine";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VideoCapture cam = new VideoCapture();
            pictureBox1.Image = cam.QueryFrame().ToBitmap();

            //OpenFileDialog dialog = new OpenFileDialog();
            //if(dialog.ShowDialog() == DialogResult.OK)
            //{
            //    //imgInput = new Image<Bgr, byte>(dialog.FileName);
            //    //pictureBox1.Image = imgInput.ToBitmap();
            //    //pictureBox1.Image = new VideoCapture[0].

            //    VideoCapture cam = new VideoCapture();
            //    pictureBox1.Image = cam.QueryFrame().ToBitmap();

            //}
        }
    }
}
