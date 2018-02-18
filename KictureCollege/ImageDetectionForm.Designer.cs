namespace KictureCollege
{
    partial class ImageDetectionForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.gbObjectToDetect = new System.Windows.Forms.GroupBox();
            this.cbUpperBody = new System.Windows.Forms.CheckBox();
            this.cbMouth = new System.Windows.Forms.CheckBox();
            this.cbNose = new System.Windows.Forms.CheckBox();
            this.cbFace = new System.Windows.Forms.CheckBox();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbKictureCollege)).BeginInit();
            this.pnlChosenImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChosenImage)).BeginInit();
            this.gbObjectToDetect.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbKictureCollege
            // 
            this.pbKictureCollege.BackColor = System.Drawing.Color.Transparent;
            this.pbKictureCollege.Image = global::KictureCollege.Properties.Resources.Kicture;
            this.pbKictureCollege.Location = new System.Drawing.Point(290, 12);
            this.pbKictureCollege.Name = "pbKictureCollege";
            this.pbKictureCollege.Size = new System.Drawing.Size(173, 76);
            this.pbKictureCollege.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKictureCollege.TabIndex = 20;
            this.pbKictureCollege.TabStop = false;
            // 
            // pnlChosenImage
            // 
            this.pnlChosenImage.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlChosenImage.Controls.Add(this.pbChosenImage);
            this.pnlChosenImage.Location = new System.Drawing.Point(237, 106);
            this.pnlChosenImage.Name = "pnlChosenImage";
            this.pnlChosenImage.Size = new System.Drawing.Size(270, 233);
            this.pnlChosenImage.TabIndex = 21;
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
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.LightGray;
            this.btnBrowse.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.Olive;
            this.btnBrowse.Location = new System.Drawing.Point(303, 354);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(145, 41);
            this.btnBrowse.TabIndex = 22;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.LightGray;
            this.btnProcess.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.Color.Olive;
            this.btnProcess.Location = new System.Drawing.Point(472, 437);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(145, 41);
            this.btnProcess.TabIndex = 23;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.BackColor = System.Drawing.Color.LightGray;
            this.btnSaveImage.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveImage.ForeColor = System.Drawing.Color.Olive;
            this.btnSaveImage.Location = new System.Drawing.Point(472, 495);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(145, 41);
            this.btnSaveImage.TabIndex = 27;
            this.btnSaveImage.Text = "Save Image";
            this.btnSaveImage.UseVisualStyleBackColor = false;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // gbObjectToDetect
            // 
            this.gbObjectToDetect.BackColor = System.Drawing.Color.Transparent;
            this.gbObjectToDetect.Controls.Add(this.cbUpperBody);
            this.gbObjectToDetect.Controls.Add(this.cbMouth);
            this.gbObjectToDetect.Controls.Add(this.cbNose);
            this.gbObjectToDetect.Controls.Add(this.cbFace);
            this.gbObjectToDetect.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbObjectToDetect.ForeColor = System.Drawing.Color.Olive;
            this.gbObjectToDetect.Location = new System.Drawing.Point(47, 437);
            this.gbObjectToDetect.Name = "gbObjectToDetect";
            this.gbObjectToDetect.Size = new System.Drawing.Size(275, 219);
            this.gbObjectToDetect.TabIndex = 33;
            this.gbObjectToDetect.TabStop = false;
            this.gbObjectToDetect.Text = "Object to Detect";
            // 
            // cbUpperBody
            // 
            this.cbUpperBody.AutoSize = true;
            this.cbUpperBody.Location = new System.Drawing.Point(20, 168);
            this.cbUpperBody.Name = "cbUpperBody";
            this.cbUpperBody.Size = new System.Drawing.Size(157, 32);
            this.cbUpperBody.TabIndex = 3;
            this.cbUpperBody.Text = "Upper Body";
            this.cbUpperBody.UseVisualStyleBackColor = true;
            // 
            // cbMouth
            // 
            this.cbMouth.AutoSize = true;
            this.cbMouth.Location = new System.Drawing.Point(20, 124);
            this.cbMouth.Name = "cbMouth";
            this.cbMouth.Size = new System.Drawing.Size(101, 32);
            this.cbMouth.TabIndex = 2;
            this.cbMouth.Text = "Mouth";
            this.cbMouth.UseVisualStyleBackColor = true;
            // 
            // cbNose
            // 
            this.cbNose.AutoSize = true;
            this.cbNose.Location = new System.Drawing.Point(20, 79);
            this.cbNose.Name = "cbNose";
            this.cbNose.Size = new System.Drawing.Size(83, 32);
            this.cbNose.TabIndex = 1;
            this.cbNose.Text = "Nose";
            this.cbNose.UseVisualStyleBackColor = true;
            // 
            // cbFace
            // 
            this.cbFace.AutoSize = true;
            this.cbFace.Location = new System.Drawing.Point(20, 35);
            this.cbFace.Name = "cbFace";
            this.cbFace.Size = new System.Drawing.Size(80, 32);
            this.cbFace.TabIndex = 0;
            this.cbFace.Text = "Face";
            this.cbFace.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(467, 561);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(151, 29);
            this.lblError.TabIndex = 34;
            this.lblError.Text = "Error Message";
            this.lblError.Visible = false;
            // 
            // ImageDetectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KictureCollege.Properties.Resources.NightSky;
            this.ClientSize = new System.Drawing.Size(849, 683);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.gbObjectToDetect);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pnlChosenImage);
            this.Controls.Add(this.pbKictureCollege);
            this.Name = "ImageDetectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageDetection";
            ((System.ComponentModel.ISupportInitialize)(this.pbKictureCollege)).EndInit();
            this.pnlChosenImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbChosenImage)).EndInit();
            this.gbObjectToDetect.ResumeLayout(false);
            this.gbObjectToDetect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbKictureCollege;
        private System.Windows.Forms.Panel pnlChosenImage;
        private System.Windows.Forms.PictureBox pbChosenImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.GroupBox gbObjectToDetect;
        private System.Windows.Forms.CheckBox cbUpperBody;
        private System.Windows.Forms.CheckBox cbMouth;
        private System.Windows.Forms.CheckBox cbNose;
        private System.Windows.Forms.CheckBox cbFace;
        private System.Windows.Forms.Label lblError;
    }
}