﻿namespace Group6_Project
{
    partial class CreateCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCategory));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roundTextBox2 = new Group6_Project.RoundTextBox();
            this.roundButton1 = new Group6_Project.CustomControls.RoundButton();
            this.roundTextBox1 = new Group6_Project.RoundTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Name = "label3";
            // 
            // roundTextBox2
            // 
            this.roundTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.roundTextBox2.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.roundTextBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.roundTextBox2.BorderRadius = 16;
            this.roundTextBox2.BorderSize = 2;
            resources.ApplyResources(this.roundTextBox2, "roundTextBox2");
            this.roundTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.roundTextBox2.Multiline = false;
            this.roundTextBox2.Name = "roundTextBox2";
            this.roundTextBox2.PasswordChar = false;
            this.roundTextBox2.PlaceholderColor = System.Drawing.Color.Red;
            this.roundTextBox2.PlaceholderText = "";
            this.roundTextBox2.Texts = "";
            this.roundTextBox2.UnderlinedStyle = true;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.White;
            this.roundButton1.BackgroundColor = System.Drawing.Color.White;
            this.roundButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(100)))));
            this.roundButton1.BorderRadius = 22;
            this.roundButton1.BorderSize = 2;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.roundButton1, "roundButton1");
            this.roundButton1.ForeColor = System.Drawing.Color.Black;
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.TextColor = System.Drawing.Color.Black;
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // roundTextBox1
            // 
            this.roundTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.roundTextBox1.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.roundTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.roundTextBox1.BorderRadius = 16;
            this.roundTextBox1.BorderSize = 2;
            resources.ApplyResources(this.roundTextBox1, "roundTextBox1");
            this.roundTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.roundTextBox1.Multiline = false;
            this.roundTextBox1.Name = "roundTextBox1";
            this.roundTextBox1.PasswordChar = false;
            this.roundTextBox1.PlaceholderColor = System.Drawing.Color.Red;
            this.roundTextBox1.PlaceholderText = "";
            this.roundTextBox1.Texts = "";
            this.roundTextBox1.UnderlinedStyle = true;
            // 
            // CreateCategory
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roundTextBox2);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RoundButton roundButton1;
        private System.Windows.Forms.Label label1;
        private RoundTextBox roundTextBox1;
        private RoundTextBox roundTextBox2;
        private System.Windows.Forms.Label label3;
    }
}