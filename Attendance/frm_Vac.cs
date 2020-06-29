using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance.Resources
{
    public partial class frm_Vac : Form
    {
        #region Declaration
        cls_BL.Vac Vac = new cls_BL.Vac();
        DataTable dt_Vac = new DataTable();
        int record_index;
        #endregion

        public frm_Vac()
        {
            InitializeComponent();

            dgv_Vac.AutoGenerateColumns = false;
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

                    txt_VacName.ReadOnly = false;
                    com_MM.Enabled = true;
                    com_dd.Enabled = true;
                    dgv_Vac.Enabled = false;

                    txt_ID.Text = "";
                    txt_VacName.Text = "";
                    com_MM.SelectedValue = -1;
                    com_dd.SelectedValue = -1;


                    txt_VacName.Focus();
                    break;

                case "Edit":

                    btn_New.Visible = false;
                    btn_Edit.Visible = false;
                    btn_Save.Visible = true;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = true;

                    txt_VacName.ReadOnly = false;
                    com_MM.Enabled = true;
                    com_dd.Enabled = true;
                    dgv_Vac.Enabled = false;

                    txt_VacName.Select();
                    break;

                case "Select":

                    btn_New.Visible = true;
                    btn_Edit.Visible = true;
                    btn_Save.Visible = false;
                    btn_Delete.Visible = true;
                    btn_Cancel.Visible = false;

                    txt_VacName.ReadOnly = true;
                    com_MM.Enabled = false;
                    com_dd.Enabled = false;
                    dgv_Vac.Enabled = true;

                    foreach (DataRow r in dt_Vac.Rows)
                    {
                        if (r["ID"].ToString() == dgv_Vac.SelectedRows[0].Cells[0].Value.ToString())
                        {
                            txt_ID.Text = r["ID"].ToString();
                            txt_VacName.Text = r["Name"].ToString();
                            com_MM.Text = r["MM"].ToString();
                            com_dd.Text = r["dd"].ToString();
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

                    txt_VacName.ReadOnly = true;
                    com_MM.Enabled = false;
                    com_dd.Enabled = false;
                    dgv_Vac.Enabled = true;

                    txt_ID.Text = "";
                    txt_VacName.Text = "";
                    com_MM.SelectedValue = -1;
                    com_dd.SelectedValue = -1;

                    if (dgv_Vac.CurrentRow != null) dgv_Vac.CurrentRow.Selected = false;
                    break;
            }
        }
        void Var()
        {
            Vac.ID = (txt_ID.Text != "") ? Convert.ToInt16(txt_ID.Text) : 0;
            Vac.Name = txt_VacName.Text.Trim();
            Vac.MM = com_MM.Text;
            Vac.dd = com_dd.Text;
        }
        void Refresh_Data()
        {
            dt_Vac = Vac.Select();
            dgv_Vac.DataSource = dt_Vac;
        }
        #endregion

        #region Form
        private void frm_Vac_Shown(object sender, EventArgs e)
        {
            if (dgv_Vac.RowCount > 0)
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
            record_index = dgv_Vac.SelectedRows[0].Index;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Var();
            if (Tag.ToString() == "New")
            {
                Vac.Insert();
                Refresh_Data();
                dgv_Vac.CurrentCell = dgv_Vac.Rows[dgv_Vac.RowCount - 1].Cells[0];
            }
            else if (Tag.ToString() == "Edit")
            {
                Vac.Update();
                Refresh_Data();
                dgv_Vac.CurrentCell = dgv_Vac.Rows[record_index].Cells[0];
            }

            Tag = "Select";
            Form_Mode("Select");
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل بالفعل تريد حذف إدارة " + txt_VacName.Text, "حذف إدارة", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                return;
            }

            Var();
            Vac.Delete();
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

        #region dgv_Vacd
        private void dgv_Vac_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Form_Mode("Select");

        }
        #endregion
    }
}
