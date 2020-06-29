namespace Attendance
{
    partial class frm_PreventNo
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
            this.txt_Authorization = new System.Windows.Forms.TextBox();
            this.txt_Run = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Authorization
            // 
            this.txt_Authorization.Location = new System.Drawing.Point(141, 72);
            this.txt_Authorization.Name = "txt_Authorization";
            this.txt_Authorization.ReadOnly = true;
            this.txt_Authorization.Size = new System.Drawing.Size(100, 27);
            this.txt_Authorization.TabIndex = 0;
            this.txt_Authorization.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Run
            // 
            this.txt_Run.Location = new System.Drawing.Point(141, 119);
            this.txt_Run.Name = "txt_Run";
            this.txt_Run.Size = new System.Drawing.Size(100, 27);
            this.txt_Run.TabIndex = 0;
            this.txt_Run.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "رقم التفويض";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "رقم التشغيل";
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(156, 172);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(75, 33);
            this.btn_Run.TabIndex = 1;
            this.btn_Run.Text = "دخول";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // frm_PreventNo
            // 
            this.AcceptButton = this.btn_Run;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 279);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Run);
            this.Controls.Add(this.txt_Authorization);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_PreventNo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_PreventNo_FormClosed);
            this.Shown += new System.EventHandler(this.frm_PreventNo_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Run;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Run;
        public System.Windows.Forms.TextBox txt_Authorization;
    }
}