/*
 Количество маршрутов с препятствиями. 
 Реализовать чтение массива с препятствием и нахождение количество маршрутов.
 Олег Манжай
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x1 = 0, x2 = 0, x3 = 0, x4 = 0, x5 = 0, x6 = 0, x7 = 0, x8 = 0, x9 = 0; // Значение кнопки
        private void btn1_Click(object sender, EventArgs e)
        {
            x1++;
            if (x1 == 1)
                btn1.BackColor = Color.Empty;
            else if (x1 == 2)
                btn1.BackColor = Color.Green;
            else if (x1 == 3)
                btn1.BackColor = Color.Yellow;
            else if (x1 == 4)
            {
                btn1.BackColor = Color.Red;
                x1 = 0;
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            x2++;
            if (x2 == 1)
                btn2.BackColor = Color.Empty;
            else if (x2 == 2)
                btn2.BackColor = Color.Green;
            else if (x2 == 3)
                btn2.BackColor = Color.Yellow;
            else if (x2 == 4)
            {
                btn2.BackColor = Color.Red;
                x2 = 0;
            }
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            x3++;
            if (x3 == 1)
                btn3.BackColor = Color.Empty;
            else if (x3 == 2)
                btn3.BackColor = Color.Green;
            else if (x3 == 3)
                btn3.BackColor = Color.Yellow;
            else if (x3 == 4)
            {
                btn3.BackColor = Color.Red;
                x3 = 0;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            x4++;
            if (x4 == 1)
                btn4.BackColor = Color.Empty;
            else if (x4 == 2)
                btn4.BackColor = Color.Green;
            else if (x4 == 3)
                btn4.BackColor = Color.Yellow;
            else if (x4 == 4)
            {
                btn4.BackColor = Color.Red;
                x4 = 0;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            x5++;
            if (x5 == 1)
                btn5.BackColor = Color.Empty;
            else if (x5 == 2)
                btn5.BackColor = Color.Green;
            else if (x5 == 3)
                btn5.BackColor = Color.Yellow;
            else if (x5 == 4)
            {
                btn5.BackColor = Color.Red;
                x5 = 0;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            x6++;
            if (x6 == 1)
                btn6.BackColor = Color.Empty;
            else if (x6 == 2)
                btn6.BackColor = Color.Green;
            else if (x6 == 3)
                btn6.BackColor = Color.Yellow;
            else if (x6 == 4)
            {
                btn6.BackColor = Color.Red;
                x6 = 0;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            x7++;
            if (x7 == 1)
                btn7.BackColor = Color.Empty;
            else if (x7 == 2)
                btn7.BackColor = Color.Green;
            else if (x7 == 3)
                btn7.BackColor = Color.Yellow;
            else if (x7 == 4)
            {
                btn7.BackColor = Color.Red;
                x7 = 0;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            x8++;
            if (x8 == 1)
                btn8.BackColor = Color.Empty;
            else if (x8 == 2)
                btn8.BackColor = Color.Green;
            else if (x8 == 3)
                btn8.BackColor = Color.Yellow;
            else if (x8 == 4)
            {
                btn8.BackColor = Color.Red;
                x8 = 0;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            x9++;
            if (x9 == 1)
                btn9.BackColor = Color.Empty;
            else if (x9 == 2)
                btn9.BackColor = Color.Green;
            else if (x9 == 3)
                btn9.BackColor = Color.Yellow;
            else if (x9 == 4)
            {
                btn9.BackColor = Color.Red;
                x9 = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Count A = new Count();
            A.Mass = new int[3, 3] { { x1, x2, x3 }, { x4, x5, x6 }, { x7, x8, x9 } }; // массив значений поля, который изменяется
            A.Mass1 = new int[3, 3] { { x1, x2, x3 }, { x4, x5, x6 }, { x7, x8, x9 } };// массив значений поля, который не изменяется 
            MessageBox.Show(A.CountWays(A).ToString());
        }
    }
}
