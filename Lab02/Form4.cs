using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form4 : Form
    {
         public Form4()
            {
                InitializeComponent();
                task1.Click += task1_Click;
                task2.Click += task2_Click;
                task3.Click += task3_Click;
            } //события при нажатии кнопок

            private void Form4_Load(object sender, EventArgs e)
            {

            }

            private void task1_Click(object sender, EventArgs e)
            {
                Form1 f1 = new Form1();
                f1.Show();
            }
            private void task2_Click(object sender, EventArgs e)
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
            private void task3_Click(object sender, EventArgs e)
            {
                Form3 f3 = new Form3();
                f3.Show();
            }
            private void label1_Click(object sender, EventArgs e)
            {

            }
        }
    }