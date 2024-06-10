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
    public partial class CreateShop : Form
    {
        public CreateShop()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

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
                String sql = "INSERT INTO shop (warehouse_id, user_id, remarks, shopname) VALUES ("+ newShopWarehouseID +","+ newShopManagerID +",'"+ newShopRemark +"','"+ newShopName +"');";
                MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                try
                {
                    if (cmd.ExecuteNonQuery() >= 1)
                    {
                        MessageBox.Show("Shop Created Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Shop Creation Failed");
                    }
                }catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();


            }
        }

        private void CreateShop_Load(object sender, EventArgs e)
        {

        }
    }
}
