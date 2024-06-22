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
        private void btnCategoryManager_Leave(object sender, EventArgs e)
        {
            btnWmLogout.BackColor = Color.FromArgb(51, 51, 100);
        }

        [Category("Event")]
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [Category("Event")]
        private void btnreceiveditem_Click(object sender, EventArgs e)
        {

            this.panFormLoad.Controls.Clear();
            ReceivedItem receivedItem = new ReceivedItem(user_id,panFormLoad) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            receivedItem.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(receivedItem);
            receivedItem.Show();
        }

        [Category("Event")]
        private void btnDispatch_Click(object sender, EventArgs e)
        {
            this.panFormLoad.Controls.Clear();
            Dispatch dispatch = new Dispatch(user_id,panFormLoad) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dispatch.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(dispatch);
            dispatch.Show();

        }

        [Category("Event")]
        private void btnStockPage_Click(object sender, EventArgs e)
        {
            this.panFormLoad.Controls.Clear();
            StockRecord stockrecord = new StockRecord(user_id,panFormLoad) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            stockrecord.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(stockrecord);
            stockrecord.Show();

        }

        [Category("Event")]
        private void btnWmLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new loginPage().ShowDialog();
            this.Close();
        }

        private void btnsetoflevel_Click(object sender, EventArgs e)
        {
            this.panFormLoad.Controls.Clear();
            setoflevel setoflevel = new setoflevel(user_id,panFormLoad) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            setoflevel.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(setoflevel);
            setoflevel.Show();

        }
    }
}
