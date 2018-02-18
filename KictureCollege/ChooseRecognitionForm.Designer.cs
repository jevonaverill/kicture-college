namespace KictureCollege
{
    partial class ChooseRecognitionForm
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
            this.pnlUploadImage = new System.Windows.Forms.Panel();
            this.pbCamera = new System.Windows.Forms.PictureBox();
            this.lblUploadImage = new System.Windows.Forms.Label();
            this.pnlUploadVideo = new System.Windows.Forms.Panel();
            this.pbMovies = new System.Windows.Forms.PictureBox();
            this.lblUploadVideo = new System.Windows.Forms.Label();
            this.pnlRealTimeDetection = new System.Windows.Forms.Panel();
            this.pbCam = new System.Windows.Forms.PictureBox();
            this.lblRealTimeDetection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbKictureCollege)).BeginInit();
            this.pnlUploadImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            this.pnlUploadVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovies)).BeginInit();
            this.pnlRealTimeDetection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCam)).BeginInit();
            this.SuspendLayout();
            // 
            // pbKictureCollege
            // 
            this.pbKictureCollege.BackColor = System.Drawing.Color.Transparent;
            this.pbKictureCollege.Image = global::KictureCollege.Properties.Resources.Kicture;
            this.pbKictureCollege.Location = new System.Drawing.Point(250, 12);
            this.pbKictureCollege.Name = "pbKictureCollege";
            this.pbKictureCollege.Size = new System.Drawing.Size(173, 76);
            this.pbKictureCollege.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKictureCollege.TabIndex = 22;
            this.pbKictureCollege.TabStop = false;
            // 
            // pnlUploadImage
            // 
            this.pnlUploadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlUploadImage.Controls.Add(this.pbCamera);
            this.pnlUploadImage.Controls.Add(this.lblUploadImage);
            this.pnlUploadImage.Location = new System.Drawing.Point(57, 110);
            this.pnlUploadImage.Name = "pnlUploadImage";
            this.pnlUploadImage.Size = new System.Drawing.Size(270, 201);
            this.pnlUploadImage.TabIndex = 23;
            this.pnlUploadImage.Click += new System.EventHandler(this.pnlUploadImage_Click);
            // 
            // pbCamera
            // 
            this.pbCamera.BackColor = System.Drawing.Color.Transparent;
            this.pbCamera.Image = global::KictureCollege.Properties.Resources.Camera;
            this.pbCamera.Location = new System.Drawing.Point(48, 59);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(176, 128);
            this.pbCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCamera.TabIndex = 3;
            this.pbCamera.TabStop = false;
            this.pbCamera.Click += new System.EventHandler(this.pbCamera_Click);
            // 
            // lblUploadImage
            // 
            this.lblUploadImage.AutoSize = true;
            this.lblUploadImage.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUploadImage.ForeColor = System.Drawing.Color.Green;
            this.lblUploadImage.Location = new System.Drawing.Point(42, 11);
            this.lblUploadImage.Name = "lblUploadImage";
            this.lblUploadImage.Size = new System.Drawing.Size(182, 32);
            this.lblUploadImage.TabIndex = 0;
            this.lblUploadImage.Text = "Upload Image";
            this.lblUploadImage.Click += new System.EventHandler(this.lblUploadImage_Click);
            // 
            // pnlUploadVideo
            // 
            this.pnlUploadVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlUploadVideo.Controls.Add(this.pbMovies);
            this.pnlUploadVideo.Controls.Add(this.lblUploadVideo);
            this.pnlUploadVideo.Location = new System.Drawing.Point(345, 110);
            this.pnlUploadVideo.Name = "pnlUploadVideo";
            this.pnlUploadVideo.Size = new System.Drawing.Size(270, 201);
            this.pnlUploadVideo.TabIndex = 24;
            this.pnlUploadVideo.Click += new System.EventHandler(this.pnlUploadVideo_Click);
            // 
            // pbMovies
            // 
            this.pbMovies.BackColor = System.Drawing.Color.Transparent;
            this.pbMovies.Image = global::KictureCollege.Properties.Resources.Movies;
            this.pbMovies.Location = new System.Drawing.Point(57, 59);
            this.pbMovies.Name = "pbMovies";
            this.pbMovies.Size = new System.Drawing.Size(159, 126);
            this.pbMovies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMovies.TabIndex = 4;
            this.pbMovies.TabStop = false;
            this.pbMovies.Click += new System.EventHandler(this.pbMovies_Click);
            // 
            // lblUploadVideo
            // 
            this.lblUploadVideo.AutoSize = true;
            this.lblUploadVideo.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUploadVideo.ForeColor = System.Drawing.Color.Green;
            this.lblUploadVideo.Location = new System.Drawing.Point(51, 11);
            this.lblUploadVideo.Name = "lblUploadVideo";
            this.lblUploadVideo.Size = new System.Drawing.Size(174, 32);
            this.lblUploadVideo.TabIndex = 0;
            this.lblUploadVideo.Text = "Upload Video";
            this.lblUploadVideo.Click += new System.EventHandler(this.lblUploadVideo_Click);
            // 
            // pnlRealTimeDetection
            // 
            this.pnlRealTimeDetection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlRealTimeDetection.Controls.Add(this.pbCam);
            this.pnlRealTimeDetection.Controls.Add(this.lblRealTimeDetection);
            this.pnlRealTimeDetection.Location = new System.Drawing.Point(159, 334);
            this.pnlRealTimeDetection.Name = "pnlRealTimeDetection";
            this.pnlRealTimeDetection.Size = new System.Drawing.Size(348, 201);
            this.pnlRealTimeDetection.TabIndex = 24;
            this.pnlRealTimeDetection.Click += new System.EventHandler(this.pnlRealTimeDetection_Click);
            // 
            // pbCam
            // 
            this.pbCam.BackColor = System.Drawing.Color.Transparent;
            this.pbCam.Image = global::KictureCollege.Properties.Resources.Cam;
            this.pbCam.Location = new System.Drawing.Point(77, 58);
            this.pbCam.Name = "pbCam";
            this.pbCam.Size = new System.Drawing.Size(199, 127);
            this.pbCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCam.TabIndex = 4;
            this.pbCam.TabStop = false;
            this.pbCam.Click += new System.EventHandler(this.pbCam_Click);
            // 
            // lblRealTimeDetection
            // 
            this.lblRealTimeDetection.AutoSize = true;
            this.lblRealTimeDetection.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealTimeDetection.ForeColor = System.Drawing.Color.Green;
            this.lblRealTimeDetection.Location = new System.Drawing.Point(51, 11);
            this.lblRealTimeDetection.Name = "lblRealTimeDetection";
            this.lblRealTimeDetection.Size = new System.Drawing.Size(255, 32);
            this.lblRealTimeDetection.TabIndex = 0;
            this.lblRealTimeDetection.Text = "Real Time Detection";
            this.lblRealTimeDetection.Click += new System.EventHandler(this.lblRealTimeDetection_Click);
            // 
            // ChooseRecognitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KictureCollege.Properties.Resources.NightSky;
            this.ClientSize = new System.Drawing.Size(674, 576);
            this.Controls.Add(this.pnlRealTimeDetection);
            this.Controls.Add(this.pnlUploadVideo);
            this.Controls.Add(this.pnlUploadImage);
            this.Controls.Add(this.pbKictureCollege);
            this.Name = "ChooseRecognitionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseRecognition";
            ((System.ComponentModel.ISupportInitialize)(this.pbKictureCollege)).EndInit();
            this.pnlUploadImage.ResumeLayout(false);
            this.pnlUploadImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            this.pnlUploadVideo.ResumeLayout(false);
            this.pnlUploadVideo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovies)).EndInit();
            this.pnlRealTimeDetection.ResumeLayout(false);
            this.pnlRealTimeDetection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbKictureCollege;
        private System.Windows.Forms.Panel pnlUploadImage;
        private System.Windows.Forms.Label lblUploadImage;
        private System.Windows.Forms.PictureBox pbCamera;
        private System.Windows.Forms.Panel pnlUploadVideo;
        private System.Windows.Forms.Label lblUploadVideo;
        private System.Windows.Forms.PictureBox pbMovies;
        private System.Windows.Forms.Panel pnlRealTimeDetection;
        private System.Windows.Forms.PictureBox pbCam;
        private System.Windows.Forms.Label lblRealTimeDetection;
    }
}