namespace Group6_Project
{
    partial class Dispatch_Detail
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
            this.gbOrderdetail = new System.Windows.Forms.GroupBox();
            this.txtboxexpecteddate = new System.Windows.Forms.TextBox();
            this.txtorder_status = new System.Windows.Forms.TextBox();
            this.txtboxcreatedate = new System.Windows.Forms.TextBox();
            this.txtboxpayment = new System.Windows.Forms.TextBox();
            this.txtboxorder_id = new System.Windows.Forms.TextBox();
            this.lblexpecteddate = new System.Windows.Forms.Label();
            this.lblcreatedate = new System.Windows.Forms.Label();
            this.lblpayment = new System.Windows.Forms.Label();
            this.lblorder_status = new System.Windows.Forms.Label();
            this.lblorder_id = new System.Windows.Forms.Label();
            this.dvgItem = new System.Windows.Forms.DataGridView();
            this.lblabck = new System.Windows.Forms.Label();
            this.btnDispatch = new System.Windows.Forms.Button();
            this.gbOrderdetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgItem)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOrderdetail
            // 
            this.gbOrderdetail.Controls.Add(this.btnDispatch);
            this.gbOrderdetail.Controls.Add(this.txtboxexpecteddate);
            this.gbOrderdetail.Controls.Add(this.txtorder_status);
            this.gbOrderdetail.Controls.Add(this.txtboxcreatedate);
            this.gbOrderdetail.Controls.Add(this.txtboxpayment);
            this.gbOrderdetail.Controls.Add(this.txtboxorder_id);
            this.gbOrderdetail.Controls.Add(this.lblexpecteddate);
            this.gbOrderdetail.Controls.Add(this.lblcreatedate);
            this.gbOrderdetail.Controls.Add(this.lblpayment);
            this.gbOrderdetail.Controls.Add(this.lblorder_status);
            this.gbOrderdetail.Controls.Add(this.lblorder_id);
            this.gbOrderdetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderdetail.ForeColor = System.Drawing.Color.White;
            this.gbOrderdetail.Location = new System.Drawing.Point(53, 75);
            this.gbOrderdetail.Name = "gbOrderdetail";
            this.gbOrderdetail.Size = new System.Drawing.Size(931, 198);
            this.gbOrderdetail.TabIndex = 0;
            this.gbOrderdetail.TabStop = false;
            this.gbOrderdetail.Text = "Order Detail";
            this.gbOrderdetail.Enter += new System.EventHandler(this.gbOrderdetail_Enter);
            // 
            // txtboxexpecteddate
            // 
            this.txtboxexpecteddate.BackColor = System.Drawing.Color.DarkGray;
            this.txtboxexpecteddate.Location = new System.Drawing.Point(636, 85);
            this.txtboxexpecteddate.Name = "txtboxexpecteddate";
            this.txtboxexpecteddate.ReadOnly = true;
            this.txtboxexpecteddate.Size = new System.Drawing.Size(204, 29);
            this.txtboxexpecteddate.TabIndex = 10;
            // 
            // txtorder_status
            // 
            this.txtorder_status.BackColor = System.Drawing.Color.DarkGray;
            this.txtorder_status.Location = new System.Drawing.Point(636, 31);
            this.txtorder_status.Name = "txtorder_status";
            this.txtorder_status.ReadOnly = true;
            this.txtorder_status.Size = new System.Drawing.Size(204, 29);
            this.txtorder_status.TabIndex = 9;
            // 
            // txtboxcreatedate
            // 
            this.txtboxcreatedate.BackColor = System.Drawing.Color.DarkGray;
            this.txtboxcreatedate.Location = new System.Drawing.Point(210, 85);
            this.txtboxcreatedate.Name = "txtboxcreatedate";
            this.txtboxcreatedate.ReadOnly = true;
            this.txtboxcreatedate.Size = new System.Drawing.Size(236, 29);
            this.txtboxcreatedate.TabIndex = 8;
            // 
            // txtboxpayment
            // 
            this.txtboxpayment.BackColor = System.Drawing.Color.DarkGray;
            this.txtboxpayment.Location = new System.Drawing.Point(210, 138);
            this.txtboxpayment.Name = "txtboxpayment";
            this.txtboxpayment.ReadOnly = true;
            this.txtboxpayment.Size = new System.Drawing.Size(236, 29);
            this.txtboxpayment.TabIndex = 7;
            // 
            // txtboxorder_id
            // 
            this.txtboxorder_id.BackColor = System.Drawing.Color.DarkGray;
            this.txtboxorder_id.Location = new System.Drawing.Point(210, 34);
            this.txtboxorder_id.Name = "txtboxorder_id";
            this.txtboxorder_id.ReadOnly = true;
            this.txtboxorder_id.Size = new System.Drawing.Size(236, 29);
            this.txtboxorder_id.TabIndex = 6;
            // 
            // lblexpecteddate
            // 
            this.lblexpecteddate.AutoSize = true;
            this.lblexpecteddate.Location = new System.Drawing.Point(483, 88);
            this.lblexpecteddate.Name = "lblexpecteddate";
            this.lblexpecteddate.Size = new System.Drawing.Size(139, 24);
            this.lblexpecteddate.TabIndex = 4;
            this.lblexpecteddate.Text = "Expected Date:";
            // 
            // lblcreatedate
            // 
            this.lblcreatedate.AutoSize = true;
            this.lblcreatedate.Location = new System.Drawing.Point(76, 88);
            this.lblcreatedate.Name = "lblcreatedate";
            this.lblcreatedate.Size = new System.Drawing.Size(113, 24);
            this.lblcreatedate.TabIndex = 3;
            this.lblcreatedate.Text = "Create Date:";
            // 
            // lblpayment
            // 
            this.lblpayment.AutoSize = true;
            this.lblpayment.Location = new System.Drawing.Point(100, 141);
            this.lblpayment.Name = "lblpayment";
            this.lblpayment.Size = new System.Drawing.Size(88, 24);
            this.lblpayment.TabIndex = 2;
            this.lblpayment.Text = "Payment:";
            // 
            // lblorder_status
            // 
            this.lblorder_status.AutoSize = true;
            this.lblorder_status.Location = new System.Drawing.Point(500, 37);
            this.lblorder_status.Name = "lblorder_status";
            this.lblorder_status.Size = new System.Drawing.Size(119, 24);
            this.lblorder_status.TabIndex = 1;
            this.lblorder_status.Text = "Order Status:";
            // 
            // lblorder_id
            // 
            this.lblorder_id.AutoSize = true;
            this.lblorder_id.Location = new System.Drawing.Point(100, 34);
            this.lblorder_id.Name = "lblorder_id";
            this.lblorder_id.Size = new System.Drawing.Size(86, 24);
            this.lblorder_id.TabIndex = 0;
            this.lblorder_id.Text = "Order ID:";
            // 
            // dvgItem
            // 
            this.dvgItem.AllowUserToAddRows = false;
            this.dvgItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dvgItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgItem.DefaultCellStyle = dataGridViewCellStyle5;
            this.dvgItem.Location = new System.Drawing.Point(53, 279);
            this.dvgItem.Name = "dvgItem";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dvgItem.RowTemplate.Height = 24;
            this.dvgItem.Size = new System.Drawing.Size(931, 390);
            this.dvgItem.TabIndex = 5;
            // 
            // lblabck
            // 
            this.lblabck.AutoSize = true;
            this.lblabck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblabck.ForeColor = System.Drawing.Color.White;
            this.lblabck.Location = new System.Drawing.Point(49, 33);
            this.lblabck.Name = "lblabck";
            this.lblabck.Size = new System.Drawing.Size(75, 24);
            this.lblabck.TabIndex = 6;
            this.lblabck.Text = "← Back";
            this.lblabck.Click += new System.EventHandler(this.lblabck_Click);
            // 
            // btnDispatch
            // 
            this.btnDispatch.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnDispatch.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDispatch.FlatAppearance.BorderSize = 2;
            this.btnDispatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDispatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispatch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDispatch.Location = new System.Drawing.Point(728, 135);
            this.btnDispatch.Name = "btnDispatch";
            this.btnDispatch.Size = new System.Drawing.Size(112, 39);
            this.btnDispatch.TabIndex = 7;
            this.btnDispatch.Text = "Dispatch";
            this.btnDispatch.UseVisualStyleBackColor = true;
            this.btnDispatch.Click += new System.EventHandler(this.btnDispatch_Click);
            // 
            // Dispatch_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1041, 718);
            this.Controls.Add(this.lblabck);
            this.Controls.Add(this.dvgItem);
            this.Controls.Add(this.gbOrderdetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dispatch_Detail";
            this.Text = "Dispatch_Detail";
            this.Load += new System.EventHandler(this.Dispatch_Detail_Load);
            this.gbOrderdetail.ResumeLayout(false);
            this.gbOrderdetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOrderdetail;
        private System.Windows.Forms.Label lblorder_id;
        private System.Windows.Forms.TextBox txtboxexpecteddate;
        private System.Windows.Forms.TextBox txtorder_status;
        private System.Windows.Forms.TextBox txtboxcreatedate;
        private System.Windows.Forms.TextBox txtboxpayment;
        private System.Windows.Forms.TextBox txtboxorder_id;
        private System.Windows.Forms.Label lblexpecteddate;
        private System.Windows.Forms.Label lblcreatedate;
        private System.Windows.Forms.Label lblpayment;
        private System.Windows.Forms.Label lblorder_status;
        private System.Windows.Forms.DataGridView dvgItem;
        private System.Windows.Forms.Label lblabck;
        private System.Windows.Forms.Button btnDispatch;
    }
}