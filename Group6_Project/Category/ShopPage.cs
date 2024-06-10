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
    public partial class ShopPage : Form
    {
        Panel panFormLoad;
        public ShopPage(Panel panFormLoad)
        {
            InitializeComponent();
            this.panFormLoad = panFormLoad;
        }

        private void ShopPage_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void rbtnSearchShop_Click(object sender, EventArgs e)
        {
            this.panFormLoad.Controls.Clear();
            SearchShop searchShop = new SearchShop(panFormLoad) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            searchShop.FormBorderStyle = FormBorderStyle.None;
            this.panFormLoad.Controls.Add(searchShop);
            searchShop.Show();
        }

        private void rbtnCreateShop_Click(object sender, EventArgs e)
        {
            this.panFormLoad.Controls.Clear();
            CreateShop createshop = new CreateShop(panFormLoad) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            createshop.FormBorderStyle = FormBorderStyle.None;
            this.panFormLoad.Controls.Add(createshop);
            createshop.Show();
        }
    }
}
