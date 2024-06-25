
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierPage));
            this.rbtnCreateSupplier = new Group6_Project.CustomControls.RoundButton();
            this.rbtnSearchSupplier = new Group6_Project.CustomControls.RoundButton();
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
            resources.ApplyResources(this.rbtnCreateSupplier, "rbtnCreateSupplier");
            this.rbtnCreateSupplier.ForeColor = System.Drawing.Color.Black;
            this.rbtnCreateSupplier.Name = "rbtnCreateSupplier";
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
            resources.ApplyResources(this.rbtnSearchSupplier, "rbtnSearchSupplier");
            this.rbtnSearchSupplier.ForeColor = System.Drawing.Color.Black;
            this.rbtnSearchSupplier.Name = "rbtnSearchSupplier";
            this.rbtnSearchSupplier.TextColor = System.Drawing.Color.Black;
            this.rbtnSearchSupplier.UseVisualStyleBackColor = false;
            this.rbtnSearchSupplier.Click += new System.EventHandler(this.rbtnSearchSupplier_Click);
            // 
            // SupplierPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.rbtnSearchSupplier);
            this.Controls.Add(this.rbtnCreateSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupplierPage";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundButton rbtnCreateSupplier;
        private CustomControls.RoundButton rbtnSearchSupplier;
    }
}