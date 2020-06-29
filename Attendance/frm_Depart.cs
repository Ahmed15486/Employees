using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance
{
    public partial class frm_Depart : Form
    {
        #region Declaration
        cls_BL.Depart Depart = new cls_BL.Depart();
        DataTable dt_Depart = new DataTable();
        int record_index;
        #endregion

        public frm_Depart()
        {
            InitializeComponent();

            dgv_Depart.AutoGenerateColumns = false;
            Refresh_Data();
        }

        #region Pro
        void Form_Mode(string mode)
        {
            switch (mode)
            {
                case "New":

                    btn_New.Visible = false;
                    btn_Edit.Visible = false;
                    btn_Save.Visible = true;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = true;
                    txt_DepartName.ReadOnly = false;
                    dgv_Depart.Enabled = false;

                    txt_ID.Text = "";
                    txt_DepartName.Text = "";


                    txt_DepartName.Focus();
                    break;

                case "Edit":

                    btn_New.Visible = false;
                    btn_Edit.Visible = false;
                    btn_Save.Visible = true;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = true;
                    txt_DepartName.ReadOnly = false;

                    dgv_Depart.Enabled = false;

                    txt_DepartName.Select();
                    break;

                case "Select":

                    btn_New.Visible = true;
                    btn_Edit.Visible = true;
                    btn_Save.Visible = false;
                    btn_Delete.Visible = true;
                    btn_Cancel.Visible = false;
                    txt_DepartName.ReadOnly = true;
                    dgv_Depart.Enabled = true;

                    foreach (DataRow r in dt_Depart.Rows)
                    {
                        if (r["ID"].ToString() == dgv_Depart.SelectedRows[0].Cells[0].Value.ToString())
                        {
                            txt_ID.Text = r["ID"].ToString();
                            txt_DepartName.Text = r["Name"].ToString();
                            break;
                        }
                    }

                    break;

                case "Empty":

                    btn_New.Visible = true;
                    btn_Edit.Visible = false;
                    btn_Save.Visible = false;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = false;
                    txt_DepartName.ReadOnly = true;
                    dgv_Depart.Enabled = true;

                    txt_ID.Text = "";
                    txt_DepartName.Text = "";
                    if(dgv_Depart.CurrentRow != null) dgv_Depart.CurrentRow.Selected = false;
                    break;
            }
        }
        void Var()
        {
            Depart.ID = (txt_ID.Text != "") ? Convert.ToInt16(txt_ID.Text) : 0;
            Depart.Name = txt_DepartName.Text.Trim();
        }
        void Refresh_Data()
        {
            dt_Depart = Depart.Select();
            dgv_Depart.DataSource = dt_Depart;
        }
        #endregion

        #region Form
        private void frm_Depart_Shown(object sender, EventArgs e)
        {
            if (dgv_Depart.RowCount > 0)
            {
                Tag = "Select";
                Form_Mode("Select");
            }
            else
            {
                Tag = "Empty";
                Form_Mode("Empty");
            }
        }

        #endregion

        #region Control
        private void btn_New_Click(object sender, EventArgs e)
        {
            Tag = "New";
            Form_Mode("New");
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Tag = "Edit";
            Form_Mode("Edit");
            record_index = dgv_Depart.SelectedRows[0].Index;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Var();
            if (Tag.ToString() == "New")
            {
                Depart.Insert();
                Refresh_Data();
                dgv_Depart.CurrentCell = dgv_Depart.Rows[dgv_Depart.RowCount - 1].Cells[0];
            }
            else if (Tag.ToString() == "Edit")
            {
                Depart.Update();
                Refresh_Data();
                dgv_Depart.CurrentCell = dgv_Depart.Rows[record_index].Cells[0];
            }

            Tag = "Select";
            Form_Mode("Select");
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل بالفعل تريد حذف إدارة " + txt_DepartName.Text, "حذف إدارة", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                return;
            }

            Var();
            Depart.Delete();
            Refresh_Data();
            Tag = "Empty";
            Form_Mode("Empty");
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Tag = "Select";
            Form_Mode("Select");
        }
        #endregion

        #region dgv_Departd
        private void dgv_Depart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
     
                Form_Mode("Select");
            
        }
        #endregion
    }
}
