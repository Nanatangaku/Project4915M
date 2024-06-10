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

namespace Group6_Project.Category.Category_Supplier
{
    public partial class UpdateSupplier : Form
    {
        Panel panFormLoad;
        String id;
        public UpdateSupplier(Panel panFormLoad, String id)
        {
            this.panFormLoad = panFormLoad;
            this.id = id;
            InitializeComponent();
        }

        private void UpdateSupplier_Load(object sender, EventArgs e)
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
                String sql = "UPDATE supplier SET supplier_name = '" + newSupplierName + "', supplier_remark = '" + newSupplierReMark + "'";
                MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                try
                {
                    if (cmd.ExecuteNonQuery() >= 1)
                    {
                        MessageBox.Show("Supplier Update Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Supplier Update Failed");
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
