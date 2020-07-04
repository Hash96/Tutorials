using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
            txtCPass.PasswordChar = '*';
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string FName = txtFName.Text;
            string LName = txtLName.Text;
            int Age = int.Parse(txtAge.Text);
            string Uni = txtUni.Text;
            string Password = txtPass.Text;
            string CPassword = txtCPass.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\University.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "INSERT INTO DataTable Values('"+ FName +"','" + LName + "'," + Age + ",'" + Uni + "','" + Password + "','" + CPassword + "')";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record inserted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
