using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace KictureCollege
{
    public partial class RealTimeRecognitionForm : Form
    {
        Capture capture;
        Image<Bgr, Byte> original;
        Image<Gray, Byte> grayscale;
        HaarCascade cascadeFace;

        public RealTimeRecognitionForm()
        {
            InitializeComponent();

            cascadeFace = new HaarCascade("haarcascade_frontalface_default.xml");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            capture = new Capture();
            timer.Enabled = true;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
        }

        private void faceDetection()
        {
            var faces = cascadeFace.Detect(grayscale, 1.1, 3, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(50, 50));

            foreach (var face in faces)
            {
                original.Draw(face.rect, new Bgr(Color.Aquamarine), 5);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            original = capture.QueryFrame();
            grayscale = capture.QueryGrayFrame();

            if (original != null && grayscale != null)
            {
                faceDetection();

                pbChosenImage.Image = original.ToBitmap();
            }
            else
            {
                pbChosenImage.Image = null;
                timer.Enabled = false;
                btnStop.Enabled = false;
            }
        }

    }
}
