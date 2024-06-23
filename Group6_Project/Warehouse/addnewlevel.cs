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

namespace Group6_Project.Warehouse
{
    public partial class addnewlevel : Form

    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");
        int user_id;
        Panel panFormLoad;
        public addnewlevel(int user_id, Panel panFormLoad)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.panFormLoad = panFormLoad;
        }

        private void addnewlevel_Load(object sender, EventArgs e)
        {

        }

        private void initial()
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtboxdescription != null && txtboxlevelnum != null)
            {
                string sql = "insert into setoflevels (level_description,level_num) values ('" + txtboxdescription.Text + "','" + txtboxlevelnum.Text + "')";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    MessageBox.Show("New level added");
                }
                else
                {
                    MessageBox.Show("Error");
                }
                conn.Close();
           

            }
            else
            {
                MessageBox.Show("Please fill in all the fields");
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.panFormLoad.Controls.Clear();
            setoflevel setoflevel = new setoflevel(user_id, panFormLoad) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            setoflevel.TopLevel = false;
            this.panFormLoad.Controls.Add(setoflevel);
            setoflevel.Show();

        }
    }
}
