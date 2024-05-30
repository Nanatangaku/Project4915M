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
    public partial class HRHomePage : Form
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

        public HRHomePage()
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
        [Category("Event")]
        private void btnUserInformation_Click(object sender, EventArgs e)
        {
            panNav.Height = btnUserInformation.Height;
            panNav.Top = btnUserInformation.Top;
            panNav.Left = btnUserInformation.Left;
            btnUserInformation.BackColor = Color.FromArgb(46, 51, 73);

            this.panFormLoad.Controls.Clear();
            CreateDepartment shop = new CreateDepartment() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            shop.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(shop);
            shop.Show();
        }
        [Category("Event")]
        private void btnUserInformation_Leave(object sender, EventArgs e)
        {
            btnUserInformation.BackColor = Color.FromArgb(51, 51, 76);
        }
    }
}
