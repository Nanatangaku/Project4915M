﻿using System;
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
            CreateRequest createrequest = new CreateRequest(user_id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            createrequest.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(createrequest);
            createrequest.Show();
        }
        [Category("Event")]
        private void btnWarehouse_Leave(object sender, EventArgs e)
        {
            btnWarehouse.BackColor = Color.FromArgb(51, 51, 76);
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

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnCheckout_Click(object sender, EventArgs e)
        {
            panNav.Height = btnCheckout.Height;
            panNav.Top = btnCheckout.Top;
            panNav.Left = btnCheckout.Left;
            btnCheckout.BackColor = Color.FromArgb(46, 51, 73);

            this.panFormLoad.Controls.Clear();
            CheckOut checkout = new CheckOut(user_id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            checkout.FormBorderStyle = FormBorderStyle.None;
            this.panFormLoad.Controls.Add(checkout);
            checkout.Show();
        }

        private void btnvieworder_Click(object sender, EventArgs e)
        {
            panNav.Height = btnvieworder.Height;
            panNav.Top = btnvieworder.Top;
            panNav.Left = btnvieworder.Left;
            btnvieworder.BackColor = Color.FromArgb(46, 51, 73);

            this.panFormLoad.Controls.Clear();
            // load the CheckOut form
            //ViewOrderPage vieworder = new ViewOrderPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //vieworder.FormBorderStyle = FormBorderStyle.None;
            //this.panFormLoad.Controls.Add(vieworder);
            //vieworder.Show();
        }
    }
}
