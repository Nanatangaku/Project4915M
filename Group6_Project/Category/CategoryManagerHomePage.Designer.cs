
namespace Group6_Project
{
    partial class CategoryManagerHomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryManagerHomePage));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCategory = new System.Windows.Forms.Button();
            this.panNav = new System.Windows.Forms.Panel();
            this.btnCategoryManager = new System.Windows.Forms.Button();
            this.btnRole = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnWarehouse = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panFormLoad = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnCategory);
            this.panelMenu.Controls.Add(this.panNav);
            this.panelMenu.Controls.Add(this.btnCategoryManager);
            this.panelMenu.Controls.Add(this.btnRole);
            this.panelMenu.Controls.Add(this.btnSupplier);
            this.panelMenu.Controls.Add(this.btnWarehouse);
            this.panelMenu.Controls.Add(this.btnShop);
            this.panelMenu.Controls.Add(this.panel2);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.btnCategory, "btnCategory");
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Image = global::Group6_Project.Properties.Resources.category;
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            this.btnCategory.Leave += new System.EventHandler(this.btnCategory_Leave);
            // 
            // panNav
            // 
            this.panNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.panNav, "panNav");
            this.panNav.Name = "panNav";
            this.panNav.Paint += new System.Windows.Forms.PaintEventHandler(this.panNav_Paint);
            // 
            // btnCategoryManager
            // 
            this.btnCategoryManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(100)))));
            this.btnCategoryManager.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.btnCategoryManager, "btnCategoryManager");
            this.btnCategoryManager.FlatAppearance.BorderSize = 0;
            this.btnCategoryManager.ForeColor = System.Drawing.Color.White;
            this.btnCategoryManager.Image = global::Group6_Project.Properties.Resources.user__1_;
            this.btnCategoryManager.Name = "btnCategoryManager";
            this.btnCategoryManager.UseVisualStyleBackColor = false;
            this.btnCategoryManager.Click += new System.EventHandler(this.btnCategoryManager_Click);
            this.btnCategoryManager.Leave += new System.EventHandler(this.btnCategoryManager_Leave);
            // 
            // btnRole
            // 
            this.btnRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnRole.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.btnRole, "btnRole");
            this.btnRole.FlatAppearance.BorderSize = 0;
            this.btnRole.ForeColor = System.Drawing.Color.White;
            this.btnRole.Image = global::Group6_Project.Properties.Resources.search;
            this.btnRole.Name = "btnRole";
            this.btnRole.UseVisualStyleBackColor = false;
            this.btnRole.Click += new System.EventHandler(this.btnRole_Click);
            this.btnRole.Leave += new System.EventHandler(this.btnRole_Leave);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnSupplier.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.btnSupplier, "btnSupplier");
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSupplier.Image = global::Group6_Project.Properties.Resources.shopping_cart;
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            this.btnSupplier.Leave += new System.EventHandler(this.btnSupplier_Leave);
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnWarehouse.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.btnWarehouse, "btnWarehouse");
            this.btnWarehouse.FlatAppearance.BorderSize = 0;
            this.btnWarehouse.ForeColor = System.Drawing.Color.White;
            this.btnWarehouse.Image = global::Group6_Project.Properties.Resources.box;
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.UseVisualStyleBackColor = false;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            this.btnWarehouse.Leave += new System.EventHandler(this.btnWarehouse_Leave);
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnShop.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.btnShop, "btnShop");
            this.btnShop.FlatAppearance.BorderSize = 0;
            this.btnShop.ForeColor = System.Drawing.Color.White;
            this.btnShop.Image = global::Group6_Project.Properties.Resources.home2;
            this.btnShop.Name = "btnShop";
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            this.btnShop.Leave += new System.EventHandler(this.btnShop_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(100)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Group6_Project.Properties.Resources.car_circle_bolt;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(100)))));
            this.panel5.Controls.Add(this.btnClose);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panFormLoad
            // 
            this.panFormLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            resources.ApplyResources(this.panFormLoad, "panFormLoad");
            this.panFormLoad.Name = "panFormLoad";
            this.panFormLoad.Paint += new System.Windows.Forms.PaintEventHandler(this.panFormLoad_Paint);
            // 
            // CategoryManagerHomePage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panFormLoad);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryManagerHomePage";
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panFormLoad;
        private System.Windows.Forms.Button btnCategoryManager;
        private System.Windows.Forms.Button btnRole;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.Panel panNav;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnClose;
    }
}

