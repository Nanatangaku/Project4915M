﻿using MySql.Data.MySqlClient;
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
    public partial class CreateWarehouse : Form
    {
        public CreateWarehouse()
        {
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            String newWarehouseName = roundTextBox1.Texts;
            String newWarehousePhone = roundTextBox2.Texts;
            if (newWarehouseName == null || newWarehousePhone == null)
            {
                MessageBox.Show("Please fill in all the information!");
            }
            else
            {
                String sql = "INSERT INTO warehouse (warehouse_name, phone) VALUES ('" + newWarehouseName + "', '" + newWarehousePhone + "')";
                MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                try
                {
                    if (cmd.ExecuteNonQuery() >= 1)
                    {
                        MessageBox.Show("Warehouse Created Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Warehouse Creation Failed");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
        }
    }
}
