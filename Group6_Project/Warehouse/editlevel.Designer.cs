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
            this.gbbefore = new System.Windows.Forms.GroupBox();
            this.lblleveldescription = new System.Windows.Forms.Label();
            this.lbllevelnum = new System.Windows.Forms.Label();
            this.txtboxdescription = new System.Windows.Forms.TextBox();
            this.txtboxlevelnum = new System.Windows.Forms.TextBox();
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
            this.gbbefore.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbbefore.ForeColor = System.Drawing.Color.White;
            this.gbbefore.Location = new System.Drawing.Point(119, 95);
            this.gbbefore.Name = "gbbefore";
            this.gbbefore.Size = new System.Drawing.Size(742, 206);
            this.gbbefore.TabIndex = 6;
            this.gbbefore.TabStop = false;
            this.gbbefore.Text = "Level Information";
            // 
            // lblleveldescription
            // 
            this.lblleveldescription.AutoSize = true;
            this.lblleveldescription.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblleveldescription.Location = new System.Drawing.Point(149, 47);
            this.lblleveldescription.Name = "lblleveldescription";
            this.lblleveldescription.Size = new System.Drawing.Size(120, 24);
            this.lblleveldescription.TabIndex = 0;
            this.lblleveldescription.Text = "Description:";
            // 
            // lbllevelnum
            // 
            this.lbllevelnum.AutoSize = true;
            this.lbllevelnum.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbllevelnum.Location = new System.Drawing.Point(127, 123);
            this.lbllevelnum.Name = "lbllevelnum";
            this.lbllevelnum.Size = new System.Drawing.Size(142, 24);
            this.lbllevelnum.TabIndex = 1;
            this.lbllevelnum.Text = "Level number:";
            // 
            // txtboxdescription
            // 
            this.txtboxdescription.BackColor = System.Drawing.SystemColors.Control;
            this.txtboxdescription.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtboxdescription.Location = new System.Drawing.Point(275, 44);
            this.txtboxdescription.Name = "txtboxdescription";
            this.txtboxdescription.Size = new System.Drawing.Size(438, 36);
            this.txtboxdescription.TabIndex = 2;
            this.txtboxdescription.TextChanged += new System.EventHandler(this.txtboxdescription_TextChanged);
            // 
            // txtboxlevelnum
            // 
            this.txtboxlevelnum.BackColor = System.Drawing.SystemColors.Control;
            this.txtboxlevelnum.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtboxlevelnum.Location = new System.Drawing.Point(275, 120);
            this.txtboxlevelnum.Name = "txtboxlevelnum";
            this.txtboxlevelnum.Size = new System.Drawing.Size(438, 36);
            this.txtboxlevelnum.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(543, 350);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 34);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btndelete.ForeColor = System.Drawing.Color.Black;
            this.btndelete.Location = new System.Drawing.Point(703, 350);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(129, 34);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.White;
            this.lblBack.Location = new System.Drawing.Point(115, 38);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(75, 24);
            this.lblBack.TabIndex = 9;
            this.lblBack.Text = "← Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // editlevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1025, 679);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gbbefore);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "editlevel";
            this.Text = "editlevel";
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