namespace tutorl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnshowback_Click(object sender, EventArgs e)
        {
            ptxback.Visible = true;
            ptxfront.Visible = false;
        }

        private void btnshowfront_Click(object sender, EventArgs e)
        {
            ptxback.Visible = false;
            ptxfront.Visible=true;
        }
    }
}
