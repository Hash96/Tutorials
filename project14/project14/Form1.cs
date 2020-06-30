using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            String Name = txtName.Text;
            int Age =int.Parse(txtAge.Text);
            lblPrint.Text = "Hello " +Name+ " you are "+Age+ " old";


        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
