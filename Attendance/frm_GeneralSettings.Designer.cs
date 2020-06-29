namespace Attendance
{
    partial class frm_GeneralSettings
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
            this.chk_Active = new System.Windows.Forms.CheckBox();
            this.num_Timer = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_Timer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.num_Timer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnl_Timer.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_Active
            // 
            this.chk_Active.AutoSize = true;
            this.chk_Active.Location = new System.Drawing.Point(443, 52);
            this.chk_Active.Name = "chk_Active";
            this.chk_Active.Size = new System.Drawing.Size(54, 18);
            this.chk_Active.TabIndex = 0;
            this.chk_Active.Text = "تفعيل";
            this.chk_Active.UseVisualStyleBackColor = true;
            this.chk_Active.CheckedChanged += new System.EventHandler(this.chk_Active_CheckedChanged);
            // 
            // num_Timer
            // 
            this.num_Timer.Location = new System.Drawing.Point(77, 17);
            this.num_Timer.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.num_Timer.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_Timer.Name = "num_Timer";
            this.num_Timer.Size = new System.Drawing.Size(55, 22);
            this.num_Timer.TabIndex = 1;
            this.num_Timer.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.num_Timer.ValueChanged += new System.EventHandler(this.num_Timer_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnl_Timer);
            this.groupBox1.Controls.Add(this.chk_Active);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 108);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "إستيراد تلقائي من ملف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "كل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "ثانية";
            // 
            // pnl_Timer
            // 
            this.pnl_Timer.Controls.Add(this.num_Timer);
            this.pnl_Timer.Controls.Add(this.label2);
            this.pnl_Timer.Controls.Add(this.label1);
            this.pnl_Timer.Location = new System.Drawing.Point(237, 33);
            this.pnl_Timer.Name = "pnl_Timer";
            this.pnl_Timer.Size = new System.Drawing.Size(200, 53);
            this.pnl_Timer.TabIndex = 5;
            // 
            // frm_GeneralSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 492);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_GeneralSettings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الإعدادات العامة";
            this.Shown += new System.EventHandler(this.frm_GeneralSettings_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.num_Timer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnl_Timer.ResumeLayout(false);
            this.pnl_Timer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_Active;
        private System.Windows.Forms.NumericUpDown num_Timer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_Timer;
    }
}