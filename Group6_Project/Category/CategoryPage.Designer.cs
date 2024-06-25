
namespace Group6_Project
{
    partial class CategoryPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryPage));
            this.rbtnSearchCategory = new Group6_Project.CustomControls.RoundButton();
            this.rbtnCreateCategory = new Group6_Project.CustomControls.RoundButton();
            this.SuspendLayout();
            // 
            // rbtnSearchCategory
            // 
            this.rbtnSearchCategory.BackColor = System.Drawing.Color.White;
            this.rbtnSearchCategory.BackgroundColor = System.Drawing.Color.White;
            this.rbtnSearchCategory.BorderColor = System.Drawing.Color.Aquamarine;
            this.rbtnSearchCategory.BorderRadius = 22;
            this.rbtnSearchCategory.BorderSize = 2;
            this.rbtnSearchCategory.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.rbtnSearchCategory, "rbtnSearchCategory");
            this.rbtnSearchCategory.ForeColor = System.Drawing.Color.Black;
            this.rbtnSearchCategory.Name = "rbtnSearchCategory";
            this.rbtnSearchCategory.TextColor = System.Drawing.Color.Black;
            this.rbtnSearchCategory.UseVisualStyleBackColor = false;
            this.rbtnSearchCategory.Click += new System.EventHandler(this.rbtnSearchCategory_Click);
            // 
            // rbtnCreateCategory
            // 
            this.rbtnCreateCategory.BackColor = System.Drawing.Color.White;
            this.rbtnCreateCategory.BackgroundColor = System.Drawing.Color.White;
            this.rbtnCreateCategory.BorderColor = System.Drawing.Color.Aquamarine;
            this.rbtnCreateCategory.BorderRadius = 22;
            this.rbtnCreateCategory.BorderSize = 2;
            this.rbtnCreateCategory.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.rbtnCreateCategory, "rbtnCreateCategory");
            this.rbtnCreateCategory.ForeColor = System.Drawing.Color.Black;
            this.rbtnCreateCategory.Name = "rbtnCreateCategory";
            this.rbtnCreateCategory.TextColor = System.Drawing.Color.Black;
            this.rbtnCreateCategory.UseVisualStyleBackColor = false;
            this.rbtnCreateCategory.Click += new System.EventHandler(this.rbtnCreateCategory_Click);
            // 
            // CategoryPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.rbtnCreateCategory);
            this.Controls.Add(this.rbtnSearchCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryPage";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundButton rbtnSearchCategory;
        private CustomControls.RoundButton rbtnCreateCategory;
    }
}