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
    public partial class SearchWarehouse : Form
    {
        public SearchWarehouse()
        {
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            String warehouseName = roundTextBox1.Texts;

            showTable(warehouseName);
            
        }

      
//geting the warehouse
        public DataTable GetWarehouse(String warehouseName)
        {
            String sql = "SELECT * FROM warehouse WHERE warehouse_name = '" + warehouseName + "'";
            MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
//To show warehouse details in dataGridView
        public void showTable(String warehouseName)
        {
            dataGridView_warehouse.DataSource = GetWarehouse(warehouseName);
        }

        private void SearchWarehouse_Load(object sender, EventArgs e)
        {

        }
    }
}
