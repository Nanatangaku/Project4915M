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
        int order_id;
        int order_status_id;
        int delivery_id;

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

            string sql = "select order_request.order_id,order_request.payment,order_request.address,delivery.create_date,delivery.despatch_date,delivery.recive_date,order_status.status from order_request,delivery,order_status where order_request.order_id = delivery.order_id and order_request.order_status_id = order_status.order_status_id and order_request.user_id = " + user_id;
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dvgvieworder_request.DataSource = dt;




            dvgvieworder_request.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dvgvieworder_request_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
            if (e.ColumnIndex == 0)
            {

                int index = e.RowIndex;
                DataGridViewRow selectedRow = dvgvieworder_request.Rows[index];
                int order_id = Convert.ToInt32(selectedRow.Cells["order_id"].Value);
                String order_status = selectedRow.Cells["status"].Value.ToString();

                this.panformload.Controls.Clear();
                OrderDetail orderDetail = new OrderDetail(order_id,order_status,this.panformload,this.user_id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                orderDetail.FormBorderStyle = FormBorderStyle.None;
                this.panformload.Controls.Add(orderDetail);
                orderDetail.Show();

            }
           
        }
        private void initialize_basic_info()
        {

        }

  
    }
}
