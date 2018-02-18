namespace KictureCollege
{
    partial class HomeForm
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
            this.pnlAreaBased = new System.Windows.Forms.Panel();
            this.pbAreaBased = new System.Windows.Forms.PictureBox();
            this.lblAreaBased = new System.Windows.Forms.Label();
            this.pnlPointBased = new System.Windows.Forms.Panel();
            this.pbPointBased = new System.Windows.Forms.PictureBox();
            this.lblPointBased = new System.Windows.Forms.Label();
            this.pnlEdgeDetection = new System.Windows.Forms.Panel();
            this.pbEdgeDetection = new System.Windows.Forms.PictureBox();
            this.lblEdgeDetection = new System.Windows.Forms.Label();
            this.pnlShapeDetection = new System.Windows.Forms.Panel();
            this.pbShapeDetection = new System.Windows.Forms.PictureBox();
            this.lblShapeDetection = new System.Windows.Forms.Label();
            this.pnlPRandClassification = new System.Windows.Forms.Panel();
            this.pbClassification = new System.Windows.Forms.PictureBox();
            this.pbPatternRecognition = new System.Windows.Forms.PictureBox();
            this.lblPRandClassification = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbKictureCollege)).BeginInit();
            this.pnlAreaBased.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAreaBased)).BeginInit();
            this.pnlPointBased.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPointBased)).BeginInit();
            this.pnlEdgeDetection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdgeDetection)).BeginInit();
            this.pnlShapeDetection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShapeDetection)).BeginInit();
            this.pnlPRandClassification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClassification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatternRecognition)).BeginInit();
            this.SuspendLayout();
            // 
            // pbKictureCollege
            // 
            this.pbKictureCollege.BackColor = System.Drawing.Color.Transparent;
            this.pbKictureCollege.Image = global::KictureCollege.Properties.Resources.Kicture;
            this.pbKictureCollege.Location = new System.Drawing.Point(294, 12);
            this.pbKictureCollege.Name = "pbKictureCollege";
            this.pbKictureCollege.Size = new System.Drawing.Size(150, 71);
            this.pbKictureCollege.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKictureCollege.TabIndex = 19;
            this.pbKictureCollege.TabStop = false;
            // 
            // pnlAreaBased
            // 
            this.pnlAreaBased.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlAreaBased.Controls.Add(this.pbAreaBased);
            this.pnlAreaBased.Controls.Add(this.lblAreaBased);
            this.pnlAreaBased.Location = new System.Drawing.Point(35, 12);
            this.pnlAreaBased.Name = "pnlAreaBased";
            this.pnlAreaBased.Size = new System.Drawing.Size(187, 245);
            this.pnlAreaBased.TabIndex = 20;
            this.pnlAreaBased.Click += new System.EventHandler(this.pnlAreaBased_Click);
            // 
            // pbAreaBased
            // 
            this.pbAreaBased.Image = global::KictureCollege.Properties.Resources.SmoothingMedianFilter;
            this.pbAreaBased.Location = new System.Drawing.Point(17, 56);
            this.pbAreaBased.Name = "pbAreaBased";
            this.pbAreaBased.Size = new System.Drawing.Size(144, 170);
            this.pbAreaBased.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAreaBased.TabIndex = 1;
            this.pbAreaBased.TabStop = false;
            this.pbAreaBased.Click += new System.EventHandler(this.pbAreaBased_Click);
            // 
            // lblAreaBased
            // 
            this.lblAreaBased.AutoSize = true;
            this.lblAreaBased.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaBased.ForeColor = System.Drawing.Color.Green;
            this.lblAreaBased.Location = new System.Drawing.Point(36, 25);
            this.lblAreaBased.Name = "lblAreaBased";
            this.lblAreaBased.Size = new System.Drawing.Size(112, 25);
            this.lblAreaBased.TabIndex = 0;
            this.lblAreaBased.Text = "Area Based";
            this.lblAreaBased.Click += new System.EventHandler(this.lblAreaBased_Click);
            // 
            // pnlPointBased
            // 
            this.pnlPointBased.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlPointBased.Controls.Add(this.pbPointBased);
            this.pnlPointBased.Controls.Add(this.lblPointBased);
            this.pnlPointBased.Location = new System.Drawing.Point(35, 277);
            this.pnlPointBased.Name = "pnlPointBased";
            this.pnlPointBased.Size = new System.Drawing.Size(187, 224);
            this.pnlPointBased.TabIndex = 21;
            this.pnlPointBased.Click += new System.EventHandler(this.pnlPointBased_Click);
            // 
            // pbPointBased
            // 
            this.pbPointBased.Image = global::KictureCollege.Properties.Resources.ThresholdExample;
            this.pbPointBased.Location = new System.Drawing.Point(17, 56);
            this.pbPointBased.Name = "pbPointBased";
            this.pbPointBased.Size = new System.Drawing.Size(153, 143);
            this.pbPointBased.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPointBased.TabIndex = 1;
            this.pbPointBased.TabStop = false;
            this.pbPointBased.Click += new System.EventHandler(this.pbPointBased_Click);
            // 
            // lblPointBased
            // 
            this.lblPointBased.AutoSize = true;
            this.lblPointBased.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointBased.ForeColor = System.Drawing.Color.Green;
            this.lblPointBased.Location = new System.Drawing.Point(36, 18);
            this.lblPointBased.Name = "lblPointBased";
            this.lblPointBased.Size = new System.Drawing.Size(117, 25);
            this.lblPointBased.TabIndex = 0;
            this.lblPointBased.Text = "Point Based";
            this.lblPointBased.Click += new System.EventHandler(this.lblPointBased_Click);
            // 
            // pnlEdgeDetection
            // 
            this.pnlEdgeDetection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlEdgeDetection.Controls.Add(this.pbEdgeDetection);
            this.pnlEdgeDetection.Controls.Add(this.lblEdgeDetection);
            this.pnlEdgeDetection.Location = new System.Drawing.Point(258, 102);
            this.pnlEdgeDetection.Name = "pnlEdgeDetection";
            this.pnlEdgeDetection.Size = new System.Drawing.Size(227, 179);
            this.pnlEdgeDetection.TabIndex = 21;
            this.pnlEdgeDetection.Click += new System.EventHandler(this.pnlEdgeDetection_Click);
            // 
            // pbEdgeDetection
            // 
            this.pbEdgeDetection.Image = global::KictureCollege.Properties.Resources.building_lsd;
            this.pbEdgeDetection.Location = new System.Drawing.Point(38, 41);
            this.pbEdgeDetection.Name = "pbEdgeDetection";
            this.pbEdgeDetection.Size = new System.Drawing.Size(157, 122);
            this.pbEdgeDetection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEdgeDetection.TabIndex = 1;
            this.pbEdgeDetection.TabStop = false;
            this.pbEdgeDetection.Click += new System.EventHandler(this.pbEdgeDetection_Click);
            // 
            // lblEdgeDetection
            // 
            this.lblEdgeDetection.AutoSize = true;
            this.lblEdgeDetection.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdgeDetection.ForeColor = System.Drawing.Color.Green;
            this.lblEdgeDetection.Location = new System.Drawing.Point(45, 10);
            this.lblEdgeDetection.Name = "lblEdgeDetection";
            this.lblEdgeDetection.Size = new System.Drawing.Size(146, 25);
            this.lblEdgeDetection.TabIndex = 0;
            this.lblEdgeDetection.Text = "Edge Detection";
            this.lblEdgeDetection.Click += new System.EventHandler(this.lblEdgeDetection_Click);
            // 
            // pnlShapeDetection
            // 
            this.pnlShapeDetection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlShapeDetection.Controls.Add(this.pbShapeDetection);
            this.pnlShapeDetection.Controls.Add(this.lblShapeDetection);
            this.pnlShapeDetection.Location = new System.Drawing.Point(258, 306);
            this.pnlShapeDetection.Name = "pnlShapeDetection";
            this.pnlShapeDetection.Size = new System.Drawing.Size(227, 179);
            this.pnlShapeDetection.TabIndex = 22;
            this.pnlShapeDetection.Click += new System.EventHandler(this.pnlShapeDetection_Click);
            // 
            // pbShapeDetection
            // 
            this.pbShapeDetection.Image = global::KictureCollege.Properties.Resources.DetectSimpleShapes;
            this.pbShapeDetection.Location = new System.Drawing.Point(38, 41);
            this.pbShapeDetection.Name = "pbShapeDetection";
            this.pbShapeDetection.Size = new System.Drawing.Size(157, 122);
            this.pbShapeDetection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShapeDetection.TabIndex = 1;
            this.pbShapeDetection.TabStop = false;
            this.pbShapeDetection.Click += new System.EventHandler(this.pbShapeDetection_Click);
            // 
            // lblShapeDetection
            // 
            this.lblShapeDetection.AutoSize = true;
            this.lblShapeDetection.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShapeDetection.ForeColor = System.Drawing.Color.Green;
            this.lblShapeDetection.Location = new System.Drawing.Point(40, 10);
            this.lblShapeDetection.Name = "lblShapeDetection";
            this.lblShapeDetection.Size = new System.Drawing.Size(155, 25);
            this.lblShapeDetection.TabIndex = 0;
            this.lblShapeDetection.Text = "Shape Detection";
            this.lblShapeDetection.Click += new System.EventHandler(this.lblShapeDetection_Click);
            // 
            // pnlPRandClassification
            // 
            this.pnlPRandClassification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlPRandClassification.Controls.Add(this.pbClassification);
            this.pnlPRandClassification.Controls.Add(this.pbPatternRecognition);
            this.pnlPRandClassification.Controls.Add(this.lblPRandClassification);
            this.pnlPRandClassification.Location = new System.Drawing.Point(515, 12);
            this.pnlPRandClassification.Name = "pnlPRandClassification";
            this.pnlPRandClassification.Size = new System.Drawing.Size(227, 489);
            this.pnlPRandClassification.TabIndex = 21;
            this.pnlPRandClassification.Click += new System.EventHandler(this.pnlPRandClassification_Click);
            // 
            // pbClassification
            // 
            this.pbClassification.Image = global::KictureCollege.Properties.Resources.FaceDetection;
            this.pbClassification.Location = new System.Drawing.Point(39, 276);
            this.pbClassification.Name = "pbClassification";
            this.pbClassification.Size = new System.Drawing.Size(152, 151);
            this.pbClassification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClassification.TabIndex = 3;
            this.pbClassification.TabStop = false;
            this.pbClassification.Click += new System.EventHandler(this.pbClassification_Click);
            // 
            // pbPatternRecognition
            // 
            this.pbPatternRecognition.Image = global::KictureCollege.Properties.Resources.Images;
            this.pbPatternRecognition.Location = new System.Drawing.Point(39, 104);
            this.pbPatternRecognition.Name = "pbPatternRecognition";
            this.pbPatternRecognition.Size = new System.Drawing.Size(152, 151);
            this.pbPatternRecognition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPatternRecognition.TabIndex = 1;
            this.pbPatternRecognition.TabStop = false;
            this.pbPatternRecognition.Click += new System.EventHandler(this.pbPatternRecognition_Click);
            // 
            // lblPRandClassification
            // 
            this.lblPRandClassification.AutoSize = true;
            this.lblPRandClassification.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPRandClassification.ForeColor = System.Drawing.Color.Green;
            this.lblPRandClassification.Location = new System.Drawing.Point(20, 35);
            this.lblPRandClassification.Name = "lblPRandClassification";
            this.lblPRandClassification.Size = new System.Drawing.Size(194, 50);
            this.lblPRandClassification.TabIndex = 0;
            this.lblPRandClassification.Text = "Pattern Recognition \r\nand Classification\r\n";
            this.lblPRandClassification.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPRandClassification.Click += new System.EventHandler(this.lblPRandClassification_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KictureCollege.Properties.Resources.NightSky;
            this.ClientSize = new System.Drawing.Size(785, 513);
            this.Controls.Add(this.pnlPRandClassification);
            this.Controls.Add(this.pnlShapeDetection);
            this.Controls.Add(this.pnlEdgeDetection);
            this.Controls.Add(this.pnlPointBased);
            this.Controls.Add(this.pnlAreaBased);
            this.Controls.Add(this.pbKictureCollege);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageProcess";
            ((System.ComponentModel.ISupportInitialize)(this.pbKictureCollege)).EndInit();
            this.pnlAreaBased.ResumeLayout(false);
            this.pnlAreaBased.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAreaBased)).EndInit();
            this.pnlPointBased.ResumeLayout(false);
            this.pnlPointBased.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPointBased)).EndInit();
            this.pnlEdgeDetection.ResumeLayout(false);
            this.pnlEdgeDetection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdgeDetection)).EndInit();
            this.pnlShapeDetection.ResumeLayout(false);
            this.pnlShapeDetection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShapeDetection)).EndInit();
            this.pnlPRandClassification.ResumeLayout(false);
            this.pnlPRandClassification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClassification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatternRecognition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbKictureCollege;
        private System.Windows.Forms.Panel pnlAreaBased;
        private System.Windows.Forms.PictureBox pbAreaBased;
        private System.Windows.Forms.Label lblAreaBased;
        private System.Windows.Forms.Panel pnlPointBased;
        private System.Windows.Forms.PictureBox pbPointBased;
        private System.Windows.Forms.Label lblPointBased;
        private System.Windows.Forms.Panel pnlEdgeDetection;
        private System.Windows.Forms.PictureBox pbEdgeDetection;
        private System.Windows.Forms.Label lblEdgeDetection;
        private System.Windows.Forms.Panel pnlShapeDetection;
        private System.Windows.Forms.PictureBox pbShapeDetection;
        private System.Windows.Forms.Label lblShapeDetection;
        private System.Windows.Forms.Panel pnlPRandClassification;
        private System.Windows.Forms.PictureBox pbPatternRecognition;
        private System.Windows.Forms.Label lblPRandClassification;
        private System.Windows.Forms.PictureBox pbClassification;
    }
}

