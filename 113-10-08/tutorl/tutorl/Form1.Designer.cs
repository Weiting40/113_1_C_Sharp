namespace tutorl
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
            ptxback = new PictureBox();
            ptxfront = new PictureBox();
            btnshowback = new Button();
            btnshowfront = new Button();
            ((System.ComponentModel.ISupportInitialize)ptxback).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxfront).BeginInit();
            SuspendLayout();
            // 
            // ptxback
            // 
            ptxback.Image = Properties.Resources.Backface_Blue;
            ptxback.Location = new Point(37, 30);
            ptxback.Name = "ptxback";
            ptxback.Size = new Size(111, 152);
            ptxback.SizeMode = PictureBoxSizeMode.Zoom;
            ptxback.TabIndex = 0;
            ptxback.TabStop = false;
            ptxback.Visible = false;
            // 
            // ptxfront
            // 
            ptxfront.Image = Properties.Resources.Ace_Spades;
            ptxfront.Location = new Point(192, 30);
            ptxfront.Name = "ptxfront";
            ptxfront.Size = new Size(111, 152);
            ptxfront.SizeMode = PictureBoxSizeMode.Zoom;
            ptxfront.TabIndex = 1;
            ptxfront.TabStop = false;
            ptxfront.Visible = false;
            // 
            // btnshowback
            // 
            btnshowback.Location = new Point(37, 212);
            btnshowback.Name = "btnshowback";
            btnshowback.Size = new Size(111, 48);
            btnshowback.TabIndex = 2;
            btnshowback.Text = "背面";
            btnshowback.UseVisualStyleBackColor = true;
            btnshowback.Click += btnshowback_Click;
            // 
            // btnshowfront
            // 
            btnshowfront.Location = new Point(192, 212);
            btnshowfront.Name = "btnshowfront";
            btnshowfront.Size = new Size(111, 48);
            btnshowfront.TabIndex = 3;
            btnshowfront.Text = "正面";
            btnshowfront.UseVisualStyleBackColor = true;
            btnshowfront.Click += btnshowfront_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 305);
            Controls.Add(btnshowfront);
            Controls.Add(btnshowback);
            Controls.Add(ptxfront);
            Controls.Add(ptxback);
            Name = "Form1";
            Text = "翻牌";
            ((System.ComponentModel.ISupportInitialize)ptxback).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxfront).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptxback;
        private PictureBox ptxfront;
        private Button btnshowback;
        private Button btnshowfront;
    }
}
