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
    public partial class CreateCategory : Form
    {
        public CreateCategory()
        {
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            String newCategoryName = roundTextBox1.Texts;
            String newCategoryDescription = roundTextBox2.Texts;
            if (newCategoryName == null || newCategoryDescription == null)
            {
                MessageBox.Show("Please fill in all the information!");
            }
            else
            {
                String sql = "INSERT INTO category (category_name, description) VALUES ('" + newCategoryName + "', '" + newCategoryDescription + "')";
                MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                try
                {
                    if (cmd.ExecuteNonQuery() >= 1)
                    {
                        MessageBox.Show("Category Created Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Category Creation Failed");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
