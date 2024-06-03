using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace Group6_Project
{
    public partial class CreateRequest : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");
        int user_id;

        public CreateRequest(int user_id)
        {
            InitializeComponent();
            this.user_id = 5;
        }

        private void CreateRequest_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "Shoppping Cart";
            btn.Text = "Add";
            btn.Name = "btnaddtocart";
            btn.UseColumnTextForButtonValue = true;

            filldvg();

            dataGridView2.ColumnCount = 6;
            dataGridView2.Columns.Add(btn);
            btn.HeaderText = "Shoppping Cart";
            btn.Text = "Remove";
            btn.Name = "btnremovefrom cart";
            btn.UseColumnTextForButtonValue = true;
            dataGridView2.Columns[1].Name = "Item id";
            dataGridView2.Columns[2].Name = "Name";




        }

        private void searchtxtbox__TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox1.Text;
            if (keyword != null)
            {
                filldvg(keyword);
            }
            else
            {
                filldvg();
            }
        }

        private void filldvg()
        {
            string sql = "select item.item_id,item.item_name,item.price,item_Category,warehouse_item.quantity from warehouse_item,item where item.item_id = warehouse_item.item_id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            //use adapter to fill the data in the datatable
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            //bind the data to the datagridview
            dataGridView1.DataSource = dt;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

            //make the data fit the datagridview1
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //make the data fit the datagridview1 weight   
            conn.Close();
        }

        private void filldvg(string valueToSearch)
        {
            string sql = "select item.item_name,item.price,item_Category,warehouse_item.quantity from warehouse_item,item where item.item_id = warehouse_item.item_id and item_name like '%" + valueToSearch + "%'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            //use adapter to fill the data in the datatable
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            //bind the data to the datagridview
            dataGridView1.DataSource = dt;



            //make the data fit the datagridview1
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //make the data fit the datagridview1 weight   
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //add select data to datagridview2
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                string item_name = selectedRow.Cells[1].Value.ToString();
                string price = selectedRow.Cells[2].Value.ToString();
                string category = selectedRow.Cells[3].Value.ToString();
                string quantity = selectedRow.Cells[4].Value.ToString();
                string[] row = { item_name, price, category, quantity };
                dataGridView2.Rows.Add(row);
                // remove the select data from datagridveiw 1
                dataGridView1.Rows.RemoveAt(index);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
