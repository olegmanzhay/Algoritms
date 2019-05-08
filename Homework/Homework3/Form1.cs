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
            FindPrograms A = new FindPrograms();
            A.Number1 = int.Parse(lblNumber1.Text);
            A.Number2 = int.Parse(lblNumber2.Text);
            lblResult.Text = A.Result(A).ToString();


        }
    }
}
