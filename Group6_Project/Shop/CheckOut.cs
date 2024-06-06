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
    public partial class CheckOut : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");
        int user_id;

        Panel panformload;
        public CheckOut(int user_id, Panel panformload)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.panformload = panformload;
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dvgcart.Columns.Add(btn);
            btn.HeaderText = "Remove";
            btn.Text = "Remove";
            btn.Name = "btnremove";
            btn.UseColumnTextForButtonValue = true;
            txtboxcreateid.Text = user_id.ToString();
            String sql = "select * from user where user_id = " + user_id; 
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtboxname.Text = reader["last_name"].ToString();
            }
            conn.Close();
            String sql2 = "select * from shop where user_id = " + user_id;
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
            conn.Open();
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read())
            {
                txtboxshopid.Text = reader2["shop_id"].ToString();
                txtboxshopname.Text = reader2["shopname"].ToString();
            }
            txtboxcreatedate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            conn.Close();
            dateTimePicker.MinDate = DateTime.Now.AddDays(7);
            // can you help me set the maxdate of datetimepicker 3month from now?
            dateTimePicker.MaxDate = DateTime.Now.AddMonths(3);
            filldvg(dvgcart);
            txtboxtotalprice.Text = "$" + count_total_price().ToString();

           

        }

        private void filldvg(DataGridView dataGridView)
        {
         
            string sql = "select item.item_id,item.item_Name,item.item_Category, item.price  ,cart.quantity from cart,item where item.item_id = cart.item_id ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            //bind the data to the datagridview
            dataGridView.DataSource = dt;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ForeColor = Color.Black;
            conn.Close();

        }

        private void dvgcart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dvgcart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int item_id = Convert.ToInt32(dvgcart.Rows[e.RowIndex].Cells[1].Value);
                string sql = "delete from cart where user_id = " + user_id + " and item_id = " + item_id ;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    MessageBox.Show("Item Removed");
                    conn.Close();
                    filldvg(dvgcart);
                    txtboxtotalprice.Text = count_total_price().ToString();

                }
                else
                {
                    MessageBox.Show("Item Removal Failed");
                }
                conn.Close();
                 

            }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            check_out();



        }

        private void txtboxtotalprice_TextChanged(object sender, EventArgs e)
        {

        }
        public double count_total_price()
        {
            double total_price = 0;
            foreach (DataGridViewRow row in dvgcart.Rows)
            {
                double quantity = Convert.ToDouble(row.Cells[5].Value);
                double price = Convert.ToDouble(row.Cells[4].Value);
                double priceofeachgood = quantity * price;
                total_price += priceofeachgood;
            }
            return total_price;
        }

        public void check_out()
        {
            if (txtboxaddress == null || txtboxaddress.Text == "")
            {
                MessageBox.Show("Please enter address");
                return;
            }
            else if (dvgcart.Rows.Count == 0)
            {
                MessageBox.Show("Please add item to cart");
                return;
            }
            else if (check_enought_quantity() == false)
            {

                return;
            }
            else
            {
                insert_order_table();

            }
        }
        public void insert_order_table()
        {
            long id = 0;
            Double total_price = Convert.ToDouble(count_total_price());
            string address = txtboxaddress.Text;
            string sql = "insert into order_request(user_id ,payment,order_status_id,address)values(" + user_id + "," + total_price + "," + 1 + "," + "\"" + address + "\"" + ");";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            if(cmd.ExecuteNonQuery() >= 1)
            {
                id = cmd.LastInsertedId;
                conn.Close();
                MessageBox.Show("Order Request Created");
                insert_order_item_table(id);
                insert_delivery_table(id);
                delete_warehouse_quantity();
                delete_cart_table();
            }else
                {
                conn.Close();
                MessageBox.Show("Create Order failed");
            }
       
        }

        public void insert_order_item_table(long id)
        {
            DataTable dt = get_from_cart_table();
            //loop the datatable and insert the data to order_item table
            conn.Open();
            foreach (DataRow row in dt.Rows)
            {
                int item_id = Convert.ToInt32(row["item_id"]);
                int quantity = Convert.ToInt32(row["quantity"]);
                string sql2 = "insert into order_item(order_id,item_id,quantity)values(" + id + "," + item_id + "," + quantity + ");";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
            
                if(cmd2.ExecuteNonQuery() >= 1)
                {
                    

                }
                else
                {
                    //
                    MessageBox.Show("create order_item table failed");
                }
               
            }
            conn.Close();
        }
        public void insert_delivery_table(long id)
        {
           long order_id = id;
            String date = "\"" + txtboxcreatedate.Text + "\"" ;
            String delivery_date = "\"" + dateTimePicker.Value.ToString("yyyy-MM-dd") + "\"" ;
        
            string nullvalue = "null";
            string sql = "insert into delivery(order_id,user_id,create_date,expected_delivery_date,despatch_date,recive_date)VALUES(" + id + "," + this.user_id + "," + date + "," + delivery_date + "," +nullvalue+  "," + nullvalue + ");";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            if(cmd.ExecuteNonQuery() >= 1)
            {
                conn.Close();
               long delivery_id  = cmd.LastInsertedId;
                string  sql2 = "update order_request set delivery_id = " + delivery_id + " where order_id = " + order_id + ";";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                conn.Open();
                if(cmd2.ExecuteNonQuery() >= 1)
                {
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("update order_request table failed");
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("insert delivery table failed");
                conn.Close();
            }
        
           
        }
        public void delete_warehouse_quantity()
        {
            DataTable dt = get_from_cart_table();
            conn.Open();
            foreach (DataRow row in dt.Rows)
            {
                int item_id = Convert.ToInt32(row["item_id"]);
                int quantity = Convert.ToInt32(row["quantity"]);
                string sql = "update warehouse_item set quantity = quantity - " + quantity + " where item_id = " + item_id + ";";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
              
                if(cmd.ExecuteNonQuery() >= 1)
                {
                    
                }
                else
                {
                    MessageBox.Show("update warehouse_item table failed");
                }
             
            }
            conn.Close();
        }

        public void delete_cart_table()
        {
            string sql = "delete from cart where user_id = " + user_id + ";";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            if(cmd.ExecuteNonQuery() >= 1)
            {
                
            }
            else
            {
                MessageBox.Show("delete cart table failed");
            }
            conn.Close();
        }
       
        public DataTable get_from_cart_table()
        {
            string sql = "select item.item_id,cart.quantity from cart,item where item.item_id = cart.item_id and user_id =  " + user_id+ ";" ;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            //return datatable 
            conn.Close();
            return dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public Boolean check_enought_quantity()
        {
            DataTable dt = get_from_cart_table();
            conn.Open();
            foreach (DataRow row in dt.Rows)
            {
                int item_id = Convert.ToInt32(row["item_id"]);
                int quantity = Convert.ToInt32(row["quantity"]);
                string sql = "select quantity from warehouse_item where item_id = " + item_id + ";";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
              
                MySqlDataReader reader = cmd.ExecuteReader();
             //if not engouht return false
                 if (reader.Read())
                {
                    int quantity_in_warehouse = Convert.ToInt32(reader["quantity"]);
                    if (quantity_in_warehouse < quantity)
                    {
                        MessageBox.Show("Not enough quantity in warehouse");
                        conn.Close();
                        return false;
                    }
                }
               
            }
            conn.Close();
            return true;
        }
    }
}
