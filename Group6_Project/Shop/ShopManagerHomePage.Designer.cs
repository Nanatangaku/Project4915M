
namespace Group6_Project
{
    partial class ShopManagerHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopManagerHomePage));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panNav = new System.Windows.Forms.Panel();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnSmLogout = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
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
            this.panelMenu.Controls.Add(this.panNav);
            this.panelMenu.Controls.Add(this.btnViewOrder);
            this.panelMenu.Controls.Add(this.btnCheckout);
            this.panelMenu.Controls.Add(this.btnSmLogout);
            this.panelMenu.Controls.Add(this.btnOrder);
            this.panelMenu.Controls.Add(this.panel2);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // panNav
            // 
            this.panNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(120)))), ((int)(((byte)(252)))));
            resources.ApplyResources(this.panNav, "panNav");
            this.panNav.Name = "panNav";
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnViewOrder.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.btnViewOrder, "btnViewOrder");
            this.btnViewOrder.FlatAppearance.BorderSize = 0;
            this.btnViewOrder.ForeColor = System.Drawing.Color.White;
            this.btnViewOrder.Image = global::Group6_Project.Properties.Resources.truck_check;
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.UseVisualStyleBackColor = false;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            this.btnViewOrder.Leave += new System.EventHandler(this.btnViewOrder_Leave);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnCheckout.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.btnCheckout, "btnCheckout");
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Image = global::Group6_Project.Properties.Resources.shopping_cart__3_;
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            this.btnCheckout.Leave += new System.EventHandler(this.btnCheckout_Leave);
            // 
            // btnSmLogout
            // 
            this.btnSmLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(100)))));
            this.btnSmLogout.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.btnSmLogout, "btnSmLogout");
            this.btnSmLogout.FlatAppearance.BorderSize = 0;
            this.btnSmLogout.ForeColor = System.Drawing.Color.White;
            this.btnSmLogout.Image = global::Group6_Project.Properties.Resources.user__1_;
            this.btnSmLogout.Name = "btnSmLogout";
            this.btnSmLogout.UseVisualStyleBackColor = false;
            this.btnSmLogout.Click += new System.EventHandler(this.btnSmLogout_Click);
            this.btnSmLogout.Leave += new System.EventHandler(this.btnCategoryManager_Leave);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.btnOrder, "btnOrder");
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Image = global::Group6_Project.Properties.Resources.list1;
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            this.btnOrder.Leave += new System.EventHandler(this.btnOrder_Leave);
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
            this.pictureBox1.BackgroundImage = global::Group6_Project.Properties.Resources.car_circle_bolt;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.ErrorImage = global::Group6_Project.Properties.Resources.car_circle_bolt;
            this.pictureBox1.InitialImage = global::Group6_Project.Properties.Resources.car_circle_bolt;
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
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // panFormLoad
            // 
            this.panFormLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            resources.ApplyResources(this.panFormLoad, "panFormLoad");
            this.panFormLoad.Name = "panFormLoad";
            this.panFormLoad.Paint += new System.Windows.Forms.PaintEventHandler(this.panFormLoad_Paint);
            // 
            // ShopManagerHomePage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panFormLoad);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopManagerHomePage";
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
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panFormLoad;
        private System.Windows.Forms.Button btnSmLogout;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel panNav;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewOrder;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnClose;
    }
}

