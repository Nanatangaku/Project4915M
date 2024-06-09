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
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.dvgvieworder_request = new System.Windows.Forms.DataGridView();
            this.txtfilter = new Group6_Project.RoundTextBox();
            this.lblsearchname = new System.Windows.Forms.Label();
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
            this.dvgvieworder_request.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgvieworder_request.Location = new System.Drawing.Point(80, 109);
            this.dvgvieworder_request.Name = "dvgvieworder_request";
            this.dvgvieworder_request.RowTemplate.Height = 24;
            this.dvgvieworder_request.Size = new System.Drawing.Size(863, 493);
            this.dvgvieworder_request.TabIndex = 1;
            this.dvgvieworder_request.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgvieworder_request_CellContentClick);
            // 
            // txtfilter
            // 
            this.txtfilter.BackColor = System.Drawing.SystemColors.Window;
            this.txtfilter.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtfilter.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtfilter.BorderRadius = 0;
            this.txtfilter.BorderSize = 2;
            this.txtfilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfilter.ForeColor = System.Drawing.Color.DimGray;
            this.txtfilter.Location = new System.Drawing.Point(274, 50);
            this.txtfilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtfilter.Multiline = false;
            this.txtfilter.Name = "txtfilter";
            this.txtfilter.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtfilter.PasswordChar = false;
            this.txtfilter.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtfilter.PlaceholderText = "name";
            this.txtfilter.Size = new System.Drawing.Size(261, 31);
            this.txtfilter.TabIndex = 0;
            this.txtfilter.Texts = "";
            this.txtfilter.UnderlinedStyle = false;
            // 
            // lblsearchname
            // 
            this.lblsearchname.AutoSize = true;
            this.lblsearchname.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblsearchname.Location = new System.Drawing.Point(80, 50);
            this.lblsearchname.Name = "lblsearchname";
            this.lblsearchname.Size = new System.Drawing.Size(166, 24);
            this.lblsearchname.TabIndex = 2;
            this.lblsearchname.Text = "Search by Name:";
            // 
            // ViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1301, 709);
            this.Controls.Add(this.lblsearchname);
            this.Controls.Add(this.dvgvieworder_request);
            this.Controls.Add(this.txtfilter);
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
        private System.Windows.Forms.Label lblsearchname;
    }
}