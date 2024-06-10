using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Group6_Project
{

    public partial class OrderDetail : Form
    {
        int order_id;
        Panel panFormLoad;
        int delivery_id;
        int status_id;
        String order_status;
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");
        int user_id;
        public OrderDetail( int order_id,String order_status,Panel panformload,int user_id)
        {
            InitializeComponent();
            this.panFormLoad = panformload;
            this.order_id = order_id;
            this.user_id = user_id;
            this.order_status = order_status;
            OrderDetail_Load();
            load_order_items();
            order_status_load_btn(order_status);
     
            
        }

        private void OrderDetail_Load()
        {
            string sql = "select item.item_name,item.item_category,item.price,order_item.quantity from item,order_item where item.item_id= order_item.item_id and order_id = " + order_id;
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dvgitem.DataSource = dt;
            dvgitem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.panFormLoad.Controls.Clear();
            ViewOrder vieworder = new ViewOrder(user_id, panFormLoad) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            vieworder.FormBorderStyle = FormBorderStyle.None;
            this.panFormLoad.Controls.Add(vieworder);
            vieworder.Show();

        }

        private void load_order_items()
        {
            string sql = "select order_id,payment,delivery_id,order_status_id from order_request where order_id = " + order_id;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtboxorderid.Text = reader["order_id"].ToString();
                lbltotalamount.Text = reader["payment"].ToString();
                delivery_id = Convert.ToInt32(reader["delivery_id"]);
                status_id = Convert.ToInt32(reader["order_status_id"]);
            }
            conn.Close();

            string sql2 ="select user_id,last_name,first_name,shop_id from user where user_id = " + user_id;
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
            conn.Open();
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                txtboxcreatorid.Text = reader2["user_id"].ToString();
                txtname.Text = reader2["last_name"].ToString() + " " + reader2["first_name"].ToString();
                txtshopid.Text = reader2["shop_id"].ToString();
            }
            conn.Close();
            string sql3 = "select status from order_status where order_status_id = " + status_id;
            MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
            conn.Open();
            MySqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                txtstatus.Text = reader3["status"].ToString();
            }
            conn.Close();
            string sql4 = "select create_date,expected_delivery_date from delivery where delivery_id = " + delivery_id;
            MySqlCommand cmd4 = new MySqlCommand(sql4, conn);
            conn.Open();
            MySqlDataReader reader4 = cmd4.ExecuteReader();
            while (reader4.Read())
            {
               // make the date format be YYYY-MM-DD
                txtcreatedate.Text = reader4["create_date"].ToString();
                //make the datetimepicker value = expected_delivery_date and only choose 3month from create_date
                dtpexpecteddate.Value = Convert.ToDateTime(reader4["expected_delivery_date"]);
            }
            conn.Close();
        }

        private void OrderDetail_Load(object sender, EventArgs e)
        {

        }

        private void gbgeneral_Enter(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string sql = "delete from order_request where order_id = " + order_id;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            if(cmd.ExecuteNonQuery() >= 1)
            {
                MessageBox.Show("Order_request deleted");
            }else
                {
                MessageBox.Show("Order_request not deleted");
            }
            conn.Close();
            string sql2 = "delete from delivery where delivery_id = " + delivery_id;
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
            conn.Open();
            if (cmd2.ExecuteNonQuery() >= 1)
            {
             
                MessageBox.Show("Delivery deleted");
                conn.Close();
            }
            else
            {
                MessageBox.Show("Delivery not deleted");
                conn.Close();
        
                
            }
            string sql3 = "delete from order_item where order_id = " + order_id;
            MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
            conn.Open();
            if (cmd3.ExecuteNonQuery() >= 1)
            {
                MessageBox.Show("Order_item deleted");
                conn.Close();
            }
            else
            {
                MessageBox.Show("Order_item not deleted");
                conn.Close();
            }

            this.panFormLoad.Controls.Clear();
            ViewOrder vieworder = new ViewOrder(user_id, panFormLoad) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            vieworder.FormBorderStyle = FormBorderStyle.None;
            this.panFormLoad.Controls.Add(vieworder);
            vieworder.Show();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string sql = "update delivery set expected_delivery_date = '" + dtpexpecteddate.Value.ToString("yyyy-MM-dd") + "' where delivery_id = " + delivery_id;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            if (cmd.ExecuteNonQuery() >= 1)
            {
                MessageBox.Show("Delivery updated");
            }
            else
            {
                MessageBox.Show("Delivery not updated");
            }
            conn.Close();
    
        }

        private void roundTextBox4__TextChanged(object sender, EventArgs e)
        {

        }

        private void lblamounttext_Click(object sender, EventArgs e)
        {

        }

        private void dtpexpecteddate_ValueChanged(object sender, EventArgs e)
        {

        }
        private void order_status_load_btn(string order_status)
        {
            if(order_status == "waiting to process")
            {
                btndelete.Visible = true;
                btnsave.Visible = true;
                btnreceive.Visible = false;
                btndownloaddispatchpdf.Visible = false;
            }
            else if(order_status == "despatched")
            {
                btndelete.Visible = false;
                btnsave.Visible = false;
                btnreceive.Visible = true;
                btndownloaddispatchpdf.Visible = false;
            }else if(order_status == "Received")
            {
                btndelete.Visible = false;
                btnsave.Visible = false;
                btnreceive.Visible = false;
                btndownloaddispatchpdf.Visible = true;
            }
        }

        private void btnreceive_Click(object sender, EventArgs e)
        {
            string sql = "update order_request set order_status_id = 9 where order_id = " + order_id;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            if (cmd.ExecuteNonQuery() >= 1)
            {
                MessageBox.Show("Order id " + order_id + " is Received");
            }
            conn.Close();

            this.panFormLoad.Controls.Clear();
            DispatchNotes dispatchnotes = new DispatchNotes(user_id, panFormLoad,order_id,delivery_id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dispatchnotes.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(dispatchnotes);
            dispatchnotes.Show();
        }

        private void btndownloaddispatchpdf_Click(object sender, EventArgs e)
        {
            this.panFormLoad.Controls.Clear();
            DispatchNotes dispatchnotes = new DispatchNotes(user_id, panFormLoad, order_id, delivery_id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dispatchnotes.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(dispatchnotes);
            dispatchnotes.Show();
        }
    }
}
