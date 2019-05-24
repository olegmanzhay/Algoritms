//2. Решить задачу о нахождении длины максимальной подпоследовательности с помощью матрицы.
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

namespace Homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            CountStr3 A = new CountStr3();
            A.Str1 = txtStr1.Text;
            A.Str2 = txtStr2.Text;
            string result = string.Empty; 
            txtCount.Text= A.Str3Count(A, ref result).ToString();
            txtStr3.Text = result;

        }
    }
}
