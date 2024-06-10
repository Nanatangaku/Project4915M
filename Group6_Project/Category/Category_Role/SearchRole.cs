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
    public partial class SearchRole : Form
    {
        //To get Data from database
        public DataTable GetData(String target)
        {
            String sql = "select * from role where role_name LIKE '%" + target + "%'";
            MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234;database=project4915mdb");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        //To show data details in dataGridView
        public void showTable(String target)
        {
            dataGridView1.DataSource = GetData(target);
        }
        public SearchRole()
        {
            InitializeComponent();
        }

        private void roundTextBox1__TextChanged(object sender, EventArgs e)
        {
            showTable(roundTextBox1.Texts);
        }

        private void SearchRole_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "Delete";
            btn.HeaderText = "Delete";
            btn.Text = "Delete";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(0, btn);
            showTable("");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try     //try deleting row from datagridview which equals to id next to the delete item
                {
                    String sql = "DELETE FROM `role` WHERE `role`.`role_id` =" + dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString() + "";
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
