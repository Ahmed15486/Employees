namespace Attendance
{
    partial class frm_LoadFile
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
            this.btn_Dat = new System.Windows.Forms.Button();
            this.btn_Txt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Dat
            // 
            this.btn_Dat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Dat.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Dat.FlatAppearance.BorderSize = 0;
            this.btn_Dat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dat.Font = new System.Drawing.Font("Tahoma", 24F);
            this.btn_Dat.Image = global::Attendance.Properties.Resources.dat_128;
            this.btn_Dat.Location = new System.Drawing.Point(59, 51);
            this.btn_Dat.Name = "btn_Dat";
            this.btn_Dat.Size = new System.Drawing.Size(153, 146);
            this.btn_Dat.TabIndex = 9;
            this.btn_Dat.TabStop = false;
            this.btn_Dat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Dat.UseVisualStyleBackColor = false;
            this.btn_Dat.Click += new System.EventHandler(this.btn_Dat_Click);
            // 
            // btn_Txt
            // 
            this.btn_Txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Txt.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Txt.FlatAppearance.BorderSize = 0;
            this.btn_Txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Txt.Font = new System.Drawing.Font("Tahoma", 24F);
            this.btn_Txt.Image = global::Attendance.Properties.Resources.txt_128;
            this.btn_Txt.Location = new System.Drawing.Point(254, 51);
            this.btn_Txt.Name = "btn_Txt";
            this.btn_Txt.Size = new System.Drawing.Size(150, 146);
            this.btn_Txt.TabIndex = 8;
            this.btn_Txt.TabStop = false;
            this.btn_Txt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Txt.UseVisualStyleBackColor = false;
            this.btn_Txt.Click += new System.EventHandler(this.btn_Txt_Click);
            // 
            // frm_LoadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 262);
            this.Controls.Add(this.btn_Dat);
            this.Controls.Add(this.btn_Txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_LoadFile";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحديد نوع الملف";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Txt;
        private System.Windows.Forms.Button btn_Dat;
    }
}