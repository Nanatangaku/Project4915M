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

    public partial class StockRecord : Form
    {
        int user_id;
        Panel panFormLoad;
        private int shop_id;
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");

        public StockRecord(int user_id,Panel panFormLoad)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.panFormLoad = panFormLoad;
        }

        private void StockRecord_Load(object sender, EventArgs e)
        {
            initialize_shopid();
            initialize_dvgstockrecord(shop_id);
            cbstatus.SelectedIndex = 0;
        }
        private void initialize_shopid()
        {
            string sql = "select shop_id from user where user_id = " + user_id;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                shop_id = reader.GetInt32("shop_id");
            }
            else
            {
                MessageBox.Show("cant not use user id to search Shop ID not found");
            }
            conn.Close();

        }
        private void initialize_dvgstockrecord(int shop_id)
        {
            string sql = "select warehouse.warehouse_id,warehouse.warehouse_name,item.item_id,item.item_name,warehouse_item.quantity from shop,warehouse,warehouse_item,item where item.item_id = warehouse_item.item_id and warehouse.warehouse_id = shop.warehouse_id and shop.shop_id = " + shop_id;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dvgstockrecord.DataSource = dt;
            conn.Close();

            dvgstockrecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void cbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbstatus.SelectedIndex == 0)
            {

                string sql = "select warehouse.warehouse_id,warehouse.warehouse_name,item.item_id,item.item_name,warehouse_item.quantity from shop,warehouse,warehouse_item,item where item.item_id = warehouse_item.item_id and warehouse.warehouse_id = shop.warehouse_id and shop.shop_id = " + shop_id;
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dvgstockrecord.DataSource = dt;
                conn.Close();


            }
            else if (cbstatus.SelectedIndex == 1)
            {
                string sql = "select warehouse.warehouse_id,warehouse.warehouse_name,item.item_id,item.item_name,warehouse_item.quantity from shop,warehouse,warehouse_item,item where item.item_id = warehouse_item.item_id and warehouse.warehouse_id = shop.warehouse_id and shop.shop_id = " + shop_id + " and warehouse_item.quantity >= 5000";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dvgstockrecord.DataSource = dt;
                conn.Close();
            }
            else if (cbstatus.SelectedIndex == 2)
            {
                string sql = "select warehouse.warehouse_id,warehouse.warehouse_name,item.item_id,item.item_name,warehouse_item.quantity from shop,warehouse,warehouse_item,item where item.item_id = warehouse_item.item_id and warehouse.warehouse_id = shop.warehouse_id and shop.shop_id = " + shop_id + " and warehouse_item.quantity between 3000 and 5000";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dvgstockrecord.DataSource = dt;
                conn.Close();
            }
            else if (cbstatus.SelectedIndex == 3)
            {
                string sql = "select warehouse.warehouse_id,warehouse.warehouse_name,item.item_id,item.item_name,warehouse_item.quantity from shop,warehouse,warehouse_item,item where item.item_id = warehouse_item.item_id and warehouse.warehouse_id = shop.warehouse_id and shop.shop_id = " + shop_id + " and warehouse_item.quantity <3000";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dvgstockrecord.DataSource = dt;
                conn.Close();
            }
        }

        private void txtboxnamefilter_TextChanged(object sender, EventArgs e)
        {
            string keyword  = "\"%" + txtboxnamefilter.Text + "%\"";

            if (cbstatus.SelectedIndex == 0)
            {

                string sql = "select warehouse.warehouse_id,warehouse.warehouse_name,item.item_id,item.item_name,warehouse_item.quantity from shop,warehouse,warehouse_item,item where item.item_id = warehouse_item.item_id and warehouse.warehouse_id = shop.warehouse_id and shop.shop_id = " + shop_id + " and item.item_name like " + keyword;
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dvgstockrecord.DataSource = dt;
                conn.Close();


            }
            else if (cbstatus.SelectedIndex == 1)
            {
                string sql = "select warehouse.warehouse_id,warehouse.warehouse_name,item.item_id,item.item_name,warehouse_item.quantity from shop,warehouse,warehouse_item,item where item.item_id = warehouse_item.item_id and warehouse.warehouse_id = shop.warehouse_id and shop.shop_id = " + shop_id + " and warehouse_item.quantity >= 5000 and item.item_name like " + keyword;
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dvgstockrecord.DataSource = dt;
                conn.Close();
            }
            else if (cbstatus.SelectedIndex == 2)
            {
                string sql = "select warehouse.warehouse_id,warehouse.warehouse_name,item.item_id,item.item_name,warehouse_item.quantity from shop,warehouse,warehouse_item,item where item.item_id = warehouse_item.item_id and warehouse.warehouse_id = shop.warehouse_id and shop.shop_id = " + shop_id + " and warehouse_item.quantity between 3000 and 5000 and item.item_name like " + keyword;
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dvgstockrecord.DataSource = dt;
                conn.Close();
            }
            else if (cbstatus.SelectedIndex == 3)
            {
                string sql = "select warehouse.warehouse_id,warehouse.warehouse_name,item.item_id,item.item_name,warehouse_item.quantity from shop,warehouse,warehouse_item,item where item.item_id = warehouse_item.item_id and warehouse.warehouse_id = shop.warehouse_id and shop.shop_id = " + shop_id + " and warehouse_item.quantity <3000 and item.item_name like " + keyword;
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dvgstockrecord.DataSource = dt;
                conn.Close();
            }
        }
    }
}
