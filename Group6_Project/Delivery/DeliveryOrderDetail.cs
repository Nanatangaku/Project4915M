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
    public partial class DeliveryOrderDetail : Form
    {
        int user_id;
        Panel panFormLoad;
        int delivery_id;
        int order_id;
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");

        public DeliveryOrderDetail(int user_id, Panel panFormLoad, int delivery_id, int order_id)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.panFormLoad = panFormLoad;
            this.delivery_id = delivery_id;
            this.order_id = order_id;
            
        }

        private void DeliveryOrderDetail_Load(object sender, EventArgs e)
        {
            Load_Order_Info();
            Load_Item_List();
            hide_button_check();
        }

        private void Load_Order_Info()
        {
            string sql = "select * from delivery where delivery_id = " + delivery_id;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtboxdelivery_id.Text = reader["delivery_id"].ToString();
                txtboxorder_id.Text = reader["order_id"].ToString();
                txtboxexpecteddeliverydate.Text = reader["expected_delivery_date"].ToString();
                txtboxdispatchdate.Text = reader["despatch_date"].ToString();
                txtboxcreate_date.Text = reader["create_date"].ToString();
                txtboxdispatchdate.Text = reader["despatch_date"].ToString();

            }
            conn.Close();
        }
        private void Load_Item_List()
        {
            string sql = "select item.item_id,item.item_name,item.item_category,item.price,order_item.quantity from item,order_item where order_item.item_id = item.item_id and order_item.order_id = " + order_id;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dvgitemlist.DataSource = dt;
            dvgitemlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
            dvgitemlist.ForeColor = Color.Black;
        }
        private void hide_button_check()
        {
            string sql = "select order_status_id from order_request where order_id = " + order_id;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (reader["order_status_id"].ToString() == "7")
                {
                    btnstart_delivery.Visible = true;
                }
                else
                {
                    btnstart_delivery.Visible = false;
                }
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.panFormLoad.Controls.Clear();
            DeliveryOrder deliveryorder = new DeliveryOrder(user_id, panFormLoad) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            deliveryorder.FormBorderStyle = FormBorderStyle.None;
            this.panFormLoad.Controls.Add(deliveryorder);
            deliveryorder.Show();
        }

        private void btnstart_delivery_Click(object sender, EventArgs e)
        {
            string sql = "update order_request set order_status_id = 9 where order_id = " + order_id;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delivery started");
                hide_button_check();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
    }
}
