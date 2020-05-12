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
        bool run = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fileName = @"D:\The Gibbon\Documents\Pictures\Funny Pictures\mine";


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            run = !run;
        }

        private void mainLoop()
        {
            while (true)
            {
                if(run == true)
                {
                    VideoCapture cam = new VideoCapture();
                    pictureBox1.Image = cam.QueryFrame().ToBitmap();
                }
                
            }
        }
    }
}
