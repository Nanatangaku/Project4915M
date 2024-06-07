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
        Panel panformload;
        public CreateRequest(int user_id,Panel panformLoad)
        {
            InitializeComponent();

            this.user_id = 5;
            this.panformload = panformLoad;
        }

        private void CreateRequest_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "Shoppping Cart";
            btn.Text = "Add";
            btn.Name = "btnaddtocart";
            btn.UseColumnTextForButtonValue = true;

            // add a column allow user enter the quantity and default value is 1
            DataGridViewTextBoxColumn txt = new DataGridViewTextBoxColumn();
            dataGridView1.Columns.Add(txt);
            txt.HeaderText = "Quantity";
            txt.Name = "txtquantity";
            // default value is 0
            txt.ValueType = typeof(int);
            filldvg();
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
            //loop all the row if the item_id is already exist in cart table remomve it from the datagridvew1

            conn.Close();
        }

        private void filldvg(string valueToSearch)
        {
            string sql = "select item.item_id, item.item_name,item.price,item_Category,warehouse_item.quantity from warehouse_item,item where item.item_id = warehouse_item.item_id and item_name like '%" + valueToSearch + "%'";
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
            //if the item_id is exist in cart remove it
          
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                var inputquantity = 0;
     
                try
                {
                    inputquantity = Convert.ToInt32(selectedRow.Cells[1].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Quantity cant be 0 or negative");
                    MessageBox.Show(ex.Message);
                    return;
                }

                if (inputquantity <= 0)
                {
                    MessageBox.Show("Quantity cant be 0 or negative");
                    return;
                }
             
                var item_id = selectedRow.Cells[2].Value.ToString();
                var sql = "insert into cart(user_id,item_id,quantity)Value(" + user_id + "," + item_id + "," + inputquantity + ");";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item added to cart");
                    //remove the row from the datagridview
                    dataGridView1.Rows.RemoveAt(index);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panformload.Controls.Clear();
            CheckOut checkOut = new CheckOut(user_id, panformload) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            checkOut.FormBorderStyle = FormBorderStyle.None;
            this.panformload.Controls.Add(checkOut);
            checkOut.Show();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
