namespace Attendance
{
    partial class frm_WS_AdvancedOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_WS_AdvancedOptions));
            this.label1 = new System.Windows.Forms.Label();
            this.chk_ti = new System.Windows.Forms.CheckBox();
            this.dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.txt_Min = new System.Windows.Forms.TextBox();
            this.txt_Hours = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grbx_ti = new System.Windows.Forms.GroupBox();
            this.num_sle = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.num_sls = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.num_sae = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.num_sas = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.num_fle = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.num_fls = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.num_fae = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.num_fas = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.chk_BonusCheck = new System.Windows.Forms.CheckBox();
            this.chk_LateCheck = new System.Windows.Forms.CheckBox();
            this.chk_LeaveEarly = new System.Windows.Forms.CheckBox();
            this.chk_AttEarly = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.grbx_ti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_sle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_sls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_sae)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_sas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_fle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_fls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_fae)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_fas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "مدة اليوم";
            // 
            // chk_ti
            // 
            this.chk_ti.AutoSize = true;
            this.chk_ti.Checked = true;
            this.chk_ti.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_ti.Location = new System.Drawing.Point(51, 243);
            this.chk_ti.Name = "chk_ti";
            this.chk_ti.Size = new System.Drawing.Size(202, 21);
            this.chk_ti.TabIndex = 36;
            this.chk_ti.Text = "تحديد نوع الحركة حسب الوقت";
            this.chk_ti.UseVisualStyleBackColor = true;
            this.chk_ti.CheckedChanged += new System.EventHandler(this.chk_ti_CheckedChanged);
            // 
            // dtp_Start
            // 
            this.dtp_Start.CustomFormat = "h:mm tt";
            this.dtp_Start.Enabled = false;
            this.dtp_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Start.Location = new System.Drawing.Point(159, 27);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.ShowUpDown = true;
            this.dtp_Start.Size = new System.Drawing.Size(84, 24);
            this.dtp_Start.TabIndex = 0;
            this.dtp_Start.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtp_Start.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "يبدأ اليوم من";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "آخر وقت للإنصراف";
            // 
            // dtp_End
            // 
            this.dtp_End.CustomFormat = "h:mm tt";
            this.dtp_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End.Location = new System.Drawing.Point(159, 57);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.ShowUpDown = true;
            this.dtp_End.Size = new System.Drawing.Size(84, 24);
            this.dtp_End.TabIndex = 1;
            this.dtp_End.TabStop = false;
            this.dtp_End.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtp_End.ValueChanged += new System.EventHandler(this.dtp_End_ValueChanged);
            // 
            // txt_Min
            // 
            this.txt_Min.Location = new System.Drawing.Point(159, 102);
            this.txt_Min.Name = "txt_Min";
            this.txt_Min.ReadOnly = true;
            this.txt_Min.Size = new System.Drawing.Size(32, 24);
            this.txt_Min.TabIndex = 44;
            this.txt_Min.TabStop = false;
            this.txt_Min.Text = "0";
            this.txt_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Hours
            // 
            this.txt_Hours.Location = new System.Drawing.Point(211, 102);
            this.txt_Hours.Name = "txt_Hours";
            this.txt_Hours.ReadOnly = true;
            this.txt_Hours.Size = new System.Drawing.Size(32, 24);
            this.txt_Hours.TabIndex = 45;
            this.txt_Hours.TabStop = false;
            this.txt_Hours.Text = "24";
            this.txt_Hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "من اليوم التالي";
            // 
            // grbx_ti
            // 
            this.grbx_ti.Controls.Add(this.label21);
            this.grbx_ti.Controls.Add(this.label20);
            this.grbx_ti.Controls.Add(this.label19);
            this.grbx_ti.Controls.Add(this.label18);
            this.grbx_ti.Controls.Add(this.label17);
            this.grbx_ti.Controls.Add(this.label16);
            this.grbx_ti.Controls.Add(this.label15);
            this.grbx_ti.Controls.Add(this.label14);
            this.grbx_ti.Controls.Add(this.num_sle);
            this.grbx_ti.Controls.Add(this.label10);
            this.grbx_ti.Controls.Add(this.num_sls);
            this.grbx_ti.Controls.Add(this.label11);
            this.grbx_ti.Controls.Add(this.num_sae);
            this.grbx_ti.Controls.Add(this.label12);
            this.grbx_ti.Controls.Add(this.num_sas);
            this.grbx_ti.Controls.Add(this.label13);
            this.grbx_ti.Controls.Add(this.num_fle);
            this.grbx_ti.Controls.Add(this.label8);
            this.grbx_ti.Controls.Add(this.num_fls);
            this.grbx_ti.Controls.Add(this.label9);
            this.grbx_ti.Controls.Add(this.num_fae);
            this.grbx_ti.Controls.Add(this.label7);
            this.grbx_ti.Controls.Add(this.num_fas);
            this.grbx_ti.Controls.Add(this.label6);
            this.grbx_ti.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbx_ti.Location = new System.Drawing.Point(0, 270);
            this.grbx_ti.Name = "grbx_ti";
            this.grbx_ti.Size = new System.Drawing.Size(770, 191);
            this.grbx_ti.TabIndex = 48;
            this.grbx_ti.TabStop = false;
            // 
            // num_sle
            // 
            this.num_sle.Location = new System.Drawing.Point(63, 141);
            this.num_sle.Name = "num_sle";
            this.num_sle.Size = new System.Drawing.Size(34, 24);
            this.num_sle.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(102, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(277, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "نهاية وقت الإنصراف دوام 2  بعد الوقت المحدد بـ";
            // 
            // num_sls
            // 
            this.num_sls.Location = new System.Drawing.Point(63, 113);
            this.num_sls.Name = "num_sls";
            this.num_sls.Size = new System.Drawing.Size(34, 24);
            this.num_sls.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(102, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(281, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "بداية وقت االإنصراف دوام 2  قبل الوقت المحدد بـ";
            // 
            // num_sae
            // 
            this.num_sae.Location = new System.Drawing.Point(446, 141);
            this.num_sae.Name = "num_sae";
            this.num_sae.Size = new System.Drawing.Size(34, 24);
            this.num_sae.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(485, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(268, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "نهاية وقت الحضور دوام 2  بعد الوقت المحدد بـ";
            // 
            // num_sas
            // 
            this.num_sas.Location = new System.Drawing.Point(446, 113);
            this.num_sas.Name = "num_sas";
            this.num_sas.Size = new System.Drawing.Size(34, 24);
            this.num_sas.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(485, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(269, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "بداية وقت الحضور دوام 2  قبل الوقت المحدد بـ";
            // 
            // num_fle
            // 
            this.num_fle.Location = new System.Drawing.Point(64, 62);
            this.num_fle.Name = "num_fle";
            this.num_fle.Size = new System.Drawing.Size(34, 24);
            this.num_fle.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(277, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "نهاية وقت الإنصراف دوام 1  بعد الوقت المحدد بـ";
            // 
            // num_fls
            // 
            this.num_fls.Location = new System.Drawing.Point(64, 34);
            this.num_fls.Name = "num_fls";
            this.num_fls.Size = new System.Drawing.Size(34, 24);
            this.num_fls.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(281, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "بداية وقت االإنصراف دوام 1  قبل الوقت المحدد بـ";
            // 
            // num_fae
            // 
            this.num_fae.Location = new System.Drawing.Point(447, 62);
            this.num_fae.Name = "num_fae";
            this.num_fae.Size = new System.Drawing.Size(34, 24);
            this.num_fae.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(486, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "نهاية وقت الحضور دوام 1  بعد الوقت المحدد بـ";
            // 
            // num_fas
            // 
            this.num_fas.Location = new System.Drawing.Point(447, 34);
            this.num_fas.Name = "num_fas";
            this.num_fas.Size = new System.Drawing.Size(34, 24);
            this.num_fas.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(486, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "بداية وقت الحضور دوام 1  قبل الوقت المحدد بـ";
            // 
            // chk_BonusCheck
            // 
            this.chk_BonusCheck.AutoSize = true;
            this.chk_BonusCheck.Checked = true;
            this.chk_BonusCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_BonusCheck.Location = new System.Drawing.Point(51, 170);
            this.chk_BonusCheck.Name = "chk_BonusCheck";
            this.chk_BonusCheck.Size = new System.Drawing.Size(238, 21);
            this.chk_BonusCheck.TabIndex = 49;
            this.chk_BonusCheck.Text = "الإضافي يدخل ضمن إجمالي المضاف";
            this.chk_BonusCheck.UseVisualStyleBackColor = true;
            // 
            // chk_LateCheck
            // 
            this.chk_LateCheck.AutoSize = true;
            this.chk_LateCheck.Checked = true;
            this.chk_LateCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_LateCheck.Location = new System.Drawing.Point(51, 195);
            this.chk_LateCheck.Name = "chk_LateCheck";
            this.chk_LateCheck.Size = new System.Drawing.Size(245, 21);
            this.chk_LateCheck.TabIndex = 50;
            this.chk_LateCheck.Text = "التأخير يدخل ضمن إجمالي المستقطع";
            this.chk_LateCheck.UseVisualStyleBackColor = true;
            // 
            // chk_LeaveEarly
            // 
            this.chk_LeaveEarly.AutoSize = true;
            this.chk_LeaveEarly.Location = new System.Drawing.Point(337, 195);
            this.chk_LeaveEarly.Name = "chk_LeaveEarly";
            this.chk_LeaveEarly.Size = new System.Drawing.Size(295, 21);
            this.chk_LeaveEarly.TabIndex = 52;
            this.chk_LeaveEarly.Text = "الإنصراف المبكر يدخل ضمن إجمالي المستقطع";
            this.chk_LeaveEarly.UseVisualStyleBackColor = true;
            // 
            // chk_AttEarly
            // 
            this.chk_AttEarly.AutoSize = true;
            this.chk_AttEarly.Location = new System.Drawing.Point(337, 170);
            this.chk_AttEarly.Name = "chk_AttEarly";
            this.chk_AttEarly.Size = new System.Drawing.Size(268, 21);
            this.chk_AttEarly.TabIndex = 51;
            this.chk_AttEarly.Text = "الحضور المبكر يدخل ضمن إجمالي المضاف";
            this.chk_AttEarly.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(399, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 17);
            this.label14.TabIndex = 19;
            this.label14.Text = "ساعة";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(399, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 17);
            this.label15.TabIndex = 20;
            this.label15.Text = "ساعة";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(399, 115);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 17);
            this.label16.TabIndex = 21;
            this.label16.Text = "ساعة";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(399, 141);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 17);
            this.label17.TabIndex = 22;
            this.label17.Text = "ساعة";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 17);
            this.label18.TabIndex = 23;
            this.label18.Text = "ساعة";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 17);
            this.label19.TabIndex = 24;
            this.label19.Text = "ساعة";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 115);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 17);
            this.label20.TabIndex = 25;
            this.label20.Text = "ساعة";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(16, 143);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 17);
            this.label21.TabIndex = 26;
            this.label21.Text = "ساعة";
            // 
            // frm_WS_AdvancedOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 461);
            this.Controls.Add(this.chk_LeaveEarly);
            this.Controls.Add(this.chk_AttEarly);
            this.Controls.Add(this.chk_LateCheck);
            this.Controls.Add(this.chk_BonusCheck);
            this.Controls.Add(this.grbx_ti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Hours);
            this.Controls.Add(this.txt_Min);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_End);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_Start);
            this.Controls.Add(this.chk_ti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_WS_AdvancedOptions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "خيارات متقدمة";
            this.Shown += new System.EventHandler(this.frm_WS_AdvancedOptions_Shown);
            this.grbx_ti.ResumeLayout(false);
            this.grbx_ti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_sle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_sls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_sae)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_sas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_fle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_fls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_fae)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_fas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_End;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_Min;
        public System.Windows.Forms.TextBox txt_Hours;
        private System.Windows.Forms.GroupBox grbx_ti;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.CheckBox chk_ti;
        public System.Windows.Forms.NumericUpDown num_sle;
        public System.Windows.Forms.NumericUpDown num_sls;
        public System.Windows.Forms.NumericUpDown num_sae;
        public System.Windows.Forms.NumericUpDown num_sas;
        public System.Windows.Forms.NumericUpDown num_fle;
        public System.Windows.Forms.NumericUpDown num_fls;
        public System.Windows.Forms.NumericUpDown num_fae;
        public System.Windows.Forms.NumericUpDown num_fas;
        public System.Windows.Forms.CheckBox chk_BonusCheck;
        public System.Windows.Forms.CheckBox chk_LateCheck;
        public System.Windows.Forms.CheckBox chk_LeaveEarly;
        public System.Windows.Forms.CheckBox chk_AttEarly;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}