using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

using Emgu.CV;
using Emgu.CV.Structure;

namespace Eye_Killer
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> imgInput;
        VideoCapture cam = new VideoCapture();
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            imgInput = cam.QueryFrame().ToImage<Bgr, byte>();            

            DetectFaceHaar();
        }

        public void DetectFaceHaar()
        {
            string facePath = Path.GetFullPath(@"../../data/haarcascade_frontalface_default.xml");
            CascadeClassifier classifierFace = new CascadeClassifier(facePath);
            var imgGray = imgInput.Convert<Gray, byte>().Clone();
            Rectangle [] faces = classifierFace.DetectMultiScale(imgGray, 1.1, 4);

            foreach(var face in faces)
            {
                imgInput.Draw(face, new Bgr(0, 0, 255), 2);
                imgInput.Draw(new CircleF(new PointF(face.X + (face.Width / 2), face.Y + (face.Height / 2)), 1), new Bgr(0, 255, 0), 2);
            }
            pictureBox1.Image = imgInput.AsBitmap();
        }
    }
}
