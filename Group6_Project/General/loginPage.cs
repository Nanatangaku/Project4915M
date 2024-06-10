using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Group6_Project
{
    public partial class loginPage : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
           (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
           );

        public loginPage()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
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

        private void loginPage_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnForgotPassword_Click(object sender, EventArgs e)
        {
            
        }
    }
}
