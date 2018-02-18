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
using System.Drawing.Imaging;

namespace KictureCollege
{
    public partial class ImageDetectionForm : Form
    {
        Image<Bgr, byte> original;
        Image<Gray, byte> grayscale;
        HaarCascade cascadeFace, cascadeNose, cascadeMouth, cascadeUpperBody;

        public ImageDetectionForm()
        {
            InitializeComponent();

            cascadeFace = new HaarCascade("haarcascade_frontalface_default.xml");
            cascadeNose = new HaarCascade("haarcascade_mcs_nose.xml");
            cascadeMouth = new HaarCascade("haarcascade_mcs_mouth.xml");
            cascadeUpperBody = new HaarCascade("haarcascade_mcs_upperbody.xml");
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "JPG Image|*.jpg|JPEG Image|*.jpeg|JPE Image|*.jpe|JFIF Image|*.jfif|PNG Image|*.png";

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                lblError.Visible = false;

                original = new Image<Bgr, byte>(openFileDialog.FileName);

                pbChosenImage.Image = original.ToBitmap();
                btnProcess.Enabled = btnSaveImage.Enabled = true;
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (original == null)
            {
                lblError.Text = "Please browse the image";
                lblError.Visible = true;
                btnProcess.Enabled = btnSaveImage.Enabled = false;
                return;
            }

            if (cbFace.Checked == false && cbMouth.Checked == false & cbNose.Checked == false && cbUpperBody.Checked == false)
            {
                lblError.Text = "Please choose the object detection type";
                lblError.Visible = true;

                original = new Image<Bgr, byte>(openFileDialog.FileName);
                pbChosenImage.Image = original.ToBitmap();
                return;
            }

            lblError.Visible = false;

            original = new Image<Bgr, byte>(openFileDialog.FileName);
            grayscale = new Image<Gray, byte>(original.Width, original.Height);
            CvInvoke.cvCvtColor(original, grayscale, COLOR_CONVERSION.CV_BGR2GRAY);

            if (cbFace.Checked == true)
            {
                var faces = cascadeFace.Detect(grayscale, 1.1, 3, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(50, 50)); 

                foreach (var face in faces)
                {
                    original.Draw(face.rect, new Bgr(Color.Aquamarine), 5);
                }
            }

            if (cbNose.Checked == true)
            {
                var noses = cascadeNose.Detect(grayscale, 1.1, 3, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(50, 50));

                foreach (var nose in noses)
                {
                    original.Draw(nose.rect, new Bgr(Color.Red), 5);
                }
            }

            if (cbMouth.Checked == true)
            {
                var mouths = cascadeMouth.Detect(grayscale, 1.1, 3, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(45, 45));

                foreach (var mouth in mouths)
                {
                    original.Draw(mouth.rect, new Bgr(Color.Green), 5);
                }
            }

            if (cbUpperBody.Checked == true)
            {
                var upperBodys = cascadeUpperBody.Detect(grayscale, 1.1, 3, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(100, 100));

                foreach (var upperBody in upperBodys)
                {
                    original.Draw(upperBody.rect, new Bgr(Color.Yellow), 5);
                }
            }

            pbChosenImage.Image = original.ToBitmap();
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            if (original == null)
            {
                lblError.Text = "Please upload the image";
                lblError.Visible = true;
                btnProcess.Enabled = btnSaveImage.Enabled = false;
                return;
            }

            lblError.Visible = false;
            saveFileDialog.Filter = "JPG Image|*.jpg|JPEG Image|*.jpeg|JPE Image|*.jpe|JFIF Image|*.jfif|PNG Image|*.png";
            saveFileDialog.Title = "Save an Image File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName != "")
                {
                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
                    switch (saveFileDialog.FilterIndex)
                    {
                        case 1:
                            this.pbChosenImage.Image.Save(fs,
                               ImageFormat.Jpeg);
                            break;

                        case 2:
                            this.pbChosenImage.Image.Save(fs,
                               ImageFormat.Bmp);
                            break;

                        case 3:
                            this.pbChosenImage.Image.Save(fs,
                               ImageFormat.Gif);
                            break;
                    }

                    fs.Close();
                }
                MessageBox.Show("Success save the picture");
            }
        }
    }
}
