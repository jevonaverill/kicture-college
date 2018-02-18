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
    public partial class ShapeDetectionForm : Form
    {
        Image<Bgr, Byte> original, temp;
        Image<Gray, Byte> grayscale, edge;

        public ShapeDetectionForm()
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

                original = temp = new Image<Bgr, byte>(openFileDialog.FileName);
                grayscale = original.Convert<Gray, Byte>();
                edge = grayscale.Canny(new Gray(150), new Gray(60)); //threshold > threshlinking
                
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

            if (cbCircle.Checked == false && cbLine.Checked == false & cbRectangle.Checked == false && cbTriangle.Checked == false)
            {
                lblError.Text = "Please choose the shape detection type";
                lblError.Visible = true;

                original = temp = new Image<Bgr, byte>(openFileDialog.FileName);
                pbChosenImage.Image = original.ToBitmap();

                return;
            }

            lblError.Visible = false;

            temp = new Image<Bgr, byte>(openFileDialog.FileName);

            if (cbLine.Checked == true)
            {
                LineSegment2D[] lines = edge.HoughLinesBinary(2, Math.PI / 180, 50, 50, 10)[0];

                foreach (LineSegment2D line in lines)
                {
                    temp.Draw(line, new Bgr(Color.Yellow), 10);
                }

                pbChosenImage.Image = temp.Bitmap;
            }

            if (cbCircle.Checked == true)
            {
                CircleF[] circles = edge.HoughCircles(new Gray(150), new Gray(150), 2, 50, 10, 100)[0];

                foreach (CircleF circle in circles)
                {
                    temp.Draw(circle, new Bgr(Color.Red), 10);
                }

                pbChosenImage.Image = temp.Bitmap;
            }

            if (cbTriangle.Checked == true)
            {
                for (Contour<Point> contour = edge.FindContours();
                    contour != null; contour = contour.HNext
                )
                {
                    if (contour.Area > 200)
                    {
                        MemStorage mem = new MemStorage();

                        Contour<Point> contourDalem = contour.ApproxPoly(contour.Perimeter * 0.16, mem);

                        if (contourDalem.Total == 3)
                        {
                            Point[] points = contourDalem.ToArray();
                            Triangle2DF triangle = new Triangle2DF(points[0], points[1], points[2]);

                            temp.Draw(triangle, new Bgr(Color.Green), 10);
                        }
                    }
                }

                pbChosenImage.Image = temp.Bitmap;
            }

            if (cbRectangle.Checked == true)
            {
                for (Contour<Point> contour = edge.FindContours();
                    contour != null; contour = contour.HNext
                )
                {
                    if (contour.Area > 200)
                    {
                        MemStorage mem = new MemStorage();

                        Contour<Point> contourDalem = contour.ApproxPoly(contour.Perimeter * 0.16, mem);

                        if (contourDalem.Total == 4)
                        {
                            Point[] points = contourDalem.ToArray();

                            bool rectangle = true;

                            LineSegment2D[] lines = PointCollection.PolyLine(points, true);

                            for (int i = 0; i < lines.Length; i++)
                            {
                                double angle = Math.Abs(lines[(i + 1) % lines.Length].GetExteriorAngleDegree(lines[i]));

                                if (angle < 80 || angle > 100)
                                {
                                    rectangle = false;
                                    break;
                                }
                            }

                            if (rectangle == true)
                            {
                                temp.Draw(contourDalem.GetMinAreaRect(), new Bgr(Color.Gold), 10);
                            }
                        }
                    }
                }

                pbChosenImage.Image = temp.Bitmap;
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
