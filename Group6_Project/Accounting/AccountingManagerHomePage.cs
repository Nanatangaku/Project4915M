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
    public partial class AccountingManagerHomePage : Form
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
        int user_id;
        public AccountingManagerHomePage(int user_id)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.user_id = user_id;
        }

        //Event
        [Category("Event")]
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        [Category("Event")]
        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            panNav.Height = btnWarehouse.Height;
            panNav.Top = btnWarehouse.Top;
            panNav.Left = btnWarehouse.Left;
            btnWarehouse.BackColor = Color.FromArgb(46, 51, 73);

            this.panFormLoad.Controls.Clear();
            Invoice showInvoice = new Invoice() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showInvoice.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(showInvoice);
            showInvoice.Show();
        }
        [Category("Event")]
        private void btnWarehouse_Leave(object sender, EventArgs e)
        {
            btnWarehouse.BackColor = Color.FromArgb(51, 51, 76);
        }
        [Category("Event")]
        private void btnSupplier_Click(object sender, EventArgs e)
        {
            panNav.Height = btnSupplier.Height;
            panNav.Top = btnSupplier.Top;
            panNav.Left = btnSupplier.Left;
            btnSupplier.BackColor = Color.FromArgb(46, 51, 73);

            this.panFormLoad.Controls.Clear();
            CompletePayment completepay = new CompletePayment() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            completepay.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(completepay);
            completepay.Show();
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

        private void panFormLoad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.panFormLoad.Controls.Clear();
            Report report = new Report(panFormLoad) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            report.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(report);
            report.Show();
        }
    }
}
