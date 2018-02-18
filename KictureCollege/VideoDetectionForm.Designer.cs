namespace KictureCollege
{
    partial class VideoDetectionForm
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
            this.components = new System.ComponentModel.Container();
            this.pbKictureCollege = new System.Windows.Forms.PictureBox();
            this.pnlChosenImage = new System.Windows.Forms.Panel();
            this.pbChosenImage = new System.Windows.Forms.PictureBox();
            this.cbUseFaceDetection = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbKictureCollege)).BeginInit();
            this.pnlChosenImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChosenImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbKictureCollege
            // 
            this.pbKictureCollege.BackColor = System.Drawing.Color.Transparent;
            this.pbKictureCollege.Image = global::KictureCollege.Properties.Resources.Kicture;
            this.pbKictureCollege.Location = new System.Drawing.Point(363, 12);
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
            this.pnlChosenImage.Location = new System.Drawing.Point(61, 118);
            this.pnlChosenImage.Name = "pnlChosenImage";
            this.pnlChosenImage.Size = new System.Drawing.Size(781, 416);
            this.pnlChosenImage.TabIndex = 22;
            // 
            // pbChosenImage
            // 
            this.pbChosenImage.Location = new System.Drawing.Point(16, 15);
            this.pbChosenImage.Name = "pbChosenImage";
            this.pbChosenImage.Size = new System.Drawing.Size(746, 380);
            this.pbChosenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChosenImage.TabIndex = 0;
            this.pbChosenImage.TabStop = false;
            // 
            // cbUseFaceDetection
            // 
            this.cbUseFaceDetection.AutoSize = true;
            this.cbUseFaceDetection.BackColor = System.Drawing.Color.Transparent;
            this.cbUseFaceDetection.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUseFaceDetection.ForeColor = System.Drawing.Color.Olive;
            this.cbUseFaceDetection.Location = new System.Drawing.Point(339, 553);
            this.cbUseFaceDetection.Name = "cbUseFaceDetection";
            this.cbUseFaceDetection.Size = new System.Drawing.Size(226, 32);
            this.cbUseFaceDetection.TabIndex = 23;
            this.cbUseFaceDetection.Text = "Use face detection";
            this.cbUseFaceDetection.UseVisualStyleBackColor = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.LightGray;
            this.btnBrowse.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.Olive;
            this.btnBrowse.Location = new System.Drawing.Point(286, 603);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(145, 41);
            this.btnBrowse.TabIndex = 24;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.LightGray;
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Olive;
            this.btnStop.Location = new System.Drawing.Point(458, 603);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(145, 41);
            this.btnStop.TabIndex = 25;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // VideoDetectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KictureCollege.Properties.Resources.NightSky;
            this.ClientSize = new System.Drawing.Size(902, 668);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.cbUseFaceDetection);
            this.Controls.Add(this.pnlChosenImage);
            this.Controls.Add(this.pbKictureCollege);
            this.Name = "VideoDetectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoDetection";
            ((System.ComponentModel.ISupportInitialize)(this.pbKictureCollege)).EndInit();
            this.pnlChosenImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbChosenImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbKictureCollege;
        private System.Windows.Forms.Panel pnlChosenImage;
        private System.Windows.Forms.PictureBox pbChosenImage;
        private System.Windows.Forms.CheckBox cbUseFaceDetection;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}