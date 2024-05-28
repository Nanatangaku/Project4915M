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
    public partial class WarehouseClerkHomePage : Form
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

        public WarehouseClerkHomePage()
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
        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            panNav.Height = btnWarehouse.Height;
            panNav.Top = btnWarehouse.Top;
            panNav.Left = btnWarehouse.Left;
            btnWarehouse.BackColor = Color.FromArgb(46, 51, 73);

            this.panFormLoad.Controls.Clear();
            SearchWarehouseStock warehouse = new SearchWarehouseStock() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            warehouse.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(warehouse);
            warehouse.Show();
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
            ReceivedItem receivedItem = new ReceivedItem() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            receivedItem.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(receivedItem);
            receivedItem.Show();
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
