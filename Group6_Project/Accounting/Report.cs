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
    public partial class Report : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");
        Panel panFormlaod;
        public Report(Panel panFormlaod)
        {

            InitializeComponent();
            this.panFormlaod = panFormlaod;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            //fill the chartreport show the order each month this year,get the data from delivery table count order_id group by create_date by month
            string sql = "select count(order_id) as order_count,month(create_date) as month from delivery where year(create_date) = year(now()) group by month(create_date)";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                chartreport.Series["Order"].Points.AddXY(reader.GetInt32("month"), reader.GetInt32("order_count"));
            }
            
            conn.Close();

        }

        private void chartreport_Click(object sender, EventArgs e)
        {

        }
    }
}
