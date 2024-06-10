namespace Group6_Project
{
    partial class OrderDetail
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
            this.lblBack = new System.Windows.Forms.Label();
            this.lblorder_id = new System.Windows.Forms.Label();
            this.gbgeneral = new System.Windows.Forms.GroupBox();
            this.dtpexpecteddate = new System.Windows.Forms.DateTimePicker();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtcreatedate = new System.Windows.Forms.TextBox();
            this.txtshopid = new System.Windows.Forms.TextBox();
            this.txtboxcreatorid = new System.Windows.Forms.TextBox();
            this.txtboxorderid = new System.Windows.Forms.TextBox();
            this.lblexpecteddeliverydate = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblcreatedate = new System.Windows.Forms.Label();
            this.lblshopid = new System.Windows.Forms.Label();
            this.lblcreatorid = new System.Windows.Forms.Label();
            this.gbitem = new System.Windows.Forms.GroupBox();
            this.dvgitem = new System.Windows.Forms.DataGridView();
            this.lblamounttext = new System.Windows.Forms.Label();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.btndelete = new Group6_Project.CustomControls.RoundButton();
            this.btnsave = new Group6_Project.CustomControls.RoundButton();
            this.gbgeneral.SuspendLayout();
            this.gbitem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgitem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBack.ForeColor = System.Drawing.Color.White;
            this.lblBack.Location = new System.Drawing.Point(51, 18);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(86, 24);
            this.lblBack.TabIndex = 0;
            this.lblBack.Text = "← Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // lblorder_id
            // 
            this.lblorder_id.AutoSize = true;
            this.lblorder_id.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblorder_id.Location = new System.Drawing.Point(151, 33);
            this.lblorder_id.Name = "lblorder_id";
            this.lblorder_id.Size = new System.Drawing.Size(99, 24);
            this.lblorder_id.TabIndex = 1;
            this.lblorder_id.Text = "Order ID:";
            // 
            // gbgeneral
            // 
            this.gbgeneral.Controls.Add(this.dtpexpecteddate);
            this.gbgeneral.Controls.Add(this.txtstatus);
            this.gbgeneral.Controls.Add(this.txtname);
            this.gbgeneral.Controls.Add(this.txtcreatedate);
            this.gbgeneral.Controls.Add(this.txtshopid);
            this.gbgeneral.Controls.Add(this.txtboxcreatorid);
            this.gbgeneral.Controls.Add(this.txtboxorderid);
            this.gbgeneral.Controls.Add(this.lblexpecteddeliverydate);
            this.gbgeneral.Controls.Add(this.lblstatus);
            this.gbgeneral.Controls.Add(this.lblname);
            this.gbgeneral.Controls.Add(this.lblcreatedate);
            this.gbgeneral.Controls.Add(this.lblshopid);
            this.gbgeneral.Controls.Add(this.lblcreatorid);
            this.gbgeneral.Controls.Add(this.lblorder_id);
            this.gbgeneral.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbgeneral.ForeColor = System.Drawing.Color.White;
            this.gbgeneral.Location = new System.Drawing.Point(55, 60);
            this.gbgeneral.Name = "gbgeneral";
            this.gbgeneral.Size = new System.Drawing.Size(889, 252);
            this.gbgeneral.TabIndex = 2;
            this.gbgeneral.TabStop = false;
            this.gbgeneral.Text = "General";
            this.gbgeneral.Enter += new System.EventHandler(this.gbgeneral_Enter);
            // 
            // dtpexpecteddate
            // 
            this.dtpexpecteddate.Location = new System.Drawing.Point(273, 195);
            this.dtpexpecteddate.Name = "dtpexpecteddate";
            this.dtpexpecteddate.Size = new System.Drawing.Size(185, 36);
            this.dtpexpecteddate.TabIndex = 23;
            this.dtpexpecteddate.ValueChanged += new System.EventHandler(this.dtpexpecteddate_ValueChanged);
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(664, 129);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.ReadOnly = true;
            this.txtstatus.Size = new System.Drawing.Size(155, 36);
            this.txtstatus.TabIndex = 21;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(664, 79);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(120, 36);
            this.txtname.TabIndex = 20;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtcreatedate
            // 
            this.txtcreatedate.Location = new System.Drawing.Point(664, 33);
            this.txtcreatedate.Name = "txtcreatedate";
            this.txtcreatedate.ReadOnly = true;
            this.txtcreatedate.Size = new System.Drawing.Size(100, 36);
            this.txtcreatedate.TabIndex = 19;
            // 
            // txtshopid
            // 
            this.txtshopid.Location = new System.Drawing.Point(285, 129);
            this.txtshopid.Name = "txtshopid";
            this.txtshopid.ReadOnly = true;
            this.txtshopid.Size = new System.Drawing.Size(100, 36);
            this.txtshopid.TabIndex = 18;
            // 
            // txtboxcreatorid
            // 
            this.txtboxcreatorid.Location = new System.Drawing.Point(285, 79);
            this.txtboxcreatorid.Name = "txtboxcreatorid";
            this.txtboxcreatorid.ReadOnly = true;
            this.txtboxcreatorid.Size = new System.Drawing.Size(100, 36);
            this.txtboxcreatorid.TabIndex = 17;
            // 
            // txtboxorderid
            // 
            this.txtboxorderid.Location = new System.Drawing.Point(285, 33);
            this.txtboxorderid.Name = "txtboxorderid";
            this.txtboxorderid.ReadOnly = true;
            this.txtboxorderid.Size = new System.Drawing.Size(100, 36);
            this.txtboxorderid.TabIndex = 16;
            // 
            // lblexpecteddeliverydate
            // 
            this.lblexpecteddeliverydate.AutoSize = true;
            this.lblexpecteddeliverydate.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblexpecteddeliverydate.Location = new System.Drawing.Point(19, 195);
            this.lblexpecteddeliverydate.Name = "lblexpecteddeliverydate";
            this.lblexpecteddeliverydate.Size = new System.Drawing.Size(231, 24);
            this.lblexpecteddeliverydate.TabIndex = 15;
            this.lblexpecteddeliverydate.Text = "Expected Delivery Date:";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblstatus.Location = new System.Drawing.Point(578, 127);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(71, 24);
            this.lblstatus.TabIndex = 7;
            this.lblstatus.Text = "Status:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblname.Location = new System.Drawing.Point(579, 73);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(70, 24);
            this.lblname.TabIndex = 6;
            this.lblname.Text = "Name:";
            // 
            // lblcreatedate
            // 
            this.lblcreatedate.AutoSize = true;
            this.lblcreatedate.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblcreatedate.Location = new System.Drawing.Point(526, 31);
            this.lblcreatedate.Name = "lblcreatedate";
            this.lblcreatedate.Size = new System.Drawing.Size(123, 24);
            this.lblcreatedate.TabIndex = 5;
            this.lblcreatedate.Text = "Create Date:";
            // 
            // lblshopid
            // 
            this.lblshopid.AutoSize = true;
            this.lblshopid.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblshopid.Location = new System.Drawing.Point(158, 123);
            this.lblshopid.Name = "lblshopid";
            this.lblshopid.Size = new System.Drawing.Size(92, 24);
            this.lblshopid.TabIndex = 4;
            this.lblshopid.Text = "Shop ID:";
            // 
            // lblcreatorid
            // 
            this.lblcreatorid.AutoSize = true;
            this.lblcreatorid.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblcreatorid.Location = new System.Drawing.Point(136, 79);
            this.lblcreatorid.Name = "lblcreatorid";
            this.lblcreatorid.Size = new System.Drawing.Size(114, 24);
            this.lblcreatorid.TabIndex = 3;
            this.lblcreatorid.Text = "Creator ID:";
            // 
            // gbitem
            // 
            this.gbitem.Controls.Add(this.dvgitem);
            this.gbitem.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbitem.ForeColor = System.Drawing.Color.White;
            this.gbitem.Location = new System.Drawing.Point(55, 318);
            this.gbitem.Name = "gbitem";
            this.gbitem.Size = new System.Drawing.Size(889, 175);
            this.gbitem.TabIndex = 3;
            this.gbitem.TabStop = false;
            this.gbitem.Text = "Item";
            // 
            // dvgitem
            // 
            this.dvgitem.AllowUserToAddRows = false;
            this.dvgitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgitem.Location = new System.Drawing.Point(23, 22);
            this.dvgitem.Name = "dvgitem";
            this.dvgitem.RowTemplate.Height = 24;
            this.dvgitem.Size = new System.Drawing.Size(824, 132);
            this.dvgitem.TabIndex = 0;
            // 
            // lblamounttext
            // 
            this.lblamounttext.AutoSize = true;
            this.lblamounttext.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblamounttext.ForeColor = System.Drawing.Color.White;
            this.lblamounttext.Location = new System.Drawing.Point(62, 505);
            this.lblamounttext.Name = "lblamounttext";
            this.lblamounttext.Size = new System.Drawing.Size(142, 24);
            this.lblamounttext.TabIndex = 6;
            this.lblamounttext.Text = "Total Amount:";
            this.lblamounttext.Click += new System.EventHandler(this.lblamounttext_Click);
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.AutoSize = true;
            this.lbltotalamount.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltotalamount.Location = new System.Drawing.Point(224, 505);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(0, 24);
            this.lbltotalamount.TabIndex = 7;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.BackgroundColor = System.Drawing.Color.Red;
            this.btndelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(100)))));
            this.btndelete.BorderRadius = 16;
            this.btndelete.BorderSize = 0;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(808, 12);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(103, 42);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "Delete";
            this.btndelete.TextColor = System.Drawing.Color.White;
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Red;
            this.btnsave.BackgroundColor = System.Drawing.Color.Red;
            this.btnsave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(100)))));
            this.btnsave.BorderRadius = 16;
            this.btnsave.BorderSize = 0;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(680, 12);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(103, 42);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.TextColor = System.Drawing.Color.White;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // OrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(987, 551);
            this.Controls.Add(this.lbltotalamount);
            this.Controls.Add(this.lblamounttext);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.gbitem);
            this.Controls.Add(this.gbgeneral);
            this.Controls.Add(this.lblBack);
            this.Name = "OrderDetail";
            this.Text = "OrderDetail";
            this.Load += new System.EventHandler(this.OrderDetail_Load);
            this.gbgeneral.ResumeLayout(false);
            this.gbgeneral.PerformLayout();
            this.gbitem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgitem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblorder_id;
        private System.Windows.Forms.GroupBox gbgeneral;
        private System.Windows.Forms.Label lblcreatedate;
        private System.Windows.Forms.Label lblshopid;
        private System.Windows.Forms.Label lblcreatorid;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.GroupBox gbitem;
        private System.Windows.Forms.DataGridView dvgitem;
        private CustomControls.RoundButton btnsave;
        private CustomControls.RoundButton btndelete;
        private System.Windows.Forms.Label lblamounttext;
        private System.Windows.Forms.Label lbltotalamount;
        private System.Windows.Forms.Label lblexpecteddeliverydate;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtcreatedate;
        private System.Windows.Forms.TextBox txtshopid;
        private System.Windows.Forms.TextBox txtboxcreatorid;
        private System.Windows.Forms.TextBox txtboxorderid;
        private System.Windows.Forms.DateTimePicker dtpexpecteddate;
    }
}