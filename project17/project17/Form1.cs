using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project17
{
    public partial class btn1 : Form
    {
        int count = 0;
        public btn1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            count++;
            lbl1.Text = count.ToString();
        }

        private void Btn1_Load(object sender, EventArgs e)
        {

        }
    }
}
