namespace HW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "�R�ߤG";
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "�R�ߤT";
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "�R�ߥ|";
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "�R�ߤ�";
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "�R�ߤ�";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
