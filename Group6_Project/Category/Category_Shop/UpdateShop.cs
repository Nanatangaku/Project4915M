using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group6_Project.Category.Category_Shop
{
    public partial class UpdateShop : Form
    {
        Panel panFormLoad;
        String id;
        public UpdateShop(Panel panFormLoad, String id)
        {
            this.id = id;
            this.panFormLoad = panFormLoad;
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
