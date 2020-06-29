namespace Attendance
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Lock = new System.Windows.Forms.Button();
            this.btn_Demo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(168, 151);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(193, 24);
            this.txt_Name.TabIndex = 0;
            this.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Name_KeyPress);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(232, 253);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 35);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(168, 193);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(193, 24);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Password_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "كلمة المرور";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "أسم المستخدم";
            // 
            // btn_Lock
            // 
            this.btn_Lock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Lock.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Lock.FlatAppearance.BorderSize = 0;
            this.btn_Lock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Lock.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_Lock.Image = global::Attendance.Properties.Resources.Lock_128;
            this.btn_Lock.Location = new System.Drawing.Point(186, 12);
            this.btn_Lock.Name = "btn_Lock";
            this.btn_Lock.Size = new System.Drawing.Size(150, 100);
            this.btn_Lock.TabIndex = 6;
            this.btn_Lock.TabStop = false;
            this.btn_Lock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Lock.UseVisualStyleBackColor = false;
            // 
            // btn_Demo
            // 
            this.btn_Demo.BackColor = System.Drawing.Color.Transparent;
            this.btn_Demo.FlatAppearance.BorderSize = 0;
            this.btn_Demo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Demo.ForeColor = System.Drawing.Color.Navy;
            this.btn_Demo.Location = new System.Drawing.Point(182, 319);
            this.btn_Demo.Name = "btn_Demo";
            this.btn_Demo.Size = new System.Drawing.Size(167, 35);
            this.btn_Demo.TabIndex = 3;
            this.btn_Demo.Text = "دخول النسخة التجريبية";
            this.btn_Demo.UseVisualStyleBackColor = false;
            this.btn_Demo.Click += new System.EventHandler(this.btn_Demo_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 366);
            this.Controls.Add(this.btn_Demo);
            this.Controls.Add(this.btn_Lock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دخول";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Login_FormClosed);
            this.Shown += new System.EventHandler(this.frm_Login_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Lock;
        private System.Windows.Forms.Button btn_Demo;
    }
}