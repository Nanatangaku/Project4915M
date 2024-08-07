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
        Panel panFormLoad;
        public CreateWarehouse(Panel panFormLoad)
        {
            this.panFormLoad = panFormLoad;
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            String newWarehouseName = roundTextBox1.Texts;
            String newWarehousePhone = roundTextBox2.Texts;
            long i;
            if (newWarehouseName == null || newWarehousePhone == null || newWarehouseName == "" || newWarehousePhone == "")
            {
                MessageBox.Show("Please fill in all the information!");
            }else if (!(long.TryParse(newWarehousePhone, out i)))
            {
                MessageBox.Show("Please no letters in Phone field!");
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

        private void roundButton2_Click(object sender, EventArgs e)
        {
            this.panFormLoad.Controls.Clear();
            SearchWarehouse searchwarehouse = new SearchWarehouse(panFormLoad) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            searchwarehouse.FormBorderStyle = FormBorderStyle.None;
            this.panFormLoad.Controls.Add(searchwarehouse);
            searchwarehouse.Show();
        }
    }
}
