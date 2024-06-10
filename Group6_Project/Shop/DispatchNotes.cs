using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group6_Project
{
    public partial class DispatchNotes : Form
    {
        int user_id;
        int order_id;
        Panel panFormLoad;
        public DispatchNotes(int user_id,Panel panFormLoad,int order_id)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.panFormLoad = panFormLoad;
            this.order_id = order_id;
        }

        private void DispatchNotes_Load(object sender, EventArgs e)
        {

        }
    }
}
