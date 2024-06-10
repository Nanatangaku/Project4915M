namespace Group6_Project
{
    partial class ReceivedItem
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
            this.lbluserid = new System.Windows.Forms.Label();
            this.lblrole = new System.Windows.Forms.Label();
            this.txtboxuserid = new System.Windows.Forms.TextBox();
            this.txtboxrole = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.lblitem = new System.Windows.Forms.Label();
            this.lblquantity = new System.Windows.Forms.Label();
            this.txtboxquantity = new System.Windows.Forms.TextBox();
            this.dvgpreadditem = new System.Windows.Forms.DataGridView();
            this.cbitem = new System.Windows.Forms.ComboBox();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.gbinput = new System.Windows.Forms.GroupBox();
            this.gbreciveitem = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgpreadditem)).BeginInit();
            this.gbinput.SuspendLayout();
            this.gbreciveitem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbluserid.ForeColor = System.Drawing.Color.White;
            this.lbluserid.Location = new System.Drawing.Point(64, 52);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(89, 24);
            this.lbluserid.TabIndex = 1;
            this.lbluserid.Text = "User ID:";
            // 
            // lblrole
            // 
            this.lblrole.AutoSize = true;
            this.lblrole.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblrole.ForeColor = System.Drawing.Color.White;
            this.lblrole.Location = new System.Drawing.Point(494, 43);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(58, 24);
            this.lblrole.TabIndex = 2;
            this.lblrole.Text = "Role:";
            // 
            // txtboxuserid
            // 
            this.txtboxuserid.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxuserid.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtboxuserid.Location = new System.Drawing.Point(183, 40);
            this.txtboxuserid.Name = "txtboxuserid";
            this.txtboxuserid.ReadOnly = true;
            this.txtboxuserid.Size = new System.Drawing.Size(186, 36);
            this.txtboxuserid.TabIndex = 3;
            // 
            // txtboxrole
            // 
            this.txtboxrole.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxrole.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtboxrole.Location = new System.Drawing.Point(558, 40);
            this.txtboxrole.Name = "txtboxrole";
            this.txtboxrole.ReadOnly = true;
            this.txtboxrole.Size = new System.Drawing.Size(218, 36);
            this.txtboxrole.TabIndex = 4;
            // 
            // btnadd
            // 
            this.btnadd.ForeColor = System.Drawing.Color.Black;
            this.btnadd.Location = new System.Drawing.Point(183, 172);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(102, 34);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnclear
            // 
            this.btnclear.ForeColor = System.Drawing.Color.Black;
            this.btnclear.Location = new System.Drawing.Point(303, 172);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(102, 34);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lblitem
            // 
            this.lblitem.AutoSize = true;
            this.lblitem.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblitem.ForeColor = System.Drawing.Color.White;
            this.lblitem.Location = new System.Drawing.Point(73, 103);
            this.lblitem.Name = "lblitem";
            this.lblitem.Size = new System.Drawing.Size(58, 24);
            this.lblitem.TabIndex = 8;
            this.lblitem.Text = "Item:";
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblquantity.ForeColor = System.Drawing.Color.White;
            this.lblquantity.Location = new System.Drawing.Point(459, 103);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(93, 24);
            this.lblquantity.TabIndex = 9;
            this.lblquantity.Text = "Quantity:";
            // 
            // txtboxquantity
            // 
            this.txtboxquantity.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxquantity.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtboxquantity.Location = new System.Drawing.Point(558, 103);
            this.txtboxquantity.Name = "txtboxquantity";
            this.txtboxquantity.Size = new System.Drawing.Size(79, 36);
            this.txtboxquantity.TabIndex = 10;
            // 
            // dvgpreadditem
            // 
            this.dvgpreadditem.AllowUserToAddRows = false;
            this.dvgpreadditem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgpreadditem.Location = new System.Drawing.Point(15, 27);
            this.dvgpreadditem.Name = "dvgpreadditem";
            this.dvgpreadditem.RowTemplate.Height = 24;
            this.dvgpreadditem.Size = new System.Drawing.Size(869, 264);
            this.dvgpreadditem.TabIndex = 11;
            // 
            // cbitem
            // 
            this.cbitem.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbitem.FormattingEnabled = true;
            this.cbitem.Location = new System.Drawing.Point(183, 103);
            this.cbitem.Name = "cbitem";
            this.cbitem.Size = new System.Drawing.Size(186, 32);
            this.cbitem.TabIndex = 12;
            this.cbitem.SelectedIndexChanged += new System.EventHandler(this.cbitem_SelectedIndexChanged);
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(828, 625);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(136, 42);
            this.btnconfirm.TabIndex = 13;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // gbinput
            // 
            this.gbinput.Controls.Add(this.lbluserid);
            this.gbinput.Controls.Add(this.txtboxuserid);
            this.gbinput.Controls.Add(this.cbitem);
            this.gbinput.Controls.Add(this.txtboxquantity);
            this.gbinput.Controls.Add(this.lblitem);
            this.gbinput.Controls.Add(this.lblquantity);
            this.gbinput.Controls.Add(this.btnadd);
            this.gbinput.Controls.Add(this.txtboxrole);
            this.gbinput.Controls.Add(this.btnclear);
            this.gbinput.Controls.Add(this.lblrole);
            this.gbinput.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbinput.ForeColor = System.Drawing.Color.White;
            this.gbinput.Location = new System.Drawing.Point(74, 48);
            this.gbinput.Name = "gbinput";
            this.gbinput.Size = new System.Drawing.Size(890, 247);
            this.gbinput.TabIndex = 14;
            this.gbinput.TabStop = false;
            this.gbinput.Text = "Input";
            // 
            // gbreciveitem
            // 
            this.gbreciveitem.Controls.Add(this.dvgpreadditem);
            this.gbreciveitem.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbreciveitem.ForeColor = System.Drawing.Color.White;
            this.gbreciveitem.Location = new System.Drawing.Point(74, 301);
            this.gbreciveitem.Name = "gbreciveitem";
            this.gbreciveitem.Size = new System.Drawing.Size(890, 306);
            this.gbreciveitem.TabIndex = 15;
            this.gbreciveitem.TabStop = false;
            this.gbreciveitem.Text = "Receive Item";
            // 
            // ReceivedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1025, 679);
            this.Controls.Add(this.gbreciveitem);
            this.Controls.Add(this.gbinput);
            this.Controls.Add(this.btnconfirm);
            this.Name = "ReceivedItem";
            this.Text = "ReceivedItem";
            this.Load += new System.EventHandler(this.ReceivedItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgpreadditem)).EndInit();
            this.gbinput.ResumeLayout(false);
            this.gbinput.PerformLayout();
            this.gbreciveitem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbluserid;
        private System.Windows.Forms.Label lblrole;
        private System.Windows.Forms.TextBox txtboxuserid;
        private System.Windows.Forms.TextBox txtboxrole;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label lblitem;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.TextBox txtboxquantity;
        private System.Windows.Forms.DataGridView dvgpreadditem;
        private System.Windows.Forms.ComboBox cbitem;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.GroupBox gbinput;
        private System.Windows.Forms.GroupBox gbreciveitem;
    }
}