namespace Group6_Project
{
    partial class CheckOut
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
            this.gbgeneral = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtboxtotalprice = new System.Windows.Forms.TextBox();
            this.lbltotalprice = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtboxshopname = new System.Windows.Forms.TextBox();
            this.txtboxcreatedate = new System.Windows.Forms.TextBox();
            this.txtboxshopid = new System.Windows.Forms.TextBox();
            this.txtboxname = new System.Windows.Forms.TextBox();
            this.txtboxcreateid = new System.Windows.Forms.TextBox();
            this.txtboxaddress = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblshopname = new System.Windows.Forms.Label();
            this.lblexpectdate = new System.Windows.Forms.Label();
            this.lblshopid = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblcreatedate = new System.Windows.Forms.Label();
            this.lblcreaterid = new System.Windows.Forms.Label();
            this.gbItem = new System.Windows.Forms.GroupBox();
            this.dvgcart = new System.Windows.Forms.DataGridView();
            this.gbgeneral.SuspendLayout();
            this.gbItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgcart)).BeginInit();
            this.SuspendLayout();
            // 
            // gbgeneral
            // 
            this.gbgeneral.Controls.Add(this.btnConfirm);
            this.gbgeneral.Controls.Add(this.txtboxtotalprice);
            this.gbgeneral.Controls.Add(this.lbltotalprice);
            this.gbgeneral.Controls.Add(this.dateTimePicker);
            this.gbgeneral.Controls.Add(this.txtboxshopname);
            this.gbgeneral.Controls.Add(this.txtboxcreatedate);
            this.gbgeneral.Controls.Add(this.txtboxshopid);
            this.gbgeneral.Controls.Add(this.txtboxname);
            this.gbgeneral.Controls.Add(this.txtboxcreateid);
            this.gbgeneral.Controls.Add(this.txtboxaddress);
            this.gbgeneral.Controls.Add(this.lbladdress);
            this.gbgeneral.Controls.Add(this.lblshopname);
            this.gbgeneral.Controls.Add(this.lblexpectdate);
            this.gbgeneral.Controls.Add(this.lblshopid);
            this.gbgeneral.Controls.Add(this.lblName);
            this.gbgeneral.Controls.Add(this.lblcreatedate);
            this.gbgeneral.Controls.Add(this.lblcreaterid);
            this.gbgeneral.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbgeneral.ForeColor = System.Drawing.Color.White;
            this.gbgeneral.Location = new System.Drawing.Point(9, 25);
            this.gbgeneral.Name = "gbgeneral";
            this.gbgeneral.Size = new System.Drawing.Size(805, 310);
            this.gbgeneral.TabIndex = 0;
            this.gbgeneral.TabStop = false;
            this.gbgeneral.Text = "General";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnConfirm.Location = new System.Drawing.Point(582, 263);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(141, 30);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtboxtotalprice
            // 
            this.txtboxtotalprice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxtotalprice.Location = new System.Drawing.Point(141, 259);
            this.txtboxtotalprice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtboxtotalprice.Name = "txtboxtotalprice";
            this.txtboxtotalprice.ReadOnly = true;
            this.txtboxtotalprice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtboxtotalprice.Size = new System.Drawing.Size(188, 36);
            this.txtboxtotalprice.TabIndex = 16;
            this.txtboxtotalprice.TextChanged += new System.EventHandler(this.txtboxtotalprice_TextChanged);
            // 
            // lbltotalprice
            // 
            this.lbltotalprice.AutoSize = true;
            this.lbltotalprice.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltotalprice.Location = new System.Drawing.Point(21, 259);
            this.lbltotalprice.Name = "lbltotalprice";
            this.lbltotalprice.Size = new System.Drawing.Size(116, 24);
            this.lbltotalprice.TabIndex = 15;
            this.lbltotalprice.Text = "Total Price:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(547, 125);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(239, 36);
            this.dateTimePicker.TabIndex = 14;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // txtboxshopname
            // 
            this.txtboxshopname.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxshopname.Location = new System.Drawing.Point(547, 80);
            this.txtboxshopname.Name = "txtboxshopname";
            this.txtboxshopname.ReadOnly = true;
            this.txtboxshopname.Size = new System.Drawing.Size(239, 36);
            this.txtboxshopname.TabIndex = 13;
            // 
            // txtboxcreatedate
            // 
            this.txtboxcreatedate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxcreatedate.Location = new System.Drawing.Point(143, 129);
            this.txtboxcreatedate.Name = "txtboxcreatedate";
            this.txtboxcreatedate.ReadOnly = true;
            this.txtboxcreatedate.Size = new System.Drawing.Size(239, 36);
            this.txtboxcreatedate.TabIndex = 12;
            // 
            // txtboxshopid
            // 
            this.txtboxshopid.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxshopid.Location = new System.Drawing.Point(143, 78);
            this.txtboxshopid.Name = "txtboxshopid";
            this.txtboxshopid.ReadOnly = true;
            this.txtboxshopid.Size = new System.Drawing.Size(239, 36);
            this.txtboxshopid.TabIndex = 11;
            // 
            // txtboxname
            // 
            this.txtboxname.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxname.Location = new System.Drawing.Point(547, 31);
            this.txtboxname.Name = "txtboxname";
            this.txtboxname.ReadOnly = true;
            this.txtboxname.Size = new System.Drawing.Size(239, 36);
            this.txtboxname.TabIndex = 10;
            // 
            // txtboxcreateid
            // 
            this.txtboxcreateid.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxcreateid.Location = new System.Drawing.Point(141, 31);
            this.txtboxcreateid.Name = "txtboxcreateid";
            this.txtboxcreateid.ReadOnly = true;
            this.txtboxcreateid.Size = new System.Drawing.Size(239, 36);
            this.txtboxcreateid.TabIndex = 9;
            // 
            // txtboxaddress
            // 
            this.txtboxaddress.Location = new System.Drawing.Point(143, 185);
            this.txtboxaddress.Multiline = true;
            this.txtboxaddress.Name = "txtboxaddress";
            this.txtboxaddress.Size = new System.Drawing.Size(651, 60);
            this.txtboxaddress.TabIndex = 8;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbladdress.Location = new System.Drawing.Point(48, 187);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(90, 24);
            this.lbladdress.TabIndex = 7;
            this.lbladdress.Text = "Address:";
            // 
            // lblshopname
            // 
            this.lblshopname.AutoSize = true;
            this.lblshopname.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblshopname.Location = new System.Drawing.Point(420, 80);
            this.lblshopname.Name = "lblshopname";
            this.lblshopname.Size = new System.Drawing.Size(122, 24);
            this.lblshopname.TabIndex = 6;
            this.lblshopname.Text = "Shop Name:";
            // 
            // lblexpectdate
            // 
            this.lblexpectdate.AutoSize = true;
            this.lblexpectdate.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblexpectdate.Location = new System.Drawing.Point(416, 129);
            this.lblexpectdate.Name = "lblexpectdate";
            this.lblexpectdate.Size = new System.Drawing.Size(126, 24);
            this.lblexpectdate.TabIndex = 5;
            this.lblexpectdate.Text = "Expect Date:";
            // 
            // lblshopid
            // 
            this.lblshopid.AutoSize = true;
            this.lblshopid.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblshopid.Location = new System.Drawing.Point(45, 80);
            this.lblshopid.Name = "lblshopid";
            this.lblshopid.Size = new System.Drawing.Size(92, 24);
            this.lblshopid.TabIndex = 4;
            this.lblshopid.Text = "Shop ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.Location = new System.Drawing.Point(472, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 24);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // lblcreatedate
            // 
            this.lblcreatedate.AutoSize = true;
            this.lblcreatedate.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblcreatedate.Location = new System.Drawing.Point(14, 129);
            this.lblcreatedate.Name = "lblcreatedate";
            this.lblcreatedate.Size = new System.Drawing.Size(123, 24);
            this.lblcreatedate.TabIndex = 2;
            this.lblcreatedate.Text = "Create Date:";
            // 
            // lblcreaterid
            // 
            this.lblcreaterid.AutoSize = true;
            this.lblcreaterid.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblcreaterid.Location = new System.Drawing.Point(32, 34);
            this.lblcreaterid.Name = "lblcreaterid";
            this.lblcreaterid.Size = new System.Drawing.Size(105, 24);
            this.lblcreaterid.TabIndex = 0;
            this.lblcreaterid.Text = "Create ID:";
            // 
            // gbItem
            // 
            this.gbItem.Controls.Add(this.dvgcart);
            this.gbItem.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbItem.ForeColor = System.Drawing.Color.White;
            this.gbItem.Location = new System.Drawing.Point(9, 346);
            this.gbItem.Name = "gbItem";
            this.gbItem.Size = new System.Drawing.Size(805, 355);
            this.gbItem.TabIndex = 1;
            this.gbItem.TabStop = false;
            this.gbItem.Text = "Item";
            // 
            // dvgcart
            // 
            this.dvgcart.AllowUserToAddRows = false;
            this.dvgcart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgcart.Location = new System.Drawing.Point(35, 36);
            this.dvgcart.Name = "dvgcart";
            this.dvgcart.RowHeadersWidth = 62;
            this.dvgcart.RowTemplate.Height = 24;
            this.dvgcart.Size = new System.Drawing.Size(720, 303);
            this.dvgcart.TabIndex = 0;
            this.dvgcart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgcart_CellClick);
            this.dvgcart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgcart_CellContentClick);
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1283, 637);
            this.Controls.Add(this.gbItem);
            this.Controls.Add(this.gbgeneral);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            this.gbgeneral.ResumeLayout(false);
            this.gbgeneral.PerformLayout();
            this.gbItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgcart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbgeneral;
        private System.Windows.Forms.Label lblexpectdate;
        private System.Windows.Forms.Label lblshopid;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblcreatedate;
        private System.Windows.Forms.Label lblcreaterid;
        private System.Windows.Forms.Label lblshopname;
        private System.Windows.Forms.TextBox txtboxaddress;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtboxshopname;
        private System.Windows.Forms.TextBox txtboxcreatedate;
        private System.Windows.Forms.TextBox txtboxshopid;
        private System.Windows.Forms.TextBox txtboxname;
        private System.Windows.Forms.TextBox txtboxcreateid;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox gbItem;
        private System.Windows.Forms.DataGridView dvgcart;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtboxtotalprice;
        private System.Windows.Forms.Label lbltotalprice;
    }
}