using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KictureCollege
{
    public partial class ChooseRecognitionForm : Form
    {
        public ChooseRecognitionForm()
        {
            InitializeComponent();
        }

        private void pnlUploadImage_Click(object sender, EventArgs e)
        {
            this.Hide();

            ImageDetectionForm imageDetectionForm = new ImageDetectionForm();
            imageDetectionForm.Show();
        }

        private void pnlUploadVideo_Click(object sender, EventArgs e)
        {
            this.Hide();

            VideoDetectionForm videoDetectionForm = new VideoDetectionForm();
            videoDetectionForm.Show();
        }

        private void pnlRealTimeDetection_Click(object sender, EventArgs e)
        {
            this.Hide();

            RealTimeRecognitionForm realTimeRecognitionForm = new RealTimeRecognitionForm();
            realTimeRecognitionForm.Show();
        }

        private void lblUploadImage_Click(object sender, EventArgs e)
        {
            this.Hide();

            ImageDetectionForm imageDetectionForm = new ImageDetectionForm();
            imageDetectionForm.Show();
        }

        private void lblUploadVideo_Click(object sender, EventArgs e)
        {
            this.Hide();

            VideoDetectionForm videoDetectionForm = new VideoDetectionForm();
            videoDetectionForm.Show();
        }

        private void lblRealTimeDetection_Click(object sender, EventArgs e)
        {
            this.Hide();

            RealTimeRecognitionForm realTimeRecognitionForm = new RealTimeRecognitionForm();
            realTimeRecognitionForm.Show();
        }

        private void pbCamera_Click(object sender, EventArgs e)
        {
            this.Hide();

            ImageDetectionForm imageDetectionForm = new ImageDetectionForm();
            imageDetectionForm.Show();
        }

        private void pbMovies_Click(object sender, EventArgs e)
        {
            this.Hide();

            VideoDetectionForm videoDetectionForm = new VideoDetectionForm();
            videoDetectionForm.Show();
        }

        private void pbCam_Click(object sender, EventArgs e)
        {
            this.Hide();

            RealTimeRecognitionForm realTimeRecognitionForm = new RealTimeRecognitionForm();
            realTimeRecognitionForm.Show();
        }
    }
}
