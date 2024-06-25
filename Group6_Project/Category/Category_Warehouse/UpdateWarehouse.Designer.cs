﻿namespace Group6_Project.Category.Category_Warehouse
{
    partial class UpdateWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateWarehouse));
            this.label1 = new System.Windows.Forms.Label();
            this.roundTextBox1 = new Group6_Project.RoundTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roundTextBox2 = new Group6_Project.RoundTextBox();
            this.roundButton1 = new Group6_Project.CustomControls.RoundButton();
            this.cancel = new Group6_Project.CustomControls.RoundButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // roundTextBox1
            // 
            this.roundTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.roundTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.roundTextBox1.BorderFocusColor = System.Drawing.Color.MediumPurple;
            this.roundTextBox1.BorderRadius = 0;
            this.roundTextBox1.BorderSize = 2;
            resources.ApplyResources(this.roundTextBox1, "roundTextBox1");
            this.roundTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.roundTextBox1.Multiline = false;
            this.roundTextBox1.Name = "roundTextBox1";
            this.roundTextBox1.PasswordChar = false;
            this.roundTextBox1.PlaceholderColor = System.Drawing.Color.DimGray;
            this.roundTextBox1.PlaceholderText = "[ Warehouse Name ]";
            this.roundTextBox1.Texts = "";
            this.roundTextBox1.UnderlinedStyle = false;
            this.roundTextBox1._TextChanged += new System.EventHandler(this.roundTextBox1__TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // roundTextBox2
            // 
            this.roundTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.roundTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.roundTextBox2.BorderFocusColor = System.Drawing.Color.MediumPurple;
            this.roundTextBox2.BorderRadius = 0;
            this.roundTextBox2.BorderSize = 2;
            resources.ApplyResources(this.roundTextBox2, "roundTextBox2");
            this.roundTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.roundTextBox2.Multiline = false;
            this.roundTextBox2.Name = "roundTextBox2";
            this.roundTextBox2.PasswordChar = false;
            this.roundTextBox2.PlaceholderColor = System.Drawing.Color.DimGray;
            this.roundTextBox2.PlaceholderText = "[ New Phone Number ]";
            this.roundTextBox2.Texts = "";
            this.roundTextBox2.UnderlinedStyle = false;
            this.roundTextBox2._TextChanged += new System.EventHandler(this.roundTextBox2__TextChanged);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.roundButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.roundButton1.BorderColor = System.Drawing.Color.Transparent;
            this.roundButton1.BorderRadius = 16;
            this.roundButton1.BorderSize = 2;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.roundButton1, "roundButton1");
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cancel.BorderColor = System.Drawing.Color.Transparent;
            this.cancel.BorderRadius = 16;
            this.cancel.BorderSize = 2;
            this.cancel.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.cancel, "cancel");
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Name = "cancel";
            this.cancel.TextColor = System.Drawing.Color.White;
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.roundTextBox1);
            this.panel1.Controls.Add(this.roundButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.roundTextBox2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // UpdateWarehouse
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(100)))));
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateWarehouse";
            this.Load += new System.EventHandler(this.UpdateWarehouse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RoundTextBox roundTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RoundTextBox roundTextBox2;
        private CustomControls.RoundButton roundButton1;
        private CustomControls.RoundButton cancel;
        private System.Windows.Forms.Panel panel1;
    }
}