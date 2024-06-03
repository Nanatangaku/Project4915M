﻿
namespace Group6_Project
{
    partial class ShopPage
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
            this.panShop = new System.Windows.Forms.Panel();
            this.roundButton2 = new Group6_Project.CustomControls.RoundButton();
            this.roundButton1 = new Group6_Project.CustomControls.RoundButton();
            this.panShop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panShop
            // 
            this.panShop.Controls.Add(this.roundButton2);
            this.panShop.Controls.Add(this.roundButton1);
            this.panShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panShop.Location = new System.Drawing.Point(0, 0);
            this.panShop.Name = "panShop";
            this.panShop.Size = new System.Drawing.Size(1317, 748);
            this.panShop.TabIndex = 10;
            this.panShop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.White;
            this.roundButton2.BackgroundColor = System.Drawing.Color.White;
            this.roundButton2.BorderColor = System.Drawing.Color.Aquamarine;
            this.roundButton2.BorderRadius = 22;
            this.roundButton2.BorderSize = 2;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton2.ForeColor = System.Drawing.Color.Black;
            this.roundButton2.Location = new System.Drawing.Point(740, 259);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(235, 150);
            this.roundButton2.TabIndex = 9;
            this.roundButton2.Text = "Create Shop";
            this.roundButton2.TextColor = System.Drawing.Color.Black;
            this.roundButton2.UseVisualStyleBackColor = false;
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.White;
            this.roundButton1.BackgroundColor = System.Drawing.Color.White;
            this.roundButton1.BorderColor = System.Drawing.Color.Aquamarine;
            this.roundButton1.BorderRadius = 22;
            this.roundButton1.BorderSize = 2;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.ForeColor = System.Drawing.Color.Black;
            this.roundButton1.Location = new System.Drawing.Point(382, 259);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(235, 150);
            this.roundButton1.TabIndex = 8;
            this.roundButton1.Text = "Search Shop";
            this.roundButton1.TextColor = System.Drawing.Color.Black;
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // ShopPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1317, 748);
            this.Controls.Add(this.panShop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopPage";
            this.Text = "ShopPage";
            this.Load += new System.EventHandler(this.ShopPage_Load);
            this.panShop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundButton roundButton2;
        private CustomControls.RoundButton roundButton1;
        private System.Windows.Forms.Panel panShop;
    }
}