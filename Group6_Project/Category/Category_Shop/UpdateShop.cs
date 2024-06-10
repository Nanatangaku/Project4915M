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

namespace Group6_Project.Category.Category_Shop
{
    public partial class UpdateShop : Form
    {
        Panel panFormLoad;
        String id;
        public UpdateShop(Panel panFormLoad, String id)
        {
            this.id = id;
            this.panFormLoad = panFormLoad;
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            String newShopName = rtxtbox_newShopName.Texts;
            String newShopWarehouseID = rtxtbox_newShopWarehouseID.Texts;
            String newShopManagerID = rtxtbox_newShopManagerID.Texts;
            String newShopRemark = rtxtbox_newShopRemark.Texts;

            if (newShopName == "" || newShopWarehouseID == "" || newShopManagerID == "" || newShopRemark == "")
            {
                MessageBox.Show("Please fill in all the information");
            }
            else
            {
                String sql = "UPDATE shop SET warehouse_id = " + newShopWarehouseID + ", user_id = " + newShopManagerID + ", remarks = '" + newShopRemark + "', shopname = '" + newShopName + "' WHERE shop_id = "+ id +"";
                MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                try
                {
                    if (cmd.ExecuteNonQuery() >= 1)
                    {
                        MessageBox.Show("Shop Update Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Shop Update Failed");
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
            SearchShop searchShop = new SearchShop(panFormLoad) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            searchShop.FormBorderStyle = FormBorderStyle.None;
            this.panFormLoad.Controls.Add(searchShop);
            searchShop.Show();
        }
    }
}
