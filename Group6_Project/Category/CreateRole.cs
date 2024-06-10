using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group6_Project
{
    public partial class CreateRole : Form
    {
        public CreateRole()
        {
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            String newRoleName = roundTextBox1.Texts;
            String newRoleDescription = roundTextBox2.Texts;
            if (newRoleName == null || newRoleDescription == null)
            {
                MessageBox.Show("Please fill in all the information!");
            }
            else
            {
                String sql = "INSERT INTO role (role_name, role_description) VALUES ('" + newRoleName + "', '" + newRoleDescription + "')";
                MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                try
                {
                    if (cmd.ExecuteNonQuery() >= 1)
                    {
                        MessageBox.Show("Role Created Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Role Creation Failed");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void roundTextBox1__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
