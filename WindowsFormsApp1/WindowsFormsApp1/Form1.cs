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
            SqlCommand com = new SqlCommand("SELECT Users FROM dbo.login WHERE Users = '" + textBox1.Text + "' ", con);// AND password = '" + textBox2.Text + "' ", con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                MessageBox.Show("GOod");
                Form2 fm = new Form2();
                fm.Show();
                this.Hide();
            }
            else
            {
                if (Properties.Settings.Default.time <= DateTime.UtcNow) ;
                {
                    Properties.Settings.Default.attempts++;
                    if (Properties.Settings.Default.attempts == 3) ;
                    {
                        Properties.Settings.Default.time = DateTime.UtcNow.AddMinutes(1);
                        Properties.Settings.Default.attempts = 0;
                        button1.Enabled = false;

                    }


                }
                MessageBox.Show("BAD");

            }
                con.Close();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.time <= DateTime.UtcNow)
            {
                button1.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }




}
