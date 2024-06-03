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

        public CheckOut(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
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
            dateTimePicker.MinDate = DateTime.Now;
            // can you help me set the maxdate of datetimepicker 3month from now?
            dateTimePicker.MaxDate = DateTime.Now.AddMonths(3);

            filldvg(dvgcart);

        }

        private void filldvg(DataGridView dataGridView)
        {
         
            string sql = "select item.item_id,item.item_Name,item.item_Category, item.price  ,cart.quantity from cart,item where item.item_id = cart.item_id ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            //use adapter to fill the data in the datatable
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

        }
    }
}
