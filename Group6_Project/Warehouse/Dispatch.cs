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
    public partial class Dispatch : Form
    {
        private int user_id;
        private Panel panFormLoad;
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");

        public Dispatch(int user_id, Panel panFormLoad)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.panFormLoad = panFormLoad;
        }

        private void Dispatch_Load(object sender, EventArgs e)
        {
            cborder_status.SelectedIndex = 0;
            initialize_dvgOrder_Rquest();
        }

        private void initialize_dvgOrder_Rquest()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dvgorder_request.Columns.Add(btn);
            btn.HeaderText = "Detail";
            btn.Text = "Detail";
            btn.Name = "btndetail";
            btn.UseColumnTextForButtonValue = true;

            string sql = "select order_request.order_id,order_request.payment,order_status.status,delivery.create_date,delivery.expected_delivery_date from order_request,order_status,delivery where order_request.order_status_id = order_status.order_status_id and order_request.delivery_id = delivery.delivery_id";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dvgorder_request.DataSource = dt;
            conn.Close();

            dvgorder_request.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void cborder_status_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cborder_status.Text == "All")
            {
                string sql = "select order_request.order_id,order_request.payment,order_status.status,delivery.create_date,delivery.expected_delivery_date from order_request,order_status,delivery where order_request.order_status_id = order_status.order_status_id and order_request.delivery_id = delivery.delivery_id";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dvgorder_request.DataSource = dt;
                conn.Close();

                dvgorder_request.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if(cborder_status.Text == "waiting to process")
            {
                string sql = "select order_request.order_id,order_request.payment,order_status.status,delivery.create_date,delivery.expected_delivery_date from order_request,order_status,delivery where order_request.order_status_id = order_status.order_status_id and order_request.delivery_id = delivery.delivery_id and order_status.order_status_id = 1";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dvgorder_request.DataSource = dt;
                conn.Close();

                dvgorder_request.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void Order_idfilter_TextChanged(object sender, EventArgs e)
        {
            string keyword = "\"%" + Order_idfilter.Text + "%\"";
            

            if (cborder_status.Text == "All")
            {
                string sql = "select order_request.order_id,order_request.payment,order_status.status,delivery.create_date,delivery.expected_delivery_date from order_request," +
                    "order_status,delivery where order_request.order_status_id = order_status.order_status_id and order_request.delivery_id = delivery.delivery_id and order_request.order_id like " + keyword+";";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dvgorder_request.DataSource = dt;
                conn.Close();

                dvgorder_request.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            
            else if (cborder_status.Text == "Dispatched")
            {
                string sql = "select order_request.order_id,order_request.payment,order_status.status,delivery.create_date,delivery.expected_delivery_date from order_request,order_status,delivery where order_request.order_status_id = order_status.order_status_id and order_request.delivery_id = delivery.delivery_id and order_status.order_status_id = 7 and order_request.order_id like " + keyword + ";";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dvgorder_request.DataSource = dt;
                conn.Close();

                dvgorder_request.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void dvgorder_request_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          //if user click column 6 button
          if (e.ColumnIndex == 0)
            {
                int order_id = Convert.ToInt32(dvgorder_request.Rows[e.RowIndex].Cells[1].Value);
                int payment = Convert.ToInt32(dvgorder_request.Rows[e.RowIndex].Cells[2].Value);
                string status = dvgorder_request.Rows[e.RowIndex].Cells[3].Value.ToString();
                string create_date = dvgorder_request.Rows[e.RowIndex].Cells[4].Value.ToString();
                string expected_delivery_date = dvgorder_request.Rows[e.RowIndex].Cells[5].Value.ToString();
                this.panFormLoad.Controls.Clear();
                Dispatch_Detail dispatch_detail = new Dispatch_Detail(user_id,order_id,panFormLoad,payment,status,create_date,expected_delivery_date) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                dispatch_detail.FormBorderStyle = FormBorderStyle.None;
                this.panFormLoad.Controls.Add(dispatch_detail);
                dispatch_detail.Show();
            }
        }
    }
}
