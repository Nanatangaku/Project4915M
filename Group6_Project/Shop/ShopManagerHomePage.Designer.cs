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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panFormLoad = new System.Windows.Forms.Panel();
            this.btnvieworder = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnCategoryManager = new System.Windows.Forms.Button();
            this.btnWarehouse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnvieworder);
            this.panelMenu.Controls.Add(this.btnCheckout);
            this.panelMenu.Controls.Add(this.panNav);
            this.panelMenu.Controls.Add(this.btnCategoryManager);
            this.panelMenu.Controls.Add(this.btnWarehouse);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(277, 878);
            this.panelMenu.TabIndex = 3;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // panNav
            // 
            this.panNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(120)))), ((int)(((byte)(252)))));
            this.panNav.Location = new System.Drawing.Point(0, 130);
            this.panNav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panNav.Name = "panNav";
            this.panNav.Size = new System.Drawing.Size(7, 77);
            this.panNav.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(100)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 130);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "OPSR System";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1272, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(100)))));
            this.panel5.Controls.Add(this.panFormLoad);
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(277, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1179, 878);
            this.panel5.TabIndex = 5;
            // 
            // panFormLoad
            // 
            this.panFormLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panFormLoad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFormLoad.Location = new System.Drawing.Point(0, 130);
            this.panFormLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panFormLoad.Name = "panFormLoad";
            this.panFormLoad.Size = new System.Drawing.Size(1179, 748);
            this.panFormLoad.TabIndex = 1;
            this.panFormLoad.Paint += new System.Windows.Forms.PaintEventHandler(this.panFormLoad_Paint);
            // 
            // btnvieworder
            // 
            this.btnvieworder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnvieworder.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnvieworder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnvieworder.FlatAppearance.BorderSize = 0;
            this.btnvieworder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvieworder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvieworder.ForeColor = System.Drawing.Color.White;
            this.btnvieworder.Image = global::Group6_Project.Properties.Resources.truck_side;
            this.btnvieworder.Location = new System.Drawing.Point(0, 284);
            this.btnvieworder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnvieworder.Name = "btnvieworder";
            this.btnvieworder.Size = new System.Drawing.Size(277, 77);
            this.btnvieworder.TabIndex = 9;
            this.btnvieworder.Text = "View Order";
            this.btnvieworder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnvieworder.UseVisualStyleBackColor = false;
            this.btnvieworder.Click += new System.EventHandler(this.btnvieworder_Click);
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
            this.btnCheckout.Image = global::Group6_Project.Properties.Resources.truck_side;
            this.btnCheckout.Location = new System.Drawing.Point(0, 207);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(277, 77);
            this.btnCheckout.TabIndex = 8;
            this.btnCheckout.Text = "Check Out";
            this.btnCheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnCategoryManager
            // 
            this.btnCategoryManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(100)))));
            this.btnCategoryManager.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCategoryManager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCategoryManager.FlatAppearance.BorderSize = 0;
            this.btnCategoryManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryManager.ForeColor = System.Drawing.Color.White;
            this.btnCategoryManager.Image = global::Group6_Project.Properties.Resources.user__1_;
            this.btnCategoryManager.Location = new System.Drawing.Point(0, 801);
            this.btnCategoryManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCategoryManager.Name = "btnCategoryManager";
            this.btnCategoryManager.Size = new System.Drawing.Size(277, 77);
            this.btnCategoryManager.TabIndex = 7;
            this.btnCategoryManager.Text = "    Shop \r\n   Manager";
            this.btnCategoryManager.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCategoryManager.UseVisualStyleBackColor = false;
            this.btnCategoryManager.Click += new System.EventHandler(this.btnCategoryManager_Click);
            this.btnCategoryManager.Leave += new System.EventHandler(this.btnCategoryManager_Leave);
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnWarehouse.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnWarehouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWarehouse.FlatAppearance.BorderSize = 0;
            this.btnWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWarehouse.ForeColor = System.Drawing.Color.White;
            this.btnWarehouse.Image = global::Group6_Project.Properties.Resources.box;
            this.btnWarehouse.Location = new System.Drawing.Point(0, 130);
            this.btnWarehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(277, 77);
            this.btnWarehouse.TabIndex = 3;
            this.btnWarehouse.Text = "    Request";
            this.btnWarehouse.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnWarehouse.UseVisualStyleBackColor = false;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            this.btnWarehouse.Leave += new System.EventHandler(this.btnWarehouse_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Group6_Project.Properties.Resources.car_circle_bolt;
            this.pictureBox1.Location = new System.Drawing.Point(105, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ShopManagerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1456, 878);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ShopManagerHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "userHomePage";
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panFormLoad;
        private System.Windows.Forms.Button btnCategoryManager;
        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.Panel panNav;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvieworder;
        private System.Windows.Forms.Button btnCheckout;
    }
}

