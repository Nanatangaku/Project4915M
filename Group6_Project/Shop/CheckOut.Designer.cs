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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lbltotalprice = new System.Windows.Forms.Label();
            this.txtboxtotalprice = new System.Windows.Forms.TextBox();
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
            this.gbgeneral.Location = new System.Drawing.Point(13, 37);
            this.gbgeneral.Margin = new System.Windows.Forms.Padding(4);
            this.gbgeneral.Name = "gbgeneral";
            this.gbgeneral.Padding = new System.Windows.Forms.Padding(4);
            this.gbgeneral.Size = new System.Drawing.Size(1208, 465);
            this.gbgeneral.TabIndex = 0;
            this.gbgeneral.TabStop = false;
            this.gbgeneral.Text = "General";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(820, 188);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(356, 51);
            this.dateTimePicker.TabIndex = 14;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // txtboxshopname
            // 
            this.txtboxshopname.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxshopname.Location = new System.Drawing.Point(821, 120);
            this.txtboxshopname.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxshopname.Name = "txtboxshopname";
            this.txtboxshopname.ReadOnly = true;
            this.txtboxshopname.Size = new System.Drawing.Size(356, 51);
            this.txtboxshopname.TabIndex = 13;
            // 
            // txtboxcreatedate
            // 
            this.txtboxcreatedate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxcreatedate.Location = new System.Drawing.Point(214, 194);
            this.txtboxcreatedate.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxcreatedate.Name = "txtboxcreatedate";
            this.txtboxcreatedate.ReadOnly = true;
            this.txtboxcreatedate.Size = new System.Drawing.Size(356, 51);
            this.txtboxcreatedate.TabIndex = 12;
            // 
            // txtboxshopid
            // 
            this.txtboxshopid.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxshopid.Location = new System.Drawing.Point(214, 117);
            this.txtboxshopid.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxshopid.Name = "txtboxshopid";
            this.txtboxshopid.ReadOnly = true;
            this.txtboxshopid.Size = new System.Drawing.Size(356, 51);
            this.txtboxshopid.TabIndex = 11;
            // 
            // txtboxname
            // 
            this.txtboxname.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxname.Location = new System.Drawing.Point(820, 46);
            this.txtboxname.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxname.Name = "txtboxname";
            this.txtboxname.ReadOnly = true;
            this.txtboxname.Size = new System.Drawing.Size(356, 51);
            this.txtboxname.TabIndex = 10;
            // 
            // txtboxcreateid
            // 
            this.txtboxcreateid.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxcreateid.Location = new System.Drawing.Point(212, 46);
            this.txtboxcreateid.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxcreateid.Name = "txtboxcreateid";
            this.txtboxcreateid.ReadOnly = true;
            this.txtboxcreateid.Size = new System.Drawing.Size(356, 51);
            this.txtboxcreateid.TabIndex = 9;
            // 
            // txtboxaddress
            // 
            this.txtboxaddress.Location = new System.Drawing.Point(214, 278);
            this.txtboxaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxaddress.Multiline = true;
            this.txtboxaddress.Name = "txtboxaddress";
            this.txtboxaddress.Size = new System.Drawing.Size(974, 88);
            this.txtboxaddress.TabIndex = 8;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbladdress.Location = new System.Drawing.Point(72, 281);
            this.lbladdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(134, 36);
            this.lbladdress.TabIndex = 7;
            this.lbladdress.Text = "Address:";
            // 
            // lblshopname
            // 
            this.lblshopname.AutoSize = true;
            this.lblshopname.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblshopname.Location = new System.Drawing.Point(630, 120);
            this.lblshopname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblshopname.Name = "lblshopname";
            this.lblshopname.Size = new System.Drawing.Size(183, 36);
            this.lblshopname.TabIndex = 6;
            this.lblshopname.Text = "Shop Name:";
            // 
            // lblexpectdate
            // 
            this.lblexpectdate.AutoSize = true;
            this.lblexpectdate.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblexpectdate.Location = new System.Drawing.Point(624, 194);
            this.lblexpectdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblexpectdate.Name = "lblexpectdate";
            this.lblexpectdate.Size = new System.Drawing.Size(190, 36);
            this.lblexpectdate.TabIndex = 5;
            this.lblexpectdate.Text = "Expect Date:";
            // 
            // lblshopid
            // 
            this.lblshopid.AutoSize = true;
            this.lblshopid.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblshopid.Location = new System.Drawing.Point(68, 120);
            this.lblshopid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblshopid.Name = "lblshopid";
            this.lblshopid.Size = new System.Drawing.Size(138, 36);
            this.lblshopid.TabIndex = 4;
            this.lblshopid.Text = "Shop ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.Location = new System.Drawing.Point(708, 51);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 36);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // lblcreatedate
            // 
            this.lblcreatedate.AutoSize = true;
            this.lblcreatedate.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblcreatedate.Location = new System.Drawing.Point(21, 194);
            this.lblcreatedate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcreatedate.Name = "lblcreatedate";
            this.lblcreatedate.Size = new System.Drawing.Size(184, 36);
            this.lblcreatedate.TabIndex = 2;
            this.lblcreatedate.Text = "Create Date:";
            // 
            // lblcreaterid
            // 
            this.lblcreaterid.AutoSize = true;
            this.lblcreaterid.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblcreaterid.Location = new System.Drawing.Point(48, 51);
            this.lblcreaterid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcreaterid.Name = "lblcreaterid";
            this.lblcreaterid.Size = new System.Drawing.Size(156, 36);
            this.lblcreaterid.TabIndex = 0;
            this.lblcreaterid.Text = "Create ID:";
            // 
            // gbItem
            // 
            this.gbItem.Controls.Add(this.dvgcart);
            this.gbItem.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbItem.ForeColor = System.Drawing.Color.White;
            this.gbItem.Location = new System.Drawing.Point(13, 519);
            this.gbItem.Margin = new System.Windows.Forms.Padding(4);
            this.gbItem.Name = "gbItem";
            this.gbItem.Padding = new System.Windows.Forms.Padding(4);
            this.gbItem.Size = new System.Drawing.Size(1208, 532);
            this.gbItem.TabIndex = 1;
            this.gbItem.TabStop = false;
            this.gbItem.Text = "Item";
            // 
            // dvgcart
            // 
            this.dvgcart.AllowUserToAddRows = false;
            this.dvgcart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgcart.Location = new System.Drawing.Point(52, 54);
            this.dvgcart.Margin = new System.Windows.Forms.Padding(4);
            this.dvgcart.Name = "dvgcart";
            this.dvgcart.RowHeadersWidth = 62;
            this.dvgcart.RowTemplate.Height = 24;
            this.dvgcart.Size = new System.Drawing.Size(1080, 454);
            this.dvgcart.TabIndex = 0;
            this.dvgcart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgcart_CellClick);
            this.dvgcart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgcart_CellContentClick);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnConfirm.Location = new System.Drawing.Point(873, 394);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(211, 45);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lbltotalprice
            // 
            this.lbltotalprice.AutoSize = true;
            this.lbltotalprice.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltotalprice.Location = new System.Drawing.Point(31, 388);
            this.lbltotalprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotalprice.Name = "lbltotalprice";
            this.lbltotalprice.Size = new System.Drawing.Size(173, 36);
            this.lbltotalprice.TabIndex = 15;
            this.lbltotalprice.Text = "Total Price:";
            // 
            // txtboxtotalprice
            // 
            this.txtboxtotalprice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxtotalprice.Location = new System.Drawing.Point(211, 388);
            this.txtboxtotalprice.Name = "txtboxtotalprice";
            this.txtboxtotalprice.ReadOnly = true;
            this.txtboxtotalprice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtboxtotalprice.Size = new System.Drawing.Size(280, 51);
            this.txtboxtotalprice.TabIndex = 16;
            this.txtboxtotalprice.TextChanged += new System.EventHandler(this.txtboxtotalprice_TextChanged);
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1952, 1064);
            this.Controls.Add(this.gbItem);
            this.Controls.Add(this.gbgeneral);
            this.Margin = new System.Windows.Forms.Padding(4);
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