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
                lblResult.Text = "�Цa�����n�O: " + area + " ������";
            }
            catch (FormatException)
            {
                MessageBox.Show("�п�J���Ī��ƭ�");
            }
        }

        private void btnBoundary_Click(object sender, EventArgs e)
        {
            try
            {
                double length = double.Parse(txtLength.Text);
                double width = double.Parse(txtWidth.Text);
                double boundary = 2 * (length + width);
                lblResult.Text = "�Цa���P���O: " + boundary + " ���";
            }
            catch (FormatException)
            {
                MessageBox.Show("�п�J���Ī��ƭ�");
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
                lblResult.Text = "�`����: NT$" + totalCost.ToString("N2");
            }
            catch (FormatException)
            {
                MessageBox.Show("�п�J���Ī��ƭ�");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
