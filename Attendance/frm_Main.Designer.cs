namespace Attendance
{
    partial class frm_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.البياناتالأساسيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.أنظمةالدوامToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الموظفينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الإداراتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الأقسامToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.أجهزةالبصمةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إستيرادمنملفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_LoadFromDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_LoadFromFile = new System.Windows.Forms.ToolStripMenuItem();
            this.التقاريرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الإعداداتToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.المستخدمينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.النسخالإحتياطيToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tim_PullFromFile = new System.Windows.Forms.Timer(this.components);
            this.btn_Sec = new System.Windows.Forms.Button();
            this.btn_Depart = new System.Windows.Forms.Button();
            this.btn_FromFile = new System.Windows.Forms.Button();
            this.btn_Device = new System.Windows.Forms.Button();
            this.btn_WorkSystem = new System.Windows.Forms.Button();
            this.btn_Rep = new System.Windows.Forms.Button();
            this.btn_Emp = new System.Windows.Forms.Button();
            this.btn_Users = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Logo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.tsm_GeneralSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.btn_Logo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 68);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(401, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Stream Time Manager";
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.البياناتالأساسيةToolStripMenuItem,
            this.إستيرادمنملفToolStripMenuItem,
            this.التقاريرToolStripMenuItem,
            this.الإعداداتToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 68);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // البياناتالأساسيةToolStripMenuItem
            // 
            this.البياناتالأساسيةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.أنظمةالدوامToolStripMenuItem,
            this.الموظفينToolStripMenuItem,
            this.الإداراتToolStripMenuItem,
            this.الأقسامToolStripMenuItem,
            this.أجهزةالبصمةToolStripMenuItem});
            this.البياناتالأساسيةToolStripMenuItem.Name = "البياناتالأساسيةToolStripMenuItem";
            this.البياناتالأساسيةToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.البياناتالأساسيةToolStripMenuItem.Text = "البيانات الأساسية";
            // 
            // أنظمةالدوامToolStripMenuItem
            // 
            this.أنظمةالدوامToolStripMenuItem.Name = "أنظمةالدوامToolStripMenuItem";
            this.أنظمةالدوامToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.أنظمةالدوامToolStripMenuItem.Text = "أنظمة الدوام";
            this.أنظمةالدوامToolStripMenuItem.Click += new System.EventHandler(this.أنظمةالدوامToolStripMenuItem_Click);
            // 
            // الموظفينToolStripMenuItem
            // 
            this.الموظفينToolStripMenuItem.Name = "الموظفينToolStripMenuItem";
            this.الموظفينToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.الموظفينToolStripMenuItem.Text = "الموظفين";
            this.الموظفينToolStripMenuItem.Click += new System.EventHandler(this.الموظفينToolStripMenuItem_Click);
            // 
            // الإداراتToolStripMenuItem
            // 
            this.الإداراتToolStripMenuItem.Name = "الإداراتToolStripMenuItem";
            this.الإداراتToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.الإداراتToolStripMenuItem.Text = "الإدارات";
            this.الإداراتToolStripMenuItem.Click += new System.EventHandler(this.الإداراتToolStripMenuItem_Click);
            // 
            // الأقسامToolStripMenuItem
            // 
            this.الأقسامToolStripMenuItem.Name = "الأقسامToolStripMenuItem";
            this.الأقسامToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.الأقسامToolStripMenuItem.Text = "الأقسام";
            this.الأقسامToolStripMenuItem.Click += new System.EventHandler(this.الأقسامToolStripMenuItem_Click);
            // 
            // أجهزةالبصمةToolStripMenuItem
            // 
            this.أجهزةالبصمةToolStripMenuItem.Name = "أجهزةالبصمةToolStripMenuItem";
            this.أجهزةالبصمةToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.أجهزةالبصمةToolStripMenuItem.Text = "أجهزة البصمة";
            this.أجهزةالبصمةToolStripMenuItem.Click += new System.EventHandler(this.أجهزةالبصمةToolStripMenuItem_Click);
            // 
            // إستيرادمنملفToolStripMenuItem
            // 
            this.إستيرادمنملفToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_LoadFromDevice,
            this.tsm_LoadFromFile});
            this.إستيرادمنملفToolStripMenuItem.Name = "إستيرادمنملفToolStripMenuItem";
            this.إستيرادمنملفToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.إستيرادمنملفToolStripMenuItem.Text = "إستيراد بيانات";
            // 
            // tsm_LoadFromDevice
            // 
            this.tsm_LoadFromDevice.Name = "tsm_LoadFromDevice";
            this.tsm_LoadFromDevice.Size = new System.Drawing.Size(152, 22);
            this.tsm_LoadFromDevice.Text = "إستيراد من جهاز";
            this.tsm_LoadFromDevice.Click += new System.EventHandler(this.tsm_LoadFromDevice_Click);
            // 
            // tsm_LoadFromFile
            // 
            this.tsm_LoadFromFile.Name = "tsm_LoadFromFile";
            this.tsm_LoadFromFile.Size = new System.Drawing.Size(152, 22);
            this.tsm_LoadFromFile.Text = "إستيراد من ملف";
            this.tsm_LoadFromFile.Click += new System.EventHandler(this.tsm_LoadFromFile_Click);
            // 
            // التقاريرToolStripMenuItem
            // 
            this.التقاريرToolStripMenuItem.Name = "التقاريرToolStripMenuItem";
            this.التقاريرToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.التقاريرToolStripMenuItem.Text = "التقارير";
            this.التقاريرToolStripMenuItem.Click += new System.EventHandler(this.التقاريرToolStripMenuItem_Click);
            // 
            // الإعداداتToolStripMenuItem1
            // 
            this.الإعداداتToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.المستخدمينToolStripMenuItem,
            this.النسخالإحتياطيToolStripMenuItem,
            this.tsm_GeneralSettings});
            this.الإعداداتToolStripMenuItem1.Name = "الإعداداتToolStripMenuItem1";
            this.الإعداداتToolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.الإعداداتToolStripMenuItem1.Text = "الإعدادات";
            // 
            // المستخدمينToolStripMenuItem
            // 
            this.المستخدمينToolStripMenuItem.Name = "المستخدمينToolStripMenuItem";
            this.المستخدمينToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.المستخدمينToolStripMenuItem.Text = "المستخدمين";
            this.المستخدمينToolStripMenuItem.Click += new System.EventHandler(this.المستخدمينToolStripMenuItem_Click);
            // 
            // النسخالإحتياطيToolStripMenuItem
            // 
            this.النسخالإحتياطيToolStripMenuItem.Name = "النسخالإحتياطيToolStripMenuItem";
            this.النسخالإحتياطيToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.النسخالإحتياطيToolStripMenuItem.Text = "النسخ الإحتياطي";
            this.النسخالإحتياطيToolStripMenuItem.Click += new System.EventHandler(this.النسخالإحتياطيToolStripMenuItem_Click);
            // 
            // tim_PullFromFile
            // 
            this.tim_PullFromFile.Enabled = true;
            this.tim_PullFromFile.Interval = 30000;
            this.tim_PullFromFile.Tick += new System.EventHandler(this.tim_PullFromFile_Tick);
            // 
            // btn_Sec
            // 
            this.btn_Sec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Sec.FlatAppearance.BorderSize = 0;
            this.btn_Sec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sec.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_Sec.Image = global::Attendance.Properties.Resources.Sect_128;
            this.btn_Sec.Location = new System.Drawing.Point(417, 311);
            this.btn_Sec.Name = "btn_Sec";
            this.btn_Sec.Size = new System.Drawing.Size(174, 180);
            this.btn_Sec.TabIndex = 7;
            this.btn_Sec.Text = "الأقسام";
            this.btn_Sec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Sec.UseVisualStyleBackColor = true;
            this.btn_Sec.Click += new System.EventHandler(this.btn_Sec_Click);
            this.btn_Sec.MouseEnter += new System.EventHandler(this.btn_Sec_MouseEnter);
            this.btn_Sec.MouseLeave += new System.EventHandler(this.btn_Sec_MouseLeave);
            // 
            // btn_Depart
            // 
            this.btn_Depart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Depart.FlatAppearance.BorderSize = 0;
            this.btn_Depart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Depart.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_Depart.Image = global::Attendance.Properties.Resources.Depart2_128;
            this.btn_Depart.Location = new System.Drawing.Point(177, 311);
            this.btn_Depart.Name = "btn_Depart";
            this.btn_Depart.Size = new System.Drawing.Size(174, 174);
            this.btn_Depart.TabIndex = 6;
            this.btn_Depart.Text = "الإدارات";
            this.btn_Depart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Depart.UseVisualStyleBackColor = true;
            this.btn_Depart.Click += new System.EventHandler(this.btn_Depart_Click);
            this.btn_Depart.MouseEnter += new System.EventHandler(this.btn_Depart_MouseEnter);
            this.btn_Depart.MouseLeave += new System.EventHandler(this.btn_Depart_MouseLeave);
            // 
            // btn_FromFile
            // 
            this.btn_FromFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_FromFile.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_FromFile.FlatAppearance.BorderSize = 0;
            this.btn_FromFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FromFile.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_FromFile.Image = global::Attendance.Properties.Resources.File_1282;
            this.btn_FromFile.Location = new System.Drawing.Point(667, 117);
            this.btn_FromFile.Name = "btn_FromFile";
            this.btn_FromFile.Size = new System.Drawing.Size(174, 174);
            this.btn_FromFile.TabIndex = 5;
            this.btn_FromFile.Text = "إستيراد من ملف";
            this.btn_FromFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_FromFile.UseVisualStyleBackColor = false;
            this.btn_FromFile.Click += new System.EventHandler(this.btn_FromFile_Click);
            this.btn_FromFile.MouseEnter += new System.EventHandler(this.btn_FromFile_MouseEnter);
            this.btn_FromFile.MouseLeave += new System.EventHandler(this.btn_FromFile_MouseLeave);
            // 
            // btn_Device
            // 
            this.btn_Device.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Device.FlatAppearance.BorderSize = 0;
            this.btn_Device.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Device.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_Device.Image = global::Attendance.Properties.Resources.FingerPrint_128;
            this.btn_Device.Location = new System.Drawing.Point(667, 311);
            this.btn_Device.Name = "btn_Device";
            this.btn_Device.Size = new System.Drawing.Size(174, 180);
            this.btn_Device.TabIndex = 4;
            this.btn_Device.Text = "أجهزة البصمة";
            this.btn_Device.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Device.UseVisualStyleBackColor = true;
            this.btn_Device.Click += new System.EventHandler(this.btn_Device_Click);
            this.btn_Device.MouseEnter += new System.EventHandler(this.btn_Device_MouseEnter);
            this.btn_Device.MouseLeave += new System.EventHandler(this.btn_Device_MouseLeave);
            // 
            // btn_WorkSystem
            // 
            this.btn_WorkSystem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_WorkSystem.BackColor = System.Drawing.Color.Transparent;
            this.btn_WorkSystem.FlatAppearance.BorderSize = 0;
            this.btn_WorkSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WorkSystem.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_WorkSystem.Image = global::Attendance.Properties.Resources.Cal_128;
            this.btn_WorkSystem.Location = new System.Drawing.Point(177, 117);
            this.btn_WorkSystem.Name = "btn_WorkSystem";
            this.btn_WorkSystem.Size = new System.Drawing.Size(174, 174);
            this.btn_WorkSystem.TabIndex = 3;
            this.btn_WorkSystem.Text = "أنظمة الدوام";
            this.btn_WorkSystem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_WorkSystem.UseVisualStyleBackColor = false;
            this.btn_WorkSystem.Click += new System.EventHandler(this.btn_WorkSystem_Click);
            this.btn_WorkSystem.MouseEnter += new System.EventHandler(this.btn_WorkSystem_MouseEnter);
            this.btn_WorkSystem.MouseLeave += new System.EventHandler(this.btn_WorkSystem_MouseLeave);
            // 
            // btn_Rep
            // 
            this.btn_Rep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Rep.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Rep.FlatAppearance.BorderSize = 0;
            this.btn_Rep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rep.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_Rep.Image = global::Attendance.Properties.Resources.Rep2_128;
            this.btn_Rep.Location = new System.Drawing.Point(417, 517);
            this.btn_Rep.Name = "btn_Rep";
            this.btn_Rep.Size = new System.Drawing.Size(174, 180);
            this.btn_Rep.TabIndex = 2;
            this.btn_Rep.Text = "التقارير";
            this.btn_Rep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Rep.UseVisualStyleBackColor = false;
            this.btn_Rep.Click += new System.EventHandler(this.btn_Rep_Click);
            this.btn_Rep.MouseEnter += new System.EventHandler(this.btn_Rep_MouseEnter);
            this.btn_Rep.MouseLeave += new System.EventHandler(this.btn_Rep_MouseLeave);
            // 
            // btn_Emp
            // 
            this.btn_Emp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Emp.FlatAppearance.BorderSize = 0;
            this.btn_Emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Emp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_Emp.Image = global::Attendance.Properties.Resources.Emps_128;
            this.btn_Emp.Location = new System.Drawing.Point(417, 117);
            this.btn_Emp.Name = "btn_Emp";
            this.btn_Emp.Size = new System.Drawing.Size(174, 174);
            this.btn_Emp.TabIndex = 1;
            this.btn_Emp.Text = "الموظفين";
            this.btn_Emp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Emp.UseVisualStyleBackColor = true;
            this.btn_Emp.Click += new System.EventHandler(this.btn_Emp_Click);
            this.btn_Emp.MouseEnter += new System.EventHandler(this.btn_Emp_MouseEnter);
            this.btn_Emp.MouseLeave += new System.EventHandler(this.btn_Emp_MouseLeave);
            // 
            // btn_Users
            // 
            this.btn_Users.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Users.FlatAppearance.BorderSize = 0;
            this.btn_Users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Users.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_Users.Image = global::Attendance.Properties.Resources.User2_128;
            this.btn_Users.Location = new System.Drawing.Point(667, 517);
            this.btn_Users.Name = "btn_Users";
            this.btn_Users.Size = new System.Drawing.Size(174, 180);
            this.btn_Users.TabIndex = 0;
            this.btn_Users.Text = "المستخدمين";
            this.btn_Users.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Users.UseVisualStyleBackColor = true;
            this.btn_Users.Click += new System.EventHandler(this.btn_Users_Click);
            this.btn_Users.MouseEnter += new System.EventHandler(this.btn_Users_MouseEnter);
            this.btn_Users.MouseLeave += new System.EventHandler(this.btn_Users_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Attendance.Properties.Resources.Clock2_5121;
            this.pictureBox1.Location = new System.Drawing.Point(0, 486);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 244);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Logo
            // 
            this.btn_Logo.FlatAppearance.BorderSize = 0;
            this.btn_Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logo.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logo.ForeColor = System.Drawing.Color.Black;
            this.btn_Logo.Image = global::Attendance.Properties.Resources.cloc_32;
            this.btn_Logo.Location = new System.Drawing.Point(344, 0);
            this.btn_Logo.Name = "btn_Logo";
            this.btn_Logo.Size = new System.Drawing.Size(59, 68);
            this.btn_Logo.TabIndex = 13;
            this.btn_Logo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Logo.UseVisualStyleBackColor = true;
            this.btn_Logo.Click += new System.EventHandler(this.btn_Logo_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Image = global::Attendance.Properties.Resources.mini1_32;
            this.button1.Location = new System.Drawing.Point(59, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 68);
            this.button1.TabIndex = 11;
            this.button1.Text = " ";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Exit.Image = global::Attendance.Properties.Resources.close1_32;
            this.btn_Exit.Location = new System.Drawing.Point(0, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(59, 68);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // tsm_GeneralSettings
            // 
            this.tsm_GeneralSettings.Name = "tsm_GeneralSettings";
            this.tsm_GeneralSettings.Size = new System.Drawing.Size(180, 22);
            this.tsm_GeneralSettings.Text = "إعدادات عامة";
            this.tsm_GeneralSettings.Click += new System.EventHandler(this.tsm_GeneralSettings_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_Sec);
            this.Controls.Add(this.btn_Depart);
            this.Controls.Add(this.btn_FromFile);
            this.Controls.Add(this.btn_Device);
            this.Controls.Add(this.btn_WorkSystem);
            this.Controls.Add(this.btn_Rep);
            this.Controls.Add(this.btn_Emp);
            this.Controls.Add(this.btn_Users);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نظام الحضور والإنصراف";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Main_FormClosed);
            this.Shown += new System.EventHandler(this.frm_Main_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Users;
        private System.Windows.Forms.Button btn_Emp;
        private System.Windows.Forms.Button btn_Rep;
        private System.Windows.Forms.Button btn_WorkSystem;
        private System.Windows.Forms.Button btn_Device;
        private System.Windows.Forms.Button btn_FromFile;
        private System.Windows.Forms.Button btn_Depart;
        private System.Windows.Forms.Button btn_Sec;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem البياناتالأساسيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem أنظمةالدوامToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الموظفينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الإداراتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الأقسامToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem أجهزةالبصمةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إستيرادمنملفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem التقاريرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الإعداداتToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem المستخدمينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem النسخالإحتياطيToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_LoadFromDevice;
        private System.Windows.Forms.ToolStripMenuItem tsm_LoadFromFile;
        private System.Windows.Forms.Timer tim_PullFromFile;
        private System.Windows.Forms.ToolStripMenuItem tsm_GeneralSettings;
    }
}