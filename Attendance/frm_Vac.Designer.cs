namespace Attendance.Resources
{
    partial class frm_Vac
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
            this.grbx_Controls = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.grbx_Details = new System.Windows.Forms.GroupBox();
            this.txt_VacName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbx_Grid = new System.Windows.Forms.GroupBox();
            this.dgv_Vac = new System.Windows.Forms.DataGridView();
            this.Vac_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vac_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.com_MM = new System.Windows.Forms.ComboBox();
            this.com_dd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grbx_Controls.SuspendLayout();
            this.grbx_Details.SuspendLayout();
            this.grbx_Grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vac)).BeginInit();
            this.SuspendLayout();
            // 
            // grbx_Controls
            // 
            this.grbx_Controls.Controls.Add(this.button1);
            this.grbx_Controls.Controls.Add(this.btn_Save);
            this.grbx_Controls.Controls.Add(this.btn_Cancel);
            this.grbx_Controls.Controls.Add(this.btn_Delete);
            this.grbx_Controls.Controls.Add(this.btn_Edit);
            this.grbx_Controls.Controls.Add(this.btn_New);
            this.grbx_Controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbx_Controls.Location = new System.Drawing.Point(0, 0);
            this.grbx_Controls.Name = "grbx_Controls";
            this.grbx_Controls.Size = new System.Drawing.Size(784, 106);
            this.grbx_Controls.TabIndex = 0;
            this.grbx_Controls.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Attendance.Properties.Resources.Depart_64;
            this.button1.Location = new System.Drawing.Point(697, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 5;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Image = global::Attendance.Properties.Resources.save_48;
            this.btn_Save.Location = new System.Drawing.Point(357, 18);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 75);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Image = global::Attendance.Properties.Resources.cancel_48;
            this.btn_Cancel.Location = new System.Drawing.Point(195, 18);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 75);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "تراجع";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Visible = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Image = global::Attendance.Properties.Resources.delete_48;
            this.btn_Delete.Location = new System.Drawing.Point(276, 18);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 75);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Visible = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Image = global::Attendance.Properties.Resources.edit_48;
            this.btn_Edit.Location = new System.Drawing.Point(438, 18);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 75);
            this.btn_Edit.TabIndex = 1;
            this.btn_Edit.Text = "تعديل";
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Visible = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.SystemColors.Control;
            this.btn_New.FlatAppearance.BorderSize = 0;
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New.Image = global::Attendance.Properties.Resources.new_48;
            this.btn_New.Location = new System.Drawing.Point(519, 18);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 75);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "جديد";
            this.btn_New.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_New.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // grbx_Details
            // 
            this.grbx_Details.Controls.Add(this.com_dd);
            this.grbx_Details.Controls.Add(this.label4);
            this.grbx_Details.Controls.Add(this.com_MM);
            this.grbx_Details.Controls.Add(this.label3);
            this.grbx_Details.Controls.Add(this.txt_VacName);
            this.grbx_Details.Controls.Add(this.label2);
            this.grbx_Details.Controls.Add(this.txt_ID);
            this.grbx_Details.Controls.Add(this.label1);
            this.grbx_Details.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbx_Details.Location = new System.Drawing.Point(0, 106);
            this.grbx_Details.Name = "grbx_Details";
            this.grbx_Details.Size = new System.Drawing.Size(488, 455);
            this.grbx_Details.TabIndex = 1;
            this.grbx_Details.TabStop = false;
            // 
            // txt_VacName
            // 
            this.txt_VacName.Location = new System.Drawing.Point(88, 132);
            this.txt_VacName.Name = "txt_VacName";
            this.txt_VacName.ReadOnly = true;
            this.txt_VacName.Size = new System.Drawing.Size(268, 24);
            this.txt_VacName.TabIndex = 3;
            this.txt_VacName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "أسم الأجازة";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(256, 66);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(100, 24);
            this.txt_ID.TabIndex = 1;
            this.txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "كود الأجازة";
            // 
            // grbx_Grid
            // 
            this.grbx_Grid.Controls.Add(this.dgv_Vac);
            this.grbx_Grid.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbx_Grid.Location = new System.Drawing.Point(494, 106);
            this.grbx_Grid.Name = "grbx_Grid";
            this.grbx_Grid.Size = new System.Drawing.Size(290, 455);
            this.grbx_Grid.TabIndex = 2;
            this.grbx_Grid.TabStop = false;
            // 
            // dgv_Vac
            // 
            this.dgv_Vac.AllowUserToAddRows = false;
            this.dgv_Vac.AllowUserToDeleteRows = false;
            this.dgv_Vac.AllowUserToOrderColumns = true;
            this.dgv_Vac.AllowUserToResizeColumns = false;
            this.dgv_Vac.AllowUserToResizeRows = false;
            this.dgv_Vac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Vac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Vac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vac_ID,
            this.Vac_Name});
            this.dgv_Vac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Vac.Location = new System.Drawing.Point(3, 20);
            this.dgv_Vac.MultiSelect = false;
            this.dgv_Vac.Name = "dgv_Vac";
            this.dgv_Vac.ReadOnly = true;
            this.dgv_Vac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Vac.Size = new System.Drawing.Size(284, 432);
            this.dgv_Vac.TabIndex = 0;
            this.dgv_Vac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Vac_CellClick);
            // 
            // Vac_ID
            // 
            this.Vac_ID.DataPropertyName = "ID";
            this.Vac_ID.FillWeight = 76.14214F;
            this.Vac_ID.HeaderText = "الكود";
            this.Vac_ID.Name = "Vac_ID";
            this.Vac_ID.ReadOnly = true;
            // 
            // Vac_Name
            // 
            this.Vac_Name.DataPropertyName = "Name";
            this.Vac_Name.FillWeight = 123.8579F;
            this.Vac_Name.HeaderText = "الأسم";
            this.Vac_Name.Name = "Vac_Name";
            this.Vac_Name.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "الشهر";
            // 
            // com_MM
            // 
            this.com_MM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_MM.FormattingEnabled = true;
            this.com_MM.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.com_MM.Location = new System.Drawing.Point(286, 181);
            this.com_MM.Name = "com_MM";
            this.com_MM.Size = new System.Drawing.Size(70, 24);
            this.com_MM.TabIndex = 6;
            // 
            // com_dd
            // 
            this.com_dd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_dd.FormattingEnabled = true;
            this.com_dd.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.com_dd.Location = new System.Drawing.Point(88, 181);
            this.com_dd.Name = "com_dd";
            this.com_dd.Size = new System.Drawing.Size(70, 24);
            this.com_dd.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "اليوم";
            // 
            // frm_Vac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.grbx_Grid);
            this.Controls.Add(this.grbx_Details);
            this.Controls.Add(this.grbx_Controls);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Vac";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الأجازات";
            this.Shown += new System.EventHandler(this.frm_Vac_Shown);
            this.grbx_Controls.ResumeLayout(false);
            this.grbx_Details.ResumeLayout(false);
            this.grbx_Details.PerformLayout();
            this.grbx_Grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_Controls;
        private System.Windows.Forms.GroupBox grbx_Details;
        private System.Windows.Forms.GroupBox grbx_Grid;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.DataGridView dgv_Vac;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.TextBox txt_VacName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vac_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vac_Name;
        private System.Windows.Forms.Button btn_Save;
        public System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox com_dd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox com_MM;
        private System.Windows.Forms.Label label3;
    }
}