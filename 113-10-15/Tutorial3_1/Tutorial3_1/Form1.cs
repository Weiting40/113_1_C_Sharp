namespace Tutorial3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            string output;


            output = "����" + txtYear.Text + "�~" + txtMonth.Text + "��" + txtDay.Text + "��" + "�P��" + txtDayofweek.Text;

            lblshow.Text = output;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtDayofweek.Text = "";
            txtDay.Text = "";
            txtMonth.Text = "";
            txtYear.Text = "";
            lblshow.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            00this.Close();
        }
    }
}
