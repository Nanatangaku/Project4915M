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
    public partial class CreateSupplier : Form
    {
        Panel panFormLoad;
        public CreateSupplier(Panel panFormLoad)
        {
            this.panFormLoad = panFormLoad; 
            InitializeComponent();
        }

        private void roundTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            String newSupplierName = roundTextBox1.Texts;
            String newSupplierReMark = roundTextBox2.Texts;
            if (newSupplierName == null || newSupplierReMark == null)
            {
                MessageBox.Show("Please fill in all the information!");
            }
            else
            {
                String sql = "INSERT INTO supplier (supplier_name, supplier_remark) VALUES ('" + newSupplierName + "', '" + newSupplierReMark + "')";
                MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                try
                {
                    if (cmd.ExecuteNonQuery() >= 1)
                    {
                        MessageBox.Show("Supplier Created Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Supplier Creation Failed");
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
            SearchSupplier searchSupplier = new SearchSupplier(panFormLoad) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            searchSupplier.FormBorderStyle = FormBorderStyle.None;
            this.panFormLoad.Controls.Add(searchSupplier);
            searchSupplier.Show();
        }
    }
}
