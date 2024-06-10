using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group6_Project.Category.Category_Supplier
{
    public partial class UpdateSupplier : Form
    {
        Panel panFormLoad;
        String id;
        public UpdateSupplier(Panel panFormLoad, String id)
        {
            this.panFormLoad = panFormLoad;
            this.id = id;
            InitializeComponent();
        }

        private void UpdateSupplier_Load(object sender, EventArgs e)
        {

        }
    }
}
