/*
Реализовать функцию перевода чисел из десятичной системы в двоичную, используя рекурсию.
 Также добавлен перевод из 10 в 16 и 8 системы счисления 
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

namespace Homework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Реализуе перевод  в определенную систему счисления 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResult_Click(object sender, EventArgs e)
        {
            NewNumber A = new NewNumber();
            A.Number = int.Parse(txtNumber.Text);
            A.SystemNumber = int.Parse(listSystem.Text);
            if (A.SystemNumber == 2)
            {
                lblResult.Text = A.ConvertSystem2(A);
            }
            else if(A.SystemNumber == 8)
            {
                lblResult.Text = A.ConvertSystem8(A);
            }
            else
            {
                lblResult.Text = A.ConvertSystem16(A);
            }
        }
    }
}
