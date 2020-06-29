namespace Attendance
{
    partial class frm_Emp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Emp));
            this.grbx_Controls = new System.Windows.Forms.GroupBox();
            this.btn_Logo = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.grbx_Details = new System.Windows.Forms.GroupBox();
            this.btn_Delete_Device = new System.Windows.Forms.Button();
            this.btn_Delete_Sec = new System.Windows.Forms.Button();
            this.btn_Delete_Depart = new System.Windows.Forms.Button();
            this.btn_Add_Device = new System.Windows.Forms.Button();
            this.btn_Add_Sec = new System.Windows.Forms.Button();
            this.btn_Add_Depart = new System.Windows.Forms.Button();
            this.btn_Add_WS = new System.Windows.Forms.Button();
            this.com_Depart = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.com_Sec = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_EmpID = new System.Windows.Forms.TextBox();
            this.com_WS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.com_Device = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_EmpName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_EmpID2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbx_Grid = new System.Windows.Forms.GroupBox();
            this.dgv_Emp = new System.Windows.Forms.DataGridView();
            this.Emp_ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbx_Controls.SuspendLayout();
            this.grbx_Details.SuspendLayout();
            this.grbx_Grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Emp)).BeginInit();
            this.SuspendLayout();
            // 
            // grbx_Controls
            // 
            this.grbx_Controls.Controls.Add(this.btn_Logo);
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
            // btn_Logo
            // 
            this.btn_Logo.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Logo.FlatAppearance.BorderSize = 0;
            this.btn_Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logo.Image = global::Attendance.Properties.Resources.Emp_64;
            this.btn_Logo.Location = new System.Drawing.Point(697, 18);
            this.btn_Logo.Name = "btn_Logo";
            this.btn_Logo.Size = new System.Drawing.Size(75, 75);
            this.btn_Logo.TabIndex = 5;
            this.btn_Logo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Logo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Logo.UseVisualStyleBackColor = false;
            this.btn_Logo.Click += new System.EventHandler(this.btn_Logo_Click);
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
            this.grbx_Details.Controls.Add(this.btn_Delete_Device);
            this.grbx_Details.Controls.Add(this.btn_Delete_Sec);
            this.grbx_Details.Controls.Add(this.btn_Delete_Depart);
            this.grbx_Details.Controls.Add(this.btn_Add_Device);
            this.grbx_Details.Controls.Add(this.btn_Add_Sec);
            this.grbx_Details.Controls.Add(this.btn_Add_Depart);
            this.grbx_Details.Controls.Add(this.btn_Add_WS);
            this.grbx_Details.Controls.Add(this.com_Depart);
            this.grbx_Details.Controls.Add(this.label7);
            this.grbx_Details.Controls.Add(this.com_Sec);
            this.grbx_Details.Controls.Add(this.label6);
            this.grbx_Details.Controls.Add(this.label5);
            this.grbx_Details.Controls.Add(this.txt_EmpID);
            this.grbx_Details.Controls.Add(this.com_WS);
            this.grbx_Details.Controls.Add(this.label4);
            this.grbx_Details.Controls.Add(this.com_Device);
            this.grbx_Details.Controls.Add(this.label3);
            this.grbx_Details.Controls.Add(this.txt_EmpName);
            this.grbx_Details.Controls.Add(this.label2);
            this.grbx_Details.Controls.Add(this.txt_EmpID2);
            this.grbx_Details.Controls.Add(this.label1);
            this.grbx_Details.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbx_Details.Location = new System.Drawing.Point(0, 106);
            this.grbx_Details.Name = "grbx_Details";
            this.grbx_Details.Size = new System.Drawing.Size(488, 455);
            this.grbx_Details.TabIndex = 1;
            this.grbx_Details.TabStop = false;
            // 
            // btn_Delete_Device
            // 
            this.btn_Delete_Device.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Delete_Device.FlatAppearance.BorderSize = 0;
            this.btn_Delete_Device.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete_Device.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_Device.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Delete_Device.Location = new System.Drawing.Point(28, 301);
            this.btn_Delete_Device.Name = "btn_Delete_Device";
            this.btn_Delete_Device.Size = new System.Drawing.Size(24, 24);
            this.btn_Delete_Device.TabIndex = 20;
            this.btn_Delete_Device.Text = "x";
            this.btn_Delete_Device.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Delete_Device.UseVisualStyleBackColor = false;
            this.btn_Delete_Device.Visible = false;
            this.btn_Delete_Device.Click += new System.EventHandler(this.btn_Delete_Device_Click);
            // 
            // btn_Delete_Sec
            // 
            this.btn_Delete_Sec.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Delete_Sec.FlatAppearance.BorderSize = 0;
            this.btn_Delete_Sec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete_Sec.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_Sec.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Delete_Sec.Location = new System.Drawing.Point(28, 274);
            this.btn_Delete_Sec.Name = "btn_Delete_Sec";
            this.btn_Delete_Sec.Size = new System.Drawing.Size(24, 24);
            this.btn_Delete_Sec.TabIndex = 19;
            this.btn_Delete_Sec.Text = "x";
            this.btn_Delete_Sec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Delete_Sec.UseVisualStyleBackColor = false;
            this.btn_Delete_Sec.Visible = false;
            this.btn_Delete_Sec.Click += new System.EventHandler(this.btn_Delete_Sec_Click);
            // 
            // btn_Delete_Depart
            // 
            this.btn_Delete_Depart.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Delete_Depart.FlatAppearance.BorderSize = 0;
            this.btn_Delete_Depart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete_Depart.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_Depart.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Delete_Depart.Location = new System.Drawing.Point(28, 247);
            this.btn_Delete_Depart.Name = "btn_Delete_Depart";
            this.btn_Delete_Depart.Size = new System.Drawing.Size(24, 24);
            this.btn_Delete_Depart.TabIndex = 18;
            this.btn_Delete_Depart.Text = "x";
            this.btn_Delete_Depart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Delete_Depart.UseVisualStyleBackColor = false;
            this.btn_Delete_Depart.Visible = false;
            this.btn_Delete_Depart.Click += new System.EventHandler(this.btn_Delete_Depart_Click);
            // 
            // btn_Add_Device
            // 
            this.btn_Add_Device.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Add_Device.FlatAppearance.BorderSize = 0;
            this.btn_Add_Device.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_Device.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Device.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Add_Device.Location = new System.Drawing.Point(58, 301);
            this.btn_Add_Device.Name = "btn_Add_Device";
            this.btn_Add_Device.Size = new System.Drawing.Size(24, 24);
            this.btn_Add_Device.TabIndex = 16;
            this.btn_Add_Device.Text = "+";
            this.btn_Add_Device.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Add_Device.UseVisualStyleBackColor = false;
            this.btn_Add_Device.Visible = false;
            this.btn_Add_Device.Click += new System.EventHandler(this.btn_Add_Device_Click);
            // 
            // btn_Add_Sec
            // 
            this.btn_Add_Sec.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Add_Sec.FlatAppearance.BorderSize = 0;
            this.btn_Add_Sec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_Sec.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Sec.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Add_Sec.Location = new System.Drawing.Point(58, 274);
            this.btn_Add_Sec.Name = "btn_Add_Sec";
            this.btn_Add_Sec.Size = new System.Drawing.Size(24, 24);
            this.btn_Add_Sec.TabIndex = 15;
            this.btn_Add_Sec.Text = "+";
            this.btn_Add_Sec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Add_Sec.UseVisualStyleBackColor = false;
            this.btn_Add_Sec.Visible = false;
            this.btn_Add_Sec.Click += new System.EventHandler(this.btn_Add_Sec_Click);
            // 
            // btn_Add_Depart
            // 
            this.btn_Add_Depart.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Add_Depart.FlatAppearance.BorderSize = 0;
            this.btn_Add_Depart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_Depart.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Depart.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Add_Depart.Location = new System.Drawing.Point(58, 247);
            this.btn_Add_Depart.Name = "btn_Add_Depart";
            this.btn_Add_Depart.Size = new System.Drawing.Size(24, 24);
            this.btn_Add_Depart.TabIndex = 14;
            this.btn_Add_Depart.Text = "+";
            this.btn_Add_Depart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Add_Depart.UseVisualStyleBackColor = false;
            this.btn_Add_Depart.Visible = false;
            this.btn_Add_Depart.Click += new System.EventHandler(this.btn_Add_Depart_Click);
            // 
            // btn_Add_WS
            // 
            this.btn_Add_WS.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Add_WS.FlatAppearance.BorderSize = 0;
            this.btn_Add_WS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_WS.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_WS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Add_WS.Location = new System.Drawing.Point(58, 220);
            this.btn_Add_WS.Name = "btn_Add_WS";
            this.btn_Add_WS.Size = new System.Drawing.Size(24, 24);
            this.btn_Add_WS.TabIndex = 13;
            this.btn_Add_WS.Text = "+";
            this.btn_Add_WS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Add_WS.UseVisualStyleBackColor = false;
            this.btn_Add_WS.Visible = false;
            this.btn_Add_WS.Click += new System.EventHandler(this.btn_Add_WS_Click);
            // 
            // com_Depart
            // 
            this.com_Depart.DisplayMember = "Name";
            this.com_Depart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Depart.Enabled = false;
            this.com_Depart.FormattingEnabled = true;
            this.com_Depart.Location = new System.Drawing.Point(88, 247);
            this.com_Depart.Name = "com_Depart";
            this.com_Depart.Size = new System.Drawing.Size(268, 24);
            this.com_Depart.TabIndex = 3;
            this.com_Depart.ValueMember = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "الإدارة";
            // 
            // com_Sec
            // 
            this.com_Sec.DisplayMember = "Name";
            this.com_Sec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Sec.Enabled = false;
            this.com_Sec.FormattingEnabled = true;
            this.com_Sec.Location = new System.Drawing.Point(88, 274);
            this.com_Sec.Name = "com_Sec";
            this.com_Sec.Size = new System.Drawing.Size(268, 24);
            this.com_Sec.TabIndex = 4;
            this.com_Sec.ValueMember = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "القسم";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "مسلسل";
            // 
            // txt_EmpID
            // 
            this.txt_EmpID.Location = new System.Drawing.Point(272, 36);
            this.txt_EmpID.Name = "txt_EmpID";
            this.txt_EmpID.ReadOnly = true;
            this.txt_EmpID.Size = new System.Drawing.Size(84, 24);
            this.txt_EmpID.TabIndex = 8;
            // 
            // com_WS
            // 
            this.com_WS.DisplayMember = "Name";
            this.com_WS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_WS.Enabled = false;
            this.com_WS.FormattingEnabled = true;
            this.com_WS.Location = new System.Drawing.Point(88, 220);
            this.com_WS.Name = "com_WS";
            this.com_WS.Size = new System.Drawing.Size(268, 24);
            this.com_WS.TabIndex = 2;
            this.com_WS.ValueMember = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "نظام الدوام";
            // 
            // com_Device
            // 
            this.com_Device.DisplayMember = "Name";
            this.com_Device.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Device.Enabled = false;
            this.com_Device.FormattingEnabled = true;
            this.com_Device.Location = new System.Drawing.Point(88, 301);
            this.com_Device.Name = "com_Device";
            this.com_Device.Size = new System.Drawing.Size(268, 24);
            this.com_Device.TabIndex = 5;
            this.com_Device.ValueMember = "ID2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "ماكينة البصمة";
            // 
            // txt_EmpName
            // 
            this.txt_EmpName.Location = new System.Drawing.Point(88, 129);
            this.txt_EmpName.Name = "txt_EmpName";
            this.txt_EmpName.ReadOnly = true;
            this.txt_EmpName.Size = new System.Drawing.Size(268, 24);
            this.txt_EmpName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "أسم الموظف";
            // 
            // txt_EmpID2
            // 
            this.txt_EmpID2.Location = new System.Drawing.Point(184, 102);
            this.txt_EmpID2.Name = "txt_EmpID2";
            this.txt_EmpID2.ReadOnly = true;
            this.txt_EmpID2.Size = new System.Drawing.Size(172, 24);
            this.txt_EmpID2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "كود الموظف";
            // 
            // grbx_Grid
            // 
            this.grbx_Grid.Controls.Add(this.dgv_Emp);
            this.grbx_Grid.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbx_Grid.Location = new System.Drawing.Point(494, 106);
            this.grbx_Grid.Name = "grbx_Grid";
            this.grbx_Grid.Size = new System.Drawing.Size(290, 455);
            this.grbx_Grid.TabIndex = 2;
            this.grbx_Grid.TabStop = false;
            // 
            // dgv_Emp
            // 
            this.dgv_Emp.AllowUserToAddRows = false;
            this.dgv_Emp.AllowUserToDeleteRows = false;
            this.dgv_Emp.AllowUserToOrderColumns = true;
            this.dgv_Emp.AllowUserToResizeColumns = false;
            this.dgv_Emp.AllowUserToResizeRows = false;
            this.dgv_Emp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Emp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Emp_ID2,
            this.Emp_Name});
            this.dgv_Emp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Emp.Location = new System.Drawing.Point(3, 20);
            this.dgv_Emp.MultiSelect = false;
            this.dgv_Emp.Name = "dgv_Emp";
            this.dgv_Emp.ReadOnly = true;
            this.dgv_Emp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Emp.Size = new System.Drawing.Size(284, 432);
            this.dgv_Emp.TabIndex = 0;
            this.dgv_Emp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Users_CellClick);
            // 
            // Emp_ID2
            // 
            this.Emp_ID2.DataPropertyName = "ID2";
            this.Emp_ID2.FillWeight = 76.14214F;
            this.Emp_ID2.HeaderText = "الكود";
            this.Emp_ID2.Name = "Emp_ID2";
            this.Emp_ID2.ReadOnly = true;
            // 
            // Emp_Name
            // 
            this.Emp_Name.DataPropertyName = "Name";
            this.Emp_Name.FillWeight = 123.8579F;
            this.Emp_Name.HeaderText = "الأسم";
            this.Emp_Name.Name = "Emp_Name";
            this.Emp_Name.ReadOnly = true;
            // 
            // frm_Emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.grbx_Grid);
            this.Controls.Add(this.grbx_Details);
            this.Controls.Add(this.grbx_Controls);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Emp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الموظفين";
            this.Shown += new System.EventHandler(this.frm_Users_Shown);
            this.grbx_Controls.ResumeLayout(false);
            this.grbx_Details.ResumeLayout(false);
            this.grbx_Details.PerformLayout();
            this.grbx_Grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Emp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_Controls;
        private System.Windows.Forms.GroupBox grbx_Details;
        private System.Windows.Forms.GroupBox grbx_Grid;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.DataGridView dgv_Emp;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox com_WS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox com_Device;
        private System.Windows.Forms.TextBox txt_EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_ID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox com_Depart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox com_Sec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Add_Device;
        private System.Windows.Forms.Button btn_Add_Sec;
        private System.Windows.Forms.Button btn_Add_Depart;
        private System.Windows.Forms.Button btn_Add_WS;
        private System.Windows.Forms.Button btn_Delete_Device;
        private System.Windows.Forms.Button btn_Delete_Sec;
        private System.Windows.Forms.Button btn_Delete_Depart;
        private System.Windows.Forms.Button btn_Logo;
        public System.Windows.Forms.TextBox txt_EmpID2;
        public System.Windows.Forms.TextBox txt_EmpName;
    }
}