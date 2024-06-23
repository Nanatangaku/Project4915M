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
            this.lbldescription.AutoSize = true;
            this.lbldescription.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbldescription.ForeColor = System.Drawing.SystemColors.Control;
            this.lbldescription.Location = new System.Drawing.Point(216, 105);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(120, 24);
            this.lbldescription.TabIndex = 0;
            this.lbldescription.Text = "Description:";
            // 
            // lbllevelnum
            // 
            this.lbllevelnum.AutoSize = true;
            this.lbllevelnum.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbllevelnum.ForeColor = System.Drawing.SystemColors.Control;
            this.lbllevelnum.Location = new System.Drawing.Point(189, 184);
            this.lbllevelnum.Name = "lbllevelnum";
            this.lbllevelnum.Size = new System.Drawing.Size(147, 24);
            this.lbllevelnum.TabIndex = 1;
            this.lbllevelnum.Text = "Level Number:";
            // 
            // txtboxdescription
            // 
            this.txtboxdescription.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtboxdescription.Location = new System.Drawing.Point(349, 102);
            this.txtboxdescription.Name = "txtboxdescription";
            this.txtboxdescription.Size = new System.Drawing.Size(251, 36);
            this.txtboxdescription.TabIndex = 2;
            // 
            // txtboxlevelnum
            // 
            this.txtboxlevelnum.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtboxlevelnum.Location = new System.Drawing.Point(349, 172);
            this.txtboxlevelnum.Name = "txtboxlevelnum";
            this.txtboxlevelnum.Size = new System.Drawing.Size(251, 36);
            this.txtboxlevelnum.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnAdd.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(509, 257);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 38);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.White;
            this.lblBack.Location = new System.Drawing.Point(86, 32);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(75, 24);
            this.lblBack.TabIndex = 10;
            this.lblBack.Text = "← Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // addnewlevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1025, 679);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtboxlevelnum);
            this.Controls.Add(this.txtboxdescription);
            this.Controls.Add(this.lbllevelnum);
            this.Controls.Add(this.lbldescription);
            this.Name = "addnewlevel";
            this.Text = "addnewlevel";
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