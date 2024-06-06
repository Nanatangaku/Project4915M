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
    public partial class SupplierPage : Form
    {
        public SupplierPage()
        {
            InitializeComponent();
        }

        private void rbtnSearchSupplier_Click(object sender, EventArgs e)
        {
            this.panSupplier.Controls.Clear();
            SearchSupplier searchsupplier = new SearchSupplier() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            searchsupplier.FormBorderStyle = FormBorderStyle.None;
            this.panSupplier.Controls.Add(searchsupplier);
            searchsupplier.Show();
        }

        private void rbtnCreateSupplier_Click(object sender, EventArgs e)
        {
            this.panSupplier.Controls.Clear();
            CreateSupplier createsupplier = new CreateSupplier() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            createsupplier.FormBorderStyle = FormBorderStyle.None;
            this.panSupplier.Controls.Add(createsupplier);
            createsupplier.Show();
        }
    }
}
