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
    public partial class SearchCategory : Form
    {
        public SearchCategory()
        {
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            String categoryName = roundTextBox1.Texts;

            showTable(categoryName);
        }
        public DataTable GetData(String Target)
        {
            String sql = "SELECT * FROM category WHERE category_name = '" + Target + "'";
            MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        //To show data details in dataGridView
        public void showTable(String Target)
        {
            dataGridView1.DataSource = GetData(Target);
        }
    }
}
