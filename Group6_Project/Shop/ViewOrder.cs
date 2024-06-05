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
    public partial class ViewOrder : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");
        int user_id;
        Panel panformload;
        public ViewOrder(int user_id, Panel panformLoad)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.panformload = panformLoad;
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            ViewOrder_dvg_load();
        }

        public void ViewOrder_dvg_load()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dvgvieworder_request.Columns.Add(btn);
            btn.HeaderText = "";
            btn.Text = "detail";
            btn.Name = "btndetail";
            btn.UseColumnTextForButtonValue = true;

            string sql = "select order_id,payment from order_request where user_id = " + user_id + ";";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dvgvieworder_request.DataSource = dt;
            conn.Close();

            dvgvieworder_request.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
