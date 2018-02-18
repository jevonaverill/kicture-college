namespace KictureCollege
{
    partial class PointBasedForm
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
            this.pbChosenImage = new System.Windows.Forms.PictureBox();
            this.pnlChosenImage = new System.Windows.Forms.Panel();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.lblMode = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.rbGrayscale = new System.Windows.Forms.RadioButton();
            this.rbThreshold = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudLow = new System.Windows.Forms.NumericUpDown();
            this.nudHigh = new System.Windows.Forms.NumericUpDown();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblLow = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbKictureCollege)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChosenImage)).BeginInit();
            this.pnlChosenImage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHigh)).BeginInit();
            this.SuspendLayout();
            // 
            // pbKictureCollege
            // 
            this.pbKictureCollege.BackColor = System.Drawing.Color.Transparent;
            this.pbKictureCollege.Image = global::KictureCollege.Properties.Resources.Kicture;
            this.pbKictureCollege.Location = new System.Drawing.Point(208, 12);
            this.pbKictureCollege.Name = "pbKictureCollege";
            this.pbKictureCollege.Size = new System.Drawing.Size(173, 76);
            this.pbKictureCollege.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKictureCollege.TabIndex = 20;
            this.pbKictureCollege.TabStop = false;
            // 
            // pbChosenImage
            // 
            this.pbChosenImage.Image = global::KictureCollege.Properties.Resources.NoImageAvailable;
            this.pbChosenImage.Location = new System.Drawing.Point(17, 16);
            this.pbChosenImage.Name = "pbChosenImage";
            this.pbChosenImage.Size = new System.Drawing.Size(239, 200);
            this.pbChosenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChosenImage.TabIndex = 21;
            this.pbChosenImage.TabStop = false;
            // 
            // pnlChosenImage
            // 
            this.pnlChosenImage.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlChosenImage.Controls.Add(this.pbChosenImage);
            this.pnlChosenImage.Location = new System.Drawing.Point(158, 106);
            this.pnlChosenImage.Name = "pnlChosenImage";
            this.pnlChosenImage.Size = new System.Drawing.Size(270, 233);
            this.pnlChosenImage.TabIndex = 22;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.Olive;
            this.btnBrowse.Location = new System.Drawing.Point(224, 355);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(145, 41);
            this.btnBrowse.TabIndex = 22;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(131, 593);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(151, 29);
            this.lblError.TabIndex = 34;
            this.lblError.Text = "Error Message";
            this.lblError.Visible = false;
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.BackColor = System.Drawing.Color.LightGray;
            this.btnSaveImage.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveImage.ForeColor = System.Drawing.Color.Olive;
            this.btnSaveImage.Location = new System.Drawing.Point(136, 515);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(145, 41);
            this.btnSaveImage.TabIndex = 33;
            this.btnSaveImage.Text = "Save Image";
            this.btnSaveImage.UseVisualStyleBackColor = false;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.BackColor = System.Drawing.Color.Transparent;
            this.lblMode.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.Olive;
            this.lblMode.Location = new System.Drawing.Point(29, 413);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(69, 29);
            this.lblMode.TabIndex = 29;
            this.lblMode.Text = "Mode";
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.LightGray;
            this.btnProcess.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.Color.Olive;
            this.btnProcess.Location = new System.Drawing.Point(136, 459);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(145, 41);
            this.btnProcess.TabIndex = 28;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // rbGrayscale
            // 
            this.rbGrayscale.AutoSize = true;
            this.rbGrayscale.BackColor = System.Drawing.Color.Transparent;
            this.rbGrayscale.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGrayscale.ForeColor = System.Drawing.Color.Olive;
            this.rbGrayscale.Location = new System.Drawing.Point(113, 409);
            this.rbGrayscale.Name = "rbGrayscale";
            this.rbGrayscale.Size = new System.Drawing.Size(125, 33);
            this.rbGrayscale.TabIndex = 35;
            this.rbGrayscale.TabStop = true;
            this.rbGrayscale.Text = "Grayscale";
            this.rbGrayscale.UseVisualStyleBackColor = false;
            // 
            // rbThreshold
            // 
            this.rbThreshold.AutoSize = true;
            this.rbThreshold.BackColor = System.Drawing.Color.Transparent;
            this.rbThreshold.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThreshold.ForeColor = System.Drawing.Color.Olive;
            this.rbThreshold.Location = new System.Drawing.Point(244, 409);
            this.rbThreshold.Name = "rbThreshold";
            this.rbThreshold.Size = new System.Drawing.Size(125, 33);
            this.rbThreshold.TabIndex = 36;
            this.rbThreshold.TabStop = true;
            this.rbThreshold.Text = "Threshold";
            this.rbThreshold.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.nudLow);
            this.groupBox1.Controls.Add(this.nudHigh);
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(this.lblLow);
            this.groupBox1.Controls.Add(this.lblHigh);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Olive;
            this.groupBox1.Location = new System.Drawing.Point(393, 413);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 157);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Threshold";
            // 
            // nudLow
            // 
            this.nudLow.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLow.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLow.Location = new System.Drawing.Point(58, 115);
            this.nudLow.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudLow.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudLow.Name = "nudLow";
            this.nudLow.Size = new System.Drawing.Size(120, 21);
            this.nudLow.TabIndex = 40;
            this.nudLow.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudHigh
            // 
            this.nudHigh.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHigh.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudHigh.Location = new System.Drawing.Point(58, 82);
            this.nudHigh.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudHigh.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudHigh.Name = "nudHigh";
            this.nudHigh.Size = new System.Drawing.Size(120, 21);
            this.nudHigh.TabIndex = 39;
            this.nudHigh.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Binary",
            "Binary Inverse",
            "To Zero",
            "To Zero Inverse",
            "Trunc"});
            this.cmbType.Location = new System.Drawing.Point(58, 48);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(136, 21);
            this.cmbType.TabIndex = 38;
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.BackColor = System.Drawing.Color.Transparent;
            this.lblLow.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLow.ForeColor = System.Drawing.Color.Olive;
            this.lblLow.Location = new System.Drawing.Point(6, 113);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(42, 23);
            this.lblLow.TabIndex = 28;
            this.lblLow.Text = "Low";
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.BackColor = System.Drawing.Color.Transparent;
            this.lblHigh.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigh.ForeColor = System.Drawing.Color.Olive;
            this.lblHigh.Location = new System.Drawing.Point(6, 80);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(46, 23);
            this.lblHigh.TabIndex = 27;
            this.lblHigh.Text = "High";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.Olive;
            this.lblType.Location = new System.Drawing.Point(6, 46);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(46, 23);
            this.lblType.TabIndex = 25;
            this.lblType.Text = "Type";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // PointBasedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KictureCollege.Properties.Resources.NightSky;
            this.ClientSize = new System.Drawing.Size(625, 651);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbThreshold);
            this.Controls.Add(this.rbGrayscale);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pnlChosenImage);
            this.Controls.Add(this.pbKictureCollege);
            this.Name = "PointBasedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PointBased";
            ((System.ComponentModel.ISupportInitialize)(this.pbKictureCollege)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChosenImage)).EndInit();
            this.pnlChosenImage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHigh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbKictureCollege;
        private System.Windows.Forms.PictureBox pbChosenImage;
        private System.Windows.Forms.Panel pnlChosenImage;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.RadioButton rbGrayscale;
        private System.Windows.Forms.RadioButton rbThreshold;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.NumericUpDown nudHigh;
        private System.Windows.Forms.NumericUpDown nudLow;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}