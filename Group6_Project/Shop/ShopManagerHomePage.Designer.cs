﻿
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
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(369, 935);
            this.panelMenu.TabIndex = 3;
            // 
            // panNav
            // 
            this.panNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(120)))), ((int)(((byte)(252)))));
            this.panNav.Location = new System.Drawing.Point(0, 162);
            this.panNav.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panNav.Name = "panNav";
            this.panNav.Size = new System.Drawing.Size(9, 96);
            this.panNav.TabIndex = 2;
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnViewOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnViewOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewOrder.FlatAppearance.BorderSize = 0;
            this.btnViewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrder.ForeColor = System.Drawing.Color.White;
            this.btnViewOrder.Image = global::Group6_Project.Properties.Resources.truck_check;
            this.btnViewOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewOrder.Location = new System.Drawing.Point(0, 354);
            this.btnViewOrder.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(369, 96);
            this.btnViewOrder.TabIndex = 9;
            this.btnViewOrder.Text = "View Order";
            this.btnViewOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnViewOrder.UseVisualStyleBackColor = false;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            this.btnViewOrder.Leave += new System.EventHandler(this.btnViewOrder_Leave);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnCheckout.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCheckout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Image = global::Group6_Project.Properties.Resources.shopping_cart__3_;
            this.btnCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckout.Location = new System.Drawing.Point(0, 258);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(369, 96);
            this.btnCheckout.TabIndex = 8;
            this.btnCheckout.Text = "Check Out";
            this.btnCheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            this.btnCheckout.Leave += new System.EventHandler(this.btnCheckout_Leave);
            // 
            // btnSmLogout
            // 
            this.btnSmLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(100)))));
            this.btnSmLogout.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSmLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSmLogout.FlatAppearance.BorderSize = 0;
            this.btnSmLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmLogout.ForeColor = System.Drawing.Color.White;
            this.btnSmLogout.Image = global::Group6_Project.Properties.Resources.user__1_;
            this.btnSmLogout.Location = new System.Drawing.Point(0, 839);
            this.btnSmLogout.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSmLogout.Name = "btnSmLogout";
            this.btnSmLogout.Size = new System.Drawing.Size(369, 96);
            this.btnSmLogout.TabIndex = 7;
            this.btnSmLogout.Text = "  Shop Manager\r\nLogout";
            this.btnSmLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSmLogout.UseVisualStyleBackColor = false;
            this.btnSmLogout.Click += new System.EventHandler(this.btnSmLogout_Click);
            this.btnSmLogout.Leave += new System.EventHandler(this.btnCategoryManager_Leave);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Image = global::Group6_Project.Properties.Resources.list1;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(0, 162);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(369, 96);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order   ";
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            this.btnOrder.Leave += new System.EventHandler(this.btnOrder_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(100)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 162);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "OPSR System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Group6_Project.Properties.Resources.car_circle_bolt;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = global::Group6_Project.Properties.Resources.car_circle_bolt;
            this.pictureBox1.InitialImage = global::Group6_Project.Properties.Resources.car_circle_bolt;
            this.pictureBox1.Location = new System.Drawing.Point(140, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(100)))));
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Location = new System.Drawing.Point(369, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1388, 38);
            this.panel5.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1337, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Size = new System.Drawing.Size(37, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panFormLoad
            // 
            this.panFormLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panFormLoad.Location = new System.Drawing.Point(369, 38);
            this.panFormLoad.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panFormLoad.Name = "panFormLoad";
            this.panFormLoad.Size = new System.Drawing.Size(1388, 898);
            this.panFormLoad.TabIndex = 1;
            this.panFormLoad.Paint += new System.Windows.Forms.PaintEventHandler(this.panFormLoad_Paint);
            // 
            // ShopManagerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1756, 935);
            this.Controls.Add(this.panFormLoad);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "ShopManagerHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "userHomePage";
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

