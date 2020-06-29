namespace Attendance
{
    partial class frm_Device
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Device));
            this.grbx_Controls = new System.Windows.Forms.GroupBox();
            this.btn_Logo = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.grbx_Details = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_DeviceID = new System.Windows.Forms.TextBox();
            this.txt_DeviceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ID2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbx_Grid = new System.Windows.Forms.GroupBox();
            this.dgv_Device = new System.Windows.Forms.DataGridView();
            this.user_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grbx_Controls.SuspendLayout();
            this.grbx_Details.SuspendLayout();
            this.grbx_Grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Device)).BeginInit();
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
            this.btn_Logo.Image = global::Attendance.Properties.Resources.FingerPrint_64;
            this.btn_Logo.Location = new System.Drawing.Point(703, 18);
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
            this.grbx_Details.Controls.Add(this.txt_Port);
            this.grbx_Details.Controls.Add(this.label4);
            this.grbx_Details.Controls.Add(this.txt_IP);
            this.grbx_Details.Controls.Add(this.label5);
            this.grbx_Details.Controls.Add(this.label3);
            this.grbx_Details.Controls.Add(this.txt_DeviceID);
            this.grbx_Details.Controls.Add(this.txt_DeviceName);
            this.grbx_Details.Controls.Add(this.label2);
            this.grbx_Details.Controls.Add(this.txt_ID2);
            this.grbx_Details.Controls.Add(this.label1);
            this.grbx_Details.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbx_Details.Location = new System.Drawing.Point(0, 106);
            this.grbx_Details.Name = "grbx_Details";
            this.grbx_Details.Size = new System.Drawing.Size(488, 455);
            this.grbx_Details.TabIndex = 1;
            this.grbx_Details.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "مسلسل";
            // 
            // txt_DeviceID
            // 
            this.txt_DeviceID.Location = new System.Drawing.Point(256, 44);
            this.txt_DeviceID.Name = "txt_DeviceID";
            this.txt_DeviceID.ReadOnly = true;
            this.txt_DeviceID.Size = new System.Drawing.Size(100, 24);
            this.txt_DeviceID.TabIndex = 4;
            this.txt_DeviceID.TabStop = false;
            this.txt_DeviceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_DeviceName
            // 
            this.txt_DeviceName.Location = new System.Drawing.Point(88, 132);
            this.txt_DeviceName.Name = "txt_DeviceName";
            this.txt_DeviceName.ReadOnly = true;
            this.txt_DeviceName.Size = new System.Drawing.Size(268, 24);
            this.txt_DeviceName.TabIndex = 2;
            this.txt_DeviceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "أسم الجهاز";
            // 
            // txt_ID2
            // 
            this.txt_ID2.Location = new System.Drawing.Point(88, 102);
            this.txt_ID2.Name = "txt_ID2";
            this.txt_ID2.ReadOnly = true;
            this.txt_ID2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_ID2.Size = new System.Drawing.Size(268, 24);
            this.txt_ID2.TabIndex = 1;
            this.txt_ID2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "كود الجهاز";
            // 
            // grbx_Grid
            // 
            this.grbx_Grid.Controls.Add(this.dgv_Device);
            this.grbx_Grid.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbx_Grid.Location = new System.Drawing.Point(494, 106);
            this.grbx_Grid.Name = "grbx_Grid";
            this.grbx_Grid.Size = new System.Drawing.Size(290, 455);
            this.grbx_Grid.TabIndex = 2;
            this.grbx_Grid.TabStop = false;
            // 
            // dgv_Device
            // 
            this.dgv_Device.AllowUserToAddRows = false;
            this.dgv_Device.AllowUserToDeleteRows = false;
            this.dgv_Device.AllowUserToOrderColumns = true;
            this.dgv_Device.AllowUserToResizeColumns = false;
            this.dgv_Device.AllowUserToResizeRows = false;
            this.dgv_Device.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Device.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Device.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_ID,
            this.User_Name});
            this.dgv_Device.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Device.Location = new System.Drawing.Point(3, 20);
            this.dgv_Device.MultiSelect = false;
            this.dgv_Device.Name = "dgv_Device";
            this.dgv_Device.ReadOnly = true;
            this.dgv_Device.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Device.Size = new System.Drawing.Size(284, 432);
            this.dgv_Device.TabIndex = 0;
            this.dgv_Device.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Users_CellClick);
            // 
            // user_ID
            // 
            this.user_ID.DataPropertyName = "ID";
            this.user_ID.FillWeight = 76.14214F;
            this.user_ID.HeaderText = "مسلسل";
            this.user_ID.Name = "user_ID";
            this.user_ID.ReadOnly = true;
            // 
            // User_Name
            // 
            this.User_Name.DataPropertyName = "Name";
            this.User_Name.FillWeight = 123.8579F;
            this.User_Name.HeaderText = "الأسم";
            this.User_Name.Name = "User_Name";
            this.User_Name.ReadOnly = true;
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(88, 224);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.ReadOnly = true;
            this.txt_Port.Size = new System.Drawing.Size(268, 24);
            this.txt_Port.TabIndex = 4;
            this.txt_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Port";
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(88, 194);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.ReadOnly = true;
            this.txt_IP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_IP.Size = new System.Drawing.Size(268, 24);
            this.txt_IP.TabIndex = 3;
            this.txt_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "IP";
            // 
            // frm_Device
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
            this.Name = "frm_Device";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "أجهزة البصمة";
            this.Shown += new System.EventHandler(this.frm_Users_Shown);
            this.grbx_Controls.ResumeLayout(false);
            this.grbx_Details.ResumeLayout(false);
            this.grbx_Details.PerformLayout();
            this.grbx_Grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Device)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_Controls;
        private System.Windows.Forms.GroupBox grbx_Details;
        private System.Windows.Forms.GroupBox grbx_Grid;
        private System.Windows.Forms.DataGridView dgv_Device;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_DeviceID;
        public System.Windows.Forms.Button btn_New;
        public System.Windows.Forms.TextBox txt_ID2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Name;
        public System.Windows.Forms.Button btn_Logo;
        public System.Windows.Forms.TextBox txt_DeviceName;
        public System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Label label5;
    }
}