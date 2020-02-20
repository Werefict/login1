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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=303-18; Initial Catalog=Login; Integrated Security=true;");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand com = new SqlCommand($"SELECT login FROM Users where login = '{textBox1.Text}' and password = '{textBox2.Text}' ", con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
                MessageBox.Show("GOOD");

        }


    }



}
