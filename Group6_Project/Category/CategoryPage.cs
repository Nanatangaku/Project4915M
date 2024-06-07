using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group6_Project
{
    public partial class CategoryPage : Form
    {
        Panel panFormLoad;
        public CategoryPage(Panel panFormLoad)
        {
            InitializeComponent();
            this.panFormLoad = panFormLoad;
        }

        private void rbtnSearchCategory_Click(object sender, EventArgs e)
        {
            this.panFormLoad.Controls.Clear();
            SearchCategory searchcategory = new SearchCategory() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            searchcategory.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(searchcategory);
            searchcategory.Show();
        }

        private void rbtnCreateCategory_Click(object sender, EventArgs e)
        {
            this.panFormLoad.Controls.Clear();
            CreateCategory createcategory = new CreateCategory() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            createcategory.FormBorderStyle = FormBorderStyle.None;
            panFormLoad.Controls.Add(createcategory);
            createcategory.Show();
        }
    }
}
