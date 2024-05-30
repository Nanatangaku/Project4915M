using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Plasmoid.Extensions;
using System.Runtime.InteropServices;

namespace Group6_Project
{
    public partial class PurchaseManagerHomePage : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public PurchaseManagerHomePage()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        //Event
        [Category("Event")]
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        [Category("Event")]
        private void btnShop_Click(object sender, EventArgs e)
        {
            panNav.Height = btnShop.Height;
            panNav.Top = btnShop.Top;
            panNav.Left = btnShop.Left;
            btnShop.BackColor = Color.FromArgb(46, 51, 73);

            this.panFormLoad.Controls.Clear();
            SetRule shop = new SetRule() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            shop.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(shop);
            shop.Show();
        }
        [Category("Event")]
        private void btnShop_Leave(object sender, EventArgs e)
        {
            btnShop.BackColor = Color.FromArgb(51, 51, 76);
        }
        
        [Category("Event")]
        private void btnSupplier_Click(object sender, EventArgs e)
        {
            panNav.Height = btnSupplier.Height;
            panNav.Top = btnSupplier.Top;
            panNav.Left = btnSupplier.Left;
            btnSupplier.BackColor = Color.FromArgb(46, 51, 73);

            this.panFormLoad.Controls.Clear();
            SupplierPage supplier = new SupplierPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            supplier.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(supplier);
            supplier.Show();
        }
        [Category("Event")]
        private void btnSupplier_Leave(object sender, EventArgs e)
        {
            btnSupplier.BackColor = Color.FromArgb(51, 51, 76);
        }
        
        [Category("Event")]
        private void btnCategoryManager_Click(object sender, EventArgs e)
        {
            panNav.Height = btnCategoryManager.Height;
            panNav.Top = btnCategoryManager.Top;
            panNav.Left = btnCategoryManager.Left;
            btnCategoryManager.BackColor = Color.FromArgb(46, 51, 73);

            this.panFormLoad.Controls.Clear();
            loginPage login = new loginPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            login.FormBorderStyle = FormBorderStyle.None;
            this.panFormLoad.Controls.Add(login);
            login.Show();
        }
        [Category("Event")]
        private void btnCategoryManager_Leave(object sender, EventArgs e)
        {
            btnCategoryManager.BackColor = Color.FromArgb(51, 51, 100);
        }
    }
}
