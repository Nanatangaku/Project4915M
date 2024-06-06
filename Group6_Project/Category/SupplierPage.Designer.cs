
namespace Group6_Project
{
    partial class SupplierPage
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
            this.rbtnCreateSupplier = new Group6_Project.CustomControls.RoundButton();
            this.rbtnSearchSupplier = new Group6_Project.CustomControls.RoundButton();
            this.panSupplier = new System.Windows.Forms.Panel();
            this.panSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnCreateSupplier
            // 
            this.rbtnCreateSupplier.BackColor = System.Drawing.Color.White;
            this.rbtnCreateSupplier.BackgroundColor = System.Drawing.Color.White;
            this.rbtnCreateSupplier.BorderColor = System.Drawing.Color.Aquamarine;
            this.rbtnCreateSupplier.BorderRadius = 22;
            this.rbtnCreateSupplier.BorderSize = 2;
            this.rbtnCreateSupplier.FlatAppearance.BorderSize = 0;
            this.rbtnCreateSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnCreateSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCreateSupplier.ForeColor = System.Drawing.Color.Black;
            this.rbtnCreateSupplier.Location = new System.Drawing.Point(550, 266);
            this.rbtnCreateSupplier.Name = "rbtnCreateSupplier";
            this.rbtnCreateSupplier.Size = new System.Drawing.Size(235, 150);
            this.rbtnCreateSupplier.TabIndex = 11;
            this.rbtnCreateSupplier.Text = "Create Supplier";
            this.rbtnCreateSupplier.TextColor = System.Drawing.Color.Black;
            this.rbtnCreateSupplier.UseVisualStyleBackColor = false;
            this.rbtnCreateSupplier.Click += new System.EventHandler(this.rbtnCreateSupplier_Click);
            // 
            // rbtnSearchSupplier
            // 
            this.rbtnSearchSupplier.BackColor = System.Drawing.Color.White;
            this.rbtnSearchSupplier.BackgroundColor = System.Drawing.Color.White;
            this.rbtnSearchSupplier.BorderColor = System.Drawing.Color.Aquamarine;
            this.rbtnSearchSupplier.BorderRadius = 22;
            this.rbtnSearchSupplier.BorderSize = 2;
            this.rbtnSearchSupplier.FlatAppearance.BorderSize = 0;
            this.rbtnSearchSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnSearchSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSearchSupplier.ForeColor = System.Drawing.Color.Black;
            this.rbtnSearchSupplier.Location = new System.Drawing.Point(250, 266);
            this.rbtnSearchSupplier.Name = "rbtnSearchSupplier";
            this.rbtnSearchSupplier.Size = new System.Drawing.Size(235, 150);
            this.rbtnSearchSupplier.TabIndex = 10;
            this.rbtnSearchSupplier.Text = "Search Supplier";
            this.rbtnSearchSupplier.TextColor = System.Drawing.Color.Black;
            this.rbtnSearchSupplier.UseVisualStyleBackColor = false;
            this.rbtnSearchSupplier.Click += new System.EventHandler(this.rbtnSearchSupplier_Click);
            // 
            // panSupplier
            // 
            this.panSupplier.Controls.Add(this.rbtnSearchSupplier);
            this.panSupplier.Controls.Add(this.rbtnCreateSupplier);
            this.panSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panSupplier.Location = new System.Drawing.Point(0, 0);
            this.panSupplier.Name = "panSupplier";
            this.panSupplier.Size = new System.Drawing.Size(1041, 748);
            this.panSupplier.TabIndex = 12;
            // 
            // SupplierPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1041, 748);
            this.Controls.Add(this.panSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupplierPage";
            this.Text = "PurchasePage";
            this.panSupplier.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundButton rbtnCreateSupplier;
        private CustomControls.RoundButton rbtnSearchSupplier;
        private System.Windows.Forms.Panel panSupplier;
    }
}