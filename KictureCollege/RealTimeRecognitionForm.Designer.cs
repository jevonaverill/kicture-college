namespace KictureCollege
{
    partial class RealTimeRecognitionForm
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
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
            this.pbKictureCollege.TabIndex = 22;
            this.pbKictureCollege.TabStop = false;
            // 
            // pnlChosenImage
            // 
            this.pnlChosenImage.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlChosenImage.Controls.Add(this.pbChosenImage);
            this.pnlChosenImage.Location = new System.Drawing.Point(61, 118);
            this.pnlChosenImage.Name = "pnlChosenImage";
            this.pnlChosenImage.Size = new System.Drawing.Size(781, 416);
            this.pnlChosenImage.TabIndex = 23;
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
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightGray;
            this.btnStart.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Olive;
            this.btnStart.Location = new System.Drawing.Point(284, 562);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(145, 41);
            this.btnStart.TabIndex = 25;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.LightGray;
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Olive;
            this.btnStop.Location = new System.Drawing.Point(455, 562);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(145, 41);
            this.btnStop.TabIndex = 26;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // RealTimeRecognitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KictureCollege.Properties.Resources.NightSky;
            this.ClientSize = new System.Drawing.Size(902, 668);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlChosenImage);
            this.Controls.Add(this.pbKictureCollege);
            this.Name = "RealTimeRecognitionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RealTimeRecognition";
            ((System.ComponentModel.ISupportInitialize)(this.pbKictureCollege)).EndInit();
            this.pnlChosenImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbChosenImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbKictureCollege;
        private System.Windows.Forms.Panel pnlChosenImage;
        private System.Windows.Forms.PictureBox pbChosenImage;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer;
    }
}