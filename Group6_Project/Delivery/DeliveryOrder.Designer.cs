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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryOrder));
            this.lblsearchdeliveryid = new System.Windows.Forms.Label();
            this.txtboxsearchbyid = new System.Windows.Forms.TextBox();
            this.cbstatusfilter = new System.Windows.Forms.ComboBox();
            this.dvgdeliveryorder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgdeliveryorder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblsearchdeliveryid
            // 
            resources.ApplyResources(this.lblsearchdeliveryid, "lblsearchdeliveryid");
            this.lblsearchdeliveryid.ForeColor = System.Drawing.Color.White;
            this.lblsearchdeliveryid.Name = "lblsearchdeliveryid";
            // 
            // txtboxsearchbyid
            // 
            resources.ApplyResources(this.txtboxsearchbyid, "txtboxsearchbyid");
            this.txtboxsearchbyid.Name = "txtboxsearchbyid";
            this.txtboxsearchbyid.TextChanged += new System.EventHandler(this.txtboxsearchbyid_TextChanged);
            // 
            // cbstatusfilter
            // 
            resources.ApplyResources(this.cbstatusfilter, "cbstatusfilter");
            this.cbstatusfilter.FormattingEnabled = true;
            this.cbstatusfilter.Items.AddRange(new object[] {
            resources.GetString("cbstatusfilter.Items"),
            resources.GetString("cbstatusfilter.Items1")});
            this.cbstatusfilter.Name = "cbstatusfilter";
            this.cbstatusfilter.SelectedIndexChanged += new System.EventHandler(this.cbstatusfilter_SelectedIndexChanged);
            // 
            // dvgdeliveryorder
            // 
            this.dvgdeliveryorder.AllowUserToAddRows = false;
            this.dvgdeliveryorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dvgdeliveryorder, "dvgdeliveryorder");
            this.dvgdeliveryorder.Name = "dvgdeliveryorder";
            this.dvgdeliveryorder.RowTemplate.Height = 24;
            this.dvgdeliveryorder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgdeliveryorder_CellContentClick);
            // 
            // DeliveryOrder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.dvgdeliveryorder);
            this.Controls.Add(this.cbstatusfilter);
            this.Controls.Add(this.txtboxsearchbyid);
            this.Controls.Add(this.lblsearchdeliveryid);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeliveryOrder";
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