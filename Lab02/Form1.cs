using Lab02;
using System;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string inputText = txtDecimalInput.Text.Trim();
            if (long.TryParse(inputText, out long decimalNumber))
            {
                if (decimalNumber < 0)
                {
                    MessageBox.Show("Пожалуйста, введите неотрицательное число.", "Ошибка ввода",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearResults();
                    return;
                }

                if (NumberConverter.ConvertToAllSystems(decimalNumber, out string binary, out string octal, out string hex))
                {
                    lblBinaryResult.Text = binary;
                    lblOctalResult.Text = octal;
                    lblHexResult.Text = hex;
                }
                else
                {
                    MessageBox.Show("Ошибка при преобразовании.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearResults();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите допустимое целое число.", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearResults();
            }
        }

        private void ClearResults()
        {
            lblBinaryResult.Text = "";
            lblOctalResult.Text = "";
            lblHexResult.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e) { }
    }
}