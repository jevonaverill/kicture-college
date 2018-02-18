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
    public partial class AreaBasedForm : Form
    {
        Image<Bgr, Byte> original, blur;

        public AreaBasedForm()
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
                lblError.Text = "Please choose the smooth type";
                lblError.Visible = true;
                return;
            }

            lblError.Visible = false;
            blur = original.CopyBlank(); //copy dari original
            switch (cmbType.SelectedIndex)
            {
                case 0:
                    //Simple Blur
                    CvInvoke.cvSmooth(original, blur, SMOOTH_TYPE.CV_BLUR, (int)nudHigh.Value, (int)nudHigh.Value, 0, 0);
                    break;
                case 1:
                    //Median Blur
                    CvInvoke.cvSmooth(original, blur, SMOOTH_TYPE.CV_MEDIAN, (int)nudHigh.Value, 0, 0, 0);
                    break;
                case 2:
                    //Gaussian Blur
                    CvInvoke.cvSmooth(original, blur, SMOOTH_TYPE.CV_GAUSSIAN, (int)nudHigh.Value, (int)nudHigh.Value, 0, 0);
                    break;
            }
            pbChosenImage.Image = blur.ToBitmap();
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
