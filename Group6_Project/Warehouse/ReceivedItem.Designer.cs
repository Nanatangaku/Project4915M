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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceivedItem));
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
            resources.ApplyResources(this.lbluserid, "lbluserid");
            this.lbluserid.ForeColor = System.Drawing.Color.White;
            this.lbluserid.Name = "lbluserid";
            // 
            // lblrole
            // 
            resources.ApplyResources(this.lblrole, "lblrole");
            this.lblrole.ForeColor = System.Drawing.Color.White;
            this.lblrole.Name = "lblrole";
            // 
            // txtboxuserid
            // 
            this.txtboxuserid.BackColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.txtboxuserid, "txtboxuserid");
            this.txtboxuserid.Name = "txtboxuserid";
            this.txtboxuserid.ReadOnly = true;
            // 
            // txtboxrole
            // 
            this.txtboxrole.BackColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.txtboxrole, "txtboxrole");
            this.txtboxrole.Name = "txtboxrole";
            this.txtboxrole.ReadOnly = true;
            // 
            // btnadd
            // 
            this.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnadd.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.btnadd, "btnadd");
            this.btnadd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnadd.Name = "btnadd";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnclear
            // 
            this.btnclear.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnclear.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.btnclear, "btnclear");
            this.btnclear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnclear.Name = "btnclear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lblitem
            // 
            resources.ApplyResources(this.lblitem, "lblitem");
            this.lblitem.ForeColor = System.Drawing.Color.White;
            this.lblitem.Name = "lblitem";
            // 
            // lblquantity
            // 
            resources.ApplyResources(this.lblquantity, "lblquantity");
            this.lblquantity.ForeColor = System.Drawing.Color.White;
            this.lblquantity.Name = "lblquantity";
            // 
            // txtboxquantity
            // 
            this.txtboxquantity.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.txtboxquantity, "txtboxquantity");
            this.txtboxquantity.Name = "txtboxquantity";
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
            resources.ApplyResources(this.dvgpreadditem, "dvgpreadditem");
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
            this.dvgpreadditem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgpreadditem_CellContentClick);
            // 
            // cbitem
            // 
            resources.ApplyResources(this.cbitem, "cbitem");
            this.cbitem.FormattingEnabled = true;
            this.cbitem.Name = "cbitem";
            this.cbitem.SelectedIndexChanged += new System.EventHandler(this.cbitem_SelectedIndexChanged);
            // 
            // btnconfirm
            // 
            this.btnconfirm.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnconfirm.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.btnconfirm, "btnconfirm");
            this.btnconfirm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnconfirm.Name = "btnconfirm";
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
            resources.ApplyResources(this.gbinput, "gbinput");
            this.gbinput.ForeColor = System.Drawing.Color.White;
            this.gbinput.Name = "gbinput";
            this.gbinput.TabStop = false;
            // 
            // ReceivedItem
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.dvgpreadditem);
            this.Controls.Add(this.gbinput);
            this.Controls.Add(this.btnconfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceivedItem";
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