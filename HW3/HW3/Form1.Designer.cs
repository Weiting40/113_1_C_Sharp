namespace HW3
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
            txtInitialBacteria = new TextBox();
            txtDoublingDays = new TextBox();
            btnCalculate = new Button();
            listBoxResult = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtInitialBacteria
            // 
            txtInitialBacteria.Location = new Point(267, 96);
            txtInitialBacteria.Name = "txtInitialBacteria";
            txtInitialBacteria.Size = new Size(170, 34);
            txtInitialBacteria.TabIndex = 0;
            // 
            // txtDoublingDays
            // 
            txtDoublingDays.Location = new Point(461, 96);
            txtDoublingDays.Name = "txtDoublingDays";
            txtDoublingDays.Size = new Size(204, 34);
            txtDoublingDays.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(101, 323);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(119, 71);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "按鍵";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;
            listBoxResult.ItemHeight = 26;
            listBoxResult.Location = new Point(267, 152);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(409, 342);
            listBoxResult.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 48);
            label1.Name = "label1";
            label1.Size = new Size(170, 26);
            label1.TabIndex = 4;
            label1.Text = "Number of days";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(461, 48);
            label2.Name = "label2";
            label2.Size = new Size(204, 26);
            label2.TabIndex = 5;
            label2.Text = "Number of Bacteria";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 552);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtDoublingDays);
            Controls.Add(txtInitialBacteria);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInitialBacteria;
        private TextBox txtDoublingDays;
        private Button btnCalculate;
        private ListBox listBoxResult;
        private Label label1;
        private Label label2;
    }
}
