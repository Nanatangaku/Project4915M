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
    public partial class editlevel : Form
    {
        int user_id;
        int setoflevel_id;
        Panel panFormLoad;
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");
        public editlevel(int user_id, int setoflevel_id, Panel panFormLoad)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.setoflevel_id = setoflevel_id;
            this.panFormLoad = panFormLoad;
   
        }

        private void editlevel_Load(object sender, EventArgs e)
        {
            initial();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.panFormLoad.Controls.Clear();
            setoflevel setoflevel = new setoflevel(user_id, panFormLoad) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; 
            setoflevel.TopLevel = false;
            this.panFormLoad.Controls.Add(setoflevel);
            setoflevel.Show();  

        }

        private void txtboxdescription_TextChanged(object sender, EventArgs e)
        {

        }
        private void initial() {
            string sql = "select * from setoflevels where levelid =  " + setoflevel_id;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtboxdescription.Text = reader["level_description"].ToString();
                txtboxlevelnum.Text = reader["level_num"].ToString();
            }
            conn.Close();
              }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = "update setoflevels set level_description = '" + txtboxdescription.Text + "', level_num = " + txtboxlevelnum.Text + " where levelid = " + setoflevel_id;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(
                sql, conn);
            if (cmd.ExecuteNonQuery () == 1)
            {
                MessageBox.Show("Update successfully");
            }
            else
            {
                MessageBox.Show("Update failed");
            }
            conn.Close();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string sql = "delete from setoflevels where levelid = " + setoflevel_id;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(
                sql, conn);
            if (cmd.ExecuteNonQuery() == 1)
                {
                MessageBox.Show("Delete successfully");
            }
            else
            {
                MessageBox.Show("Delete failed");
            }
            conn.Close();
        }
    }
}
