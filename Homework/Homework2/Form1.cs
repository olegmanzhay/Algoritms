/*
 Реализовать функцию возведения числа a в степень b:
    -Без рекурсии.
    -Рекурсивно.
  Манжай Олег
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

namespace Homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result A = new Result();
            A.Number = int.Parse(txtNumber.Text);
            A.Degree = int.Parse(txtDegree.Text);
            txtResult.Text = A.ResultWithoutRec(A).ToString();
        
        }

        private void bntRec_Click(object sender, EventArgs e)
        {
            Result A = new Result();
            A.Number = int.Parse(txtNumber.Text);
            A.Degree = int.Parse(txtDegree.Text);
            txtResult.Text = A.ResultRec(A).ToString();
        }
    }
}
