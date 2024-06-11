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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.White;
            this.lblBack.Location = new System.Drawing.Point(59, 44);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(75, 24);
            this.lblBack.TabIndex = 1;
            this.lblBack.Text = "← Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // btnstart_delivery
            // 
            this.btnstart_delivery.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnstart_delivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstart_delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart_delivery.ForeColor = System.Drawing.Color.White;
            this.btnstart_delivery.Location = new System.Drawing.Point(795, 173);
            this.btnstart_delivery.Name = "btnstart_delivery";
            this.btnstart_delivery.Size = new System.Drawing.Size(88, 26);
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
            this.gborder_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gborder_info.ForeColor = System.Drawing.Color.White;
            this.gborder_info.Location = new System.Drawing.Point(63, 89);
            this.gborder_info.Name = "gborder_info";
            this.gborder_info.Size = new System.Drawing.Size(933, 245);
            this.gborder_info.TabIndex = 3;
            this.gborder_info.TabStop = false;
            this.gborder_info.Text = "Order Information";
            // 
            // txtboxexpecteddeliverydate
            // 
            this.txtboxexpecteddeliverydate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxexpecteddeliverydate.Location = new System.Drawing.Point(254, 172);
            this.txtboxexpecteddeliverydate.Name = "txtboxexpecteddeliverydate";
            this.txtboxexpecteddeliverydate.ReadOnly = true;
            this.txtboxexpecteddeliverydate.Size = new System.Drawing.Size(223, 29);
            this.txtboxexpecteddeliverydate.TabIndex = 11;
            // 
            // txtboxcreate_date
            // 
            this.txtboxcreate_date.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxcreate_date.Location = new System.Drawing.Point(254, 114);
            this.txtboxcreate_date.Name = "txtboxcreate_date";
            this.txtboxcreate_date.ReadOnly = true;
            this.txtboxcreate_date.Size = new System.Drawing.Size(223, 29);
            this.txtboxcreate_date.TabIndex = 10;
            // 
            // txtboxdispatchdate
            // 
            this.txtboxdispatchdate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxdispatchdate.Location = new System.Drawing.Point(690, 110);
            this.txtboxdispatchdate.Name = "txtboxdispatchdate";
            this.txtboxdispatchdate.ReadOnly = true;
            this.txtboxdispatchdate.Size = new System.Drawing.Size(193, 29);
            this.txtboxdispatchdate.TabIndex = 9;
            // 
            // txtboxorder_id
            // 
            this.txtboxorder_id.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxorder_id.Location = new System.Drawing.Point(690, 49);
            this.txtboxorder_id.Name = "txtboxorder_id";
            this.txtboxorder_id.ReadOnly = true;
            this.txtboxorder_id.Size = new System.Drawing.Size(193, 29);
            this.txtboxorder_id.TabIndex = 7;
            // 
            // txtboxdelivery_id
            // 
            this.txtboxdelivery_id.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxdelivery_id.Location = new System.Drawing.Point(254, 48);
            this.txtboxdelivery_id.Name = "txtboxdelivery_id";
            this.txtboxdelivery_id.ReadOnly = true;
            this.txtboxdelivery_id.Size = new System.Drawing.Size(223, 29);
            this.txtboxdelivery_id.TabIndex = 6;
            // 
            // lbldespatch_date
            // 
            this.lbldespatch_date.AutoSize = true;
            this.lbldespatch_date.Location = new System.Drawing.Point(522, 114);
            this.lbldespatch_date.Name = "lbldespatch_date";
            this.lbldespatch_date.Size = new System.Drawing.Size(130, 24);
            this.lbldespatch_date.TabIndex = 5;
            this.lbldespatch_date.Text = "Dispatch Date:";
            // 
            // lblexpected_delivery_date
            // 
            this.lblexpected_delivery_date.AutoSize = true;
            this.lblexpected_delivery_date.Location = new System.Drawing.Point(17, 175);
            this.lblexpected_delivery_date.Name = "lblexpected_delivery_date";
            this.lblexpected_delivery_date.Size = new System.Drawing.Size(211, 24);
            this.lblexpected_delivery_date.TabIndex = 3;
            this.lblexpected_delivery_date.Text = "Expected Delivery Date:";
            // 
            // lblcreate_date
            // 
            this.lblcreate_date.AutoSize = true;
            this.lblcreate_date.Location = new System.Drawing.Point(115, 114);
            this.lblcreate_date.Name = "lblcreate_date";
            this.lblcreate_date.Size = new System.Drawing.Size(113, 24);
            this.lblcreate_date.TabIndex = 2;
            this.lblcreate_date.Text = "Create Date:";
            // 
            // lblorder_id
            // 
            this.lblorder_id.AutoSize = true;
            this.lblorder_id.Location = new System.Drawing.Point(566, 54);
            this.lblorder_id.Name = "lblorder_id";
            this.lblorder_id.Size = new System.Drawing.Size(86, 24);
            this.lblorder_id.TabIndex = 1;
            this.lblorder_id.Text = "Order ID:";
            // 
            // lbldelivery_id
            // 
            this.lbldelivery_id.AutoSize = true;
            this.lbldelivery_id.Location = new System.Drawing.Point(124, 52);
            this.lbldelivery_id.Name = "lbldelivery_id";
            this.lbldelivery_id.Size = new System.Drawing.Size(104, 24);
            this.lbldelivery_id.TabIndex = 0;
            this.lbldelivery_id.Text = "Delivery ID:";
            // 
            // gbitemlist
            // 
            this.gbitemlist.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbitemlist.ForeColor = System.Drawing.Color.White;
            this.gbitemlist.Location = new System.Drawing.Point(63, 389);
            this.gbitemlist.Name = "gbitemlist";
            this.gbitemlist.Size = new System.Drawing.Size(0, 0);
            this.gbitemlist.TabIndex = 4;
            this.gbitemlist.TabStop = false;
            this.gbitemlist.Text = "Item List";
            // 
            // dvgitemlist
            // 
            this.dvgitemlist.AllowUserToAddRows = false;
            this.dvgitemlist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dvgitemlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgitemlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgitemlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgitemlist.DefaultCellStyle = dataGridViewCellStyle5;
            this.dvgitemlist.Location = new System.Drawing.Point(63, 364);
            this.dvgitemlist.Name = "dvgitemlist";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgitemlist.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dvgitemlist.RowTemplate.Height = 24;
            this.dvgitemlist.Size = new System.Drawing.Size(933, 380);
            this.dvgitemlist.TabIndex = 0;
            // 
            // DeliveryOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1041, 778);
            this.Controls.Add(this.dvgitemlist);
            this.Controls.Add(this.gbitemlist);
            this.Controls.Add(this.gborder_info);
            this.Controls.Add(this.lblBack);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeliveryOrderDetail";
            this.Text = "DeliveryOrderDetail";
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