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
    public partial class frm_GeneralSettings : Form
    {
        cls_BL.General general = new cls_BL.General();
        DataTable dt = new DataTable();
        public frm_GeneralSettings()
        {
            InitializeComponent();
        }

        #region Form
        private void frm_GeneralSettings_Shown(object sender, EventArgs e)
        {
            dt = general.Select("SELECT * FROM Sys LIMIT 1;");
            chk_Active.Checked = Convert.ToBoolean(dt.Rows[0]["AutoPullFromFile"]);

            pnl_Timer.Visible = chk_Active.Checked;
        }
        #endregion

        private void chk_Active_CheckedChanged(object sender, EventArgs e)
        {
            dt = general.Select("UPDATE Sys SET AutoPullFromFile = " + Convert.ToInt32(chk_Active.Checked) + "; SELECT * FROM Sys LIMIT 1;");
            chk_Active.Checked = Convert.ToBoolean(dt.Rows[0]["AutoPullFromFile"]);

            pnl_Timer.Visible = chk_Active.Checked;
        }

        private void num_Timer_ValueChanged(object sender, EventArgs e)
        {
            dt = general.Select("UPDATE Sys SET AutoPullFromFileTimer = " + Convert.ToInt32(num_Timer.Value) + "; SELECT * FROM Sys LIMIT 1;");
            num_Timer.Value = Convert.ToInt32(dt.Rows[0]["AutoPullFromFileTimer"]);
        }
    }
}
