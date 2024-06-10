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
            this.lblBack = new System.Windows.Forms.Label();
            this.btnstart_delivery = new System.Windows.Forms.Button();
            this.gborder_info = new System.Windows.Forms.GroupBox();
            this.lbldelivery_id = new System.Windows.Forms.Label();
            this.lblorder_id = new System.Windows.Forms.Label();
            this.lblcreate_date = new System.Windows.Forms.Label();
            this.lblexpected_delivery_date = new System.Windows.Forms.Label();
            this.lbldespatch_date = new System.Windows.Forms.Label();
            this.txtboxdelivery_id = new System.Windows.Forms.TextBox();
            this.txtboxorder_id = new System.Windows.Forms.TextBox();
            this.txtboxdispatchdate = new System.Windows.Forms.TextBox();
            this.txtboxcreate_date = new System.Windows.Forms.TextBox();
            this.txtboxexpecteddeliverydate = new System.Windows.Forms.TextBox();
            this.gbitemlist = new System.Windows.Forms.GroupBox();
            this.dvgitemlist = new System.Windows.Forms.DataGridView();
            this.gborder_info.SuspendLayout();
            this.gbitemlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgitemlist)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBack.ForeColor = System.Drawing.Color.White;
            this.lblBack.Location = new System.Drawing.Point(59, 41);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(86, 24);
            this.lblBack.TabIndex = 1;
            this.lblBack.Text = "← Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // btnstart_delivery
            // 
            this.btnstart_delivery.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnstart_delivery.ForeColor = System.Drawing.Color.Black;
            this.btnstart_delivery.Location = new System.Drawing.Point(861, 198);
            this.btnstart_delivery.Name = "btnstart_delivery";
            this.btnstart_delivery.Size = new System.Drawing.Size(193, 49);
            this.btnstart_delivery.TabIndex = 2;
            this.btnstart_delivery.Text = "Delivery Confirm";
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
            this.gborder_info.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gborder_info.ForeColor = System.Drawing.Color.White;
            this.gborder_info.Location = new System.Drawing.Point(63, 82);
            this.gborder_info.Name = "gborder_info";
            this.gborder_info.Size = new System.Drawing.Size(1117, 271);
            this.gborder_info.TabIndex = 3;
            this.gborder_info.TabStop = false;
            this.gborder_info.Text = "Order Information";
            // 
            // lbldelivery_id
            // 
            this.lbldelivery_id.AutoSize = true;
            this.lbldelivery_id.Location = new System.Drawing.Point(148, 43);
            this.lbldelivery_id.Name = "lbldelivery_id";
            this.lbldelivery_id.Size = new System.Drawing.Size(124, 24);
            this.lbldelivery_id.TabIndex = 0;
            this.lbldelivery_id.Text = "Delivery ID:";
            // 
            // lblorder_id
            // 
            this.lblorder_id.AutoSize = true;
            this.lblorder_id.Location = new System.Drawing.Point(688, 43);
            this.lblorder_id.Name = "lblorder_id";
            this.lblorder_id.Size = new System.Drawing.Size(99, 24);
            this.lblorder_id.TabIndex = 1;
            this.lblorder_id.Text = "Order ID:";
            // 
            // lblcreate_date
            // 
            this.lblcreate_date.AutoSize = true;
            this.lblcreate_date.Location = new System.Drawing.Point(149, 99);
            this.lblcreate_date.Name = "lblcreate_date";
            this.lblcreate_date.Size = new System.Drawing.Size(123, 24);
            this.lblcreate_date.TabIndex = 2;
            this.lblcreate_date.Text = "Create Date:";
            // 
            // lblexpected_delivery_date
            // 
            this.lblexpected_delivery_date.AutoSize = true;
            this.lblexpected_delivery_date.Location = new System.Drawing.Point(41, 157);
            this.lblexpected_delivery_date.Name = "lblexpected_delivery_date";
            this.lblexpected_delivery_date.Size = new System.Drawing.Size(231, 24);
            this.lblexpected_delivery_date.TabIndex = 3;
            this.lblexpected_delivery_date.Text = "Expected Delivery Date:";
            // 
            // lbldespatch_date
            // 
            this.lbldespatch_date.AutoSize = true;
            this.lbldespatch_date.Location = new System.Drawing.Point(644, 99);
            this.lbldespatch_date.Name = "lbldespatch_date";
            this.lbldespatch_date.Size = new System.Drawing.Size(143, 24);
            this.lbldespatch_date.TabIndex = 5;
            this.lbldespatch_date.Text = "Dispatch Date:";
            // 
            // txtboxdelivery_id
            // 
            this.txtboxdelivery_id.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxdelivery_id.Location = new System.Drawing.Point(278, 40);
            this.txtboxdelivery_id.Name = "txtboxdelivery_id";
            this.txtboxdelivery_id.ReadOnly = true;
            this.txtboxdelivery_id.Size = new System.Drawing.Size(261, 36);
            this.txtboxdelivery_id.TabIndex = 6;
            // 
            // txtboxorder_id
            // 
            this.txtboxorder_id.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxorder_id.Location = new System.Drawing.Point(793, 40);
            this.txtboxorder_id.Name = "txtboxorder_id";
            this.txtboxorder_id.ReadOnly = true;
            this.txtboxorder_id.Size = new System.Drawing.Size(261, 36);
            this.txtboxorder_id.TabIndex = 7;
            // 
            // txtboxdispatchdate
            // 
            this.txtboxdispatchdate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxdispatchdate.Location = new System.Drawing.Point(793, 96);
            this.txtboxdispatchdate.Name = "txtboxdispatchdate";
            this.txtboxdispatchdate.ReadOnly = true;
            this.txtboxdispatchdate.Size = new System.Drawing.Size(261, 36);
            this.txtboxdispatchdate.TabIndex = 9;
            // 
            // txtboxcreate_date
            // 
            this.txtboxcreate_date.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxcreate_date.Location = new System.Drawing.Point(278, 96);
            this.txtboxcreate_date.Name = "txtboxcreate_date";
            this.txtboxcreate_date.ReadOnly = true;
            this.txtboxcreate_date.Size = new System.Drawing.Size(261, 36);
            this.txtboxcreate_date.TabIndex = 10;
            // 
            // txtboxexpecteddeliverydate
            // 
            this.txtboxexpecteddeliverydate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxexpecteddeliverydate.Location = new System.Drawing.Point(278, 154);
            this.txtboxexpecteddeliverydate.Name = "txtboxexpecteddeliverydate";
            this.txtboxexpecteddeliverydate.ReadOnly = true;
            this.txtboxexpecteddeliverydate.Size = new System.Drawing.Size(261, 36);
            this.txtboxexpecteddeliverydate.TabIndex = 11;
            // 
            // gbitemlist
            // 
            this.gbitemlist.Controls.Add(this.dvgitemlist);
            this.gbitemlist.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbitemlist.ForeColor = System.Drawing.Color.White;
            this.gbitemlist.Location = new System.Drawing.Point(63, 359);
            this.gbitemlist.Name = "gbitemlist";
            this.gbitemlist.Size = new System.Drawing.Size(1117, 296);
            this.gbitemlist.TabIndex = 4;
            this.gbitemlist.TabStop = false;
            this.gbitemlist.Text = "Item List";
            // 
            // dvgitemlist
            // 
            this.dvgitemlist.AllowUserToAddRows = false;
            this.dvgitemlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgitemlist.Location = new System.Drawing.Point(29, 36);
            this.dvgitemlist.Name = "dvgitemlist";
            this.dvgitemlist.RowTemplate.Height = 24;
            this.dvgitemlist.Size = new System.Drawing.Size(1064, 243);
            this.dvgitemlist.TabIndex = 0;
            // 
            // DeliveryOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1301, 709);
            this.Controls.Add(this.gbitemlist);
            this.Controls.Add(this.gborder_info);
            this.Controls.Add(this.lblBack);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "DeliveryOrderDetail";
            this.Text = "DeliveryOrderDetail";
            this.Load += new System.EventHandler(this.DeliveryOrderDetail_Load);
            this.gborder_info.ResumeLayout(false);
            this.gborder_info.PerformLayout();
            this.gbitemlist.ResumeLayout(false);
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