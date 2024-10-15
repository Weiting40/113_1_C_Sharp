namespace TextBoxDemo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblshow = new Label();
            btnConfirm_Click = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F);
            label1.Location = new Point(59, 78);
            label1.Name = "label1";
            label1.Size = new Size(189, 41);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 24F);
            label2.Location = new Point(59, 194);
            label2.Name = "label2";
            label2.Size = new Size(186, 41);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 24F);
            label3.Location = new Point(59, 309);
            label3.Name = "label3";
            label3.Size = new Size(177, 41);
            label3.TabIndex = 2;
            label3.Text = "Full Name:";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Microsoft JhengHei UI", 24F);
            txtLastName.Location = new Point(275, 187);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(215, 48);
            txtLastName.TabIndex = 25;
            txtLastName.TextChanged += textBox2_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Microsoft JhengHei UI", 24F);
            txtFirstName.Location = new Point(275, 75);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(215, 48);
            txtFirstName.TabIndex = 27;
            // 
            // lblshow
            // 
            lblshow.BorderStyle = BorderStyle.Fixed3D;
            lblshow.Font = new Font("Microsoft JhengHei UI", 24F);
            lblshow.Location = new Point(275, 294);
            lblshow.Name = "lblshow";
            lblshow.Size = new Size(215, 56);
            lblshow.TabIndex = 28;
            lblshow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConfirm_Click
            // 
            btnConfirm_Click.Location = new Point(261, 385);
            btnConfirm_Click.Name = "btnConfirm_Click";
            btnConfirm_Click.Size = new Size(122, 39);
            btnConfirm_Click.TabIndex = 29;
            btnConfirm_Click.Text = "Comfirm";
            btnConfirm_Click.UseVisualStyleBackColor = true;
            btnConfirm_Click.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirm_Click);
            Controls.Add(lblshow);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblshow;
        private Button btnConfirm_Click;
    }
}
