//Реализовать перевод из десятичной в двоичную систему счисления с использованием стека.
// Олег Манжай
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            Stack<string> number2 = new Stack<string>();
            int number10 = int.Parse(textBox1.Text);
            while (number10 > 0)
            {
                number2.Push((number10 % 2).ToString());
                number10 /= 2;
            }
            foreach (string s in number2)
                label3.Text += s;

        }
    }
}
