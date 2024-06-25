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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetail));
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
            this.btnreorder = new Group6_Project.CustomControls.RoundButton();
            this.btndownloaddispatchpdf = new Group6_Project.CustomControls.RoundButton();
            this.btnreceive = new Group6_Project.CustomControls.RoundButton();
            this.gbgeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgitem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBack
            // 
            resources.ApplyResources(this.lblBack, "lblBack");
            this.lblBack.ForeColor = System.Drawing.Color.White;
            this.lblBack.Name = "lblBack";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // lblorder_id
            // 
            resources.ApplyResources(this.lblorder_id, "lblorder_id");
            this.lblorder_id.Name = "lblorder_id";
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
            resources.ApplyResources(this.gbgeneral, "gbgeneral");
            this.gbgeneral.ForeColor = System.Drawing.Color.White;
            this.gbgeneral.Name = "gbgeneral";
            this.gbgeneral.TabStop = false;
            this.gbgeneral.Enter += new System.EventHandler(this.gbgeneral_Enter);
            // 
            // dtpexpecteddate
            // 
            resources.ApplyResources(this.dtpexpecteddate, "dtpexpecteddate");
            this.dtpexpecteddate.Name = "dtpexpecteddate";
            this.dtpexpecteddate.ValueChanged += new System.EventHandler(this.dtpexpecteddate_ValueChanged);
            // 
            // txtstatus
            // 
            this.txtstatus.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.txtstatus, "txtstatus");
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.ReadOnly = true;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.txtname, "txtname");
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtcreatedate
            // 
            this.txtcreatedate.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.txtcreatedate, "txtcreatedate");
            this.txtcreatedate.Name = "txtcreatedate";
            this.txtcreatedate.ReadOnly = true;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnsave.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnsave.BorderColor = System.Drawing.Color.Transparent;
            this.btnsave.BorderRadius = 16;
            this.btnsave.BorderSize = 2;
            this.btnsave.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnsave, "btnsave");
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Name = "btnsave";
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
            resources.ApplyResources(this.btndelete, "btndelete");
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Name = "btndelete";
            this.btndelete.TextColor = System.Drawing.Color.White;
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtshopid
            // 
            this.txtshopid.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.txtshopid, "txtshopid");
            this.txtshopid.Name = "txtshopid";
            this.txtshopid.ReadOnly = true;
            // 
            // txtboxcreatorid
            // 
            this.txtboxcreatorid.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.txtboxcreatorid, "txtboxcreatorid");
            this.txtboxcreatorid.Name = "txtboxcreatorid";
            this.txtboxcreatorid.ReadOnly = true;
            // 
            // txtboxorderid
            // 
            this.txtboxorderid.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.txtboxorderid, "txtboxorderid");
            this.txtboxorderid.Name = "txtboxorderid";
            this.txtboxorderid.ReadOnly = true;
            // 
            // lblexpecteddeliverydate
            // 
            resources.ApplyResources(this.lblexpecteddeliverydate, "lblexpecteddeliverydate");
            this.lblexpecteddeliverydate.Name = "lblexpecteddeliverydate";
            // 
            // lblstatus
            // 
            resources.ApplyResources(this.lblstatus, "lblstatus");
            this.lblstatus.Name = "lblstatus";
            // 
            // lblname
            // 
            resources.ApplyResources(this.lblname, "lblname");
            this.lblname.Name = "lblname";
            // 
            // lblcreatedate
            // 
            resources.ApplyResources(this.lblcreatedate, "lblcreatedate");
            this.lblcreatedate.Name = "lblcreatedate";
            // 
            // lblshopid
            // 
            resources.ApplyResources(this.lblshopid, "lblshopid");
            this.lblshopid.Name = "lblshopid";
            // 
            // lblcreatorid
            // 
            resources.ApplyResources(this.lblcreatorid, "lblcreatorid");
            this.lblcreatorid.Name = "lblcreatorid";
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
            resources.ApplyResources(this.dvgitem, "dvgitem");
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
            this.dvgitem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgitem_CellContentClick);
            // 
            // lblamounttext
            // 
            resources.ApplyResources(this.lblamounttext, "lblamounttext");
            this.lblamounttext.ForeColor = System.Drawing.Color.White;
            this.lblamounttext.Name = "lblamounttext";
            this.lblamounttext.Click += new System.EventHandler(this.lblamounttext_Click);
            // 
            // lbltotalamount
            // 
            resources.ApplyResources(this.lbltotalamount, "lbltotalamount");
            this.lbltotalamount.ForeColor = System.Drawing.Color.White;
            this.lbltotalamount.Name = "lbltotalamount";
            // 
            // btnreorder
            // 
            this.btnreorder.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnreorder.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnreorder.BorderColor = System.Drawing.Color.Transparent;
            this.btnreorder.BorderRadius = 16;
            this.btnreorder.BorderSize = 2;
            this.btnreorder.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnreorder, "btnreorder");
            this.btnreorder.ForeColor = System.Drawing.Color.White;
            this.btnreorder.Name = "btnreorder";
            this.btnreorder.TextColor = System.Drawing.Color.White;
            this.btnreorder.UseVisualStyleBackColor = false;
            this.btnreorder.Click += new System.EventHandler(this.btnreorder_Click);
            // 
            // btndownloaddispatchpdf
            // 
            this.btndownloaddispatchpdf.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btndownloaddispatchpdf.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btndownloaddispatchpdf.BorderColor = System.Drawing.Color.Transparent;
            this.btndownloaddispatchpdf.BorderRadius = 16;
            this.btndownloaddispatchpdf.BorderSize = 2;
            this.btndownloaddispatchpdf.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btndownloaddispatchpdf, "btndownloaddispatchpdf");
            this.btndownloaddispatchpdf.ForeColor = System.Drawing.Color.White;
            this.btndownloaddispatchpdf.Name = "btndownloaddispatchpdf";
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
            resources.ApplyResources(this.btnreceive, "btnreceive");
            this.btnreceive.ForeColor = System.Drawing.Color.White;
            this.btnreceive.Name = "btnreceive";
            this.btnreceive.TextColor = System.Drawing.Color.White;
            this.btnreceive.UseVisualStyleBackColor = false;
            this.btnreceive.Click += new System.EventHandler(this.btnreceive_Click);
            // 
            // OrderDetail
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.btnreorder);
            this.Controls.Add(this.dvgitem);
            this.Controls.Add(this.btndownloaddispatchpdf);
            this.Controls.Add(this.btnreceive);
            this.Controls.Add(this.lbltotalamount);
            this.Controls.Add(this.lblamounttext);
            this.Controls.Add(this.gbgeneral);
            this.Controls.Add(this.lblBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderDetail";
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
        private CustomControls.RoundButton btnreorder;
    }
}