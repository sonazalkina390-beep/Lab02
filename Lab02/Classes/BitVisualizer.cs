using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab02
{
    public static class BitVisualizer
    {
        /// Рисует биты числа в Graphics.
        public static void DrawBits(Graphics g, string binaryStr, int xStart, int yStart, int squareSize = 30, int spacing = 5)
        {
            if (string.IsNullOrEmpty(binaryStr)) return;

            Font font = new Font("Arial", 10);
            Pen blackPen = Pens.Black;

            for (int i = 0; i < binaryStr.Length; i++)
            {
                char bit = binaryStr[i];
                int x = xStart + i * (squareSize + spacing);
                int y = yStart;

                Brush fillBrush = bit == '1' ? Brushes.Black : Brushes.White;
                Brush textBrush = bit == '1' ? Brushes.White : Brushes.Black;

                // Рисуем квадрат
                g.FillRectangle(fillBrush, x, y, squareSize, squareSize);
                g.DrawRectangle(blackPen, x, y, squareSize, squareSize);

                // Рисуем цифру
                SizeF textSize = g.MeasureString(bit.ToString(), font);
                float tx = x + (squareSize - textSize.Width) / 2;
                float ty = y + (squareSize - textSize.Height) / 2;
                g.DrawString(bit.ToString(), font, textBrush, tx, ty);
            }

            font.Dispose();
        }

        /// Рисует подпись под визуализацией.
        public static void DrawCaption(Graphics g, long decimalValue, string binaryStr, int x, int y, Font font)
        {
            string caption = $"Десятичное: {decimalValue}, Двоичное: {binaryStr}";
            g.DrawString(caption, font, Brushes.Black, x, y);
        }
    }
}