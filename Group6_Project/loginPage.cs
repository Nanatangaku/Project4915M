using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Group6_Project
{
    public partial class loginPage : Form
    {

        public loginPage()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void roundTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            //get the roundtestbox text
            string username = roundTextBox1.Texts;
            string password = roundTextBox2.Texts;
            string connstring = "select * from user where account_name = \"" + username + "\" and password = \"" + password + "\"";

            MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=4915mdb");
            MySqlCommand cmd = new MySqlCommand(connstring, conn);
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Login Successful");
                string role = (string)reader["role"];
               if(role == "AccountManager")
                {
                    this.Hide();
                    new AccountingManagerHomePage().ShowDialog();
                    this.Close();
                }else if(role == "AccountClerk")
                {
                    this.Hide();
                    new AccountingClerkHomePage().ShowDialog();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Login Failed");
            }

        }

        private void roundTextBox1__TextChanged_1(object sender, EventArgs e)
        {

        }

        private void roundTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void roundButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
