
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
            this.rbtnCreateShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnCreateShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCreateShop.ForeColor = System.Drawing.Color.Black;
            this.rbtnCreateShop.Location = new System.Drawing.Point(550, 266);
            this.rbtnCreateShop.Name = "rbtnCreateShop";
            this.rbtnCreateShop.Size = new System.Drawing.Size(235, 150);
            this.rbtnCreateShop.TabIndex = 9;
            this.rbtnCreateShop.Text = "Create Shop";
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
            this.rbtnSearchShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnSearchShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSearchShop.ForeColor = System.Drawing.Color.Black;
            this.rbtnSearchShop.Location = new System.Drawing.Point(250, 266);
            this.rbtnSearchShop.Name = "rbtnSearchShop";
            this.rbtnSearchShop.Size = new System.Drawing.Size(235, 150);
            this.rbtnSearchShop.TabIndex = 8;
            this.rbtnSearchShop.Text = "Search Shop";
            this.rbtnSearchShop.TextColor = System.Drawing.Color.Black;
            this.rbtnSearchShop.UseVisualStyleBackColor = false;
            this.rbtnSearchShop.Click += new System.EventHandler(this.rbtnSearchShop_Click);
            // 
            // ShopPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1041, 718);
            this.Controls.Add(this.rbtnCreateShop);
            this.Controls.Add(this.rbtnSearchShop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopPage";
            this.Text = "ShopPage";
            this.Load += new System.EventHandler(this.ShopPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundButton rbtnCreateShop;
        private CustomControls.RoundButton rbtnSearchShop;
    }
}