
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopPage));
            this.rbtnCreateShop = new Group6_Project.CustomControls.RoundButton();
            this.rbtnSearchShop = new Group6_Project.CustomControls.RoundButton();
            this.SuspendLayout();
            // 
            // rbtnCreateShop
            // 
            this.rbtnCreateShop.BackColor = System.Drawing.Color.White;
            this.rbtnCreateShop.BackgroundColor = System.Drawing.Color.White;
            this.rbtnCreateShop.BorderColor = System.Drawing.Color.Aquamarine;
            this.rbtnCreateShop.BorderRadius = 22;
            this.rbtnCreateShop.BorderSize = 2;
            this.rbtnCreateShop.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.rbtnCreateShop, "rbtnCreateShop");
            this.rbtnCreateShop.ForeColor = System.Drawing.Color.Black;
            this.rbtnCreateShop.Name = "rbtnCreateShop";
            this.rbtnCreateShop.TextColor = System.Drawing.Color.Black;
            this.rbtnCreateShop.UseVisualStyleBackColor = false;
            this.rbtnCreateShop.Click += new System.EventHandler(this.rbtnCreateShop_Click);
            // 
            // rbtnSearchShop
            // 
            this.rbtnSearchShop.BackColor = System.Drawing.Color.White;
            this.rbtnSearchShop.BackgroundColor = System.Drawing.Color.White;
            this.rbtnSearchShop.BorderColor = System.Drawing.Color.Aquamarine;
            this.rbtnSearchShop.BorderRadius = 22;
            this.rbtnSearchShop.BorderSize = 2;
            this.rbtnSearchShop.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.rbtnSearchShop, "rbtnSearchShop");
            this.rbtnSearchShop.ForeColor = System.Drawing.Color.Black;
            this.rbtnSearchShop.Name = "rbtnSearchShop";
            this.rbtnSearchShop.TextColor = System.Drawing.Color.Black;
            this.rbtnSearchShop.UseVisualStyleBackColor = false;
            this.rbtnSearchShop.Click += new System.EventHandler(this.rbtnSearchShop_Click);
            // 
            // ShopPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.rbtnCreateShop);
            this.Controls.Add(this.rbtnSearchShop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopPage";
            this.Load += new System.EventHandler(this.ShopPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundButton rbtnCreateShop;
        private CustomControls.RoundButton rbtnSearchShop;
    }
}