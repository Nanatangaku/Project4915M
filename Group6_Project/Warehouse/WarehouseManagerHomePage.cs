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
    public partial class WarehouseManagerHomePage : Form
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
        public WarehouseManagerHomePage(int user_id)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.user_id = user_id;
        }

        //Event
        
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

        [Category("Event")]
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreceiveditem_Click(object sender, EventArgs e)
        {

            this.panFormLoad.Controls.Clear();
            ReceivedItem receivedItem = new ReceivedItem(user_id,panFormLoad) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            receivedItem.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(receivedItem);
            receivedItem.Show();
        }

     

        private void btnDispatch_Click(object sender, EventArgs e)
        {
            this.panFormLoad.Controls.Clear();
            Dispatch dispatch = new Dispatch(user_id,panFormLoad) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dispatch.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(dispatch);
            dispatch.Show();

        }
    }
}
