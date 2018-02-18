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
    public partial class EdgeDetectionForm : Form
    {
        Image<Bgr, Byte> original;
        Image<Gray, Byte> grayscale, threshold, edge;

        public EdgeDetectionForm()
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

            if (cmbType.SelectedIndex == -1)
            {
                lblError.Text = "Please choose the edge detection type";
                lblError.Visible = true;
                return;
            }
            else
            {
                lblError.Visible = false;
                grayscale = original.Convert<Gray, Byte>();

                threshold = grayscale.ThresholdBinary(new Gray(127), new Gray(255));

                edge = new Image<Gray, Byte>(threshold.Width, threshold.Height);

                switch (cmbType.SelectedIndex)
                {
                    case 0: //Canny
                        CvInvoke.cvCanny(threshold, edge, (double)nudLow.Value, (double)nudHigh.Value, (int)nudApertureSize.Value);
                        break;
                    case 1: //Laplace
                        edge = threshold.Laplace((int)nudApertureSize.Value).Convert<Gray, Byte>();
                        break;
                    case 2: //Sobel
                        edge = threshold.Sobel(1, 0, (int)nudApertureSize.Value).Convert<Gray, Byte>();
                        break;
                    default:
                        break;
                }

                pbChosenImage.Image = edge.ToBitmap();
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

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbType.SelectedIndex)
            {
                case 0: //Canny
                    nudLow.Enabled = nudHigh.Enabled = true;
                    break;
                case 1: //Laplace
                    nudLow.Enabled = nudHigh.Enabled = false;
                    break;
                case 2: //Sobel
                    nudLow.Enabled = nudHigh.Enabled = false;
                    break;
                default:
                    break;
            }
        }
    }
}
