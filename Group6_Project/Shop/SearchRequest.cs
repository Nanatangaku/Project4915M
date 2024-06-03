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
    public partial class SearchRequest : Form

    {
        private int user_id;
        public SearchRequest()
        {
            InitializeComponent();
            this.user_id = 8;
        }

        private void SearchRequest_Load(object sender, EventArgs e)
        {
            string sql = "select * from order_request where order_rquest = " + user_id + ";";
            MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            DataTable dt = new DataTable("Request Info");


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
