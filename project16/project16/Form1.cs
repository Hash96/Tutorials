using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Cal_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(num1.Text);
            int Num2 = int.Parse(num2.Text);

            lbl3.Text = (Num1 + Num2).ToString();
            lbl4.Text = (Num1 - Num2).ToString();
            lbl5.Text = (Num1 * Num2).ToString();
            lbl6.Text = (Num1 / Num2).ToString();
        }
    }
}
