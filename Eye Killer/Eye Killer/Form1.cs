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
            //get the cascade classifier
            string facePath = Path.GetFullPath(@"../../data/haarcascade_frontalface_default.xml");
            CascadeClassifier classifierFace = new CascadeClassifier(facePath);

            //find faces in the current image
            var imgGray = imgInput.Convert<Gray, byte>().Clone();
            Rectangle [] faces = classifierFace.DetectMultiScale(imgGray, 1.1, 4);

            //Get center point of face
            float faceCenterX = faces[0].X + faces[0].Width / 2;
            float faceCenterY = faces[0].Y + faces[0].Height / 2;

            //Display faces x and y position
            textBoxFaceX.Text = "X: " + faceCenterX;
            textBoxFaceY.Text = "Y: " + faceCenterY;

            //Draw rectangle and circle over first face
            imgInput.Draw(faces[0], new Bgr(0, 0, 255), 2);
            imgInput.Draw(new CircleF(new PointF(faceCenterX, faceCenterY), 1), new Bgr(0, 255, 0), 2);

            //set the picture box image
            pictureBox1.Image = imgInput.AsBitmap();
        }
    }
}
