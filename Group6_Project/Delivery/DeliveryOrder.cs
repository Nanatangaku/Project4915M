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
    public partial class DeliveryOrder : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");
        int user_id;
        Panel panFormLoad;


        public DeliveryOrder(int user_id, Panel panFormLoad)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.panFormLoad = panFormLoad;
        }

        private void DeliveryOrder_Load(object sender, EventArgs e)
        {
            Load_basic_dvg();
        }

        private void Load_basic_dvg()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dvgdeliveryorder.Columns.Add(btn);
            btn.HeaderText = "Detail";
            btn.Text = "Detail";
            btn.Name = "btnDetail";
            btn.UseColumnTextForButtonValue = true;

            string sql = "select delivery.delivery_id,delivery.order_id,delivery.expected_delivery_date,delivery.despatch_date from delivery";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dvgdeliveryorder.DataSource = dt;
            dvgdeliveryorder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();

        }
    }
}
