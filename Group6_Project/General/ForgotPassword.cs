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
    public partial class ForgotPassword : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
         );

        public ForgotPassword()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnVerify_Click(object sender, EventArgs e)
        {
            //get the roundtestbox text
            string username = rtxtUserName.Texts;
            string email = rtxtEmail.Texts;
            string phone = rtxtPhone.Texts;

            username = "\"" + username + "\"";
            email = "\"" + email + "\"";
            phone = "\"" + phone + "\"";

            string sql = "select * from user where user_name = " + username + " and email = " + email + " and phone = " + phone;
            MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int user_id = 0;
                user_id = (int)reader["user_id"];
                conn.Close();

                if (user_id != 0)
                {
                    MessageBox.Show("Verify Successful!!!");
                    string sql2 = "update user set password = " + roundTextBox1.Texts.ToString() + "  where user_name = " + username;
                    MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                    conn.Open();
                  
                    MySqlDataReader reader2 = cmd2.ExecuteReader();
                   
                    this.Hide();
                    new loginPage().ShowDialog();
                    this.Close();
                }else
                {
                    MessageBox.Show("Invalid Account Infromation");
                }
                conn.Close();

            }
            else
            {
                MessageBox.Show("Invaild inofrmation");
            }
        }

        private void rbtnReturnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new loginPage().ShowDialog();
            this.Close();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
