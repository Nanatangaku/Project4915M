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
        public ShopPage()
        {
            InitializeComponent();
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            this.panShop.Controls.Clear();
            CreateShop createshop = new CreateShop() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            createshop.FormBorderStyle = FormBorderStyle.None;
            this.panShop.Controls.Add(createshop);
            createshop.Show();


        }

        private void ShopPage_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.panShop.Controls.Clear();
            SearchShop searchShop = new SearchShop() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            searchShop.FormBorderStyle = FormBorderStyle.None;
            this.panShop.Controls.Add(searchShop);
            searchShop.Show();
        }
    }
}
