using Group6_Project.Warehouse;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group6_Project
{
    public partial class setoflevel : Form
    {   
        int user_id;
        Panel panFormLoad;
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");

        public setoflevel(int user_id, Panel panFormLoad)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.panFormLoad = panFormLoad;
        }

        private void setoflevel_Load(object sender, EventArgs e)
        {
            initial_dvglevel();
        }


        private void initial_dvglevel()
        {
            // add a detail button to the datagridview
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dvglevel.Columns.Add(btn);
            btn.HeaderText = "";
            btn.Text = "Detail";
            btn.Name = "btnDetail";
            btn.UseColumnTextForButtonValue = true;

           string sql = "select * from setoflevels";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dvglevel.DataSource = dt;
            conn.Close();
            dvglevel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dvglevel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // if click the detail button , go to the editsetoflevel form
            if (e.ColumnIndex == dvglevel.Columns["btnDetail"].Index)
            {
                this.panFormLoad.Controls.Clear();
                int setoflevel_id = Convert.ToInt32(dvglevel.Rows[e.RowIndex].Cells["levelid"].Value);
         
                editlevel editlevel = new editlevel(user_id,setoflevel_id,panFormLoad) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                editlevel.FormBorderStyle = FormBorderStyle.None;
                this.panFormLoad.Controls.Add(editlevel);
                editlevel.Show();

            }
        }

        private void txtfilter_TextChanged(object sender, EventArgs e)
        {
            string keyword = "%" + txtfilter.Text + "%";
            string sql = "select * from setoflevels where level_description like '" + keyword + "'";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dvglevel.DataSource = dt;
            conn.Close();
            dvglevel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            this.panFormLoad.Controls.Clear();
            addnewlevel addnewlevel = new addnewlevel(user_id,panFormLoad) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            addnewlevel.FormBorderStyle = FormBorderStyle.None;
            this.panFormLoad.Controls.Add(addnewlevel);
            addnewlevel.Show();

        }
    }
}
