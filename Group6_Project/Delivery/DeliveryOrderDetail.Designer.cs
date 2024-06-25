namespace Group6_Project
{
    partial class DeliveryOrderDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryOrderDetail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBack = new System.Windows.Forms.Label();
            this.btnstart_delivery = new System.Windows.Forms.Button();
            this.gborder_info = new System.Windows.Forms.GroupBox();
            this.txtboxexpecteddeliverydate = new System.Windows.Forms.TextBox();
            this.txtboxcreate_date = new System.Windows.Forms.TextBox();
            this.txtboxdispatchdate = new System.Windows.Forms.TextBox();
            this.txtboxorder_id = new System.Windows.Forms.TextBox();
            this.txtboxdelivery_id = new System.Windows.Forms.TextBox();
            this.lbldespatch_date = new System.Windows.Forms.Label();
            this.lblexpected_delivery_date = new System.Windows.Forms.Label();
            this.lblcreate_date = new System.Windows.Forms.Label();
            this.lblorder_id = new System.Windows.Forms.Label();
            this.lbldelivery_id = new System.Windows.Forms.Label();
            this.gbitemlist = new System.Windows.Forms.GroupBox();
            this.dvgitemlist = new System.Windows.Forms.DataGridView();
            this.gborder_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgitemlist)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBack
            // 
            resources.ApplyResources(this.lblBack, "lblBack");
            this.lblBack.ForeColor = System.Drawing.Color.White;
            this.lblBack.Name = "lblBack";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // btnstart_delivery
            // 
            this.btnstart_delivery.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            resources.ApplyResources(this.btnstart_delivery, "btnstart_delivery");
            this.btnstart_delivery.ForeColor = System.Drawing.Color.White;
            this.btnstart_delivery.Name = "btnstart_delivery";
            this.btnstart_delivery.UseVisualStyleBackColor = true;
            this.btnstart_delivery.Click += new System.EventHandler(this.btnstart_delivery_Click);
            // 
            // gborder_info
            // 
            this.gborder_info.Controls.Add(this.txtboxexpecteddeliverydate);
            this.gborder_info.Controls.Add(this.txtboxcreate_date);
            this.gborder_info.Controls.Add(this.btnstart_delivery);
            this.gborder_info.Controls.Add(this.txtboxdispatchdate);
            this.gborder_info.Controls.Add(this.txtboxorder_id);
            this.gborder_info.Controls.Add(this.txtboxdelivery_id);
            this.gborder_info.Controls.Add(this.lbldespatch_date);
            this.gborder_info.Controls.Add(this.lblexpected_delivery_date);
            this.gborder_info.Controls.Add(this.lblcreate_date);
            this.gborder_info.Controls.Add(this.lblorder_id);
            this.gborder_info.Controls.Add(this.lbldelivery_id);
            resources.ApplyResources(this.gborder_info, "gborder_info");
            this.gborder_info.ForeColor = System.Drawing.Color.White;
            this.gborder_info.Name = "gborder_info";
            this.gborder_info.TabStop = false;
            // 
            // txtboxexpecteddeliverydate
            // 
            this.txtboxexpecteddeliverydate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.txtboxexpecteddeliverydate, "txtboxexpecteddeliverydate");
            this.txtboxexpecteddeliverydate.Name = "txtboxexpecteddeliverydate";
            this.txtboxexpecteddeliverydate.ReadOnly = true;
            // 
            // txtboxcreate_date
            // 
            this.txtboxcreate_date.BackColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.txtboxcreate_date, "txtboxcreate_date");
            this.txtboxcreate_date.Name = "txtboxcreate_date";
            this.txtboxcreate_date.ReadOnly = true;
            // 
            // txtboxdispatchdate
            // 
            this.txtboxdispatchdate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.txtboxdispatchdate, "txtboxdispatchdate");
            this.txtboxdispatchdate.Name = "txtboxdispatchdate";
            this.txtboxdispatchdate.ReadOnly = true;
            // 
            // txtboxorder_id
            // 
            this.txtboxorder_id.BackColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.txtboxorder_id, "txtboxorder_id");
            this.txtboxorder_id.Name = "txtboxorder_id";
            this.txtboxorder_id.ReadOnly = true;
            // 
            // txtboxdelivery_id
            // 
            this.txtboxdelivery_id.BackColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.txtboxdelivery_id, "txtboxdelivery_id");
            this.txtboxdelivery_id.Name = "txtboxdelivery_id";
            this.txtboxdelivery_id.ReadOnly = true;
            // 
            // lbldespatch_date
            // 
            resources.ApplyResources(this.lbldespatch_date, "lbldespatch_date");
            this.lbldespatch_date.Name = "lbldespatch_date";
            // 
            // lblexpected_delivery_date
            // 
            resources.ApplyResources(this.lblexpected_delivery_date, "lblexpected_delivery_date");
            this.lblexpected_delivery_date.Name = "lblexpected_delivery_date";
            // 
            // lblcreate_date
            // 
            resources.ApplyResources(this.lblcreate_date, "lblcreate_date");
            this.lblcreate_date.Name = "lblcreate_date";
            // 
            // lblorder_id
            // 
            resources.ApplyResources(this.lblorder_id, "lblorder_id");
            this.lblorder_id.Name = "lblorder_id";
            // 
            // lbldelivery_id
            // 
            resources.ApplyResources(this.lbldelivery_id, "lbldelivery_id");
            this.lbldelivery_id.Name = "lbldelivery_id";
            // 
            // gbitemlist
            // 
            resources.ApplyResources(this.gbitemlist, "gbitemlist");
            this.gbitemlist.ForeColor = System.Drawing.Color.White;
            this.gbitemlist.Name = "gbitemlist";
            this.gbitemlist.TabStop = false;
            // 
            // dvgitemlist
            // 
            this.dvgitemlist.AllowUserToAddRows = false;
            this.dvgitemlist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dvgitemlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgitemlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgitemlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgitemlist.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dvgitemlist, "dvgitemlist");
            this.dvgitemlist.Name = "dvgitemlist";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgitemlist.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgitemlist.RowTemplate.Height = 24;
            // 
            // DeliveryOrderDetail
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.dvgitemlist);
            this.Controls.Add(this.gbitemlist);
            this.Controls.Add(this.gborder_info);
            this.Controls.Add(this.lblBack);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeliveryOrderDetail";
            this.Load += new System.EventHandler(this.DeliveryOrderDetail_Load);
            this.gborder_info.ResumeLayout(false);
            this.gborder_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgitemlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Button btnstart_delivery;
        private System.Windows.Forms.GroupBox gborder_info;
        private System.Windows.Forms.Label lbldespatch_date;
        private System.Windows.Forms.Label lblexpected_delivery_date;
        private System.Windows.Forms.Label lblcreate_date;
        private System.Windows.Forms.Label lblorder_id;
        private System.Windows.Forms.Label lbldelivery_id;
        private System.Windows.Forms.TextBox txtboxexpecteddeliverydate;
        private System.Windows.Forms.TextBox txtboxcreate_date;
        private System.Windows.Forms.TextBox txtboxdispatchdate;
        private System.Windows.Forms.TextBox txtboxorder_id;
        private System.Windows.Forms.TextBox txtboxdelivery_id;
        private System.Windows.Forms.GroupBox gbitemlist;
        private System.Windows.Forms.DataGridView dvgitemlist;
    }
}