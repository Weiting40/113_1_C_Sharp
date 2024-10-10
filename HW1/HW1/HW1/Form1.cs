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
            lblTranslation.Text = "톀ㅯ짨";
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "톀ㅯ짽";
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "톀ㅯ�|";
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "톀ㅯㄽ";
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "톀ㅯㅋ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
