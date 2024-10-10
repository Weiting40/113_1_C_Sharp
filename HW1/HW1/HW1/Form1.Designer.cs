namespace HW1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnExit = new Button();
            lblTranslation = new Label();
            pic2 = new PictureBox();
            pic3 = new PictureBox();
            pic4 = new PictureBox();
            pic5 = new PictureBox();
            pic6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic6).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft JhengHei UI", 12F);
            btnExit.Location = new Point(306, 353);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(116, 48);
            btnExit.TabIndex = 0;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblTranslation
            // 
            lblTranslation.BorderStyle = BorderStyle.Fixed3D;
            lblTranslation.Font = new Font("Microsoft JhengHei UI", 24F);
            lblTranslation.Location = new Point(258, 221);
            lblTranslation.Name = "lblTranslation";
            lblTranslation.Size = new Size(207, 76);
            lblTranslation.TabIndex = 1;
            lblTranslation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pic2
            // 
            pic2.Image = (Image)resources.GetObject("pic2.Image");
            pic2.Location = new Point(27, 12);
            pic2.Name = "pic2";
            pic2.Size = new Size(89, 130);
            pic2.SizeMode = PictureBoxSizeMode.Zoom;
            pic2.TabIndex = 2;
            pic2.TabStop = false;
            pic2.Click += pic2_Click;
            // 
            // pic3
            // 
            pic3.Image = (Image)resources.GetObject("pic3.Image");
            pic3.Location = new Point(182, 12);
            pic3.Name = "pic3";
            pic3.Size = new Size(89, 130);
            pic3.SizeMode = PictureBoxSizeMode.Zoom;
            pic3.TabIndex = 3;
            pic3.TabStop = false;
            pic3.Click += pic3_Click;
            // 
            // pic4
            // 
            pic4.Image = (Image)resources.GetObject("pic4.Image");
            pic4.Location = new Point(333, 12);
            pic4.Name = "pic4";
            pic4.Size = new Size(89, 130);
            pic4.SizeMode = PictureBoxSizeMode.Zoom;
            pic4.TabIndex = 4;
            pic4.TabStop = false;
            pic4.Click += pic4_Click;
            // 
            // pic5
            // 
            pic5.Image = (Image)resources.GetObject("pic5.Image");
            pic5.Location = new Point(483, 12);
            pic5.Name = "pic5";
            pic5.Size = new Size(89, 130);
            pic5.SizeMode = PictureBoxSizeMode.Zoom;
            pic5.TabIndex = 5;
            pic5.TabStop = false;
            pic5.Click += pic5_Click;
            // 
            // pic6
            // 
            pic6.Image = (Image)resources.GetObject("pic6.Image");
            pic6.Location = new Point(633, 12);
            pic6.Name = "pic6";
            pic6.Size = new Size(89, 130);
            pic6.SizeMode = PictureBoxSizeMode.Zoom;
            pic6.TabIndex = 6;
            pic6.TabStop = false;
            pic6.Click += pic6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 450);
            Controls.Add(pic6);
            Controls.Add(pic5);
            Controls.Add(pic4);
            Controls.Add(pic3);
            Controls.Add(pic2);
            Controls.Add(lblTranslation);
            Controls.Add(btnExit);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Label lblTranslation;
        private PictureBox pic2;
        private PictureBox pic3;
        private PictureBox pic4;
        private PictureBox pic5;
        private PictureBox pic6;
    }
}
