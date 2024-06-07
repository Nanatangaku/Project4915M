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
    public partial class DepartmentPage : Form
    {
        Panel panFormLoad;
        public DepartmentPage(Panel panFormLoad)
        {
            InitializeComponent();
            this.panFormLoad = panFormLoad;
        }

        private void rbtnSearchDepartment_Click(object sender, EventArgs e)
        {
            this.panFormLoad.Controls.Clear();
            SearchDepartment searchdepartment = new SearchDepartment() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            searchdepartment.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(searchdepartment);
            searchdepartment.Show();
        }

        private void rbtnCreateDepartment_Click(object sender, EventArgs e)
        {
            this.panFormLoad.Controls.Clear();
            CreateDepartment createdepartment = new CreateDepartment() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            createdepartment.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(createdepartment);
            createdepartment.Show();
        }
    }
}
