
namespace Group6_Project
{
    partial class WarehousePage
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
            this.rbtnCreateWare = new Group6_Project.CustomControls.RoundButton();
            this.rbtnSearchWare = new Group6_Project.CustomControls.RoundButton();
            this.SuspendLayout();
            // 
            // rbtnCreateWare
            // 
            this.rbtnCreateWare.BackColor = System.Drawing.Color.White;
            this.rbtnCreateWare.BackgroundColor = System.Drawing.Color.White;
            this.rbtnCreateWare.BorderColor = System.Drawing.Color.Aquamarine;
            this.rbtnCreateWare.BorderRadius = 22;
            this.rbtnCreateWare.BorderSize = 2;
            this.rbtnCreateWare.FlatAppearance.BorderSize = 0;
            this.rbtnCreateWare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnCreateWare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCreateWare.ForeColor = System.Drawing.Color.Black;
            this.rbtnCreateWare.Location = new System.Drawing.Point(550, 266);
            this.rbtnCreateWare.Name = "rbtnCreateWare";
            this.rbtnCreateWare.Size = new System.Drawing.Size(235, 150);
            this.rbtnCreateWare.TabIndex = 9;
            this.rbtnCreateWare.Text = "Create Warehouse";
            this.rbtnCreateWare.TextColor = System.Drawing.Color.Black;
            this.rbtnCreateWare.UseVisualStyleBackColor = false;
            this.rbtnCreateWare.Click += new System.EventHandler(this.rbtnCreateWare_Click);
            // 
            // rbtnSearchWare
            // 
            this.rbtnSearchWare.BackColor = System.Drawing.Color.White;
            this.rbtnSearchWare.BackgroundColor = System.Drawing.Color.White;
            this.rbtnSearchWare.BorderColor = System.Drawing.Color.Aquamarine;
            this.rbtnSearchWare.BorderRadius = 22;
            this.rbtnSearchWare.BorderSize = 2;
            this.rbtnSearchWare.FlatAppearance.BorderSize = 0;
            this.rbtnSearchWare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnSearchWare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSearchWare.ForeColor = System.Drawing.Color.Black;
            this.rbtnSearchWare.Location = new System.Drawing.Point(250, 266);
            this.rbtnSearchWare.Name = "rbtnSearchWare";
            this.rbtnSearchWare.Size = new System.Drawing.Size(235, 150);
            this.rbtnSearchWare.TabIndex = 8;
            this.rbtnSearchWare.Text = "Search Warehouse";
            this.rbtnSearchWare.TextColor = System.Drawing.Color.Black;
            this.rbtnSearchWare.UseVisualStyleBackColor = false;
            this.rbtnSearchWare.Click += new System.EventHandler(this.rbtnSearchWare_Click);
            // 
            // WarehousePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1041, 748);
            this.Controls.Add(this.rbtnSearchWare);
            this.Controls.Add(this.rbtnCreateWare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WarehousePage";
            this.Text = "WarehousePage";
            this.Load += new System.EventHandler(this.WarehousePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundButton rbtnCreateWare;
        private CustomControls.RoundButton rbtnSearchWare;
        private System.Windows.Forms.Panel panWarehouse;
    }
}