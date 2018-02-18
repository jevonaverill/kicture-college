namespace KictureCollege
{
    partial class AreaBasedForm
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.nudHigh = new System.Windows.Forms.NumericUpDown();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblError = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbKictureCollege)).BeginInit();
            this.pnlChosenImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChosenImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHigh)).BeginInit();
            this.SuspendLayout();
            // 
            // pbKictureCollege
            // 
            this.pbKictureCollege.BackColor = System.Drawing.Color.Transparent;
            this.pbKictureCollege.Image = global::KictureCollege.Properties.Resources.Kicture;
            this.pbKictureCollege.Location = new System.Drawing.Point(291, 12);
            this.pbKictureCollege.Name = "pbKictureCollege";
            this.pbKictureCollege.Size = new System.Drawing.Size(173, 76);
            this.pbKictureCollege.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKictureCollege.TabIndex = 19;
            this.pbKictureCollege.TabStop = false;
            // 
            // pnlChosenImage
            // 
            this.pnlChosenImage.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlChosenImage.Controls.Add(this.pbChosenImage);
            this.pnlChosenImage.Location = new System.Drawing.Point(240, 103);
            this.pnlChosenImage.Name = "pnlChosenImage";
            this.pnlChosenImage.Size = new System.Drawing.Size(270, 233);
            this.pnlChosenImage.TabIndex = 20;
            // 
            // pbChosenImage
            // 
            this.pbChosenImage.Image = global::KictureCollege.Properties.Resources.NoImageAvailable;
            this.pbChosenImage.Location = new System.Drawing.Point(16, 15);
            this.pbChosenImage.Name = "pbChosenImage";
            this.pbChosenImage.Size = new System.Drawing.Size(239, 200);
            this.pbChosenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChosenImage.TabIndex = 0;
            this.pbChosenImage.TabStop = false;
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.LightGray;
            this.btnProcess.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.Color.Olive;
            this.btnProcess.Location = new System.Drawing.Point(496, 398);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(145, 41);
            this.btnProcess.TabIndex = 13;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.LightGray;
            this.btnBrowse.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.Olive;
            this.btnBrowse.Location = new System.Drawing.Point(306, 353);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(145, 41);
            this.btnBrowse.TabIndex = 21;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.Olive;
            this.lblType.Location = new System.Drawing.Point(97, 404);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(58, 29);
            this.lblType.TabIndex = 22;
            this.lblType.Text = "Type";
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.BackColor = System.Drawing.Color.Transparent;
            this.lblHigh.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigh.ForeColor = System.Drawing.Color.Olive;
            this.lblHigh.Location = new System.Drawing.Point(97, 453);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(58, 29);
            this.lblHigh.TabIndex = 23;
            this.lblHigh.Text = "High";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Simple Blur",
            "Median Blur",
            "Gaussian Blur"});
            this.cmbType.Location = new System.Drawing.Point(178, 412);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(150, 21);
            this.cmbType.TabIndex = 24;
            // 
            // nudHigh
            // 
            this.nudHigh.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudHigh.Location = new System.Drawing.Point(178, 462);
            this.nudHigh.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudHigh.Minimum = new decimal(new int[] {
            101,
            0,
            0,
            0});
            this.nudHigh.Name = "nudHigh";
            this.nudHigh.Size = new System.Drawing.Size(120, 20);
            this.nudHigh.TabIndex = 25;
            this.nudHigh.Value = new decimal(new int[] {
            101,
            0,
            0,
            0});
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.BackColor = System.Drawing.Color.LightGray;
            this.btnSaveImage.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveImage.ForeColor = System.Drawing.Color.Olive;
            this.btnSaveImage.Location = new System.Drawing.Point(496, 453);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(145, 41);
            this.btnSaveImage.TabIndex = 26;
            this.btnSaveImage.Text = "Save Image";
            this.btnSaveImage.UseVisualStyleBackColor = false;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(235, 511);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(151, 29);
            this.lblError.TabIndex = 27;
            this.lblError.Text = "Error Message";
            this.lblError.Visible = false;
            // 
            // AreaBasedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KictureCollege.Properties.Resources.NightSky;
            this.ClientSize = new System.Drawing.Size(735, 565);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.nudHigh);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblHigh);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.pnlChosenImage);
            this.Controls.Add(this.pbKictureCollege);
            this.Name = "AreaBasedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AreaBased";
            ((System.ComponentModel.ISupportInitialize)(this.pbKictureCollege)).EndInit();
            this.pnlChosenImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbChosenImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHigh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbKictureCollege;
        private System.Windows.Forms.Panel pnlChosenImage;
        private System.Windows.Forms.PictureBox pbChosenImage;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.NumericUpDown nudHigh;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}