using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form3 : Form
    {
        private string currentBinary = "";
        private long currentDecimal = -1;

        public Form3()
        {
            InitializeComponent();
        }

        private void btnVisualizeBinary_Click(object sender, EventArgs e)
        {
            string input = txtDecimalForVisualization.Text.Trim();

            if (long.TryParse(input, out long parsedValue) && parsedValue > 1000)
            {
                MessageBox.Show("Пожалуйста, введите число не больше 1000.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                currentBinary = "";
                currentDecimal = -1;
                pictureBoxBinaryVisualization.Invalidate(); // Обновляем PictureBox, чтобы очистить его
                return; // Прервать выполнение метода, если число больше 1000
            }

            if (long.TryParse(input, out long dec) && dec >= 0)
            {
                currentDecimal = dec;
                currentBinary = Convert.ToString(dec, 2);
                pictureBoxBinaryVisualization.Invalidate();
            }
            else
            {
                MessageBox.Show("Введите неотрицательное целое число.");
                currentBinary = "";
                currentDecimal = -1;
                pictureBoxBinaryVisualization.Invalidate();
            }
        }

        private void pictureBoxBinaryVisualization_Paint(object sender, PaintEventArgs e)
        {
            if (string.IsNullOrEmpty(currentBinary) || currentDecimal < 0) return;
            Graphics g = e.Graphics;
            int xStart = 10;
            int yStart = 10;
            int squareSize = 30;
            int spacing = 5;

            BitVisualizer.DrawBits(g, currentBinary, xStart, yStart, squareSize, spacing);

            Font font = new Font("Arial", 10);
            BitVisualizer.DrawCaption(g, currentDecimal, currentBinary, xStart, yStart + squareSize + 10, font);
            font.Dispose();
        }

        private void Form3_Load(object sender, EventArgs e) { }
    }
}
