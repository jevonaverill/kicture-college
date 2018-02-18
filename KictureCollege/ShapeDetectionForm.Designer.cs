namespace KictureCollege
{
    partial class ShapeDetectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbKictureCollege = new System.Windows.Forms.PictureBox();
            this.pnlChosenImage = new System.Windows.Forms.Panel();
            this.pbChosenImage = new System.Windows.Forms.PictureBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.gbShapeDetection = new System.Windows.Forms.GroupBox();
            this.cbRectangle = new System.Windows.Forms.CheckBox();
            this.cbTriangle = new System.Windows.Forms.CheckBox();
            this.cbCircle = new System.Windows.Forms.CheckBox();
            this.cbLine = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbKictureCollege)).BeginInit();
            this.pnlChosenImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChosenImage)).BeginInit();
            this.gbShapeDetection.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbKictureCollege
            // 
            this.pbKictureCollege.BackColor = System.Drawing.Color.Transparent;
            this.pbKictureCollege.Image = global::KictureCollege.Properties.Resources.Kicture;
            this.pbKictureCollege.Location = new System.Drawing.Point(283, 12);
            this.pbKictureCollege.Name = "pbKictureCollege";
            this.pbKictureCollege.Size = new System.Drawing.Size(173, 76);
            this.pbKictureCollege.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKictureCollege.TabIndex = 21;
            this.pbKictureCollege.TabStop = false;
            // 
            // pnlChosenImage
            // 
            this.pnlChosenImage.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlChosenImage.Controls.Add(this.pbChosenImage);
            this.pnlChosenImage.Location = new System.Drawing.Point(231, 107);
            this.pnlChosenImage.Name = "pnlChosenImage";
            this.pnlChosenImage.Size = new System.Drawing.Size(270, 233);
            this.pnlChosenImage.TabIndex = 23;
            // 
            // pbChosenImage
            // 
            this.pbChosenImage.Image = global::KictureCollege.Properties.Resources.NoImageAvailable;
            this.pbChosenImage.Location = new System.Drawing.Point(17, 16);
            this.pbChosenImage.Name = "pbChosenImage";
            this.pbChosenImage.Size = new System.Drawing.Size(239, 200);
            this.pbChosenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChosenImage.TabIndex = 24;
            this.pbChosenImage.TabStop = false;
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.LightGray;
            this.btnProcess.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.Color.Olive;
            this.btnProcess.Location = new System.Drawing.Point(463, 418);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(145, 41);
            this.btnProcess.TabIndex = 28;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.BackColor = System.Drawing.Color.LightGray;
            this.btnSaveImage.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveImage.ForeColor = System.Drawing.Color.Olive;
            this.btnSaveImage.Location = new System.Drawing.Point(463, 481);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(145, 41);
            this.btnSaveImage.TabIndex = 29;
            this.btnSaveImage.Text = "Save Image";
            this.btnSaveImage.UseVisualStyleBackColor = false;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(458, 543);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(151, 29);
            this.lblError.TabIndex = 30;
            this.lblError.Text = "Error Message";
            this.lblError.Visible = false;
            // 
            // gbShapeDetection
            // 
            this.gbShapeDetection.BackColor = System.Drawing.Color.Transparent;
            this.gbShapeDetection.Controls.Add(this.cbRectangle);
            this.gbShapeDetection.Controls.Add(this.cbTriangle);
            this.gbShapeDetection.Controls.Add(this.cbCircle);
            this.gbShapeDetection.Controls.Add(this.cbLine);
            this.gbShapeDetection.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbShapeDetection.ForeColor = System.Drawing.Color.Olive;
            this.gbShapeDetection.Location = new System.Drawing.Point(66, 406);
            this.gbShapeDetection.Name = "gbShapeDetection";
            this.gbShapeDetection.Size = new System.Drawing.Size(275, 219);
            this.gbShapeDetection.TabIndex = 32;
            this.gbShapeDetection.TabStop = false;
            this.gbShapeDetection.Text = "Shape Detection";
            // 
            // cbRectangle
            // 
            this.cbRectangle.AutoSize = true;
            this.cbRectangle.Location = new System.Drawing.Point(20, 168);
            this.cbRectangle.Name = "cbRectangle";
            this.cbRectangle.Size = new System.Drawing.Size(139, 32);
            this.cbRectangle.TabIndex = 3;
            this.cbRectangle.Text = "Rectangle";
            this.cbRectangle.UseVisualStyleBackColor = true;
            // 
            // cbTriangle
            // 
            this.cbTriangle.AutoSize = true;
            this.cbTriangle.Location = new System.Drawing.Point(20, 124);
            this.cbTriangle.Name = "cbTriangle";
            this.cbTriangle.Size = new System.Drawing.Size(124, 32);
            this.cbTriangle.TabIndex = 2;
            this.cbTriangle.Text = "Triangle";
            this.cbTriangle.UseVisualStyleBackColor = true;
            // 
            // cbCircle
            // 
            this.cbCircle.AutoSize = true;
            this.cbCircle.Location = new System.Drawing.Point(20, 79);
            this.cbCircle.Name = "cbCircle";
            this.cbCircle.Size = new System.Drawing.Size(92, 32);
            this.cbCircle.TabIndex = 1;
            this.cbCircle.Text = "Circle";
            this.cbCircle.UseVisualStyleBackColor = true;
            // 
            // cbLine
            // 
            this.cbLine.AutoSize = true;
            this.cbLine.Location = new System.Drawing.Point(20, 35);
            this.cbLine.Name = "cbLine";
            this.cbLine.Size = new System.Drawing.Size(77, 32);
            this.cbLine.TabIndex = 0;
            this.cbLine.Text = "Line";
            this.cbLine.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.LightGray;
            this.btnBrowse.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.Olive;
            this.btnBrowse.Location = new System.Drawing.Point(299, 359);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(145, 41);
            this.btnBrowse.TabIndex = 33;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // ShapeDetectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KictureCollege.Properties.Resources.NightSky;
            this.ClientSize = new System.Drawing.Size(855, 673);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.gbShapeDetection);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.pnlChosenImage);
            this.Controls.Add(this.pbKictureCollege);
            this.Name = "ShapeDetectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShapeDetection";
            ((System.ComponentModel.ISupportInitialize)(this.pbKictureCollege)).EndInit();
            this.pnlChosenImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbChosenImage)).EndInit();
            this.gbShapeDetection.ResumeLayout(false);
            this.gbShapeDetection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbKictureCollege;
        private System.Windows.Forms.Panel pnlChosenImage;
        private System.Windows.Forms.PictureBox pbChosenImage;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.GroupBox gbShapeDetection;
        private System.Windows.Forms.CheckBox cbLine;
        private System.Windows.Forms.CheckBox cbRectangle;
        private System.Windows.Forms.CheckBox cbTriangle;
        private System.Windows.Forms.CheckBox cbCircle;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}