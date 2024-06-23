using Group6_Project.Category.Category_Warehouse;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
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
        Panel panFormLoad;
        //To get Data from database
        public DataTable GetData(String target)
        {
            String sql = "select * from warehouse where warehouse_name LIKE '%" + target + "%'";
            MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            return dataTable;
        }
        //To show data details in dataGridView
        public void showTable(String target)
        {
            dataGridView1.DataSource = GetData(target);
        }
        public SearchWarehouse(Panel panFromLoad)
        {
            this.panFormLoad = panFromLoad;
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            
        }
        private void SearchWarehouse_Load(object sender, EventArgs e)
        {
            //create button update
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.Name = "Update";
            btnUpdate.HeaderText = "Update";
            btnUpdate.Text = "Update";
            btnUpdate.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(0, btnUpdate);

            //create button delete
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "Delete";
            btnDelete.HeaderText = "Delete";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(1, btnDelete);
            showTable("");
        }

        private void roundTextBox1__TextChanged(object sender, EventArgs e)
        {
            showTable(roundTextBox1.Texts);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                this.panFormLoad.Controls.Clear();
                UpdateWarehouse updateWarehouse = new UpdateWarehouse(panFormLoad, dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value.ToString()) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                updateWarehouse.FormBorderStyle = FormBorderStyle.None;
                this.panFormLoad.Controls.Add(updateWarehouse);
                updateWarehouse.Show();
            }
            if (e.ColumnIndex == 1)
            {
                try     //try deleting row from datagridview which equals to id next to the delete item
                {
                    String sql = "DELETE FROM `warehouse` WHERE `warehouse`.`warehouse_id` =" + dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString() + "";
                    MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Item deleted.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            showTable("");
        }
    }
}
