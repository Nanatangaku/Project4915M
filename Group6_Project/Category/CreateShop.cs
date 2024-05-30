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
            String newShopName = rtxtbox_newname.Texts;
            String newnumber = rtxtbox_newshopnum.Texts;
            String newaddress = rtxtbox_newaddress.Texts;
            String newphone = rtxtbox_newphone.Texts;
            String newmanagerid = rtxtbox_newmanagerid.Texts;

            if (newShopName == "" || newnumber == "" || newaddress == "" || newphone == "" || newmanagerid == "")
            {
                MessageBox.Show("Please fill in all the information");
            }
            else
            {
               String sql = "INSERT INTO shop (Shop_ID, name, address, phone, manager_ID) VALUES ('" + newnumber + "', '" + newShopName + "', '" + newaddress + "', '" + newphone + "', '" + newmanagerid + "')";
                MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=4915mdb");
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
    }
}
