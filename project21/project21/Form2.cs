using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project21
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int IDno = int.Parse(txtid.Text);
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\TestDB.mdf;Integrated Security=True;Connect Timeout=30");

            String del = "DELETE FROM testtable Where ID='" + IDno + "'";
            SqlCommand cmd = new SqlCommand(del, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted successfully");
            }
            catch (Exception se)
            {
                MessageBox.Show("" + se);
            }
        }
    }
}
