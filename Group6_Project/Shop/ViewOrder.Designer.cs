namespace Group6_Project
{
    partial class ViewOrder
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
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.dvgvieworder_request = new System.Windows.Forms.DataGridView();
            this.lblsearchid = new System.Windows.Forms.Label();
            this.txtfilter = new Group6_Project.RoundTextBox();
            this.cbfilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgvieworder_request)).BeginInit();
            this.SuspendLayout();
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // dvgvieworder_request
            // 
            this.dvgvieworder_request.AllowUserToAddRows = false;
            this.dvgvieworder_request.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dvgvieworder_request.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgvieworder_request.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgvieworder_request.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgvieworder_request.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgvieworder_request.Location = new System.Drawing.Point(87, 132);
            this.dvgvieworder_request.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvgvieworder_request.Name = "dvgvieworder_request";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgvieworder_request.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgvieworder_request.RowTemplate.Height = 24;
            this.dvgvieworder_request.Size = new System.Drawing.Size(1245, 681);
            this.dvgvieworder_request.TabIndex = 1;
            this.dvgvieworder_request.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgvieworder_request_CellContentClick);
            // 
            // lblsearchid
            // 
            this.lblsearchid.AutoSize = true;
            this.lblsearchid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchid.ForeColor = System.Drawing.Color.White;
            this.lblsearchid.Location = new System.Drawing.Point(189, 61);
            this.lblsearchid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsearchid.Name = "lblsearchid";
            this.lblsearchid.Size = new System.Drawing.Size(176, 24);
            this.lblsearchid.TabIndex = 2;
            this.lblsearchid.Text = "Search by Order ID:";
            // 
            // txtfilter
            // 
            this.txtfilter.BackColor = System.Drawing.SystemColors.Window;
            this.txtfilter.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtfilter.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtfilter.BorderRadius = 0;
            this.txtfilter.BorderSize = 1;
            this.txtfilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfilter.ForeColor = System.Drawing.Color.DimGray;
            this.txtfilter.Location = new System.Drawing.Point(433, 58);
            this.txtfilter.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtfilter.Multiline = false;
            this.txtfilter.Name = "txtfilter";
            this.txtfilter.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtfilter.PasswordChar = false;
            this.txtfilter.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtfilter.PlaceholderText = "";
            this.txtfilter.Size = new System.Drawing.Size(489, 37);
            this.txtfilter.TabIndex = 0;
            this.txtfilter.Texts = "";
            this.txtfilter.UnderlinedStyle = false;
            // 
            // cbfilter
            // 
            this.cbfilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbfilter.FormattingEnabled = true;
            this.cbfilter.Items.AddRange(new object[] {
            "All",
            "Waiting to Process",
            "Dispatched",
            "Delivering",
            "Complete Order"});
            this.cbfilter.Location = new System.Drawing.Point(1012, 58);
            this.cbfilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbfilter.Name = "cbfilter";
            this.cbfilter.Size = new System.Drawing.Size(284, 32);
            this.cbfilter.TabIndex = 3;
            this.cbfilter.SelectedIndexChanged += new System.EventHandler(this.cbfilter_SelectedIndexChanged);
            // 
            // ViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1388, 898);
            this.Controls.Add(this.cbfilter);
            this.Controls.Add(this.lblsearchid);
            this.Controls.Add(this.dvgvieworder_request);
            this.Controls.Add(this.txtfilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewOrder";
            this.Text = "ViewOrder";
            this.Load += new System.EventHandler(this.ViewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgvieworder_request)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundTextBox txtfilter;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.DataGridView dvgvieworder_request;
        private System.Windows.Forms.Label lblsearchid;
        private System.Windows.Forms.ComboBox cbfilter;
    }
}