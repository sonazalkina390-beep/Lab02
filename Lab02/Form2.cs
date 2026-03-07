using System;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAddBinary_Click(object sender, EventArgs e)
        {
            string bin1 = txtBinary1.Text.Trim();
            string bin2 = txtBinary2.Text.Trim();

            if (!BinaryCalculator.AddBinary(bin1, bin2, out string binarySum, out long decimalSum))
            {
                MessageBox.Show("Пожалуйста, введите корректные двоичные числа (только 0 и 1).",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearResults();
                return;
            }

            lblBinarySumResult.Text = binarySum;
            lblDecimalSumResult.Text = decimalSum.ToString();
        }

        private void ClearResults()
        {
            lblBinarySumResult.Text = "";
            lblDecimalSumResult.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e) { }
    }
}