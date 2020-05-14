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
using System.Diagnostics;

using Emgu.CV;
using Emgu.CV.Structure;

namespace Eye_Killer
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> imgInput;
        VideoCapture cam = new VideoCapture();
        Rectangle face;

        public Stopwatch watch;

        public Form1()
        {
            InitializeComponent();

            face = new Rectangle();
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
            
            try
            {
                face = classifierFace.DetectMultiScale(imgGray, 1.1, 4)[0];
                //Get center point of face
                float faceCenterX = face.X + face.Width / 2;
                float faceCenterY = face.Y + face.Height / 2;

                //Display faces x and y position
                textBoxFaceX.Text = "X: " + faceCenterX;
                textBoxFaceY.Text = "Y: " + faceCenterY;

                //Draw rectangle and circle over first face
                imgInput.Draw(face, new Bgr(0, 0, 255), 2);
                imgInput.Draw(new CircleF(new PointF(faceCenterX, faceCenterY), 1), new Bgr(0, 255, 0), 2);                

                ////Scale face position to 0 - 180
                //int scaledX = Convert.ToInt16(faceCenterX / (imgInput.Width / 180));
                //int scaledY = Convert.ToInt16(faceCenterY / (imgInput.Height / 180));

                //Do some math to figure out the angle the servos need to be at


                //Send face position to arduino
                if (serialPortArduino.IsOpen == true && watch.ElapsedMilliseconds > 15)
                {
                    string coordinates = "X" + calculateAngle(faceCenterX, (imgInput.Width/2)) + "Y" + calculateAngle(faceCenterY, (imgInput.Height / 2));
                    label2.Text = coordinates;
                    serialPortArduino.Write(coordinates);
                    watch = Stopwatch.StartNew();
                }
            }
            catch (Exception) { };

            //set the picture box image
            pictureBox1.Image = imgInput.AsBitmap();

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            
            try
            {
                serialPortArduino.PortName = textBoxPortName.Text;
                serialPortArduino.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error\n\n" + ex.Message + "\n\nSerial port closed");
                serialPortArduino.Close();
            }
            
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            serialPortArduino.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            watch = Stopwatch.StartNew();
        }

        private int calculateAngle(float faceCenter, int halfPoint) //Calculate the angle the servos should be at
        {
            double angle = 0;
            double radians = 0;
            int distance = calculateDistance();

            if (faceCenter > halfPoint)
            {
                radians = (Math.PI / 180) * (distance / (faceCenter - halfPoint));
                angle = 180 - Math.Atan(radians);
            }
            else
            {
                radians = (Math.PI / 180) *  (distance / faceCenter);
                angle = Math.Atan(radians);
            }
            return (int)(angle*(180/Math.PI));
        }

        private int calculateDistance() //Finish this at some point
        {
            return 250;
        }
    }
}
