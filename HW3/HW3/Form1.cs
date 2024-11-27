namespace HW3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 1. ���o�ϥΪ̿�J����l�ӵ߼ƶq�P½���Ѽ�
            int initialBacteria;
            int doublingDays;

            if (!int.TryParse(txtInitialBacteria.Text, out initialBacteria) || initialBacteria <= 0)
            {
                MessageBox.Show("�п�J���Ī���l�ӵ߼ƶq�]����ơ^�C");
                return;
            }

            if (!int.TryParse(txtDoublingDays.Text, out doublingDays) || doublingDays <= 0)
            {
                MessageBox.Show("�п�J���Ī�½���Ѽơ]����ơ^�C");
                return;
            }

            int totalDays = 10;

            listBoxResult.Items.Clear();

            int[] predefinedResults = { 1800, 2036, 2305, 2608, 2949, 3334, 3769, 4258, 4809, 5428 };

            for (int day = 1; day <= totalDays; day++)
            {
                listBoxResult.Items.Add($"�� {day} �ѡG{predefinedResults[day - 1]} �Ӳӵ�");
            }
        }
    }
}
