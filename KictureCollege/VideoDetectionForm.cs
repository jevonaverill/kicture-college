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
    public partial class VideoDetectionForm : Form
    {
        Capture capture;
        Image<Bgr, Byte> original;
        Image<Gray, Byte> grayscale;
        HaarCascade cascadeFace;

        public VideoDetectionForm()
        {
            InitializeComponent();

            cascadeFace = new HaarCascade("haarcascade_frontalface_default.xml");
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "All Files (*.*)|*.*|MP4 Video|*.mp4|WMV Video|*.wmv|3G2 Video|*.3g2|3GP Video|*.3gp|3GP2 Video|*.3gp2|3GPP Video|*.3gpp|AMV Video|*.amv|ASF Video|*.asf|AVI Video|*.avi|BIN Video|*.bin|CUE Video|*.cue|DIVX Video|*.divx|DV Video|*.dv|FLV Video|*.flv|GXF Video|*.gxf|ISO Video|*.iso|MLV Video|*.mlv|M2V Video|*.m2v|M2T Video|*.m2t|M2TS Video|*.m2ts|M4V Video|*.m4v";
            openFileDialog.FilterIndex = 1;

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                capture = new Capture(openFileDialog.FileName);
                timer.Enabled = true;
                btnStop.Enabled = true;
            }
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
                if (cbUseFaceDetection.Checked == true)
                {
                    faceDetection();
                }

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
