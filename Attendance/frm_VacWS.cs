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
    public partial class frm_VacWS : Form
    {
        #region Declarations
        cls_BL.Vac vac = new cls_BL.Vac();
        DataTable dt_AvailableVac = new DataTable();
        DataTable dt_SelectedVac = new DataTable();
        public string WSID;
        #endregion

        public frm_VacWS()
        {
            InitializeComponent();
        }

        #region Form
        private void frm_VacWS_Shown(object sender, EventArgs e)
        {            
            FillAvailable();
            FillSelected();
        }
        private void frm_VacWS_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dictionary<string, int> sv = new Dictionary<string, int>();
            for (int i = 0; i < dgv_SelectedVac.RowCount; i++)
            {
                if (Convert.ToBoolean(dgv_SelectedVac.Rows[i].Cells[3].Value) == true)
                {
                    sv.Add(dgv_SelectedVac.Rows[i].Cells["ID"].Value.ToString(), 1);
                }
                else
                {
                    sv.Add(dgv_SelectedVac.Rows[i].Cells["ID"].Value.ToString(), 0);
                }
            }
            vac.Insert(sv, WSID);
        }
        #endregion

        #region Pro
        void FillAvailable()
        {
            dt_AvailableVac = vac.Select();
            dgv_AvailableVac.Rows.Clear();
            foreach (DataRow r in dt_AvailableVac.Rows)
            {
                dgv_AvailableVac.Rows.Add(false, r["Name"].ToString(), r["ID"].ToString());
            }
        }
        void FillSelected()
        {
            dt_SelectedVac = vac.Select_SelectedVac(WSID);
            dgv_SelectedVac.Rows.Clear();
            foreach (DataRow r in dt_SelectedVac.Rows)
            {
                dgv_SelectedVac.Rows.Add(false, r["Name"].ToString(), r["VacID"].ToString(),Convert.ToBoolean(r["Bonus"]),"يحتسب إضافي");

                for (int i = 0; i < dgv_AvailableVac.RowCount; i++)
                {
                    if (r["VacID"].ToString() == dgv_AvailableVac.Rows[i].Cells["ID2"].Value.ToString())
                    {
                        dgv_AvailableVac.Rows.RemoveAt(i);
                        i--;
                        break;
                    }
                }  
            }
        }
        #endregion

        #region btn
        private void VacAdd_Click(object sender, EventArgs e)
        {
            Attendance.Resources.frm_Vac vac = new Resources.frm_Vac();
            vac.ShowDialog();
            FillAvailable();
            FillSelected();
        }
        private void btn_Available_SelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv_AvailableVac.Rows)
            {
                r.Cells[0].Value = true;
            }
        }
        private void btn_Available_DisSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv_AvailableVac.Rows)
            {
                r.Cells[0].Value = false;
            }
        }
        private void btn_Selected_SelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv_SelectedVac.Rows)
            {
                r.Cells[0].Value = true;
            }
        }
        private void btn_Selected_DisSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv_SelectedVac.Rows)
            {
                r.Cells[0].Value = false;
            }
        }
        private void btn_f_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_AvailableVac.RowCount; i++)
            {
                if (Convert.ToBoolean(dgv_AvailableVac.Rows[i].Cells[0].Value) == true)
                {
                    dgv_SelectedVac.Rows.Add(false, dgv_AvailableVac.Rows[i].Cells[1].Value.ToString(), dgv_AvailableVac.Rows[i].Cells[2].Value.ToString(),false,"يحتسب إضافي");
                    dgv_AvailableVac.Rows.RemoveAt(i);
                    i--;                
                }
            }

            //if (btn_f.Focused)
            //{
            //    List<string> sv = new List<string>();
            //    for (int i = 0; i < dgv_SelectedVac.RowCount; i++)
            //    {
            //        sv.Add(dgv_SelectedVac.Rows[i].Cells["ID"].Value.ToString());
            //    }
            //    vac.Insert_VacWS(sv, WSID);
            //}
        }
        private void btn_b_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_SelectedVac.RowCount; i++)
            {
                if (Convert.ToBoolean(dgv_SelectedVac.Rows[i].Cells[0].Value) == true)
                {
                    dgv_AvailableVac.Rows.Add(false, dgv_SelectedVac.Rows[i].Cells[1].Value.ToString(), dgv_SelectedVac.Rows[i].Cells[2].Value.ToString());
                    dgv_SelectedVac.Rows.RemoveAt(i);
                    i--;
                }
            }

            //if (btn_b.Focused)
            //{
            //    List<string> sv = new List<string>();
            //    for (int i = 0; i < dgv_SelectedVac.RowCount; i++)
            //    {
            //        sv.Add(dgv_SelectedVac.Rows[i].Cells["ID"].Value.ToString());
            //    }
            //    vac.Insert_VacWS(sv, WSID);
            //}
        }
        #endregion

        #region dgv
        private void dgv_SelectedVac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                dgv_SelectedVac.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = (Convert.ToBoolean(dgv_SelectedVac.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == false) ? true : false;
                string b = Convert.ToInt32(dgv_SelectedVac.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).ToString();
                string v = dgv_SelectedVac.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                vac.Update_VacWS(b, v, WSID);
            }
        }
        #endregion
    }
}
