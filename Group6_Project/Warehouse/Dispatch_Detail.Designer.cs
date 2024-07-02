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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dispatch_Detail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbOrderdetail = new System.Windows.Forms.GroupBox();
            this.btnDispatch = new System.Windows.Forms.Button();
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
            resources.ApplyResources(this.gbOrderdetail, "gbOrderdetail");
            this.gbOrderdetail.ForeColor = System.Drawing.Color.White;
            this.gbOrderdetail.Name = "gbOrderdetail";
            this.gbOrderdetail.TabStop = false;
            this.gbOrderdetail.Enter += new System.EventHandler(this.gbOrderdetail_Enter);
            // 
            // btnDispatch
            // 
            this.btnDispatch.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnDispatch.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDispatch.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.btnDispatch, "btnDispatch");
            this.btnDispatch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDispatch.Name = "btnDispatch";
            this.btnDispatch.UseVisualStyleBackColor = true;
            this.btnDispatch.Click += new System.EventHandler(this.btnDispatch_Click);
            // 
            // txtboxexpecteddate
            // 
            this.txtboxexpecteddate.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.txtboxexpecteddate, "txtboxexpecteddate");
            this.txtboxexpecteddate.Name = "txtboxexpecteddate";
            this.txtboxexpecteddate.ReadOnly = true;
            // 
            // txtorder_status
            // 
            this.txtorder_status.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.txtorder_status, "txtorder_status");
            this.txtorder_status.Name = "txtorder_status";
            this.txtorder_status.ReadOnly = true;
            // 
            // txtboxcreatedate
            // 
            this.txtboxcreatedate.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.txtboxcreatedate, "txtboxcreatedate");
            this.txtboxcreatedate.Name = "txtboxcreatedate";
            this.txtboxcreatedate.ReadOnly = true;
            // 
            // txtboxpayment
            // 
            this.txtboxpayment.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.txtboxpayment, "txtboxpayment");
            this.txtboxpayment.Name = "txtboxpayment";
            this.txtboxpayment.ReadOnly = true;
            // 
            // txtboxorder_id
            // 
            this.txtboxorder_id.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.txtboxorder_id, "txtboxorder_id");
            this.txtboxorder_id.Name = "txtboxorder_id";
            this.txtboxorder_id.ReadOnly = true;
            // 
            // lblexpecteddate
            // 
            resources.ApplyResources(this.lblexpecteddate, "lblexpecteddate");
            this.lblexpecteddate.Name = "lblexpecteddate";
            // 
            // lblcreatedate
            // 
            resources.ApplyResources(this.lblcreatedate, "lblcreatedate");
            this.lblcreatedate.Name = "lblcreatedate";
            // 
            // lblpayment
            // 
            resources.ApplyResources(this.lblpayment, "lblpayment");
            this.lblpayment.Name = "lblpayment";
            // 
            // lblorder_status
            // 
            resources.ApplyResources(this.lblorder_status, "lblorder_status");
            this.lblorder_status.Name = "lblorder_status";
            // 
            // lblorder_id
            // 
            resources.ApplyResources(this.lblorder_id, "lblorder_id");
            this.lblorder_id.Name = "lblorder_id";
            // 
            // dvgItem
            // 
            this.dvgItem.AllowUserToAddRows = false;
            this.dvgItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dvgItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgItem.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dvgItem, "dvgItem");
            this.dvgItem.Name = "dvgItem";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgItem.RowTemplate.Height = 24;
            this.dvgItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgItem_CellContentClick);
            // 
            // lblabck
            // 
            resources.ApplyResources(this.lblabck, "lblabck");
            this.lblabck.ForeColor = System.Drawing.Color.White;
            this.lblabck.Name = "lblabck";
            this.lblabck.Click += new System.EventHandler(this.lblabck_Click);
            // 
            // Dispatch_Detail
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.lblabck);
            this.Controls.Add(this.dvgItem);
            this.Controls.Add(this.gbOrderdetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dispatch_Detail";
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