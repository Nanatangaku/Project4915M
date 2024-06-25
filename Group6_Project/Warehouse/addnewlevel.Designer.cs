namespace Group6_Project.Warehouse
{
    partial class addnewlevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addnewlevel));
            this.lbldescription = new System.Windows.Forms.Label();
            this.lbllevelnum = new System.Windows.Forms.Label();
            this.txtboxdescription = new System.Windows.Forms.TextBox();
            this.txtboxlevelnum = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldescription
            // 
            resources.ApplyResources(this.lbldescription, "lbldescription");
            this.lbldescription.ForeColor = System.Drawing.SystemColors.Control;
            this.lbldescription.Name = "lbldescription";
            // 
            // lbllevelnum
            // 
            resources.ApplyResources(this.lbllevelnum, "lbllevelnum");
            this.lbllevelnum.ForeColor = System.Drawing.SystemColors.Control;
            this.lbllevelnum.Name = "lbllevelnum";
            // 
            // txtboxdescription
            // 
            resources.ApplyResources(this.txtboxdescription, "txtboxdescription");
            this.txtboxdescription.Name = "txtboxdescription";
            // 
            // txtboxlevelnum
            // 
            resources.ApplyResources(this.txtboxlevelnum, "txtboxlevelnum");
            this.txtboxlevelnum.Name = "txtboxlevelnum";
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblBack
            // 
            resources.ApplyResources(this.lblBack, "lblBack");
            this.lblBack.ForeColor = System.Drawing.Color.White;
            this.lblBack.Name = "lblBack";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // addnewlevel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtboxlevelnum);
            this.Controls.Add(this.txtboxdescription);
            this.Controls.Add(this.lbllevelnum);
            this.Controls.Add(this.lbldescription);
            this.Name = "addnewlevel";
            this.Load += new System.EventHandler(this.addnewlevel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lbllevelnum;
        private System.Windows.Forms.TextBox txtboxdescription;
        private System.Windows.Forms.TextBox txtboxlevelnum;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblBack;
    }
}