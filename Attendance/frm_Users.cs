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
    public partial class frm_Users : Form
    {
        #region Declaration
        cls_BL.Users users = new cls_BL.Users();
        DataTable dt_users = new DataTable();
        int record_index;
        #endregion

        public frm_Users()
        {
            InitializeComponent();

            dgv_Users.AutoGenerateColumns = false;
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
                    txt_UserName.ReadOnly = false;
                    txt_UserPassword.ReadOnly = false;
                    dgv_Users.Enabled = false;

                    txt_UserID.Text = "";
                    txt_UserName.Text = "";
                    txt_UserPassword.Text = "";

                    txt_UserName.Focus();
                    break;

                case "Edit":

                    btn_New.Visible = false;
                    btn_Edit.Visible = false;
                    btn_Save.Visible = true;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = true;
                    txt_UserName.ReadOnly = false;
                    txt_UserPassword.ReadOnly = false;
                    dgv_Users.Enabled = false;

                    txt_UserPassword.Select();
                    break;

                case "Select":

                    btn_New.Visible = true;
                    btn_Edit.Visible = true;
                    btn_Save.Visible = false;
                    btn_Delete.Visible = true;
                    btn_Cancel.Visible = false;
                    txt_UserName.ReadOnly = true;
                    txt_UserPassword.ReadOnly = true;
                    dgv_Users.Enabled = true;

                    foreach (DataRow r in dt_users.Rows)
                    {
                        if(r["ID"].ToString() == dgv_Users.SelectedRows[0].Cells[0].Value.ToString())
                        {
                            txt_UserID.Text = r["ID"].ToString();
                            txt_UserName.Text = r["Name"].ToString();
                            txt_UserPassword.Text = r["Password"].ToString();
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
                    txt_UserName.ReadOnly = true;
                    txt_UserPassword.ReadOnly = true;
                    dgv_Users.Enabled = true;

                    txt_UserID.Text = "";
                    txt_UserName.Text = "";
                    txt_UserPassword.Text = "";
                    dgv_Users.CurrentRow.Selected = false;
                    break;
            }
        }
        void Var()
        {
            users.ID = (txt_UserID.Text != "")? Convert.ToInt16(txt_UserID.Text) : 0;
            users.Name = txt_UserName.Text.Trim();
            users.Password = txt_UserPassword.Text.Trim();
        }
        void Refresh_Data()
        {
            dt_users = users.Select();
            dgv_Users.DataSource = dt_users;
        }
        #endregion

        #region Form
        private void frm_Users_Shown(object sender, EventArgs e)
        {
            if(dgv_Users.RowCount > 0)
            {
                Tag = "Select";
                Form_Mode("Select");
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
            record_index = dgv_Users.SelectedRows[0].Index;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Var();
            if (Tag.ToString() == "New")
            {
                users.Insert();
                Refresh_Data();
                dgv_Users.CurrentCell = dgv_Users.Rows[dgv_Users.RowCount-1].Cells[0];
            }
            else if (Tag.ToString() == "Edit")
            {
                users.Update();
                Refresh_Data();
                dgv_Users.CurrentCell = dgv_Users.Rows[record_index].Cells[0];
            }

            Tag = "Select";
            Form_Mode("Select");
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(dgv_Users.SelectedRows[0].Index == 0)
            {
                MessageBox.Show("لا يمكن حذف أول مستخدم", "حذف مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (MessageBox.Show("هل بالفعل تريد حذف هذا المستخدم", "حذف مستخدم", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                return;
            }

            Var();
            users.Delete();
            Refresh_Data();
            Tag = "Select";
            Form_Mode("Select");
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Tag = "Select";
            Form_Mode("Select");
        }
        #endregion

        #region dgv_Userd
        private void dgv_Users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Tag.ToString() == "Select")
            {
                Form_Mode("Select");
            }
        }
        #endregion

    }
}
