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

namespace project19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(StudentID.Text);
            string Name = txtName.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\StudentDB.mdf;Integrated Security=True;Connect Timeout=30");
            String qry = "INSERT INTO StudentTable Values("+ID+",'"+Name+"')";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record inserted successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

    }
}
