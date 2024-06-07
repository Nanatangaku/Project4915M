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
    public partial class RolePage : Form
    {
        Panel panFormLoad;
        public RolePage(Panel panFormLoad)
        {
            InitializeComponent();
            this.panFormLoad = panFormLoad;
        }

        private void rbtnSearchRole_Click(object sender, EventArgs e)
        {
            this.panFormLoad.Controls.Clear();
            SearchRole searchrole = new SearchRole() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            searchrole.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(searchrole);
            searchrole.Show();
        }

        private void rbtnCreateRole_Click(object sender, EventArgs e)
        {
            this.panFormLoad.Controls.Clear();
            CreateRole createrole = new CreateRole() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            createrole.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(createrole);
            createrole.Show();
        }
    }
}
