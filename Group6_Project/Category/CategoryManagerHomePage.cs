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
    public partial class CategoryManagerHomePage : Form
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
        public CategoryManagerHomePage(int user_id)
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
        private void btnShop_Click(object sender, EventArgs e)
        {
            // 控制navbar的位置 紫色
            panNav.Height = btnShop.Height;
            panNav.Top = btnShop.Top;
            panNav.Left = btnShop.Left;
            btnShop.BackColor = Color.FromArgb(46, 51, 73);

            this.panFormLoad.Controls.Clear();
            ShopPage shop = new ShopPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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
        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            panNav.Height = btnWarehouse.Height;
            panNav.Top = btnWarehouse.Top;
            panNav.Left = btnWarehouse.Left;
            btnWarehouse.BackColor = Color.FromArgb(46, 51, 73);

            this.panFormLoad.Controls.Clear();
            WarehousePage warehouse = new WarehousePage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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
        private void btnDepartment_Click(object sender, EventArgs e)
        {
            panNav.Height = btnDepartment.Height;
            panNav.Top = btnDepartment.Top;
            panNav.Left = btnDepartment.Left;
            btnDepartment.BackColor = Color.FromArgb(46, 51, 73);

            this.panFormLoad.Controls.Clear();
            DepartmentPage department = new DepartmentPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            department.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(department);
            department.Show();
        }
        [Category("Event")]
        private void btnDepartment_Leave(object sender, EventArgs e)
        {
            btnDepartment.BackColor = Color.FromArgb(51, 51, 76);
        }
        [Category("Event")]
        private void btnRole_Click(object sender, EventArgs e)
        {
            panNav.Height = btnRole.Height;
            panNav.Top = btnRole.Top;
            panNav.Left = btnRole.Left;
            btnRole.BackColor = Color.FromArgb(46, 51, 73);

            this.panFormLoad.Controls.Clear();
            RolePage role = new RolePage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            role.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(role);
            role.Show();
        }
        [Category("Event")]
        private void btnRole_Leave(object sender, EventArgs e)
        {
            btnRole.BackColor = Color.FromArgb(51, 51, 76);
        }
        [Category("Event")]
        private void btnCategory_Click(object sender, EventArgs e)
        {
           
            panNav.Height = btnCategory.Height;
            panNav.Top = btnCategory.Top;
            panNav.Left = btnCategory.Left;
            btnCategory.BackColor = Color.FromArgb(46, 51, 73);

            this.panFormLoad.Controls.Clear();
            CategoryPage category = new CategoryPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            category.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(category);
            category.Show();

            Object a = Activator.CreateInstance(typeof(EventArgs));
            EventArgs click = (EventArgs)a; 
            
        }
        [Category("Event")]
        private void btnCategory_Leave(object sender, EventArgs e)
        {
            btnCategory.BackColor = Color.FromArgb(51, 51, 76);
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

        private void panNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panFormLoad_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
