namespace Q1
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
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtLength = new TextBox();
            txtWidth = new TextBox();
            txtUnitCost = new TextBox();
            btnArea = new Button();
            btnBoundary = new Button();
            btnCost = new Button();
            btnExit = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 15F);
            label2.Location = new Point(130, 218);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(184, 25);
            label2.TabIndex = 1;
            label2.Text = "Width of the Field:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 348);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(212, 25);
            label3.TabIndex = 2;
            label3.Text = "Unit Cost of  Fencing:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 15F);
            label1.Location = new Point(130, 105);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 0;
            label1.Text = "Length of the Field:";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(401, 91);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(288, 33);
            txtLength.TabIndex = 3;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(401, 210);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(288, 33);
            txtWidth.TabIndex = 4;
            // 
            // txtUnitCost
            // 
            txtUnitCost.Location = new Point(401, 340);
            txtUnitCost.Name = "txtUnitCost";
            txtUnitCost.Size = new Size(288, 33);
            txtUnitCost.TabIndex = 5;
            // 
            // btnArea
            // 
            btnArea.Location = new Point(130, 523);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(125, 73);
            btnArea.TabIndex = 6;
            btnArea.Text = "Area";
            btnArea.UseVisualStyleBackColor = true;
            btnArea.Click += btnArea_Click;
            // 
            // btnBoundary
            // 
            btnBoundary.Location = new Point(334, 523);
            btnBoundary.Name = "btnBoundary";
            btnBoundary.Size = new Size(125, 73);
            btnBoundary.TabIndex = 7;
            btnBoundary.Text = "Boundary";
            btnBoundary.UseVisualStyleBackColor = true;
            btnBoundary.Click += btnBoundary_Click;
            // 
            // btnCost
            // 
            btnCost.Location = new Point(564, 523);
            btnCost.Name = "btnCost";
            btnCost.Size = new Size(125, 73);
            btnCost.TabIndex = 8;
            btnCost.Text = "Cost";
            btnCost.UseVisualStyleBackColor = true;
            btnCost.Click += btnCost_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(775, 523);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(125, 73);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.FlatStyle = FlatStyle.System;
            lblResult.ImageAlign = ContentAlignment.TopLeft;
            lblResult.Location = new Point(180, 448);
            lblResult.Margin = new Padding(5, 0, 5, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(212, 25);
            lblResult.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 750);
            Controls.Add(lblResult);
            Controls.Add(btnExit);
            Controls.Add(btnCost);
            Controls.Add(btnBoundary);
            Controls.Add(btnArea);
            Controls.Add(txtUnitCost);
            Controls.Add(txtWidth);
            Controls.Add(txtLength);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft JhengHei UI", 15F);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Cost of  Fencing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox txtLength;
        private TextBox txtWidth;
        private TextBox txtUnitCost;
        private Button btnArea;
        private Button btnBoundary;
        private Button btnCost;
        private Button btnExit;
        private Label lblResult;
    }
}
