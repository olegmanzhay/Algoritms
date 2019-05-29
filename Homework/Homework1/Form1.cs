/*Написать программу, которая определяет, 
 * является ли введённая скобочная последовательность правильной. 
 * Примеры правильных скобочных выражений – (), ([])(), {}(), ([{}]), 
 * неправильных – )(, ())({), (, ])}), ([(]), для скобок – [, (, {.
Например: (2+(2*2)) или [2/{5*(4+7)}].
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
        private void btnResult_Click(object sender, EventArgs e)
        {
            TrueFalseResult A = new TrueFalseResult();
            A.Str = txtStr.Text;
            lblResult.Text = A.Result(A).ToString();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
