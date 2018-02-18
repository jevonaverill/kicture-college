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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void pnlAreaBased_Click(object sender, EventArgs e)
        {
            this.Hide();

            AreaBasedForm areaBasedForm = new AreaBasedForm();
            areaBasedForm.Show();
        }

        private void lblAreaBased_Click(object sender, EventArgs e)
        {
            this.Hide();

            AreaBasedForm areaBasedForm = new AreaBasedForm();
            areaBasedForm.Show();
        }

        private void pbAreaBased_Click(object sender, EventArgs e)
        {
            this.Hide();

            AreaBasedForm areaBasedForm = new AreaBasedForm();
            areaBasedForm.Show();
        }

        private void pnlPointBased_Click(object sender, EventArgs e)
        {
            this.Hide();

            PointBasedForm pointBasedForm = new PointBasedForm();
            pointBasedForm.Show();
        }

        private void lblPointBased_Click(object sender, EventArgs e)
        {
            this.Hide();

            PointBasedForm pointBasedForm = new PointBasedForm();
            pointBasedForm.Show();
        }

        private void pbPointBased_Click(object sender, EventArgs e)
        {
            this.Hide();

            PointBasedForm pointBasedForm = new PointBasedForm();
            pointBasedForm.Show();
        }

        private void pnlEdgeDetection_Click(object sender, EventArgs e)
        {
            this.Hide();

            EdgeDetectionForm edgeDetectionForm = new EdgeDetectionForm();
            edgeDetectionForm.Show();
        }

        private void lblEdgeDetection_Click(object sender, EventArgs e)
        {
            this.Hide();

            EdgeDetectionForm edgeDetectionForm = new EdgeDetectionForm();
            edgeDetectionForm.Show();
        }

        private void pbEdgeDetection_Click(object sender, EventArgs e)
        {
            this.Hide();

            EdgeDetectionForm edgeDetectionForm = new EdgeDetectionForm();
            edgeDetectionForm.Show();
        }

        private void pnlShapeDetection_Click(object sender, EventArgs e)
        {
            this.Hide();

            ShapeDetectionForm shapeDetectionForm = new ShapeDetectionForm();
            shapeDetectionForm.Show();
        }

        private void lblShapeDetection_Click(object sender, EventArgs e)
        {
            this.Hide();

            ShapeDetectionForm shapeDetectionForm = new ShapeDetectionForm();
            shapeDetectionForm.Show();
        }

        private void pbShapeDetection_Click(object sender, EventArgs e)
        {
            this.Hide();

            ShapeDetectionForm shapeDetectionForm = new ShapeDetectionForm();
            shapeDetectionForm.Show();
        }

        private void pnlPRandClassification_Click(object sender, EventArgs e)
        {
            this.Hide();

            ChooseRecognitionForm chooseRecognitionForm = new ChooseRecognitionForm();
            chooseRecognitionForm.Show();
        }

        private void lblPRandClassification_Click(object sender, EventArgs e)
        {
            this.Hide();

            ChooseRecognitionForm chooseRecognitionForm = new ChooseRecognitionForm();
            chooseRecognitionForm.Show();
        }

        private void pbPatternRecognition_Click(object sender, EventArgs e)
        {
            this.Hide();

            ChooseRecognitionForm chooseRecognitionForm = new ChooseRecognitionForm();
            chooseRecognitionForm.Show();
        }

        private void pbClassification_Click(object sender, EventArgs e)
        {
            this.Hide();

            ChooseRecognitionForm chooseRecognitionForm = new ChooseRecognitionForm();
            chooseRecognitionForm.Show();
        }

    }
}
