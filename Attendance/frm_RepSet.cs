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
    public partial class frm_RepSet : Form
    {
        public int User_ID;
        public DataGridView DGV;
        cls_BL.GSet GSet = new cls_BL.GSet();
        DataTable dt_GSet = new DataTable();

        public frm_RepSet()
        {
            InitializeComponent();
        }

        #region Form
        private void frm_RepSet_Shown(object sender, EventArgs e)
        {
            GSet.User_ID = User_ID;
            dt_GSet = GSet.Select();
            chk_Date.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["Date"]);
            chk_Day.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["Day"]);
            chk_Att1.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["Att1"]);
            chk_AttEarly1.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["AttEarly1"]);
            chk_Late1.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["Late1"]);
            chk_Leave1.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["Leave1"]);
            chk_LeaveEarly1.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["LeaveEarly1"]);
            chk_Bonus1.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["Bonus1"]);
            chk_Period1.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["Period1"]);
            chk_Att2.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["Att2"]);
            chk_AttEarly2.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["AttEarly2"]);
            chk_Late2.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["Late2"]);
            chk_Leave2.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["Leave2"]);
            chk_LeaveEarly2.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["LeaveEarly2"]);
            chk_Bonus2.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["Bonus2"]);
            chk_Period2.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["Period2"]);
            chk_Come_Early.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["Come_Early"]);
            chk_Late.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["Late"]);
            chk_Leave_Early.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["Leave_Early"]);
            chk_Bonus.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["Bonus"]);
            chk_Period.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["Period"]);
            chk_TotalSub.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["TotalSum"]);
            chk_TotalSum.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["TotalSub"]);
            chk_TotalHours.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["TotalHours"]);
            chk_Device1.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["Device1"]);
            chk_Device2.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["Device2"]);
            chk_TimeType.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["TimeType"]);
            chk_BonusType.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["BonusType"]);
            chk_Holiday.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["Holiday"]);
            chk_Absent.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["Absent"]);
            chk_Edited.Checked = Convert.ToBoolean(dt_GSet.Rows[0]["Edited"]);
        }
        private void frm_RepSet_FormClosing(object sender, FormClosingEventArgs e)
        {
            var();
            GSet.Update();
        }
        #endregion

        #region Pro
        void var()
        {
            GSet.User_ID = User_ID;
            GSet.Date = chk_Date.Checked;
            GSet.Day = chk_Day.Checked;
            GSet.Att1 = chk_Att1.Checked;
            GSet.AttEarly1 = Convert.ToInt32(chk_AttEarly1.Checked);
            GSet.Late1 = Convert.ToInt32(chk_Late1.Checked);
            GSet.Leave1 = chk_Leave1.Checked;
            GSet.LeaveEarly1 = Convert.ToInt32(chk_LeaveEarly1.Checked);
            GSet.Bonus1 = Convert.ToInt32(chk_Bonus1.Checked);
            GSet.Period1 = chk_Period1.Checked;
            GSet.Att2 = chk_Att2.Checked;
            GSet.AttEarly2 = Convert.ToInt32(chk_AttEarly2.Checked);
            GSet.Late2 = Convert.ToInt32(chk_Late2.Checked);
            GSet.Leave2 = chk_Leave2.Checked;
            GSet.LeaveEarly2 = Convert.ToInt32(chk_LeaveEarly2.Checked);
            GSet.Bonus2 = Convert.ToInt32(chk_Bonus2.Checked);
            GSet.Period2 = chk_Period2.Checked;
            GSet.Come_Early = chk_Come_Early.Checked;
            GSet.Late = chk_Late.Checked;
            GSet.Leave_Early = chk_Leave_Early.Checked;
            GSet.Bonus = chk_Bonus.Checked;
            GSet.Period = chk_Period.Checked;
            GSet.TotalSum = Convert.ToInt32(chk_TotalSub.Checked);
            GSet.TotalSub = Convert.ToInt32(chk_TotalSum.Checked);                
            GSet.TotalHours = chk_TotalHours.Checked;
            GSet.TimeType = chk_TimeType.Checked;
            GSet.BonusType = chk_BonusType.Checked;
            GSet.Holiday = chk_Holiday.Checked;
            GSet.Device1 = chk_Device1.Checked;
            GSet.Device2 = chk_Device2.Checked;                    
            GSet.Absent = chk_Absent.Checked;
            GSet.Edited = chk_Edited.Checked;
        }
        #endregion

        #region Controls
        private void chk_Date_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["التاريخ"] == null) return;
            DGV.Columns["التاريخ"].Visible = chk_Date.Checked;
        }
        private void chk_Day_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["اليوم"] == null) return;
            DGV.Columns["اليوم"].Visible = chk_Day.Checked;
        }
        private void chk_Att1_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["حضور دوام 1"] == null) return;
            DGV.Columns["حضور دوام 1"].Visible = chk_Att1.Checked;
        }
        private void chk_AttEarly1_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["حضور مبكر1"] == null) return;
            DGV.Columns["حضور مبكر1"].Visible = chk_AttEarly1.Checked;
        }
        private void chk_Late1_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["تأخير1"] == null) return;
            DGV.Columns["تأخير1"].Visible = chk_Late1.Checked;
        }
        private void chk_Leave1_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["إنصراف دوام 1"] == null) return;
            DGV.Columns["إنصراف دوام 1"].Visible = chk_Leave1.Checked;
        }
        private void chk_LeaveEarly1_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["إنصراف مبكر1"] == null) return;
            DGV.Columns["إنصراف مبكر1"].Visible = chk_LeaveEarly1.Checked;
        }
        private void chk_Bonus1_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["إضافي1"] == null) return;
            DGV.Columns["إضافي1"].Visible = chk_Bonus1.Checked;
        }
        private void chk_Priod1_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["الفترة الأولى"] == null) return;
            DGV.Columns["الفترة الأولى"].Visible = chk_Period1.Checked;
        }
        private void chk_Att2_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["حضور دوام 2"] == null) return;
            DGV.Columns["حضور دوام 2"].Visible = chk_Att2.Checked;
        }
        private void chk_AttEarly2_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["حضور مبكر2"] == null) return;
            DGV.Columns["حضور مبكر2"].Visible = chk_AttEarly2.Checked;
        }
        private void chk_Late2_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["تأخير2"] == null) return;
            DGV.Columns["تأخير2"].Visible = chk_Late2.Checked;
        }
        private void chk_Leave2_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["إنصراف دوام 2"] == null) return;
            DGV.Columns["إنصراف دوام 2"].Visible = chk_Leave2.Checked;
        }
        private void chk_LeaveEarly2_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["إنصراف مبكر2"] == null) return;
            DGV.Columns["إنصراف مبكر2"].Visible = chk_LeaveEarly2.Checked;
        }
        private void chk_Bonus2_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["إضافي2"] == null) return;
            DGV.Columns["إضافي2"].Visible = chk_Bonus2.Checked;
        }
        private void chk_Priod2_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["الفترة الثانية"] == null) return;
            DGV.Columns["الفترة الثانية"].Visible = chk_Period2.Checked;
        }
        private void chk_Late_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["تأخير"] == null) return;
            DGV.Columns["تأخير"].Visible = chk_Late.Checked;
        }
        private void chk_Over_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["إضافي"] == null) return;
            DGV.Columns["إضافي"].Visible = chk_Bonus.Checked;
        }
        private void chk_Period_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["الدوام"] == null) return;
            DGV.Columns["الدوام"].Visible = chk_Period.Checked;
        }
        private void chk_TotalSum_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["إجمالي المضاف"] == null) return;
            DGV.Columns["إجمالي المضاف"].Visible = chk_TotalSum.Checked;
        }
        private void chk_TotalSub_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["إجمالي المستقطع"] == null) return;
            DGV.Columns["إجمالي المستقطع"].Visible = chk_TotalSub.Checked;
        }
        private void chk_TotalHours_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["عدد الساعات"] == null) return;
            DGV.Columns["عدد الساعات"].Visible = chk_TotalHours.Checked;
        }
        private void chk_TimeType_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["نظام المواعيد"] == null) return;
            DGV.Columns["نظام المواعيد"].Visible = chk_TimeType.Checked;
        }
        private void chk_BonusType_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["نوع الإضافي"] == null) return;
            DGV.Columns["نوع الإضافي"].Visible = chk_BonusType.Checked;
        }
        private void chk_Holiday_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["أجازة ؟"] == null) return;
            DGV.Columns["أجازة ؟"].Visible = chk_Holiday.Checked;
        }
        private void chk_Device1_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["جهاز الحضور"] == null) return;
            DGV.Columns["جهاز الحضور"].Visible = chk_Device1.Checked;
        }
        private void chk_Device2_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["جهاز الإنصراف"] == null) return;
            DGV.Columns["جهاز الإنصراف"].Visible = chk_Device2.Checked;
        }
        private void chk_Come_Early_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["حضور مبكر"] == null) return;
            DGV.Columns["حضور مبكر"].Visible = chk_Come_Early.Checked;
        }
        private void chk_Leave_Early_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["إنصراف مبكر"] == null) return;
            DGV.Columns["إنصراف مبكر"].Visible = chk_Leave_Early.Checked;
        }
        private void chk_Absent_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["غائب ؟"] == null) return;
            DGV.Columns["غائب ؟"].Visible = chk_Absent.Checked;
        }
        private void chk_Edited_CheckedChanged(object sender, EventArgs e)
        {
            if (DGV.Columns["حركات معدلة"] == null) return;
            DGV.Columns["حركات معدلة"].Visible = chk_Edited.Checked;
        }
        #endregion
    }
}
