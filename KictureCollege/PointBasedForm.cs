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
    public partial class PointBasedForm : Form
    {
        Image<Bgr, Byte> original;
        Image<Gray, Byte> grayscale, threshold;

        public PointBasedForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "All Files (*.*)|*.*|JPG Image|*.jpg|JPEG Image|*.jpeg|JPE Image|*.jpe|JFIF Image|*.jfif|PNG Image|*.png";
            openFileDialog.FilterIndex = 1;

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                lblError.Visible = false;
                original = new Image<Bgr, byte>(openFileDialog.FileName);
                grayscale = new Image<Gray, byte>(original.Width, original.Height);
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
                rbGrayscale.Checked = rbThreshold.Checked = false;
                return;
            }

            if (rbGrayscale.Checked == false && rbThreshold.Checked == false)
            {
                lblError.Text = "Please choose the mode";
                lblError.Visible = true;
                return;
            }

            if (rbGrayscale.Checked == true)
            {
                lblError.Visible = false;

                //original = new Image<Bgr, byte>(new Bitmap(pbChosenImage.Image));

                CvInvoke.cvCvtColor(original, grayscale, COLOR_CONVERSION.CV_BGR2GRAY);
                pbChosenImage.Image = grayscale.ToBitmap();
                return;
            }

            if (rbThreshold.Checked == true)
            {
                if (cmbType.SelectedIndex == -1)
                {
                    lblError.Text = "Please choose the threshold type";
                    lblError.Visible = true;
                    return;
                }
                else
                {
                    lblError.Visible = false;

                    double thresholdValue = (Double)nudLow.Value;
                    double maxThresholdValue = (Double)nudHigh.Value;

                    CvInvoke.cvCvtColor(original, grayscale, COLOR_CONVERSION.CV_BGR2GRAY);

                    threshold = grayscale.CopyBlank();

                    switch (cmbType.SelectedIndex)
                    {
                        case 0:
                            CvInvoke.cvThreshold(grayscale, threshold, thresholdValue, maxThresholdValue, THRESH.CV_THRESH_BINARY);
                            break;
                        case 1:
                            CvInvoke.cvThreshold(grayscale, threshold, thresholdValue, maxThresholdValue, THRESH.CV_THRESH_BINARY_INV);
                            break;
                        case 2:
                            CvInvoke.cvThreshold(grayscale, threshold, thresholdValue, maxThresholdValue, THRESH.CV_THRESH_TOZERO);
                            break;
                        case 3:
                            CvInvoke.cvThreshold(grayscale, threshold, thresholdValue, maxThresholdValue, THRESH.CV_THRESH_TOZERO_INV);
                            break;
                        case 4:
                            CvInvoke.cvThreshold(grayscale, threshold, thresholdValue, maxThresholdValue, THRESH.CV_THRESH_TRUNC);
                            break;
                        default:
                            break;
                    }

                    pbChosenImage.Image = threshold.ToBitmap();
                }
            }
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
