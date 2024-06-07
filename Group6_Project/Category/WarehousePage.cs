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
    public partial class WarehousePage : Form
    {
        Panel panFormLoad;
        public WarehousePage(Panel panFormLoad)
        {
            InitializeComponent();
            this.panFormLoad = panFormLoad;
        }

        private void WarehousePage_Load(object sender, EventArgs e)
        {

        }

        private void rbtnSearchWare_Click(object sender, EventArgs e)
        {
            this.panFormLoad.Controls.Clear();
            SearchWarehouse searchwarehouse = new SearchWarehouse() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            searchwarehouse.FormBorderStyle = FormBorderStyle.None;
            this.panFormLoad.Controls.Add(searchwarehouse);
            searchwarehouse.Show();
        }

        private void rbtnCreateWare_Click(object sender, EventArgs e)
        {
            this.panFormLoad.Controls.Clear();
            CreateWarehouse createwarehouse = new CreateWarehouse() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            createwarehouse.FormBorderStyle = FormBorderStyle.None;
            this.panFormLoad.Controls.Add(createwarehouse);
            createwarehouse.Show();
        }
    }
}
