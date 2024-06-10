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
            //set the default value for the combobox
            cbstatusfilter.SelectedIndex = 0;
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

        private void dvgdeliveryorder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                int delivery_id = Convert.ToInt32(dvgdeliveryorder.Rows[e.RowIndex].Cells["delivery_id"].Value);
                int order_id = Convert.ToInt32(dvgdeliveryorder.Rows[e.RowIndex].Cells["order_id"].Value);
                this.panFormLoad.Controls.Clear();
                DeliveryOrderDetail dod = new DeliveryOrderDetail(user_id, panFormLoad,delivery_id,order_id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                dod.FormBorderStyle = FormBorderStyle.None;
                this.panFormLoad.Controls.Add(dod);
                dod.Show();
            }
        }

        private void cbstatusfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbstatusfilter.SelectedIndex == 0)
            {
                string sql = "select delivery.delivery_id,delivery.order_id,delivery.expected_delivery_date,delivery.despatch_date from delivery,order_request where order_request.delivery_id = delivery.delivery_id and order_request.order_status_id = 7";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dvgdeliveryorder.DataSource = dt;
                dvgdeliveryorder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                conn.Close();
            }
            else if (cbstatusfilter.SelectedIndex == 1)
            {
                string sql = "select delivery.delivery_id,delivery.order_id,delivery.expected_delivery_date,delivery.despatch_date from delivery,order_request where order_request.delivery_id = delivery.delivery_id and order_request.order_status_id = 9";
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

        private void txtboxsearchbyid_TextChanged(object sender, EventArgs e)
        {
            string keyword = "\"%" + txtboxsearchbyid.Text + "%\"";
            if (cbstatusfilter.SelectedIndex == 0)
            {
                string sql = "select delivery.delivery_id,delivery.order_id,delivery.expected_delivery_date,delivery.despatch_date from delivery,order_request where order_request.delivery_id = delivery.delivery_id and order_request.order_status_id = 7 and delivery.delivery_id like" + keyword;
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dvgdeliveryorder.DataSource = dt;
                dvgdeliveryorder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                conn.Close();
            }
            else if (cbstatusfilter.SelectedIndex == 1)
            {
                string sql = "select delivery.delivery_id,delivery.order_id,delivery.expected_delivery_date,delivery.despatch_date from delivery,order_request where order_request.delivery_id = delivery.delivery_id and order_request.order_status_id = 9 and delivery.delivery_id like" + keyword;
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
}
