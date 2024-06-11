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
    public partial class DeliveryManagerHomePage : Form
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
        public DeliveryManagerHomePage(int user_id)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.user_id = user_id;
        }

        //Event
        
        [Category("Event")]
        private void btnCategoryManager_Leave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(51, 51, 100);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panFormLoad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndeliveryorder_Click(object sender, EventArgs e)
        {

            this.panFormLoad.Controls.Clear();
            DeliveryOrder deliveryorder = new DeliveryOrder(user_id, panFormLoad) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            deliveryorder.FormBorderStyle = FormBorderStyle.None;
            this.panFormLoad.Controls.Add(deliveryorder);
            deliveryorder.Show();
        }

  


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new loginPage().ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
