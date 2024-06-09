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
    public partial class ReceivedItem : Form
    {
        int user_id;
        Panel panFormLoad;
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");

        public ReceivedItem(int user_id, Panel panFormLoad)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.panFormLoad = panFormLoad;
        }

        private void ReceivedItem_Load(object sender, EventArgs e)
        {
            load_basic_data(user_id);
            load_item_data();
            initialize_dvgpreadditem();
        }

        private void load_basic_data(int user_id)
        {
            txtboxuserid.Text = user_id.ToString();
            string sql = "select user.user_id, role.role_name from user,role where user.role_id = role.role_id and user.user_id = " + user_id;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtboxrole.Text = reader.GetString("role_name");
            }
            conn.Close();
        }

        private void load_item_data()
        {
            cbitem.Items.Clear();
            string sql = "select item_Name from item";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbitem.Items.Add(reader.GetString("item_name"));
            }
            conn.Close();
        }

        private void cbitem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void initialize_dvgpreadditem()
        {
            //initialize dvg column 1 is button,2 is item name and 3 is quantity
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dvgpreadditem.Columns.Add(btn);
            btn.HeaderText = "Remove";
            btn.Text = "remove";
            btn.Name = "btnremove";
            btn.UseColumnTextForButtonValue = true;

            dvgpreadditem.Columns.Add("item_name", "Item Name");
            dvgpreadditem.Columns.Add("quantity", "Quantity");
            dvgpreadditem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //set column 0 weight = 1, column 1 weight = 2, column 2 weight = 1



        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (cbitem.Text == "" || txtboxquantity.Text == "")
            {

                MessageBox.Show("Please fill in all fields"); return;
            }
            else
            { 
                //add item name and quantity to dvg column 2 and 3
                dvgpreadditem.Rows.Add("Remove", cbitem.Text, txtboxquantity.Text);
                //remove the selected item in cbitem
                cbitem.Items.Remove(cbitem.Text);
                clear_input();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear_input();  
        }

        private void clear_input()
        {

           cbitem.Text = "";
            txtboxquantity.Text = "";
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            //add dvg data to database
            if (dvgpreadditem.Rows.Count == 0)
            {
                MessageBox.Show("Please add item to the list");
                return;
            }
            else
            {
      
                for (int i = 0; i < dvgpreadditem.Rows.Count; i++)
                {
                    string item_name = dvgpreadditem.Rows[i].Cells[1].Value.ToString();
                    string quantity = dvgpreadditem.Rows[i].Cells[2].Value.ToString();
                    int item_id = get_item_id(item_name);
                    int warehouse_id = get_warehouse_id(user_id);
                    int current_quantity = get_item_quantity(item_id, warehouse_id);
                    int new_quantity = current_quantity + Convert.ToInt32(quantity);
                    string sql = "update warehouse_item set quantity = " + new_quantity + " where item_id = " + item_id + " and warehouse_id = " + warehouse_id;
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
        
                MessageBox.Show("Item added successfully");
                dvgpreadditem.Rows.Clear();
                load_item_data();
            }
        }

        private int get_item_id(string item_name)
        {
            int item_id;
            string sql = "select item_id from item where item_name = '" + item_name + "'";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            item_id = reader.GetInt32("item_id");
            conn.Close();
            return item_id;
        }
        private int get_item_quantity(int item_id,int warehouse_id)
        {

           int quantity;
            string sql = "select quantity from warehouse_item where item_id = " + item_id + " and warehouse_id = " + warehouse_id + ";" ;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            quantity = reader.GetInt32("quantity");
            conn.Close();
            return quantity;
        }

        private int get_warehouse_id(int user_id)
        {
            int warehouse_id = 0;
            string sql = "select shop_id from user where user_id = " + user_id;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int shop_id = reader.GetInt32("shop_id");
                conn.Close();
                string sql2 = "select warehouse_id from shop where shop_id = " + shop_id;
                conn.Open();
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                if (reader2.Read())
                {
                    warehouse_id = reader2.GetInt32("warehouse_id");
                } else { MessageBox.Show("warehouse not found "); }
                      
                conn.Close();
            } else { MessageBox.Show("shop not found"); }
            return warehouse_id;
        }
    }
}
