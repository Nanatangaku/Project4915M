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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblorder_id = new System.Windows.Forms.Label();
            this.gbgeneral = new System.Windows.Forms.GroupBox();
            this.dtpexpecteddate = new System.Windows.Forms.DateTimePicker();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtcreatedate = new System.Windows.Forms.TextBox();
            this.btnsave = new Group6_Project.CustomControls.RoundButton();
            this.btndelete = new Group6_Project.CustomControls.RoundButton();
            this.txtshopid = new System.Windows.Forms.TextBox();
            this.txtboxcreatorid = new System.Windows.Forms.TextBox();
            this.txtboxorderid = new System.Windows.Forms.TextBox();
            this.lblexpecteddeliverydate = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblcreatedate = new System.Windows.Forms.Label();
            this.lblshopid = new System.Windows.Forms.Label();
            this.lblcreatorid = new System.Windows.Forms.Label();
            this.dvgitem = new System.Windows.Forms.DataGridView();
            this.lblamounttext = new System.Windows.Forms.Label();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.btndownloaddispatchpdf = new Group6_Project.CustomControls.RoundButton();
            this.btnreceive = new Group6_Project.CustomControls.RoundButton();
            this.gbgeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgitem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.White;
            this.lblBack.Location = new System.Drawing.Point(30, 18);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(75, 24);
            this.lblBack.TabIndex = 0;
            this.lblBack.Text = "← Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // lblorder_id
            // 
            this.lblorder_id.AutoSize = true;
            this.lblorder_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorder_id.Location = new System.Drawing.Point(154, 47);
            this.lblorder_id.Name = "lblorder_id";
            this.lblorder_id.Size = new System.Drawing.Size(86, 24);
            this.lblorder_id.TabIndex = 1;
            this.lblorder_id.Text = "Order ID:";
            // 
            // gbgeneral
            // 
            this.gbgeneral.Controls.Add(this.dtpexpecteddate);
            this.gbgeneral.Controls.Add(this.txtstatus);
            this.gbgeneral.Controls.Add(this.txtname);
            this.gbgeneral.Controls.Add(this.txtcreatedate);
            this.gbgeneral.Controls.Add(this.btnsave);
            this.gbgeneral.Controls.Add(this.btndelete);
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
            this.gbgeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbgeneral.ForeColor = System.Drawing.Color.White;
            this.gbgeneral.Location = new System.Drawing.Point(35, 60);
            this.gbgeneral.Name = "gbgeneral";
            this.gbgeneral.Size = new System.Drawing.Size(975, 272);
            this.gbgeneral.TabIndex = 2;
            this.gbgeneral.TabStop = false;
            this.gbgeneral.Text = "General";
            this.gbgeneral.Enter += new System.EventHandler(this.gbgeneral_Enter);
            // 
            // dtpexpecteddate
            // 
            this.dtpexpecteddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpexpecteddate.Location = new System.Drawing.Point(264, 216);
            this.dtpexpecteddate.Name = "dtpexpecteddate";
            this.dtpexpecteddate.Size = new System.Drawing.Size(208, 29);
            this.dtpexpecteddate.TabIndex = 23;
            this.dtpexpecteddate.ValueChanged += new System.EventHandler(this.dtpexpecteddate_ValueChanged);
            // 
            // txtstatus
            // 
            this.txtstatus.BackColor = System.Drawing.Color.DarkGray;
            this.txtstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstatus.Location = new System.Drawing.Point(666, 156);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.ReadOnly = true;
            this.txtstatus.Size = new System.Drawing.Size(210, 29);
            this.txtstatus.TabIndex = 21;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.DarkGray;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(666, 99);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(210, 29);
            this.txtname.TabIndex = 20;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtcreatedate
            // 
            this.txtcreatedate.BackColor = System.Drawing.Color.DarkGray;
            this.txtcreatedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcreatedate.Location = new System.Drawing.Point(666, 42);
            this.txtcreatedate.Name = "txtcreatedate";
            this.txtcreatedate.ReadOnly = true;
            this.txtcreatedate.Size = new System.Drawing.Size(210, 29);
            this.txtcreatedate.TabIndex = 19;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnsave.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnsave.BorderColor = System.Drawing.Color.Transparent;
            this.btnsave.BorderRadius = 16;
            this.btnsave.BorderSize = 2;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(773, 212);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(103, 42);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.TextColor = System.Drawing.Color.White;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btndelete.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btndelete.BorderColor = System.Drawing.Color.Transparent;
            this.btndelete.BorderRadius = 16;
            this.btndelete.BorderSize = 2;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(638, 212);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(103, 42);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "Delete";
            this.btndelete.TextColor = System.Drawing.Color.White;
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtshopid
            // 
            this.txtshopid.BackColor = System.Drawing.Color.DarkGray;
            this.txtshopid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtshopid.Location = new System.Drawing.Point(264, 159);
            this.txtshopid.Name = "txtshopid";
            this.txtshopid.ReadOnly = true;
            this.txtshopid.Size = new System.Drawing.Size(208, 29);
            this.txtshopid.TabIndex = 18;
            // 
            // txtboxcreatorid
            // 
            this.txtboxcreatorid.BackColor = System.Drawing.Color.DarkGray;
            this.txtboxcreatorid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxcreatorid.Location = new System.Drawing.Point(264, 102);
            this.txtboxcreatorid.Name = "txtboxcreatorid";
            this.txtboxcreatorid.ReadOnly = true;
            this.txtboxcreatorid.Size = new System.Drawing.Size(208, 29);
            this.txtboxcreatorid.TabIndex = 17;
            // 
            // txtboxorderid
            // 
            this.txtboxorderid.BackColor = System.Drawing.Color.DarkGray;
            this.txtboxorderid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxorderid.Location = new System.Drawing.Point(264, 45);
            this.txtboxorderid.Name = "txtboxorderid";
            this.txtboxorderid.ReadOnly = true;
            this.txtboxorderid.Size = new System.Drawing.Size(208, 29);
            this.txtboxorderid.TabIndex = 16;
            // 
            // lblexpecteddeliverydate
            // 
            this.lblexpecteddeliverydate.AutoSize = true;
            this.lblexpecteddeliverydate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexpecteddeliverydate.Location = new System.Drawing.Point(29, 218);
            this.lblexpecteddeliverydate.Name = "lblexpecteddeliverydate";
            this.lblexpecteddeliverydate.Size = new System.Drawing.Size(211, 24);
            this.lblexpecteddeliverydate.TabIndex = 15;
            this.lblexpecteddeliverydate.Text = "Expected Delivery Date:";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(568, 158);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(65, 24);
            this.lblstatus.TabIndex = 7;
            this.lblstatus.Text = "Status:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(567, 101);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(66, 24);
            this.lblname.TabIndex = 6;
            this.lblname.Text = "Name:";
            // 
            // lblcreatedate
            // 
            this.lblcreatedate.AutoSize = true;
            this.lblcreatedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcreatedate.Location = new System.Drawing.Point(520, 44);
            this.lblcreatedate.Name = "lblcreatedate";
            this.lblcreatedate.Size = new System.Drawing.Size(113, 24);
            this.lblcreatedate.TabIndex = 5;
            this.lblcreatedate.Text = "Create Date:";
            // 
            // lblshopid
            // 
            this.lblshopid.AutoSize = true;
            this.lblshopid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshopid.Location = new System.Drawing.Point(158, 161);
            this.lblshopid.Name = "lblshopid";
            this.lblshopid.Size = new System.Drawing.Size(82, 24);
            this.lblshopid.TabIndex = 4;
            this.lblshopid.Text = "Shop ID:";
            // 
            // lblcreatorid
            // 
            this.lblcreatorid.AutoSize = true;
            this.lblcreatorid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcreatorid.Location = new System.Drawing.Point(142, 104);
            this.lblcreatorid.Name = "lblcreatorid";
            this.lblcreatorid.Size = new System.Drawing.Size(98, 24);
            this.lblcreatorid.TabIndex = 3;
            this.lblcreatorid.Text = "Creator ID:";
            // 
            // dvgitem
            // 
            this.dvgitem.AllowUserToAddRows = false;
            this.dvgitem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dvgitem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgitem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgitem.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgitem.Location = new System.Drawing.Point(35, 341);
            this.dvgitem.Name = "dvgitem";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgitem.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgitem.RowTemplate.Height = 24;
            this.dvgitem.Size = new System.Drawing.Size(975, 290);
            this.dvgitem.TabIndex = 0;
            // 
            // lblamounttext
            // 
            this.lblamounttext.AutoSize = true;
            this.lblamounttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamounttext.ForeColor = System.Drawing.Color.White;
            this.lblamounttext.Location = new System.Drawing.Point(30, 656);
            this.lblamounttext.Name = "lblamounttext";
            this.lblamounttext.Size = new System.Drawing.Size(127, 24);
            this.lblamounttext.TabIndex = 6;
            this.lblamounttext.Text = "Total Amount:";
            this.lblamounttext.Click += new System.EventHandler(this.lblamounttext_Click);
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.AutoSize = true;
            this.lbltotalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalamount.ForeColor = System.Drawing.Color.White;
            this.lbltotalamount.Location = new System.Drawing.Point(163, 657);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(0, 24);
            this.lbltotalamount.TabIndex = 7;
            // 
            // btndownloaddispatchpdf
            // 
            this.btndownloaddispatchpdf.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btndownloaddispatchpdf.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btndownloaddispatchpdf.BorderColor = System.Drawing.Color.Transparent;
            this.btndownloaddispatchpdf.BorderRadius = 16;
            this.btndownloaddispatchpdf.BorderSize = 2;
            this.btndownloaddispatchpdf.FlatAppearance.BorderSize = 0;
            this.btndownloaddispatchpdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndownloaddispatchpdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndownloaddispatchpdf.ForeColor = System.Drawing.Color.White;
            this.btndownloaddispatchpdf.Location = new System.Drawing.Point(717, 648);
            this.btndownloaddispatchpdf.Name = "btndownloaddispatchpdf";
            this.btndownloaddispatchpdf.Size = new System.Drawing.Size(145, 42);
            this.btndownloaddispatchpdf.TabIndex = 9;
            this.btndownloaddispatchpdf.Text = "Download Dispatch ";
            this.btndownloaddispatchpdf.TextColor = System.Drawing.Color.White;
            this.btndownloaddispatchpdf.UseVisualStyleBackColor = false;
            this.btndownloaddispatchpdf.Click += new System.EventHandler(this.btndownloaddispatchpdf_Click);
            // 
            // btnreceive
            // 
            this.btnreceive.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnreceive.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnreceive.BorderColor = System.Drawing.Color.Transparent;
            this.btnreceive.BorderRadius = 16;
            this.btnreceive.BorderSize = 2;
            this.btnreceive.FlatAppearance.BorderSize = 0;
            this.btnreceive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreceive.ForeColor = System.Drawing.Color.White;
            this.btnreceive.Location = new System.Drawing.Point(896, 648);
            this.btnreceive.Name = "btnreceive";
            this.btnreceive.Size = new System.Drawing.Size(103, 42);
            this.btnreceive.TabIndex = 8;
            this.btnreceive.Text = "Receive";
            this.btnreceive.TextColor = System.Drawing.Color.White;
            this.btnreceive.UseVisualStyleBackColor = false;
            this.btnreceive.Click += new System.EventHandler(this.btnreceive_Click);
            // 
            // OrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1041, 718);
            this.Controls.Add(this.dvgitem);
            this.Controls.Add(this.btndownloaddispatchpdf);
            this.Controls.Add(this.btnreceive);
            this.Controls.Add(this.lbltotalamount);
            this.Controls.Add(this.lblamounttext);
            this.Controls.Add(this.gbgeneral);
            this.Controls.Add(this.lblBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderDetail";
            this.Text = "OrderDetail";
            this.Load += new System.EventHandler(this.OrderDetail_Load);
            this.gbgeneral.ResumeLayout(false);
            this.gbgeneral.PerformLayout();
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
        private CustomControls.RoundButton btnreceive;
        private CustomControls.RoundButton btndownloaddispatchpdf;
    }
}