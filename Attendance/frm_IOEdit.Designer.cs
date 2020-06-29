namespace Attendance
{
    partial class frm_IOEdit
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
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.btn_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_IOName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.com_Event = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.com_Device = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtp
            // 
            this.dtp.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(555, 70);
            this.dtp.Margin = new System.Windows.Forms.Padding(4);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(227, 27);
            this.dtp.TabIndex = 0;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(446, 150);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 40);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "موافق";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(833, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "رقم الحركة";
            this.label1.Visible = false;
            // 
            // lbl_IOName
            // 
            this.lbl_IOName.Location = new System.Drawing.Point(802, 73);
            this.lbl_IOName.Name = "lbl_IOName";
            this.lbl_IOName.Size = new System.Drawing.Size(163, 19);
            this.lbl_IOName.TabIndex = 3;
            this.lbl_IOName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_IOName.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(651, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "الوقت";
            // 
            // com_Event
            // 
            this.com_Event.DisplayMember = "Name";
            this.com_Event.FormattingEnabled = true;
            this.com_Event.Location = new System.Drawing.Point(338, 70);
            this.com_Event.Name = "com_Event";
            this.com_Event.Size = new System.Drawing.Size(185, 27);
            this.com_Event.TabIndex = 5;
            this.com_Event.ValueMember = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "الحدث";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "جهاز البصمة";
            // 
            // com_Device
            // 
            this.com_Device.DisplayMember = "Name";
            this.com_Device.FormattingEnabled = true;
            this.com_Device.Location = new System.Drawing.Point(73, 70);
            this.com_Device.Name = "com_Device";
            this.com_Device.Size = new System.Drawing.Size(215, 27);
            this.com_Device.TabIndex = 7;
            this.com_Device.ValueMember = "ID2";
            // 
            // frm_IOEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 202);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.com_Device);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.com_Event);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_IOName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.dtp);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_IOEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل حركة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_IOName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox com_Event;
        public System.Windows.Forms.ComboBox com_Device;
    }
}