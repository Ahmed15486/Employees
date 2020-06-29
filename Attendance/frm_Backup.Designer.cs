namespace Attendance
{
    partial class frm_Backup
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
            this.btn_Backup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Backup = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_BrowseBackup = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_BrowseRestore = new System.Windows.Forms.Button();
            this.btn_Restore = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Restore = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Backup
            // 
            this.btn_Backup.Location = new System.Drawing.Point(199, 65);
            this.btn_Backup.Name = "btn_Backup";
            this.btn_Backup.Size = new System.Drawing.Size(75, 23);
            this.btn_Backup.TabIndex = 0;
            this.btn_Backup.Text = "نسخ";
            this.btn_Backup.UseVisualStyleBackColor = true;
            this.btn_Backup.Click += new System.EventHandler(this.btn_Backup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "المسار";
            this.label1.Visible = false;
            // 
            // txt_Backup
            // 
            this.txt_Backup.Location = new System.Drawing.Point(47, 39);
            this.txt_Backup.Name = "txt_Backup";
            this.txt_Backup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Backup.Size = new System.Drawing.Size(369, 20);
            this.txt_Backup.TabIndex = 2;
            this.txt_Backup.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_BrowseBackup);
            this.groupBox1.Controls.Add(this.btn_Backup);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Backup);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 176);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "حفظ نسخة إحتياطية";
            // 
            // btn_BrowseBackup
            // 
            this.btn_BrowseBackup.Font = new System.Drawing.Font("Tahoma", 7F);
            this.btn_BrowseBackup.Location = new System.Drawing.Point(19, 38);
            this.btn_BrowseBackup.Name = "btn_BrowseBackup";
            this.btn_BrowseBackup.Size = new System.Drawing.Size(22, 23);
            this.btn_BrowseBackup.TabIndex = 3;
            this.btn_BrowseBackup.Text = "...";
            this.btn_BrowseBackup.UseVisualStyleBackColor = true;
            this.btn_BrowseBackup.Visible = false;
            this.btn_BrowseBackup.Click += new System.EventHandler(this.btn_BrowseBackup_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_BrowseRestore);
            this.groupBox2.Controls.Add(this.btn_Restore);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_Restore);
            this.groupBox2.Location = new System.Drawing.Point(12, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 175);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "إسترجاع نسخة إحتياطية";
            // 
            // btn_BrowseRestore
            // 
            this.btn_BrowseRestore.Font = new System.Drawing.Font("Tahoma", 7F);
            this.btn_BrowseRestore.Location = new System.Drawing.Point(19, 75);
            this.btn_BrowseRestore.Name = "btn_BrowseRestore";
            this.btn_BrowseRestore.Size = new System.Drawing.Size(22, 23);
            this.btn_BrowseRestore.TabIndex = 3;
            this.btn_BrowseRestore.Text = "...";
            this.btn_BrowseRestore.UseVisualStyleBackColor = true;
            this.btn_BrowseRestore.Click += new System.EventHandler(this.btn_BrowseRestore_Click);
            // 
            // btn_Restore
            // 
            this.btn_Restore.Location = new System.Drawing.Point(202, 102);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(75, 23);
            this.btn_Restore.TabIndex = 0;
            this.btn_Restore.Text = "إسترجاع";
            this.btn_Restore.UseVisualStyleBackColor = true;
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "المسار";
            // 
            // txt_Restore
            // 
            this.txt_Restore.Location = new System.Drawing.Point(47, 76);
            this.txt_Restore.Name = "txt_Restore";
            this.txt_Restore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Restore.Size = new System.Drawing.Size(369, 20);
            this.txt_Restore.TabIndex = 2;
            // 
            // frm_Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 195);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Backup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نسخ وإسترجاع النسخ الإحتياطية لقاعدة البيانات";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Backup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Backup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_BrowseBackup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_BrowseRestore;
        private System.Windows.Forms.Button btn_Restore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Restore;
    }
}