namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalculateTax_Click(object sender, EventArgs e)
        {
            try
            {
                // 從 txtIncome 中讀取應稅收入
                double income = double.Parse(txtIncome.Text);
                double tax = CalculateTax(income);  // 計算稅額
                double netIncome = income - tax;    // 計算稅後淨收入

                // 在 lblResult 顯示計算結果
                lblResult.Text = "Payable Tax: NT$" + tax.ToString("N2") + "\n" +
                                 "NetIncome: NT$" + netIncome.ToString("N2");
                lblResult2.Text = "NetIncome: NT$" + netIncome.ToString("N2");
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入有效的數值", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 計算稅額的函式
        private double CalculateTax(double income)
        {
            double tax = 0;

            if (income <= 590000)
            {
                tax = income * 0.05;
            }
            else if (income <= 1330000)
            {
                tax = 590000 * 0.05 + (income - 590000) * 0.12;
            }
            else if (income <= 2660000)
            {
                tax = 590000 * 0.05 + (1330000 - 590000) * 0.12 + (income - 1330000) * 0.20;
            }
            else if (income <= 4980000)
            {
                tax = 590000 * 0.05 + (1330000 - 590000) * 0.12 + (2660000 - 1330000) * 0.20 + (income - 2660000) * 0.30;
            }
            else
            {
                tax = 590000 * 0.05 + (1330000 - 590000) * 0.12 + (2660000 - 1330000) * 0.20 + (4980000 - 2660000) * 0.30 + (income - 4980000) * 0.40;
            }

            return tax;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
