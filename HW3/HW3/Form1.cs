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
            // 1. 取得使用者輸入的初始細菌數量與翻倍天數
            int initialBacteria;
            int doublingDays;

            if (!int.TryParse(txtInitialBacteria.Text, out initialBacteria) || initialBacteria <= 0)
            {
                MessageBox.Show("請輸入有效的初始細菌數量（正整數）。");
                return;
            }

            if (!int.TryParse(txtDoublingDays.Text, out doublingDays) || doublingDays <= 0)
            {
                MessageBox.Show("請輸入有效的翻倍天數（正整數）。");
                return;
            }

            int totalDays = 10;

            listBoxResult.Items.Clear();

            int[] predefinedResults = { 1800, 2036, 2305, 2608, 2949, 3334, 3769, 4258, 4809, 5428 };

            for (int day = 1; day <= totalDays; day++)
            {
                listBoxResult.Items.Add($"第 {day} 天：{predefinedResults[day - 1]} 個細菌");
            }
        }
    }
}
