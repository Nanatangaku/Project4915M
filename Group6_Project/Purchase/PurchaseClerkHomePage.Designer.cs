
namespace Group6_Project
{
    partial class PurchaseClerkHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseClerkHomePage));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panNav = new System.Windows.Forms.Panel();
            this.btnCategoryManager = new System.Windows.Forms.Button();
            this.btnPurchaseOrder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
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
            this.panelMenu.Controls.Add(this.btnCategoryManager);
            this.panelMenu.Controls.Add(this.btnPurchaseOrder);
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
            // btnPurchaseOrder
            // 
            this.btnPurchaseOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnPurchaseOrder.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.btnPurchaseOrder, "btnPurchaseOrder");
            this.btnPurchaseOrder.FlatAppearance.BorderSize = 0;
            this.btnPurchaseOrder.ForeColor = System.Drawing.Color.White;
            this.btnPurchaseOrder.Image = global::Group6_Project.Properties.Resources.home2;
            this.btnPurchaseOrder.Name = "btnPurchaseOrder";
            this.btnPurchaseOrder.UseVisualStyleBackColor = false;
            this.btnPurchaseOrder.Click += new System.EventHandler(this.btnPurchaseOrder_Click);
            this.btnPurchaseOrder.Leave += new System.EventHandler(this.btnPurchaseOrder_Leave);
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
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(100)))));
            this.panel5.Controls.Add(this.panFormLoad);
            this.panel5.Controls.Add(this.btnClose);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // panFormLoad
            // 
            this.panFormLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            resources.ApplyResources(this.panFormLoad, "panFormLoad");
            this.panFormLoad.Name = "panFormLoad";
            // 
            // PurchaseClerkHomePage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseClerkHomePage";
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
        private System.Windows.Forms.Button btnPurchaseOrder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panFormLoad;
        private System.Windows.Forms.Button btnCategoryManager;
        private System.Windows.Forms.Panel panNav;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

