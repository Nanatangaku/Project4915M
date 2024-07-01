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
using System.Runtime.CompilerServices;

namespace Group6_Project
{
    public partial class ShopManagerHomePage : Form

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

        private int user_id;

        public ShopManagerHomePage(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        //Event
        [Category("Event")]
        private void btnCategoryManager_Leave(object sender, EventArgs e)
        {
            btnSmLogout.BackColor = Color.FromArgb(51, 51, 100);
        }

        [Category("Event")]
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            panNav.Height = btnCheckout.Height;
            panNav.Top = btnCheckout.Top;
            panNav.Left = btnCheckout.Left;
            btnCheckout.BackColor = Color.FromArgb(46, 51, 73);

            this.panFormLoad.Controls.Clear();
            CheckOut checkout = new CheckOut(user_id,panFormLoad) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            checkout.FormBorderStyle = FormBorderStyle.None;
            this.panFormLoad.Controls.Add(checkout);
            checkout.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            panNav.Height = btnOrder.Height;
            panNav.Top = btnOrder.Top;
            panNav.Left = btnOrder.Left;
            btnOrder.BackColor = Color.FromArgb(46, 51, 73);

            this.panFormLoad.Controls.Clear();
            CreateRequest createrequest = new CreateRequest(user_id,panFormLoad) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            createrequest.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(createrequest);
            createrequest.Show();
        }

        private void btnOrder_Leave(object sender, EventArgs e)
        {
            btnOrder.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void btnCheckout_Leave(object sender, EventArgs e)
        {
            btnCheckout.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void btnViewOrder_Leave(object sender, EventArgs e)
        {
            btnViewOrder.BackColor = Color.FromArgb(51, 51, 76);
        }

        [Category("Event")]
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            panNav.Height = btnViewOrder.Height;
            panNav.Top = btnViewOrder.Top;
            panNav.Left = btnViewOrder.Left;
            btnViewOrder.BackColor = Color.FromArgb(46, 51, 73);

            this.panFormLoad.Controls.Clear();
            ViewOrder vieworder = new ViewOrder(user_id, panFormLoad) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            vieworder.FormBorderStyle = FormBorderStyle.None;
            this.panFormLoad.Controls.Add(vieworder);
            vieworder.Show();
        }

        private void btnSmLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new loginPage().ShowDialog();
            this.Close();
        }

        private void panFormLoad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }

