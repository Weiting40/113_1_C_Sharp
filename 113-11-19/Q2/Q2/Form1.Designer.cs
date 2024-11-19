namespace Q2
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
            txtIncome = new TextBox();
            btnCalculateTax = new Button();
            btnExit = new Button();
            lblResult = new Label();
            lblResult2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 20F);
            label1.Location = new Point(59, 50);
            label1.Name = "label1";
            label1.Size = new Size(356, 35);
            label1.TabIndex = 0;
            label1.Text = "Enter your Taxable Income:";
            // 
            // txtIncome
            // 
            txtIncome.Location = new Point(88, 108);
            txtIncome.Name = "txtIncome";
            txtIncome.Size = new Size(198, 23);
            txtIncome.TabIndex = 1;
            // 
            // btnCalculateTax
            // 
            btnCalculateTax.Location = new Point(120, 319);
            btnCalculateTax.Name = "btnCalculateTax";
            btnCalculateTax.Size = new Size(137, 47);
            btnCalculateTax.TabIndex = 2;
            btnCalculateTax.Text = "Calculate Tax";
            btnCalculateTax.UseVisualStyleBackColor = true;
            btnCalculateTax.Click += btnCalculateTax_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(345, 319);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(137, 47);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.Font = new Font("Microsoft JhengHei UI", 15F);
            lblResult.Location = new Point(88, 149);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(206, 70);
            lblResult.TabIndex = 4;
            // 
            // lblResult2
            // 
            lblResult2.BorderStyle = BorderStyle.Fixed3D;
            lblResult2.Font = new Font("Microsoft JhengHei UI", 15F);
            lblResult2.Location = new Point(88, 235);
            lblResult2.Name = "lblResult2";
            lblResult2.Size = new Size(206, 70);
            lblResult2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult2);
            Controls.Add(lblResult);
            Controls.Add(btnExit);
            Controls.Add(btnCalculateTax);
            Controls.Add(txtIncome);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Income Tax Calculation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIncome;
        private Button btnCalculateTax;
        private Button btnExit;
        private Label lblResult;
        private Label lblResult2;
    }
}
