namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            try
            {
                double length = double.Parse(txtLength.Text);
                double width = double.Parse(txtWidth.Text);
                double area = length * width;
                lblResult.Text = "田地的面積是: " + area + " 平方單位";
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入有效的數值");
            }
        }

        private void btnBoundary_Click(object sender, EventArgs e)
        {
            try
            {
                double length = double.Parse(txtLength.Text);
                double width = double.Parse(txtWidth.Text);
                double boundary = 2 * (length + width);
                lblResult.Text = "田地的周長是: " + boundary + " 單位";
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入有效的數值");
            }
        }

        private void btnCost_Click(object sender, EventArgs e)
        {
            try
            {
                double length = double.Parse(txtLength.Text);
                double width = double.Parse(txtWidth.Text);
                double unitCost = double.Parse(txtUnitCost.Text);
                double boundary = 2 * (length + width);
                double totalCost = unitCost * boundary;
                lblResult.Text = "總成本: NT$" + totalCost.ToString("N2");
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入有效的數值");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
