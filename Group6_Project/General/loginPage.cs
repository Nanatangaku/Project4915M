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

            username = "\"" + username + "\"";
            password = "\"" + password + "\"";
            string sql = "select * from user inner join role on user.role_id = role.role_id where user_name = " + username +" and password = "  + password ;
            MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

          

            if (reader.Read())
            {
                int user_id = (int)reader["user_id"];
                MessageBox.Show("Login Successful");
                string role = (string)reader["role_name"];
          
                if (role == "HR")
                {
                  
                    
                    this.Hide();
                    new HRHomePage(user_id).ShowDialog();
                    this.Close();
                }
                else if (role == "Category Manager")
                {
                    this.Hide();
                    new CategoryManagerHomePage(user_id).ShowDialog();
                    this.Close();
                }
                else if (role == "Warehouse Manager")
                {
                    this.Hide();
                    new WarehouseManagerHomePage(user_id).ShowDialog();
                    this.Close();
                }
                else if (role == "Delivery Manager")
                {
                    this.Hide();
                    new DeliveryManagerHomePage(user_id).ShowDialog();
                    this.Close();
                }
  
                else if (role == "Purchase Manager")
                {
                    this.Hide();
                    new PurchaseManagerHomePage(user_id).ShowDialog();
                    this.Close();
                }

                else if (role == "Shop Manager")
                {
                    this.Hide();
                    new ShopManagerHomePage(user_id).ShowDialog();
                    this.Close();

                }
                else if (role == "Account Manager")
                {
                    this.Hide();
                    new AccountingManagerHomePage(user_id).ShowDialog();
                    this.Close();


                }
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
            conn.Close();
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

        private void loginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
