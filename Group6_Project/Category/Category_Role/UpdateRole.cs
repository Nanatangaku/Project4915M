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

namespace Group6_Project.Category.Category_Role
{
    public partial class UpdateRole : Form
    {
        Panel panFormLoad;
        String id;
        public UpdateRole(Panel panFormLoad, String id)
        {
            this.panFormLoad = panFormLoad;
            this.id = id;
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            String newRoleName = roundTextBox1.Texts;
            String newRoleDescription = roundTextBox2.Texts;
            if (newRoleName == null || newRoleDescription == null || newRoleName =="" || newRoleDescription == "")
            {
                MessageBox.Show("Please fill in all the information!");
            }
            else
            {
                String sql = "UPDATE role SET role_name = '"+ newRoleName +"', role_description = '"+ newRoleDescription + "' WHERE role_id = "+ id +"";
                MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                try
                {
                    if (cmd.ExecuteNonQuery() >= 1)
                    {
                        MessageBox.Show("Role Update Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Role Update Failed");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.panFormLoad.Controls.Clear();
            SearchRole searchRole = new SearchRole(panFormLoad) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            searchRole.FormBorderStyle = FormBorderStyle.None;
            this.panFormLoad.Controls.Add(searchRole);
            searchRole.Show();
        }

        private void UpdateRole_Load(object sender, EventArgs e)
        {

        }
    }
}
