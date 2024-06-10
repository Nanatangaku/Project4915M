namespace Group6_Project
{
    partial class DeliveryOrder
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
            this.lblsearchdeliveryid = new System.Windows.Forms.Label();
            this.txtboxsearchbyid = new System.Windows.Forms.TextBox();
            this.cbstatusfilter = new System.Windows.Forms.ComboBox();
            this.dvgdeliveryorder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgdeliveryorder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblsearchdeliveryid
            // 
            this.lblsearchdeliveryid.AutoSize = true;
            this.lblsearchdeliveryid.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblsearchdeliveryid.ForeColor = System.Drawing.Color.White;
            this.lblsearchdeliveryid.Location = new System.Drawing.Point(93, 65);
            this.lblsearchdeliveryid.Name = "lblsearchdeliveryid";
            this.lblsearchdeliveryid.Size = new System.Drawing.Size(219, 24);
            this.lblsearchdeliveryid.TabIndex = 0;
            this.lblsearchdeliveryid.Text = "Search By delivery ID:";
            // 
            // txtboxsearchbyid
            // 
            this.txtboxsearchbyid.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtboxsearchbyid.Location = new System.Drawing.Point(318, 61);
            this.txtboxsearchbyid.Name = "txtboxsearchbyid";
            this.txtboxsearchbyid.Size = new System.Drawing.Size(460, 36);
            this.txtboxsearchbyid.TabIndex = 1;
            // 
            // cbstatusfilter
            // 
            this.cbstatusfilter.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbstatusfilter.FormattingEnabled = true;
            this.cbstatusfilter.Items.AddRange(new object[] {
            "Waiting to delivery",
            "Delivering"});
            this.cbstatusfilter.Location = new System.Drawing.Point(947, 65);
            this.cbstatusfilter.Name = "cbstatusfilter";
            this.cbstatusfilter.Size = new System.Drawing.Size(200, 32);
            this.cbstatusfilter.TabIndex = 2;
            // 
            // dvgdeliveryorder
            // 
            this.dvgdeliveryorder.AllowUserToAddRows = false;
            this.dvgdeliveryorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgdeliveryorder.Location = new System.Drawing.Point(97, 132);
            this.dvgdeliveryorder.Name = "dvgdeliveryorder";
            this.dvgdeliveryorder.RowTemplate.Height = 24;
            this.dvgdeliveryorder.Size = new System.Drawing.Size(1050, 465);
            this.dvgdeliveryorder.TabIndex = 3;
            // 
            // DeliveryOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1301, 709);
            this.Controls.Add(this.dvgdeliveryorder);
            this.Controls.Add(this.cbstatusfilter);
            this.Controls.Add(this.txtboxsearchbyid);
            this.Controls.Add(this.lblsearchdeliveryid);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Name = "DeliveryOrder";
            this.Text = "DeliveryOrder";
            this.Load += new System.EventHandler(this.DeliveryOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgdeliveryorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsearchdeliveryid;
        private System.Windows.Forms.TextBox txtboxsearchbyid;
        private System.Windows.Forms.ComboBox cbstatusfilter;
        private System.Windows.Forms.DataGridView dvgdeliveryorder;
    }
}