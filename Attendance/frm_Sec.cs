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
    public partial class frm_Sec : Form
    {
        #region Declaration
        cls_BL.Sec Sec = new cls_BL.Sec();
        DataTable dt_Sec = new DataTable();
        int record_index;
        #endregion

        public frm_Sec()
        {
            InitializeComponent();

            dgv_Sec.AutoGenerateColumns = false;
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
                    txt_SecName.ReadOnly = false;
                    dgv_Sec.Enabled = false;

                    txt_ID.Text = "";
                    txt_SecName.Text = "";


                    txt_SecName.Focus();
                    break;

                case "Edit":

                    btn_New.Visible = false;
                    btn_Edit.Visible = false;
                    btn_Save.Visible = true;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = true;
                    txt_SecName.ReadOnly = false;

                    dgv_Sec.Enabled = false;

                    txt_SecName.Select();
                    break;

                case "Select":

                    btn_New.Visible = true;
                    btn_Edit.Visible = true;
                    btn_Save.Visible = false;
                    btn_Delete.Visible = true;
                    btn_Cancel.Visible = false;
                    txt_SecName.ReadOnly = true;
                    dgv_Sec.Enabled = true;

                    foreach (DataRow r in dt_Sec.Rows)
                    {
                        if (r["ID"].ToString() == dgv_Sec.SelectedRows[0].Cells[0].Value.ToString())
                        {
                            txt_ID.Text = r["ID"].ToString();
                            txt_SecName.Text = r["Name"].ToString();
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
                    txt_SecName.ReadOnly = true;
                    dgv_Sec.Enabled = true;

                    txt_ID.Text = "";
                    txt_SecName.Text = "";
                    if (dgv_Sec.CurrentRow != null) dgv_Sec.CurrentRow.Selected = false;
                    break;
            }
        }
        void Var()
        {
            Sec.ID = (txt_ID.Text != "") ? Convert.ToInt16(txt_ID.Text) : 0;
            Sec.Name = txt_SecName.Text.Trim();
        }
        void Refresh_Data()
        {
            dt_Sec = Sec.Select();
            dgv_Sec.DataSource = dt_Sec;
        }
        #endregion

        #region Form
        private void frm_Sec_Shown(object sender, EventArgs e)
        {
            if (dgv_Sec.RowCount > 0)
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
            record_index = dgv_Sec.SelectedRows[0].Index;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Var();
            if (Tag.ToString() == "New")
            {
                Sec.Insert();
                Refresh_Data();
                dgv_Sec.CurrentCell = dgv_Sec.Rows[dgv_Sec.RowCount - 1].Cells[0];
            }
            else if (Tag.ToString() == "Edit")
            {
                Sec.Update();
                Refresh_Data();
                dgv_Sec.CurrentCell = dgv_Sec.Rows[record_index].Cells[0];
            }

            Tag = "Select";
            Form_Mode("Select");
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل بالفعل تريد حذف قسم " + txt_SecName.Text, "حذف قسم", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                return;
            }

            Var();
            Sec.Delete();
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

        #region dgv_Secd
        private void dgv_Sec_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Form_Mode("Select");

        }
        #endregion
    }
}
