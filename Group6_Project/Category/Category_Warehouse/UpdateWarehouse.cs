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

namespace Group6_Project.Category.Category_Warehouse
{
    public partial class UpdateWarehouse : Form
    {
        Panel panFormLoad;
        String id;
        public UpdateWarehouse(Panel panFormLoad, String id)
        {
            this.panFormLoad = panFormLoad;
            this.id = id;
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            String newWarehouseName = roundTextBox1.Texts;
            String newWarehousePhone = roundTextBox2.Texts;
            if (newWarehouseName == null || newWarehousePhone == null || newWarehouseName == "" || newWarehousePhone == "")
            {
                MessageBox.Show("Please fill in all the information!");
            }
            else
            {
                String sql = "UPDATE warehouse SET warehouse_name = '"+ newWarehouseName +"', phone = '"+ newWarehousePhone +"' WHERE warehouse_id = '"+ id +"'";
                MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                try
                {
                    if (cmd.ExecuteNonQuery() >= 1)
                    {
                        MessageBox.Show("Warehouse Update Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Warehouse Update Failed");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.panFormLoad.Controls.Clear();
            SearchWarehouse searchwarehouse = new SearchWarehouse(panFormLoad) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            searchwarehouse.FormBorderStyle = FormBorderStyle.None;
            this.panFormLoad.Controls.Add(searchwarehouse);
            searchwarehouse.Show();
        }

        private void UpdateWarehouse_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void roundTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void roundTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
