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
    public partial class frm_Device : Form
    {
        #region Declaration
        cls_BL.Device Device = new cls_BL.Device();
        DataTable dt_Device = new DataTable();
        int record_index;
        public bool New;
        #endregion

        public frm_Device()
        {
            InitializeComponent();

            dgv_Device.AutoGenerateColumns = false;
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

                    txt_ID2.ReadOnly = false;
                    txt_DeviceName.ReadOnly = false;
                    txt_IP.ReadOnly = false;
                    txt_Port.ReadOnly = false;

                    dgv_Device.Enabled = false;
                    dgv_Device.ClearSelection();

                    txt_DeviceID.Text = "";
                    txt_ID2.Text = (New == false)?"" : txt_ID2.Text;
                    txt_DeviceName.Text = "";
                    txt_IP.Text = "";
                    txt_Port.Text = "";

                    if(New == true)
                    {
                        txt_DeviceName.Focus();
                    }
                    else
                    {
                        txt_ID2.Focus();
                    }

                    break;
                #endregion
                #region Edit
                case "Edit":

                    btn_New.Visible = false;
                    btn_Edit.Visible = false;
                    btn_Save.Visible = true;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = true;
                    txt_DeviceName.ReadOnly = false;
                    txt_ID2.ReadOnly = false;
                    txt_IP.ReadOnly = false;
                    txt_Port.ReadOnly = false;
                    dgv_Device.Enabled = false;

                    txt_ID2.Select();
                    break;
                #endregion
                #region Select
                case "Select":

                    btn_New.Visible = true;
                    btn_Edit.Visible = true;
                    btn_Save.Visible = false;
                    btn_Delete.Visible = true;
                    btn_Cancel.Visible = false;
                    txt_DeviceName.ReadOnly = true;
                    txt_ID2.ReadOnly = true;
                    txt_IP.ReadOnly = true;
                    txt_Port.ReadOnly = true;

                    dgv_Device.Enabled = true;

                    foreach (DataRow r in dt_Device.Rows)
                    {
                        if(dgv_Device.SelectedRows.Count == 0)
                        {
                            dgv_Device.Rows[0].Selected = true;
                        }
                        if (r["ID"].ToString() == dgv_Device.SelectedRows[0].Cells[0].Value.ToString())
                        {
                            txt_DeviceID.Text = r["ID"].ToString();
                            txt_ID2.Text = r["ID2"].ToString();
                            txt_DeviceName.Text = r["Name"].ToString();
                            txt_IP.Text = r["ip"].ToString();
                            txt_Port.Text = r["port"].ToString();
                            break;
                        }
                    }
                    New = false;

                    break;
                #endregion
                #region Empty
                case "Empty":

                    btn_New.Visible = true;
                    btn_Edit.Visible = false;
                    btn_Save.Visible = false;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = false;
                    txt_DeviceName.ReadOnly = true;
                    txt_ID2.ReadOnly = true;
                    txt_IP.ReadOnly = true;
                    txt_Port.ReadOnly = true;

                    dgv_Device.Enabled = true;

                    txt_DeviceID.Text = "";
                    txt_DeviceName.Text = "";
                    txt_ID2.Text = "";
                    txt_IP.Text = "";
                    txt_Port.Text = "";
                    if (dgv_Device.CurrentRow != null) dgv_Device.CurrentRow.Selected = false;
                    break;
                    #endregion
            }
        }
        void Var()
        {
            Device.ID = (txt_DeviceID.Text != "") ? Convert.ToInt16(txt_DeviceID.Text) : 0;
            Device.ID2 = txt_ID2.Text.Trim();
            Device.Name = txt_DeviceName.Text.Trim();
            Device.ip = txt_IP.Text.Trim();
            Device.port = txt_Port.Text.Trim();
        }
        void Refresh_Data()
        {
            dt_Device = Device.Select();
            dgv_Device.DataSource = dt_Device;
            if (dgv_Device.Rows.Count > 0)
            {
                dgv_Device.CurrentCell = dgv_Device.Rows[0].Cells[0];
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
            if(New == true)
            {
                Tag = "New";
                Form_Mode("New");
                return;
            }
            if (dgv_Device.RowCount > 0)
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
            Tag = "New";
            Form_Mode("New");
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Tag = "Edit";
            Form_Mode("Edit");
            record_index = dgv_Device.SelectedRows[0].Index;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(txt_ID2.Text.Trim() == "No Device Code")
            {
                MessageBox.Show("لا يمكن الحفظ بهذا الكود", "حفظ جهاز", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Var();
            if (Tag.ToString() == "New")
            {
                Device.Insert();
                Refresh_Data();
                dgv_Device.CurrentCell = dgv_Device.Rows[dgv_Device.RowCount - 1].Cells[0];
            }
            else if (Tag.ToString() == "Edit")
            {
                Device.Update();
                Refresh_Data();
                dgv_Device.CurrentCell = dgv_Device.Rows[record_index].Cells[0];
            }

            Tag = "Select";
            Form_Mode("Select");            
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل بالفعل تريد حذف هذا الجهاز", "حذف جهاز", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                return;
            }

            Var();
            Device.Delete();
            Refresh_Data();
            if (dgv_Device.RowCount > 0)
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
            if (Tag.ToString() == "New")
            {
                Tag = "Empty";
                Form_Mode("Empty");
            }
            else if (Tag.ToString() == "Edit")
            {
                Tag = "Select";
                Form_Mode("Select");
            }
        }
        private void btn_Logo_Click(object sender, EventArgs e)
        {
            if (Tag.ToString() != "Empty" && Tag.ToString() != "Select") return;
            frm_New n = new frm_New();
            n.Text = "أجهزة غير مسجلة";
            n.device = this;
            n.Tag = "Device";
            n.list_New.ValueMember = "Device_ID";
            n.list_New.DisplayMember = "Device_ID";
            n.list_New.DataSource = Device.SelectNew();
            n.label1.Text = n.list_New.Items.Count.ToString() + " غير مسجل";
            n.ShowDialog();
            txt_DeviceName.Focus();
        }
        #endregion

        #region dgv_Userd
        private void dgv_Users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Form_Mode("Select");
        }
        #endregion
    }
}
