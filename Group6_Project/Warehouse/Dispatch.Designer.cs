namespace Group6_Project
{
    partial class Dispatch
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
            this.Order_idfilter = new System.Windows.Forms.TextBox();
            this.lblorder_id = new System.Windows.Forms.Label();
            this.cborder_status = new System.Windows.Forms.ComboBox();
            this.dvgorder_request = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgorder_request)).BeginInit();
            this.SuspendLayout();
            // 
            // Order_idfilter
            // 
            this.Order_idfilter.Location = new System.Drawing.Point(282, 63);
            this.Order_idfilter.Name = "Order_idfilter";
            this.Order_idfilter.Size = new System.Drawing.Size(245, 22);
            this.Order_idfilter.TabIndex = 0;
            this.Order_idfilter.TextChanged += new System.EventHandler(this.Order_idfilter_TextChanged);
            // 
            // lblorder_id
            // 
            this.lblorder_id.AutoSize = true;
            this.lblorder_id.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblorder_id.ForeColor = System.Drawing.Color.White;
            this.lblorder_id.Location = new System.Drawing.Point(77, 61);
            this.lblorder_id.Name = "lblorder_id";
            this.lblorder_id.Size = new System.Drawing.Size(199, 24);
            this.lblorder_id.TabIndex = 1;
            this.lblorder_id.Text = "Search By Order ID:";
            // 
            // cborder_status
            // 
            this.cborder_status.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cborder_status.FormattingEnabled = true;
            this.cborder_status.Items.AddRange(new object[] {
            "All",
            "waiting to process"});
            this.cborder_status.Location = new System.Drawing.Point(767, 63);
            this.cborder_status.Name = "cborder_status";
            this.cborder_status.Size = new System.Drawing.Size(204, 32);
            this.cborder_status.TabIndex = 2;
            this.cborder_status.SelectedIndexChanged += new System.EventHandler(this.cborder_status_SelectedIndexChanged);
            // 
            // dvgorder_request
            // 
            this.dvgorder_request.AllowUserToAddRows = false;
            this.dvgorder_request.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgorder_request.Location = new System.Drawing.Point(81, 108);
            this.dvgorder_request.Name = "dvgorder_request";
            this.dvgorder_request.RowTemplate.Height = 24;
            this.dvgorder_request.Size = new System.Drawing.Size(890, 403);
            this.dvgorder_request.TabIndex = 3;
            this.dvgorder_request.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgorder_request_CellContentClick);
            // 
            // Dispatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1025, 679);
            this.Controls.Add(this.dvgorder_request);
            this.Controls.Add(this.cborder_status);
            this.Controls.Add(this.lblorder_id);
            this.Controls.Add(this.Order_idfilter);
            this.Name = "Dispatch";
            this.Text = "Dispatch";
            this.Load += new System.EventHandler(this.Dispatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgorder_request)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Order_idfilter;
        private System.Windows.Forms.Label lblorder_id;
        private System.Windows.Forms.ComboBox cborder_status;
        private System.Windows.Forms.DataGridView dvgorder_request;
    }
}