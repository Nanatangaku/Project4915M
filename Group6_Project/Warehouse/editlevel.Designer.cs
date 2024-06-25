namespace Group6_Project.Warehouse
{
    partial class editlevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editlevel));
            this.gbbefore = new System.Windows.Forms.GroupBox();
            this.txtboxlevelnum = new System.Windows.Forms.TextBox();
            this.lblleveldescription = new System.Windows.Forms.Label();
            this.lbllevelnum = new System.Windows.Forms.Label();
            this.txtboxdescription = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.lblBack = new System.Windows.Forms.Label();
            this.gbbefore.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbbefore
            // 
            this.gbbefore.Controls.Add(this.txtboxlevelnum);
            this.gbbefore.Controls.Add(this.lblleveldescription);
            this.gbbefore.Controls.Add(this.lbllevelnum);
            this.gbbefore.Controls.Add(this.txtboxdescription);
            resources.ApplyResources(this.gbbefore, "gbbefore");
            this.gbbefore.ForeColor = System.Drawing.Color.White;
            this.gbbefore.Name = "gbbefore";
            this.gbbefore.TabStop = false;
            // 
            // txtboxlevelnum
            // 
            this.txtboxlevelnum.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.txtboxlevelnum, "txtboxlevelnum");
            this.txtboxlevelnum.Name = "txtboxlevelnum";
            // 
            // lblleveldescription
            // 
            resources.ApplyResources(this.lblleveldescription, "lblleveldescription");
            this.lblleveldescription.Name = "lblleveldescription";
            // 
            // lbllevelnum
            // 
            resources.ApplyResources(this.lbllevelnum, "lbllevelnum");
            this.lbllevelnum.Name = "lbllevelnum";
            // 
            // txtboxdescription
            // 
            this.txtboxdescription.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.txtboxdescription, "txtboxdescription");
            this.txtboxdescription.Name = "txtboxdescription";
            this.txtboxdescription.TextChanged += new System.EventHandler(this.txtboxdescription_TextChanged);
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btndelete
            // 
            resources.ApplyResources(this.btndelete, "btndelete");
            this.btndelete.ForeColor = System.Drawing.Color.Black;
            this.btndelete.Name = "btndelete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // lblBack
            // 
            resources.ApplyResources(this.lblBack, "lblBack");
            this.lblBack.ForeColor = System.Drawing.Color.White;
            this.lblBack.Name = "lblBack";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // editlevel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gbbefore);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "editlevel";
            this.Load += new System.EventHandler(this.editlevel_Load);
            this.gbbefore.ResumeLayout(false);
            this.gbbefore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbbefore;
        private System.Windows.Forms.TextBox txtboxlevelnum;
        private System.Windows.Forms.Label lblleveldescription;
        private System.Windows.Forms.Label lbllevelnum;
        private System.Windows.Forms.TextBox txtboxdescription;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label lblBack;
    }
}