namespace Attendance
{
    partial class frm_VacWS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Selected_DisSelectAll = new System.Windows.Forms.Button();
            this.btn_Selected_SelectAll = new System.Windows.Forms.Button();
            this.btn_Available_DisSelectAll = new System.Windows.Forms.Button();
            this.btn_Available_SelectAll = new System.Windows.Forms.Button();
            this.dgv_AvailableVac = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_b = new System.Windows.Forms.Button();
            this.btn_f = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_SelectedVac = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_VacAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AvailableVac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectedVac)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Selected_DisSelectAll
            // 
            this.btn_Selected_DisSelectAll.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btn_Selected_DisSelectAll.Location = new System.Drawing.Point(547, 429);
            this.btn_Selected_DisSelectAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Selected_DisSelectAll.Name = "btn_Selected_DisSelectAll";
            this.btn_Selected_DisSelectAll.Size = new System.Drawing.Size(73, 32);
            this.btn_Selected_DisSelectAll.TabIndex = 37;
            this.btn_Selected_DisSelectAll.Text = "إلغاء الكل";
            this.btn_Selected_DisSelectAll.UseVisualStyleBackColor = true;
            this.btn_Selected_DisSelectAll.Click += new System.EventHandler(this.btn_Selected_DisSelectAll_Click);
            // 
            // btn_Selected_SelectAll
            // 
            this.btn_Selected_SelectAll.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btn_Selected_SelectAll.Location = new System.Drawing.Point(463, 429);
            this.btn_Selected_SelectAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Selected_SelectAll.Name = "btn_Selected_SelectAll";
            this.btn_Selected_SelectAll.Size = new System.Drawing.Size(77, 32);
            this.btn_Selected_SelectAll.TabIndex = 36;
            this.btn_Selected_SelectAll.Text = "تحديد الكل";
            this.btn_Selected_SelectAll.UseVisualStyleBackColor = true;
            this.btn_Selected_SelectAll.Click += new System.EventHandler(this.btn_Selected_SelectAll_Click);
            // 
            // btn_Available_DisSelectAll
            // 
            this.btn_Available_DisSelectAll.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btn_Available_DisSelectAll.Location = new System.Drawing.Point(209, 429);
            this.btn_Available_DisSelectAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Available_DisSelectAll.Name = "btn_Available_DisSelectAll";
            this.btn_Available_DisSelectAll.Size = new System.Drawing.Size(73, 32);
            this.btn_Available_DisSelectAll.TabIndex = 35;
            this.btn_Available_DisSelectAll.Text = "إلغاء الكل";
            this.btn_Available_DisSelectAll.UseVisualStyleBackColor = true;
            this.btn_Available_DisSelectAll.Click += new System.EventHandler(this.btn_Available_DisSelectAll_Click);
            // 
            // btn_Available_SelectAll
            // 
            this.btn_Available_SelectAll.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btn_Available_SelectAll.Location = new System.Drawing.Point(125, 429);
            this.btn_Available_SelectAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Available_SelectAll.Name = "btn_Available_SelectAll";
            this.btn_Available_SelectAll.Size = new System.Drawing.Size(77, 32);
            this.btn_Available_SelectAll.TabIndex = 34;
            this.btn_Available_SelectAll.Text = "تحديد الكل";
            this.btn_Available_SelectAll.UseVisualStyleBackColor = true;
            this.btn_Available_SelectAll.Click += new System.EventHandler(this.btn_Available_SelectAll_Click);
            // 
            // dgv_AvailableVac
            // 
            this.dgv_AvailableVac.AllowUserToAddRows = false;
            this.dgv_AvailableVac.AllowUserToDeleteRows = false;
            this.dgv_AvailableVac.AllowUserToOrderColumns = true;
            this.dgv_AvailableVac.AllowUserToResizeColumns = false;
            this.dgv_AvailableVac.AllowUserToResizeRows = false;
            this.dgv_AvailableVac.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_AvailableVac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AvailableVac.ColumnHeadersVisible = false;
            this.dgv_AvailableVac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn5,
            this.dataGridViewTextBoxColumn11,
            this.ID2});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_AvailableVac.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_AvailableVac.GridColor = System.Drawing.SystemColors.Window;
            this.dgv_AvailableVac.Location = new System.Drawing.Point(101, 146);
            this.dgv_AvailableVac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_AvailableVac.Name = "dgv_AvailableVac";
            this.dgv_AvailableVac.RowHeadersVisible = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 10F);
            this.dgv_AvailableVac.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_AvailableVac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AvailableVac.Size = new System.Drawing.Size(224, 275);
            this.dgv_AvailableVac.TabIndex = 33;
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.HeaderText = "chk";
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            this.dataGridViewCheckBoxColumn5.Width = 20;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn11.HeaderText = "Name";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 112;
            // 
            // ID2
            // 
            this.ID2.DataPropertyName = "ID";
            this.ID2.HeaderText = "ID";
            this.ID2.Name = "ID2";
            this.ID2.Visible = false;
            // 
            // btn_b
            // 
            this.btn_b.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_b.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_b.Location = new System.Drawing.Point(331, 275);
            this.btn_b.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_b.Name = "btn_b";
            this.btn_b.Size = new System.Drawing.Size(30, 32);
            this.btn_b.TabIndex = 32;
            this.btn_b.Text = "<";
            this.btn_b.UseVisualStyleBackColor = true;
            this.btn_b.Click += new System.EventHandler(this.btn_b_Click);
            // 
            // btn_f
            // 
            this.btn_f.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_f.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_f.Location = new System.Drawing.Point(331, 235);
            this.btn_f.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_f.Name = "btn_f";
            this.btn_f.Size = new System.Drawing.Size(30, 32);
            this.btn_f.TabIndex = 31;
            this.btn_f.Text = ">";
            this.btn_f.UseVisualStyleBackColor = true;
            this.btn_f.Click += new System.EventHandler(this.btn_f_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "الأجازات المتاحة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "الأجازات المحددة";
            // 
            // dgv_SelectedVac
            // 
            this.dgv_SelectedVac.AllowUserToAddRows = false;
            this.dgv_SelectedVac.AllowUserToDeleteRows = false;
            this.dgv_SelectedVac.AllowUserToOrderColumns = true;
            this.dgv_SelectedVac.AllowUserToResizeColumns = false;
            this.dgv_SelectedVac.AllowUserToResizeRows = false;
            this.dgv_SelectedVac.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_SelectedVac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SelectedVac.ColumnHeadersVisible = false;
            this.dgv_SelectedVac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn4,
            this.N,
            this.ID,
            this.Bonus,
            this.lbl});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SelectedVac.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_SelectedVac.GridColor = System.Drawing.SystemColors.Window;
            this.dgv_SelectedVac.Location = new System.Drawing.Point(367, 146);
            this.dgv_SelectedVac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_SelectedVac.Name = "dgv_SelectedVac";
            this.dgv_SelectedVac.RowHeadersVisible = false;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 10F);
            this.dgv_SelectedVac.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_SelectedVac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SelectedVac.Size = new System.Drawing.Size(336, 275);
            this.dgv_SelectedVac.TabIndex = 28;
            this.dgv_SelectedVac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SelectedVac_CellClick);
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.HeaderText = "chk";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.Width = 20;
            // 
            // N
            // 
            this.N.DataPropertyName = "Name";
            this.N.HeaderText = "Name";
            this.N.Name = "N";
            this.N.Width = 170;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Bonus
            // 
            this.Bonus.HeaderText = "Bonus";
            this.Bonus.Name = "Bonus";
            this.Bonus.Width = 20;
            // 
            // lbl
            // 
            this.lbl.HeaderText = "lbl";
            this.lbl.Name = "lbl";
            // 
            // btn_VacAdd
            // 
            this.btn_VacAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_VacAdd.FlatAppearance.BorderSize = 0;
            this.btn_VacAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VacAdd.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_VacAdd.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_VacAdd.Location = new System.Drawing.Point(251, 97);
            this.btn_VacAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_VacAdd.Name = "btn_VacAdd";
            this.btn_VacAdd.Size = new System.Drawing.Size(36, 32);
            this.btn_VacAdd.TabIndex = 38;
            this.btn_VacAdd.Text = "+";
            this.btn_VacAdd.UseVisualStyleBackColor = true;
            this.btn_VacAdd.Click += new System.EventHandler(this.VacAdd_Click);
            // 
            // frm_VacWS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_VacAdd);
            this.Controls.Add(this.btn_Selected_DisSelectAll);
            this.Controls.Add(this.btn_Selected_SelectAll);
            this.Controls.Add(this.btn_Available_DisSelectAll);
            this.Controls.Add(this.btn_Available_SelectAll);
            this.Controls.Add(this.dgv_AvailableVac);
            this.Controls.Add(this.btn_b);
            this.Controls.Add(this.btn_f);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_SelectedVac);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_VacWS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحديد الأجازات";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_VacWS_FormClosing);
            this.Shown += new System.EventHandler(this.frm_VacWS_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AvailableVac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectedVac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Selected_DisSelectAll;
        private System.Windows.Forms.Button btn_Selected_SelectAll;
        private System.Windows.Forms.Button btn_Available_DisSelectAll;
        private System.Windows.Forms.Button btn_Available_SelectAll;
        private System.Windows.Forms.DataGridView dgv_AvailableVac;
        private System.Windows.Forms.Button btn_b;
        private System.Windows.Forms.Button btn_f;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_SelectedVac;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Bonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbl;
        private System.Windows.Forms.Button btn_VacAdd;
    }
}