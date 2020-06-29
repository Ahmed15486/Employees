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
    public partial class frm_WS_AdvancedOptions : Form
    {
        #region Declarations
        public int Day_Hours;
        public int Day_Min;
        public string WS_Tag;

        public bool ti;

        public int fas;
        public int fae;
        public int fls;
        public int fle;
        public int sas;
        public int sae;
        public int sls;
        public int sle;
        public string WSID;
        #endregion

        public frm_WS_AdvancedOptions()
        {
            InitializeComponent();
        }

        #region Form
        private void frm_WS_AdvancedOptions_Shown(object sender, EventArgs e)
        {
            if(WS_Tag == "Select")
            {
                dtp_End.Enabled = false;
                chk_BonusCheck.Enabled = false;
                chk_LateCheck.Enabled = false;
                chk_AttEarly.Enabled = false;
                chk_LeaveEarly.Enabled = false;
                chk_ti.Enabled = false;
                num_fas.Enabled = false;
                num_fae.Enabled = false;
                num_fls.Enabled = false;
                num_fle.Enabled = false;
                num_sas.Enabled = false;
                num_sae.Enabled = false;
                num_sls.Enabled = false;
                num_sle.Enabled = false;
            }

            Tag = "0";
            txt_Hours.Text = Day_Hours.ToString();
            txt_Min.Text = Day_Min.ToString();

            dtp_End.Value = dtp_End.Value.AddHours(Convert.ToDouble(txt_Hours.Text) - 24);
            dtp_End.Value = dtp_End.Value.AddMinutes(Convert.ToDouble(txt_Min.Text));
            Tag = "1";

            chk_ti.Checked = ti;
            grbx_ti.Visible = ti;

            num_fas.Value = fas;
            num_fae.Value = fae;
            num_fls.Value = fls;
            num_fle.Value = fle;
            num_sas.Value = sas;
            num_sae.Value = sae;
            num_sls.Value = sls;
            num_sle.Value = sle;
        }
        #endregion

        #region Details
        private void dtp_End_ValueChanged(object sender, EventArgs e)
        {
            if (Tag.ToString() == "0") { return; }
            TimeSpan end = dtp_End.Value.TimeOfDay;
            TimeSpan start = dtp_Start.Value.TimeOfDay;
            TimeSpan result = end - start;

            txt_Hours.Text = (24 + result.Hours).ToString();
            txt_Min.Text = result.Minutes.ToString();
        }
        private void chk_ti_CheckedChanged(object sender, EventArgs e)
        {
            grbx_ti.Visible = chk_ti.Checked;
        }
        #endregion
    }
}
