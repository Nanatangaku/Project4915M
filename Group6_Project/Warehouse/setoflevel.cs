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
    }
}
