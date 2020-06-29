namespace Attendance
{
    partial class frm_Rep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Rep));
            this.DGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_WSShow = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.com_Sec = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.com_Depart = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.com_WS = new System.Windows.Forms.ComboBox();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_ExportTOExcel = new System.Windows.Forms.Button();
            this.btn_Att = new System.Windows.Forms.Button();
            this.btn_IO = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_To = new System.Windows.Forms.DateTimePicker();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.com_Emp = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV.Location = new System.Drawing.Point(0, 121);
            this.DGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGV.RowTemplate.Height = 30;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(1156, 547);
            this.DGV.TabIndex = 0;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            this.DGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellDoubleClick);
            this.DGV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DGV_DataError);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_WSShow);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.com_Sec);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.com_Depart);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.com_WS);
            this.panel1.Controls.Add(this.btn_Settings);
            this.panel1.Controls.Add(this.btn_Print);
            this.panel1.Controls.Add(this.btn_ExportTOExcel);
            this.panel1.Controls.Add(this.btn_Att);
            this.panel1.Controls.Add(this.btn_IO);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtp_To);
            this.panel1.Controls.Add(this.dtp_From);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.com_Emp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(1156, 121);
            this.panel1.TabIndex = 14;
            // 
            // btn_WSShow
            // 
            this.btn_WSShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_WSShow.FlatAppearance.BorderSize = 0;
            this.btn_WSShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WSShow.Image = global::Attendance.Properties.Resources.Search_16;
            this.btn_WSShow.Location = new System.Drawing.Point(618, 11);
            this.btn_WSShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_WSShow.Name = "btn_WSShow";
            this.btn_WSShow.Size = new System.Drawing.Size(25, 19);
            this.btn_WSShow.TabIndex = 32;
            this.btn_WSShow.UseVisualStyleBackColor = true;
            this.btn_WSShow.Click += new System.EventHandler(this.btn_WSShow_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(856, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "القسم";
            // 
            // com_Sec
            // 
            this.com_Sec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.com_Sec.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_Sec.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_Sec.DisplayMember = "Name";
            this.com_Sec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.com_Sec.Enabled = false;
            this.com_Sec.FormattingEnabled = true;
            this.com_Sec.Location = new System.Drawing.Point(647, 31);
            this.com_Sec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.com_Sec.Name = "com_Sec";
            this.com_Sec.Size = new System.Drawing.Size(204, 20);
            this.com_Sec.TabIndex = 30;
            this.com_Sec.ValueMember = "ID";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1096, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "الإدارة";
            // 
            // com_Depart
            // 
            this.com_Depart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.com_Depart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_Depart.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_Depart.DisplayMember = "Name";
            this.com_Depart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.com_Depart.Enabled = false;
            this.com_Depart.FormattingEnabled = true;
            this.com_Depart.Location = new System.Drawing.Point(926, 31);
            this.com_Depart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.com_Depart.Name = "com_Depart";
            this.com_Depart.Size = new System.Drawing.Size(165, 20);
            this.com_Depart.TabIndex = 28;
            this.com_Depart.ValueMember = "ID";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(856, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "نظام الدوام";
            // 
            // com_WS
            // 
            this.com_WS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.com_WS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_WS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_WS.DisplayMember = "Name";
            this.com_WS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_WS.FormattingEnabled = true;
            this.com_WS.Location = new System.Drawing.Point(647, 10);
            this.com_WS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.com_WS.Name = "com_WS";
            this.com_WS.Size = new System.Drawing.Size(204, 21);
            this.com_WS.TabIndex = 26;
            this.com_WS.ValueMember = "ID";
            // 
            // btn_Settings
            // 
            this.btn_Settings.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Image = global::Attendance.Properties.Resources.Settings2_64;
            this.btn_Settings.Location = new System.Drawing.Point(452, 0);
            this.btn_Settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(91, 121);
            this.btn_Settings.TabIndex = 24;
            this.btn_Settings.Text = "إعدادات";
            this.btn_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Print.FlatAppearance.BorderSize = 0;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Print.Image = global::Attendance.Properties.Resources.Print_64;
            this.btn_Print.Location = new System.Drawing.Point(353, 0);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(99, 121);
            this.btn_Print.TabIndex = 25;
            this.btn_Print.Text = "طباعة";
            this.btn_Print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_ExportTOExcel
            // 
            this.btn_ExportTOExcel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_ExportTOExcel.FlatAppearance.BorderSize = 0;
            this.btn_ExportTOExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportTOExcel.Image = global::Attendance.Properties.Resources.Excel_64;
            this.btn_ExportTOExcel.Location = new System.Drawing.Point(233, 0);
            this.btn_ExportTOExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ExportTOExcel.Name = "btn_ExportTOExcel";
            this.btn_ExportTOExcel.Size = new System.Drawing.Size(120, 121);
            this.btn_ExportTOExcel.TabIndex = 15;
            this.btn_ExportTOExcel.Text = "تصدير للإكسيل";
            this.btn_ExportTOExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ExportTOExcel.UseVisualStyleBackColor = true;
            this.btn_ExportTOExcel.Click += new System.EventHandler(this.btn_ExportTOExcel_Click);
            // 
            // btn_Att
            // 
            this.btn_Att.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Att.FlatAppearance.BorderSize = 0;
            this.btn_Att.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Att.Image = global::Attendance.Properties.Resources.Att2_64;
            this.btn_Att.Location = new System.Drawing.Point(104, 0);
            this.btn_Att.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Att.Name = "btn_Att";
            this.btn_Att.Size = new System.Drawing.Size(129, 121);
            this.btn_Att.TabIndex = 23;
            this.btn_Att.Text = "الحضور والإنصراف";
            this.btn_Att.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Att.UseVisualStyleBackColor = true;
            this.btn_Att.Click += new System.EventHandler(this.btn_Att_Click);
            // 
            // btn_IO
            // 
            this.btn_IO.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_IO.FlatAppearance.BorderSize = 0;
            this.btn_IO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IO.Image = global::Attendance.Properties.Resources.IO_64;
            this.btn_IO.Location = new System.Drawing.Point(0, 0);
            this.btn_IO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_IO.Name = "btn_IO";
            this.btn_IO.Size = new System.Drawing.Size(104, 121);
            this.btn_IO.TabIndex = 22;
            this.btn_IO.Text = "الحركات";
            this.btn_IO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_IO.UseVisualStyleBackColor = true;
            this.btn_IO.Click += new System.EventHandler(this.btn_IO_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1102, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "إلى";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1104, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "من";
            // 
            // dtp_To
            // 
            this.dtp_To.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_To.CustomFormat = "yyyy-MM-dd  hh:mm:ss tt";
            this.dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_To.Location = new System.Drawing.Point(927, 80);
            this.dtp_To.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.Size = new System.Drawing.Size(165, 20);
            this.dtp_To.TabIndex = 19;
            // 
            // dtp_From
            // 
            this.dtp_From.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_From.CustomFormat = "yyyy-MM-dd  hh:mm:ss tt";
            this.dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_From.Location = new System.Drawing.Point(926, 58);
            this.dtp_From.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(165, 20);
            this.dtp_From.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1096, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "الموظف";
            // 
            // com_Emp
            // 
            this.com_Emp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.com_Emp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_Emp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_Emp.DisplayMember = "Name";
            this.com_Emp.FormattingEnabled = true;
            this.com_Emp.Location = new System.Drawing.Point(926, 10);
            this.com_Emp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.com_Emp.Name = "com_Emp";
            this.com_Emp.Size = new System.Drawing.Size(165, 21);
            this.com_Emp.TabIndex = 16;
            this.com_Emp.ValueMember = "ID2";
            this.com_Emp.SelectedIndexChanged += new System.EventHandler(this.com_Emp_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 668);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1156, 20);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frm_Rep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 688);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Rep";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير الحضور واإنصراف";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.frm_Rep_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ExportTOExcel;
        private System.Windows.Forms.Button btn_Att;
        private System.Windows.Forms.Button btn_IO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_To;
        private System.Windows.Forms.DateTimePicker dtp_From;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox com_Emp;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox com_WS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox com_Sec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox com_Depart;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btn_WSShow;
    }
}

