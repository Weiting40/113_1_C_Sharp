namespace HW2
{
    public partial class Form1 : Form
    {
        //Constant fieds
        const decimal textBox1 = 0.15m;
        const decimal textBox2 = 0.12m;
        const decimal textBox3 = 0.09m;

        // Field variable to hold the total,
        //initialized with 0.
        private decimal total = 0m;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1(object sender, EventArgs e)
        {
            //Add the value of 15 cents to the total.
            total += textBox1;

            //Display the total, fomatted as currency.
            totalLabel.Text = total.ToString("c");

        }
    }
}
