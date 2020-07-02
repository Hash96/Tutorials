using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Login_Click(object sender, EventArgs e)
        {
            String username = txt1.Text;
            String password = txt2.Text;


            if (username == "Admin" && password == "admin123")
            {
                Form2 fm = new Form2();
                fm.Show();
                this.Hide();
            }
            else { }
        }
    }
}
