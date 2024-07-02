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
            create_level_cb();
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
            if (cbstatus.Text == "All")
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
            else
            {
                string sql = "select level_num from setoflevels where level_description = \"" + cbstatus.Text + "\"";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                int level_num = 0;
                if (reader.Read())
                {
                    level_num = reader.GetInt32("level_num");
                }

                conn.Close();
                int pre_level = 0;
                int next_level = 0;
                string sql2 = "select level_num  from setoflevels order by level_num ASC";
                conn.Open();
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                //i want the next number of level_num to be the upper bound
                while (reader2.Read())
                {

                    
                    pre_level = next_level;
                    next_level = reader2.GetInt32("level_num");

                
                    if (next_level == level_num)
                    {

                        break;
                    }
 


                }
                string sql3 = "select warehouse.warehouse_id,warehouse.warehouse_name,item.item_id,item.item_name,warehouse_item.quantity from shop,warehouse,warehouse_item,item,setoflevels where item.item_id = warehouse_item.item_id and warehouse.warehouse_id = shop.warehouse_id and shop.shop_id = " + shop_id + " and warehouse_item.quantity between " + pre_level + " and " + next_level;
                conn.Close();
                conn.Open();
                MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
                MySqlDataReader reader3 = cmd3.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader3);
                dvgstockrecord.DataSource = dt;
                conn.Close();
              

                conn.Close();
            }
     
        }

        private void txtboxnamefilter_TextChanged(object sender, EventArgs e)
        {
            string keyword  = "\"%" + txtboxnamefilter.Text + "%\"";

            if (cbstatus.Text == "All")
            {
                string sql = "select warehouse.warehouse_id,warehouse.warehouse_name,item.item_id,item.item_name,warehouse_item.quantity from shop,warehouse,warehouse_item,item where item.item_id = warehouse_item.item_id and warehouse.warehouse_id = shop.warehouse_id and shop.shop_id = " + shop_id + " and item.item_name Like "  + keyword;
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dvgstockrecord.DataSource = dt;
                conn.Close();
            }
            else
            {
                string sql = "select level_num from setoflevels where level_description = \"" + cbstatus.Text + "\"";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                int level_num = 0;
                if (reader.Read())
                {
                    level_num = reader.GetInt32("level_num");
                }

                conn.Close();
                int pre_level = 0;
                string sql2 = "select level_num  from setoflevels order by level_num ASC";
                conn.Open();
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    if (reader2.GetInt32("level_num") == level_num)
                    {
                        string sql3 = "select warehouse.warehouse_id,warehouse.warehouse_name,item.item_id,item.item_name,warehouse_item.quantity from shop,warehouse,warehouse_item,item,setoflevels where item.item_id = warehouse_item.item_id and warehouse.warehouse_id = shop.warehouse_id and shop.shop_id = " + shop_id + " and warehouse_item.quantity between " + pre_level + " and " + level_num + " and item.item_name Like " + keyword; 
                        conn.Close();
                        conn.Open();
                        MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
                        MySqlDataReader reader3 = cmd3.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader3);
                        dvgstockrecord.DataSource = dt;
                        conn.Close();
                        break;
                    }
                    pre_level = reader2.GetInt32("level_num");
                }
                conn.Close();
            }

        }

       private void create_level_cb()
        {

            string sql = "select * from setoflevels order by level_num DESC";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                cbstatus.Items.Add(reader.GetString("level_description"));
            }
            conn.Close();


        }

        private void dvgstockrecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
