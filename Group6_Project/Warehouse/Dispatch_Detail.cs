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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group6_Project
{
    public partial class Dispatch_Detail : Form
    {
        int user_id;
        int order_id;
        Panel panFormLoad;
        int payment;
        string status;
        string create_date;
        string expected_delivery_date;
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");

        public Dispatch_Detail(int user_id,int order_id,Panel panFormLoad,int payment,string status,string create_date,string expected_delivery_date)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.order_id = order_id;
            this.panFormLoad = panFormLoad;
            this.payment = payment;
            this.status = status;
            this.create_date = create_date;
            this.expected_delivery_date = expected_delivery_date;
        }

        private void Dispatch_Detail_Load(object sender, EventArgs e)
        {
            initialize_data_gbitem();
            OrderDetail_Load();
            btnDispatch_show();
        }

        private void initialize_data_gbitem()
        {
            txtboxorder_id.Text = order_id.ToString();
            txtboxpayment.Text = payment.ToString();
            txtorder_status.Text = status.ToString();
            txtboxcreatedate.Text = create_date.ToString();
            txtboxexpecteddate.Text = expected_delivery_date.ToString();

        }

        private void gbOrderdetail_Enter(object sender, EventArgs e)
        {

        }
        private void OrderDetail_Load()
        {
            string sql = "select item.item_name,item.item_category,item.price,order_item.quantity from item,order_item where item.item_id= order_item.item_id and order_id = " + order_id;
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dvgItem.DataSource = dt;
            dvgItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void lblabck_Click(object sender, EventArgs e)
        {
            this.panFormLoad.Controls.Clear();
            Dispatch dispatch = new Dispatch(user_id, panFormLoad) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dispatch.FormBorderStyle = FormBorderStyle.None;
            this.panFormLoad.Controls.Add(dispatch);
            dispatch.Show();
        }

        private void btnDispatch_Click(object sender, EventArgs e)
        {
            string sql = "update order_request set order_status_id = 7  where order_id = " + order_id;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            if (cmd.ExecuteNonQuery() >= 1)
            {
                MessageBox.Show("Order id "+order_id +" is Dispatched");
            }
            conn.Close();
            string sql2 = "update delivery set despatch_date = now() where order_id = " + order_id;
            conn.Open();
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
            if (cmd2.ExecuteNonQuery() >= 1)
            {

            } else {
                MessageBox.Show("despatch_date set error ");
            } 
                  
            conn.Close();
        }

        private Boolean checkdispached()
        {
            if (status == "waiting to process")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnDispatch_show()
        {
            if (checkdispached())
            {
                btnDispatch.Visible = true;
            }
            else
            {
                btnDispatch.Visible = false;
            }
        }
    }
}
