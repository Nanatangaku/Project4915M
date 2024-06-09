namespace Group6_Project
{
    partial class ReceivedItem
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
            this.lbluserid = new System.Windows.Forms.Label();
            this.lblrole = new System.Windows.Forms.Label();
            this.txtboxuserid = new System.Windows.Forms.TextBox();
            this.txtboxrole = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.lblitem = new System.Windows.Forms.Label();
            this.lblquantity = new System.Windows.Forms.Label();
            this.txtboxquantity = new System.Windows.Forms.TextBox();
            this.dvgpreadditem = new System.Windows.Forms.DataGridView();
            this.cbitem = new System.Windows.Forms.ComboBox();
            this.btnconfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgpreadditem)).BeginInit();
            this.SuspendLayout();
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbluserid.ForeColor = System.Drawing.Color.White;
            this.lbluserid.Location = new System.Drawing.Point(125, 45);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(89, 24);
            this.lbluserid.TabIndex = 1;
            this.lbluserid.Text = "User ID:";
            // 
            // lblrole
            // 
            this.lblrole.AutoSize = true;
            this.lblrole.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblrole.ForeColor = System.Drawing.Color.White;
            this.lblrole.Location = new System.Drawing.Point(609, 45);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(58, 24);
            this.lblrole.TabIndex = 2;
            this.lblrole.Text = "Role:";
            // 
            // txtboxuserid
            // 
            this.txtboxuserid.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxuserid.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtboxuserid.Location = new System.Drawing.Point(220, 38);
            this.txtboxuserid.Name = "txtboxuserid";
            this.txtboxuserid.ReadOnly = true;
            this.txtboxuserid.Size = new System.Drawing.Size(186, 36);
            this.txtboxuserid.TabIndex = 3;
            // 
            // txtboxrole
            // 
            this.txtboxrole.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxrole.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtboxrole.Location = new System.Drawing.Point(682, 38);
            this.txtboxrole.Name = "txtboxrole";
            this.txtboxrole.ReadOnly = true;
            this.txtboxrole.Size = new System.Drawing.Size(218, 36);
            this.txtboxrole.TabIndex = 4;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(659, 203);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(102, 34);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(798, 203);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(102, 34);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lblitem
            // 
            this.lblitem.AutoSize = true;
            this.lblitem.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblitem.ForeColor = System.Drawing.Color.White;
            this.lblitem.Location = new System.Drawing.Point(156, 105);
            this.lblitem.Name = "lblitem";
            this.lblitem.Size = new System.Drawing.Size(58, 24);
            this.lblitem.TabIndex = 8;
            this.lblitem.Text = "Item:";
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblquantity.ForeColor = System.Drawing.Color.White;
            this.lblquantity.Location = new System.Drawing.Point(574, 105);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(93, 24);
            this.lblquantity.TabIndex = 9;
            this.lblquantity.Text = "Quantity:";
            // 
            // txtboxquantity
            // 
            this.txtboxquantity.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxquantity.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtboxquantity.Location = new System.Drawing.Point(682, 102);
            this.txtboxquantity.Name = "txtboxquantity";
            this.txtboxquantity.Size = new System.Drawing.Size(79, 36);
            this.txtboxquantity.TabIndex = 10;
            // 
            // dvgpreadditem
            // 
            this.dvgpreadditem.AllowUserToAddRows = false;
            this.dvgpreadditem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgpreadditem.Location = new System.Drawing.Point(220, 278);
            this.dvgpreadditem.Name = "dvgpreadditem";
            this.dvgpreadditem.RowTemplate.Height = 24;
            this.dvgpreadditem.Size = new System.Drawing.Size(680, 225);
            this.dvgpreadditem.TabIndex = 11;
            // 
            // cbitem
            // 
            this.cbitem.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbitem.FormattingEnabled = true;
            this.cbitem.Location = new System.Drawing.Point(220, 102);
            this.cbitem.Name = "cbitem";
            this.cbitem.Size = new System.Drawing.Size(186, 32);
            this.cbitem.TabIndex = 12;
            this.cbitem.SelectedIndexChanged += new System.EventHandler(this.cbitem_SelectedIndexChanged);
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(764, 543);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(136, 42);
            this.btnconfirm.TabIndex = 13;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // ReceivedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1025, 679);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.cbitem);
            this.Controls.Add(this.dvgpreadditem);
            this.Controls.Add(this.txtboxquantity);
            this.Controls.Add(this.lblquantity);
            this.Controls.Add(this.lblitem);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtboxrole);
            this.Controls.Add(this.txtboxuserid);
            this.Controls.Add(this.lblrole);
            this.Controls.Add(this.lbluserid);
            this.Name = "ReceivedItem";
            this.Text = "ReceivedItem";
            this.Load += new System.EventHandler(this.ReceivedItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgpreadditem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbluserid;
        private System.Windows.Forms.Label lblrole;
        private System.Windows.Forms.TextBox txtboxuserid;
        private System.Windows.Forms.TextBox txtboxrole;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label lblitem;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.TextBox txtboxquantity;
        private System.Windows.Forms.DataGridView dvgpreadditem;
        private System.Windows.Forms.ComboBox cbitem;
        private System.Windows.Forms.Button btnconfirm;
    }
}