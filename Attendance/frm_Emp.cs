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
    public partial class frm_Emp : Form
    {
        #region Declaration
        public bool Demo;
        cls_BL.Emp Emp = new cls_BL.Emp();
        cls_BL.WorkSys WorkSys = new cls_BL.WorkSys();
        cls_BL.Device Device = new cls_BL.Device();
        cls_BL.Depart Depart = new cls_BL.Depart();
        cls_BL.Sec Sec = new cls_BL.Sec();
        DataTable dt_Emp = new DataTable();
        int record_index;
        #endregion

        public frm_Emp()
        {
            InitializeComponent();

            dgv_Emp.AutoGenerateColumns = false;
            Refresh_Data();
        }

        #region Pro
        void Form_Mode(string mode)
        {
            switch (mode)
            {
                #region New
                case "New":

                    btn_New.Visible = false;
                    btn_Edit.Visible = false;
                    btn_Save.Visible = true;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = true;

                    txt_EmpID2.ReadOnly = false;
                    txt_EmpName.ReadOnly = false;
                    com_Device.Enabled = true;
                    com_Depart.Enabled = true;
                    com_Sec.Enabled = true;
                    com_WS.Enabled = true;
                    dgv_Emp.Enabled = false;

                    btn_Add_WS.Visible = true;
                    btn_Add_Depart.Visible = true;
                    btn_Add_Sec.Visible = true;
                    btn_Add_Device.Visible = true;
                    btn_Delete_Depart.Visible = true;
                    btn_Delete_Sec.Visible = true;
                    btn_Delete_Device.Visible = true;

                    txt_EmpID.Text = "";
                    txt_EmpID2.Text = "";
                    txt_EmpName.Text = "";
                    com_Device.SelectedValue = -1;
                    com_Depart.SelectedValue = -1;
                    com_Sec.SelectedValue = -1;
                    com_WS.SelectedValue = -1;

                    txt_EmpID2.Focus();
                    break;
                #endregion
                #region Edit
                case "Edit":

                    btn_New.Visible = false;
                    btn_Edit.Visible = false;
                    btn_Save.Visible = true;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = true;

                    txt_EmpName.ReadOnly = false;
                    com_Device.Enabled = true;
                    com_Depart.Enabled = true;
                    com_Sec.Enabled = true;
                    com_WS.Enabled = true;
                    dgv_Emp.Enabled = false;

                    btn_Add_WS.Visible = true;
                    btn_Add_Depart.Visible = true;
                    btn_Add_Sec.Visible = true;
                    btn_Add_Device.Visible = true;
                    btn_Delete_Depart.Visible = true;
                    btn_Delete_Sec.Visible = true;
                    btn_Delete_Device.Visible = true;

                    break;
                #endregion
                #region Select
                case "Select":

                    btn_New.Visible = true;
                    btn_Edit.Visible = true;
                    btn_Save.Visible = false;
                    btn_Delete.Visible = true;
                    btn_Cancel.Visible = false;

                    txt_EmpID2.ReadOnly = true;
                    txt_EmpName.ReadOnly = true;
                    com_Device.Enabled = false;
                    com_Depart.Enabled = false;
                    com_Sec.Enabled = false;
                    com_WS.Enabled = false;
                    dgv_Emp.Enabled = true;

                    btn_Add_WS.Visible = false ;
                    btn_Add_Depart.Visible = false;
                    btn_Add_Sec.Visible = false;
                    btn_Add_Device.Visible = false;
                    btn_Delete_Depart.Visible = false;
                    btn_Delete_Sec.Visible = false;
                    btn_Delete_Device.Visible = false;

                    foreach (DataRow r in dt_Emp.Rows)
                    {
                        if (r["ID2"].ToString() == dgv_Emp.SelectedRows[0].Cells[0].Value.ToString())
                        {
                            txt_EmpID.Text = r["ID"].ToString();
                            txt_EmpID2.Text = r["ID2"].ToString();
                            txt_EmpName.Text = r["Name"].ToString();
                            com_Device.SelectedValue = r["Device"];
                            com_Depart.SelectedValue = r["Depart"];
                            com_Sec.SelectedValue = r["Sec"];
                            com_WS.SelectedValue = r["WS"];
                            break;
                        }
                    }

                    break;
                #endregion
                #region Empty
                case "Empty":

                    txt_EmpID.ReadOnly = true;
                    txt_EmpID2.ReadOnly = true;
                    btn_New.Visible = true;
                    btn_Edit.Visible = false;
                    btn_Save.Visible = false;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = false;
                    txt_EmpName.ReadOnly = true;
                    dgv_Emp.Enabled = true;

                    txt_EmpID.Text = "";
                    txt_EmpID2.Text = "";
                    txt_EmpName.Text = "";
                    if(dgv_Emp.CurrentRow != null) dgv_Emp.CurrentRow.Selected = false;

                    com_Device.Enabled = false;
                    com_Depart.Enabled = false;
                    com_Sec.Enabled = false;
                    com_WS.Enabled = false;

                    btn_Add_WS.Visible = false;
                    btn_Add_Depart.Visible = false;
                    btn_Add_Sec.Visible = false;
                    btn_Add_Device.Visible = false;
                    btn_Delete_Depart.Visible = false;
                    btn_Delete_Sec.Visible = false;
                    btn_Delete_Device.Visible = false;

                    break;
                    #endregion
            }
        }
        void Var()
        {
            Emp.ID = (txt_EmpID.Text != "") ? Convert.ToInt16(txt_EmpID.Text) : 0;
            Emp.ID2 = txt_EmpID2.Text.Trim();
            Emp.Name = txt_EmpName.Text.Trim();
            Emp.Device = (com_Device.SelectedValue != null)? com_Device.SelectedValue.ToString() : "";
            Emp.Depart = (com_Depart.SelectedValue != null) ? com_Depart.SelectedValue.ToString() : "";
            Emp.Sec = (com_Sec.SelectedValue != null) ? com_Sec.SelectedValue.ToString() : "";
            Emp.WS = Convert.ToInt16(com_WS.SelectedValue);
        }
        void Refresh_Data()
        {
            dt_Emp = Emp.Select();
            dgv_Emp.DataSource = dt_Emp;
            com_Device.DataSource = Device.Select();
            com_Depart.DataSource = Depart.Select();
            com_Sec.DataSource = Sec.Select();
            com_WS.DataSource = WorkSys.Select();

            if (dgv_Emp.Rows.Count > 0)
            {
                dgv_Emp.CurrentCell = dgv_Emp.Rows[0].Cells[0];
                Form_Mode("Select");
            }
            else
            {
                Form_Mode("Empty");
            }
        }
        #endregion

        #region Form
        private void frm_Users_Shown(object sender, EventArgs e)
        {
            if (dgv_Emp.RowCount > 0)
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
        public void btn_New_Click(object sender, EventArgs e)
        {
            if (Demo)
            {
                if (Emp.Select_Cout() >= 3)
                {
                    MessageBox.Show("هذه نسخة تجريبية ولا يمكن اضافة أكثر من 3 موظفين", "نسخة تجريبية", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }

            Tag = "New";
            Form_Mode("New");
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Tag = "Edit";
            Form_Mode("Edit");
            record_index = dgv_Emp.SelectedRows[0].Index;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(txt_EmpID2.Text.Trim() == "")
            {
                MessageBox.Show("يجب إدخال كود الموظف", "حفظ بيانات موظف", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_EmpID2.Focus();
                return;
            }
            if (txt_EmpName.Text.Trim() == "")
            {
                MessageBox.Show("يجب إدخال أسم الموظف", "حفظ بيانات موظف", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_EmpName.Focus();
                return;
            }
            if (com_WS.SelectedValue == null)
            {
                MessageBox.Show("يجب إدخال نظام دوام الموظف", "حفظ بيانات موظف", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                com_WS.DroppedDown = true;
                return;
            }
            Var();
            if (Tag.ToString() == "New")
            {
                Emp.Insert();
                Refresh_Data();
                dgv_Emp.CurrentCell = dgv_Emp.Rows[dgv_Emp.RowCount - 1].Cells[0];
            }
            else if (Tag.ToString() == "Edit")
            {
                Emp.Update();
                Refresh_Data();
                dgv_Emp.CurrentCell = dgv_Emp.Rows[record_index].Cells[0];
            }

            Tag = "Select";
            Form_Mode("Select");
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل بالفعل تريد حذف هذا الموظف", "حذف موظف", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                return;
            }

            Var();
            Emp.Delete();
            Refresh_Data();
            if (dgv_Emp.RowCount > 0)
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
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if(Tag.ToString() == "New")
            {
                Tag = "Empty";
                Form_Mode("Empty");
            }
            else if(Tag.ToString() == "Edit")
            {
                Tag = "Select";
                Form_Mode("Select");
            }
        }
        private void btn_Logo_Click(object sender, EventArgs e)
        {
            if (Tag.ToString() != "Empty" && Tag.ToString() != "Select") return;
            frm_New n = new frm_New();
            n.Text = "موظفين غير مسجلين";
            n.emp = this;
            n.Tag = "Emp";
            n.list_New.ValueMember = "Emp_ID";
            n.list_New.DisplayMember = "Emp_ID";
            n.list_New.DataSource = Emp.SelectNew();
            n.label1.Text = n.list_New.Items.Count.ToString() + " غير مسجل";
            n.ShowDialog();
            txt_EmpName.Focus();
        }
        #endregion

        #region dgv_Userd
        private void dgv_Users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Tag.ToString() == "Select" || Tag.ToString() == "Empty")
            {
                Form_Mode("Select");
            }
        }
        #endregion

        #region com
        private void btn_Add_WS_Click(object sender, EventArgs e)
        {
            frm_WorkSys frm_ws = new frm_WorkSys();
            frm_ws.ShowDialog();
            com_WS.DataSource = WorkSys.Select();
            com_WS.SelectedValue = frm_ws.txt_ID.Text;
        }
        private void btn_Add_Depart_Click(object sender, EventArgs e)
        {
            frm_Depart frm_Depart = new frm_Depart();
            frm_Depart.ShowDialog();
            com_Depart.DataSource = Depart.Select();
            com_Depart.SelectedValue = frm_Depart.txt_ID.Text;
        }
        private void btn_Add_Sec_Click(object sender, EventArgs e)
        {
            frm_Sec frm_Sec = new frm_Sec();
            frm_Sec.ShowDialog();
            com_Sec.DataSource = Sec.Select();
            com_Sec.SelectedValue = frm_Sec.txt_ID.Text;
        }
        private void btn_Add_Device_Click(object sender, EventArgs e)
        {
            frm_Device frm_Device = new frm_Device();
            frm_Device.ShowDialog();
            com_Device.DataSource = Device.Select();
            com_Device.SelectedValue = frm_Device.txt_ID2.Text;
        }
        private void btn_Delete_Depart_Click(object sender, EventArgs e)
        {
            com_Depart.SelectedValue = -1;
        }
        private void btn_Delete_Sec_Click(object sender, EventArgs e)
        {
            com_Sec.SelectedValue = -1;
        }
        private void btn_Delete_Device_Click(object sender, EventArgs e)
        {
            com_Device.SelectedValue = -1;
        }
        #endregion
    }
}
