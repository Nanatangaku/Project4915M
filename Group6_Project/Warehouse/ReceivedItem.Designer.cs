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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.dvgpreadditem)).BeginInit();
            this.gbinput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserid.ForeColor = System.Drawing.Color.White;
            this.lbluserid.Location = new System.Drawing.Point(68, 46);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(76, 24);
            this.lbluserid.TabIndex = 1;
            this.lbluserid.Text = "User ID:";
            // 
            // lblrole
            // 
            this.lblrole.AutoSize = true;
            this.lblrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrole.ForeColor = System.Drawing.Color.White;
            this.lblrole.Location = new System.Drawing.Point(446, 46);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(54, 24);
            this.lblrole.TabIndex = 2;
            this.lblrole.Text = "Role:";
            // 
            // txtboxuserid
            // 
            this.txtboxuserid.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxuserid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxuserid.Location = new System.Drawing.Point(162, 44);
            this.txtboxuserid.Name = "txtboxuserid";
            this.txtboxuserid.ReadOnly = true;
            this.txtboxuserid.Size = new System.Drawing.Size(222, 29);
            this.txtboxuserid.TabIndex = 3;
            // 
            // txtboxrole
            // 
            this.txtboxrole.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxrole.Location = new System.Drawing.Point(506, 44);
            this.txtboxrole.Name = "txtboxrole";
            this.txtboxrole.ReadOnly = true;
            this.txtboxrole.Size = new System.Drawing.Size(218, 29);
            this.txtboxrole.TabIndex = 4;
            // 
            // btnadd
            // 
            this.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnadd.FlatAppearance.BorderSize = 2;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnadd.Location = new System.Drawing.Point(485, 170);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(102, 34);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnclear
            // 
            this.btnclear.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnclear.FlatAppearance.BorderSize = 2;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnclear.Location = new System.Drawing.Point(622, 170);
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
            this.lblitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitem.ForeColor = System.Drawing.Color.White;
            this.lblitem.Location = new System.Drawing.Point(94, 99);
            this.lblitem.Name = "lblitem";
            this.lblitem.Size = new System.Drawing.Size(50, 24);
            this.lblitem.TabIndex = 8;
            this.lblitem.Text = "Item:";
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantity.ForeColor = System.Drawing.Color.White;
            this.lblquantity.Location = new System.Drawing.Point(417, 102);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(83, 24);
            this.lblquantity.TabIndex = 9;
            this.lblquantity.Text = "Quantity:";
            // 
            // txtboxquantity
            // 
            this.txtboxquantity.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxquantity.Location = new System.Drawing.Point(506, 99);
            this.txtboxquantity.Name = "txtboxquantity";
            this.txtboxquantity.Size = new System.Drawing.Size(218, 29);
            this.txtboxquantity.TabIndex = 10;
            // 
            // dvgpreadditem
            // 
            this.dvgpreadditem.AllowUserToAddRows = false;
            this.dvgpreadditem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dvgpreadditem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgpreadditem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgpreadditem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgpreadditem.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgpreadditem.Location = new System.Drawing.Point(93, 275);
            this.dvgpreadditem.Name = "dvgpreadditem";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgpreadditem.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgpreadditem.RowTemplate.Height = 24;
            this.dvgpreadditem.Size = new System.Drawing.Size(873, 334);
            this.dvgpreadditem.TabIndex = 11;
            // 
            // cbitem
            // 
            this.cbitem.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbitem.FormattingEnabled = true;
            this.cbitem.Location = new System.Drawing.Point(162, 96);
            this.cbitem.Name = "cbitem";
            this.cbitem.Size = new System.Drawing.Size(222, 32);
            this.cbitem.TabIndex = 12;
            this.cbitem.SelectedIndexChanged += new System.EventHandler(this.cbitem_SelectedIndexChanged);
            // 
            // btnconfirm
            // 
            this.btnconfirm.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnconfirm.FlatAppearance.BorderSize = 2;
            this.btnconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnconfirm.Location = new System.Drawing.Point(821, 630);
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
            this.gbinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbinput.ForeColor = System.Drawing.Color.White;
            this.gbinput.Location = new System.Drawing.Point(139, 30);
            this.gbinput.Name = "gbinput";
            this.gbinput.Size = new System.Drawing.Size(784, 228);
            this.gbinput.TabIndex = 14;
            this.gbinput.TabStop = false;
            this.gbinput.Text = "Input";
            // 
            // ReceivedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1041, 718);
            this.Controls.Add(this.dvgpreadditem);
            this.Controls.Add(this.gbinput);
            this.Controls.Add(this.btnconfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceivedItem";
            this.Text = "ReceivedItem";
            this.Load += new System.EventHandler(this.ReceivedItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgpreadditem)).EndInit();
            this.gbinput.ResumeLayout(false);
            this.gbinput.PerformLayout();
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
    }
}