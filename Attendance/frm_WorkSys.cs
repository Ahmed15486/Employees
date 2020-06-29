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
    public partial class frm_WorkSys : Form
    {
        #region Declaration
        public bool Demo;
        cls_BL.WorkSys WorkSys = new cls_BL.WorkSys();
        DataTable dt_WorkSys = new DataTable();
        int record_index;
        #endregion

        public frm_WorkSys()
        {
            InitializeComponent();

            dgv_WorkSys.AutoGenerateColumns = false;
            Refresh_Data();
        }

        #region Form
        private void frm_Users_Shown(object sender, EventArgs e)
        {
            if (dgv_WorkSys.RowCount > 0)
            {
                Tag = "Select";
                Form_Mode("Select");
            }
        }

        #endregion

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
                    btn_AdvancedOptions.Enabled = true;
                    btn_AllDays.Enabled = true;

                    txt_Name.ReadOnly = false;
                    dgv_WorkSys.Enabled = false;

                    chk_Enable(true);

                    pnl_sa.Enabled = true;
                    pnl_su.Enabled = true;
                    pnl_mo.Enabled = true;
                    pnl_tu.Enabled = true;
                    pnl_we.Enabled = true;
                    pnl_th.Enabled = true;
                    pnl_fr.Enabled = true;

                    txt_ID.Text = "";
                    txt_Name.Text = "";

                    txt_Name.Focus();
                    break;
                #endregion

                #region Edit
                case "Edit":

                    btn_New.Visible = false;
                    btn_Edit.Visible = false;
                    btn_Save.Visible = true;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = true;
                    btn_AdvancedOptions.Enabled = true;
                    btn_AllDays.Enabled = true;

                    txt_Name.ReadOnly = false;
                    tab_Days.Visible = true;
                    dgv_WorkSys.Enabled = false;

                    chk_Enable(true);

                    pnl_sa.Enabled = true;
                    pnl_su.Enabled = true;
                    pnl_mo.Enabled = true;
                    pnl_tu.Enabled = true;
                    pnl_we.Enabled = true;
                    pnl_th.Enabled = true;
                    pnl_fr.Enabled = true;

                    break;
                #endregion

                #region Select
                case "Select":
                     
                    btn_New.Visible = true;
                    btn_Edit.Visible = true;
                    btn_Save.Visible = false;
                    btn_Delete.Visible = true;
                    btn_Cancel.Visible = false;
                    btn_AdvancedOptions.Enabled = true;
                    btn_AllDays.Enabled = false;

                    txt_Name.ReadOnly = true;

                    chk_Enable(false);

                    pnl_sa.Enabled = false;
                    pnl_su.Enabled = false;
                    pnl_mo.Enabled = false;
                    pnl_tu.Enabled = false;
                    pnl_we.Enabled = false;
                    pnl_th.Enabled = false;
                    pnl_fr.Enabled = false;

                    dgv_WorkSys.Enabled = true;

                    foreach (DataRow r in dt_WorkSys.Rows)
                    {
                        if (r["ID"].ToString() == dgv_WorkSys.SelectedRows[0].Cells[0].Value.ToString())
                        {

                            #region General
                            txt_ID.Text = r["ID"].ToString();
                            txt_Name.Text = r["Name"].ToString();
                            WorkSys.Day_Hours = Convert.ToInt16(r["Day_Hours"]);
                            WorkSys.Day_Min = Convert.ToInt16(r["Day_Min"]);
                            WorkSys.BonusCheck = Convert.ToBoolean(r["BonusCheck"]);
                            WorkSys.LateCheck = Convert.ToBoolean(r["LateCheck"]);
                            WorkSys.AttEarly = Convert.ToBoolean(r["AttEarly"]);
                            WorkSys.LeaveEarly = Convert.ToBoolean(r["LeaveEarly"]);
                            WorkSys.ti = Convert.ToBoolean(r["ti"]);
                            WorkSys.first_as = Convert.ToInt32(r["First_as"]);
                            WorkSys.first_ae = Convert.ToInt32(r["First_ae"]);
                            WorkSys.first_ls = Convert.ToInt32(r["First_ls"]);
                            WorkSys.first_le = Convert.ToInt32(r["First_le"]);
                            WorkSys.second_as = Convert.ToInt32(r["Second_as"]);
                            WorkSys.second_ae = Convert.ToInt32(r["Second_ae"]);
                            WorkSys.second_ls = Convert.ToInt32(r["Second_ls"]);
                            WorkSys.second_le = Convert.ToInt32(r["Second_le"]);
                            #endregion

                            #region sa
                            dtp_saHours.Value = Convert.ToDateTime("01-01-2016 "+ r["saPeriod_Hours"].ToString().Substring(0,2) + ":" + r["saPeriod_Hours"].ToString().Substring(3, 2) + ":00");
                            chk_saType.Checked = Convert.ToBoolean(r["saType"]);
                            chk_sah.Checked = Convert.ToBoolean(r["sah"]);
                            chk_saBonus.Checked = Convert.ToBoolean(r["saBonus"]);
                            chk_saf.Checked = Convert.ToBoolean(r["saf"]);
                            dtp_safs.Value = Convert.ToDateTime(r["safs"]);
                            dtp_safe.Value = Convert.ToDateTime(r["safe"]);
                            dtp_safa.Value = Convert.ToDateTime(r["safa"]);
                            chk_sas.Checked = Convert.ToBoolean(r["sas"]);
                            dtp_sass.Value = Convert.ToDateTime(r["sass"]);
                            dtp_sase.Value = Convert.ToDateTime(r["sase"]);
                            dtp_sasa.Value = Convert.ToDateTime(r["sasa"]);
                            #endregion

                            #region su
                            dtp_suHours.Value = Convert.ToDateTime("01-01-2016 " + r["suPeriod_Hours"].ToString().Substring(0, 2) + ":" + r["suPeriod_Hours"].ToString().Substring(3, 2) + ":00");
                            chk_suType.Checked = Convert.ToBoolean(r["suType"]);
                            chk_suh.Checked = Convert.ToBoolean(r["suh"]);
                            chk_suBonus.Checked = Convert.ToBoolean(r["suBonus"]);
                            chk_suf.Checked = Convert.ToBoolean(r["suf"]);
                            dtp_sufs.Value = Convert.ToDateTime(r["sufs"]);
                            dtp_sufe.Value = Convert.ToDateTime(r["sufe"]);
                            dtp_sufa.Value = Convert.ToDateTime(r["sufa"]);
                            chk_sus.Checked = Convert.ToBoolean(r["sus"]);
                            dtp_suss.Value = Convert.ToDateTime(r["suss"]);
                            dtp_suse.Value = Convert.ToDateTime(r["suse"]);
                            dtp_susa.Value = Convert.ToDateTime(r["susa"]);
                            #endregion

                            #region mo
                            dtp_moHours.Value = Convert.ToDateTime("01-01-2016 " + r["moPeriod_Hours"].ToString().Substring(0, 2) + ":" + r["moPeriod_Hours"].ToString().Substring(3, 2) + ":00");
                            chk_moType.Checked = Convert.ToBoolean(r["moType"]);
                            chk_moh.Checked = Convert.ToBoolean(r["moh"]);
                            chk_moBonus.Checked = Convert.ToBoolean(r["moBonus"]);
                            chk_mof.Checked = Convert.ToBoolean(r["mof"]);
                            dtp_mofs.Value = Convert.ToDateTime(r["mofs"]);
                            dtp_mofe.Value = Convert.ToDateTime(r["mofe"]);
                            dtp_mofa.Value = Convert.ToDateTime(r["mofa"]);
                            chk_mos.Checked = Convert.ToBoolean(r["mos"]);
                            dtp_moss.Value = Convert.ToDateTime(r["moss"]);
                            dtp_mose.Value = Convert.ToDateTime(r["mose"]);
                            dtp_mosa.Value = Convert.ToDateTime(r["mosa"]);
                            #endregion

                            #region tu
                            dtp_tuHours.Value = Convert.ToDateTime("01-01-2016 " + r["tuPeriod_Hours"].ToString().Substring(0, 2) + ":" + r["tuPeriod_Hours"].ToString().Substring(3, 2) + ":00");
                            chk_tuType.Checked = Convert.ToBoolean(r["tuType"]);
                            chk_tuh.Checked = Convert.ToBoolean(r["tuh"]);
                            chk_tuBonus.Checked = Convert.ToBoolean(r["tuBonus"]);
                            chk_tuf.Checked = Convert.ToBoolean(r["tuf"]);
                            dtp_tufs.Value = Convert.ToDateTime(r["tufs"]);
                            dtp_tufe.Value = Convert.ToDateTime(r["tufe"]);
                            dtp_tufa.Value = Convert.ToDateTime(r["tufa"]);
                            chk_tus.Checked = Convert.ToBoolean(r["tus"]);
                            dtp_tuss.Value = Convert.ToDateTime(r["tuss"]);
                            dtp_tuse.Value = Convert.ToDateTime(r["tuse"]);
                            dtp_tusa.Value = Convert.ToDateTime(r["tusa"]);
                            #endregion

                            #region we
                            dtp_weHours.Value = Convert.ToDateTime("01-01-2016 " + r["wePeriod_Hours"].ToString().Substring(0, 2) + ":" + r["wePeriod_Hours"].ToString().Substring(3, 2) + ":00");
                            chk_weType.Checked = Convert.ToBoolean(r["weType"]);
                            chk_weh.Checked = Convert.ToBoolean(r["weh"]);
                            chk_weBonus.Checked = Convert.ToBoolean(r["weBonus"]);
                            chk_wef.Checked = Convert.ToBoolean(r["wef"]);
                            dtp_wefs.Value = Convert.ToDateTime(r["wefs"]);
                            dtp_wefe.Value = Convert.ToDateTime(r["wefe"]);
                            dtp_wefa.Value = Convert.ToDateTime(r["wefa"]);
                            chk_wes.Checked = Convert.ToBoolean(r["wes"]);
                            dtp_wess.Value = Convert.ToDateTime(r["wess"]);
                            dtp_wese.Value = Convert.ToDateTime(r["wese"]);
                            dtp_wesa.Value = Convert.ToDateTime(r["wesa"]);
                            #endregion

                            #region th
                            dtp_thHours.Value = Convert.ToDateTime("01-01-2016 " + r["thPeriod_Hours"].ToString().Substring(0, 2) + ":" + r["thPeriod_Hours"].ToString().Substring(3, 2) + ":00");
                            chk_thType.Checked = Convert.ToBoolean(r["thType"]);
                            chk_thh.Checked = Convert.ToBoolean(r["thh"]);
                            chk_thBonus.Checked = Convert.ToBoolean(r["thBonus"]);
                            chk_thf.Checked = Convert.ToBoolean(r["thf"]);
                            dtp_thfs.Value = Convert.ToDateTime(r["thfs"]);
                            dtp_thfe.Value = Convert.ToDateTime(r["thfe"]);
                            dtp_thfa.Value = Convert.ToDateTime(r["thfa"]);
                            chk_ths.Checked = Convert.ToBoolean(r["ths"]);
                            dtp_thss.Value = Convert.ToDateTime(r["thss"]);
                            dtp_thse.Value = Convert.ToDateTime(r["thse"]);
                            dtp_thsa.Value = Convert.ToDateTime(r["thsa"]);
                            #endregion

                            #region fr
                            dtp_frHours.Value = Convert.ToDateTime("01-01-2016 " + r["frPeriod_Hours"].ToString().Substring(0, 2) + ":" + r["frPeriod_Hours"].ToString().Substring(3, 2) + ":00");
                            chk_frType.Checked = Convert.ToBoolean(r["frType"]);
                            chk_frh.Checked = Convert.ToBoolean(r["frh"]);
                            chk_frBonus.Checked = Convert.ToBoolean(r["frBonus"]);
                            chk_frf.Checked = Convert.ToBoolean(r["frf"]);
                            dtp_frfs.Value = Convert.ToDateTime(r["frfs"]);
                            dtp_frfe.Value = Convert.ToDateTime(r["frfe"]);
                            dtp_frfa.Value = Convert.ToDateTime(r["frfa"]);
                            chk_frs.Checked = Convert.ToBoolean(r["frs"]);
                            dtp_frss.Value = Convert.ToDateTime(r["frss"]);
                            dtp_frse.Value = Convert.ToDateTime(r["frse"]);
                            dtp_frsa.Value = Convert.ToDateTime(r["frsa"]);
                            #endregion

                            #region chk_Bonus
                            chk_saBonus.Visible = (chk_sah.Checked) ? true : false;
                            chk_suBonus.Visible = (chk_suh.Checked) ? true : false;
                            chk_moBonus.Visible = (chk_moh.Checked) ? true : false;
                            chk_tuBonus.Visible = (chk_tuh.Checked) ? true : false;
                            chk_weBonus.Visible = (chk_weh.Checked) ? true : false;
                            chk_thBonus.Visible = (chk_thh.Checked) ? true : false;
                            chk_frBonus.Visible = (chk_frh.Checked) ? true : false;
                            #endregion
                            break;
                        }
                    }

                    break;
                #endregion

                #region Empyt
                case "Empty":

                    btn_New.Visible = true;
                    btn_Edit.Visible = false;
                    btn_Save.Visible = false;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = false;
                    btn_AdvancedOptions.Enabled = false;
                    btn_AllDays.Enabled = false;

                    txt_Name.ReadOnly = true;
                    dgv_WorkSys.Enabled = true;

                    chk_Enable(false);

                    txt_ID.Text = "";
                    txt_Name.Text = "";
                    if(dgv_WorkSys.CurrentRow != null)dgv_WorkSys.CurrentRow.Selected = false;                 
                    break;
                    #endregion
            }
        }
        void chk_Enable(bool b)
        {
            chk_saType.Enabled = b;
            chk_suType.Enabled = b;
            chk_moType.Enabled = b;
            chk_tuType.Enabled = b;
            chk_weType.Enabled = b;
            chk_thType.Enabled = b;
            chk_frType.Enabled = b;

            chk_sah.Enabled = b;
            chk_suh.Enabled = b;
            chk_moh.Enabled = b;
            chk_tuh.Enabled = b;
            chk_weh.Enabled = b;
            chk_thh.Enabled = b;
            chk_frh.Enabled = b;

            chk_saBonus.Enabled = b;
            chk_suBonus.Enabled = b;
            chk_moBonus.Enabled = b;
            chk_tuBonus.Enabled = b;
            chk_weBonus.Enabled = b;
            chk_thBonus.Enabled = b;
            chk_frBonus.Enabled = b;
        }
        void pnl_Visible(string day)
        {
            switch (day)
            {
                #region sa
                case "sa":
                    if(chk_saType.Checked && chk_sah.Checked) 
                    {
                        if(chk_saBonus.Checked) // NonFixed
                        {
                            pnl_sa.Visible = false;
                            pnl_saNonfixed.Visible = true;
                        }
                        else // Holiday
                        {
                            pnl_sa.Visible = false;
                            pnl_saNonfixed.Visible = false;
                        }

                    }
                    if (!chk_saType.Checked && chk_sah.Checked) 
                    {
                        if (chk_saBonus.Checked) // Fixed
                        {
                            pnl_sa.Visible = true;
                            pnl_saNonfixed.Visible = false;
                        }
                        else // Holiday
                        {
                            pnl_sa.Visible = false;
                            pnl_saNonfixed.Visible = false;
                        }
                    }
                    if (chk_saType.Checked && !chk_sah.Checked) // NonFiexd
                    {
                        pnl_sa.Visible = false;
                        pnl_saNonfixed.Visible = true;
                    }
                    if (!chk_saType.Checked && !chk_sah.Checked) // Fiexd
                    {
                        pnl_sa.Visible = true;
                        pnl_saNonfixed.Visible = false;
                    }
                    break;
                #endregion

                #region su
                case "su":
                    if (chk_suType.Checked && chk_suh.Checked)
                    {
                        if (chk_suBonus.Checked) // NonFixed
                        {
                            pnl_su.Visible = false;
                            pnl_suNonfixed.Visible = true;
                        }
                        else // Holiday
                        {
                            pnl_su.Visible = false;
                            pnl_suNonfixed.Visible = false;
                        }

                    }
                    if (!chk_suType.Checked && chk_suh.Checked)
                    {
                        if (chk_suBonus.Checked) // Fixed
                        {
                            pnl_su.Visible = true;
                            pnl_suNonfixed.Visible = false;
                        }
                        else // Holiday
                        {
                            pnl_su.Visible = false;
                            pnl_suNonfixed.Visible = false;
                        }
                    }
                    if (chk_suType.Checked && !chk_suh.Checked) // NonFiexd
                    {
                        pnl_su.Visible = false;
                        pnl_suNonfixed.Visible = true;
                    }
                    if (!chk_suType.Checked && !chk_suh.Checked) // Fiexd
                    {
                        pnl_su.Visible = true;
                        pnl_suNonfixed.Visible = false;
                    }
                    break;
                #endregion

                #region mo
                case "mo":
                    if (chk_moType.Checked && chk_moh.Checked)
                    {
                        if (chk_moBonus.Checked) // NonFixed
                        {
                            pnl_mo.Visible = false;
                            pnl_moNonfixed.Visible = true;
                        }
                        else // Holiday
                        {
                            pnl_mo.Visible = false;
                            pnl_moNonfixed.Visible = false;
                        }

                    }
                    if (!chk_moType.Checked && chk_moh.Checked)
                    {
                        if (chk_moBonus.Checked) // Fixed
                        {
                            pnl_mo.Visible = true;
                            pnl_moNonfixed.Visible = false;
                        }
                        else // Holiday
                        {
                            pnl_mo.Visible = false;
                            pnl_moNonfixed.Visible = false;
                        }
                    }
                    if (chk_moType.Checked && !chk_moh.Checked) // NonFiexd
                    {
                        pnl_mo.Visible = false;
                        pnl_moNonfixed.Visible = true;
                    }
                    if (!chk_moType.Checked && !chk_moh.Checked) // Fiexd
                    {
                        pnl_mo.Visible = true;
                        pnl_moNonfixed.Visible = false;
                    }
                    break;
                #endregion

                #region tu
                case "tu":
                    if (chk_tuType.Checked && chk_tuh.Checked)
                    {
                        if (chk_tuBonus.Checked) // NonFixed
                        {
                            pnl_tu.Visible = false;
                            pnl_tuNonfixed.Visible = true;
                        }
                        else // Holiday
                        {
                            pnl_tu.Visible = false;
                            pnl_tuNonfixed.Visible = false;
                        }

                    }
                    if (!chk_tuType.Checked && chk_tuh.Checked)
                    {
                        if (chk_tuBonus.Checked) // Fixed
                        {
                            pnl_tu.Visible = true;
                            pnl_tuNonfixed.Visible = false;
                        }
                        else // Holiday
                        {
                            pnl_tu.Visible = false;
                            pnl_tuNonfixed.Visible = false;
                        }
                    }
                    if (chk_tuType.Checked && !chk_tuh.Checked) // NonFiexd
                    {
                        pnl_tu.Visible = false;
                        pnl_tuNonfixed.Visible = true;
                    }
                    if (!chk_tuType.Checked && !chk_tuh.Checked) // Fiexd
                    {
                        pnl_tu.Visible = true;
                        pnl_tuNonfixed.Visible = false;
                    }
                    break;
                #endregion

                #region we
                case "we":
                    if (chk_weType.Checked && chk_weh.Checked)
                    {
                        if (chk_weBonus.Checked) // NonFixed
                        {
                            pnl_we.Visible = false;
                            pnl_weNonfixed.Visible = true;
                        }
                        else // Holiday
                        {
                            pnl_we.Visible = false;
                            pnl_weNonfixed.Visible = false;
                        }

                    }
                    if (!chk_weType.Checked && chk_weh.Checked)
                    {
                        if (chk_weBonus.Checked) // Fixed
                        {
                            pnl_we.Visible = true;
                            pnl_weNonfixed.Visible = false;
                        }
                        else // Holiday
                        {
                            pnl_we.Visible = false;
                            pnl_weNonfixed.Visible = false;
                        }
                    }
                    if (chk_weType.Checked && !chk_weh.Checked) // NonFiexd
                    {
                        pnl_we.Visible = false;
                        pnl_weNonfixed.Visible = true;
                    }
                    if (!chk_weType.Checked && !chk_weh.Checked) // Fiexd
                    {
                        pnl_we.Visible = true;
                        pnl_weNonfixed.Visible = false;
                    }
                    break;
                #endregion

                #region th
                case "th":
                    if (chk_thType.Checked && chk_thh.Checked)
                    {
                        if (chk_thBonus.Checked) // NonFixed
                        {
                            pnl_th.Visible = false;
                            pnl_thNonfixed.Visible = true;
                        }
                        else // Holiday
                        {
                            pnl_th.Visible = false;
                            pnl_thNonfixed.Visible = false;
                        }

                    }
                    if (!chk_thType.Checked && chk_thh.Checked)
                    {
                        if (chk_thBonus.Checked) // Fixed
                        {
                            pnl_th.Visible = true;
                            pnl_thNonfixed.Visible = false;
                        }
                        else // Holiday
                        {
                            pnl_th.Visible = false;
                            pnl_thNonfixed.Visible = false;
                        }
                    }
                    if (chk_thType.Checked && !chk_thh.Checked) // NonFiexd
                    {
                        pnl_th.Visible = false;
                        pnl_thNonfixed.Visible = true;
                    }
                    if (!chk_thType.Checked && !chk_thh.Checked) // Fiexd
                    {
                        pnl_th.Visible = true;
                        pnl_thNonfixed.Visible = false;
                    }
                    break;
                #endregion

                #region fr
                case "fr":
                    if (chk_frType.Checked && chk_frh.Checked)
                    {
                        if (chk_frBonus.Checked) // NonFixed
                        {
                            pnl_fr.Visible = false;
                            pnl_frNonfixed.Visible = true;
                        }
                        else // Holiday
                        {
                            pnl_fr.Visible = false;
                            pnl_frNonfixed.Visible = false;
                        }

                    }
                    if (!chk_frType.Checked && chk_frh.Checked)
                    {
                        if (chk_frBonus.Checked) // Fixed
                        {
                            pnl_fr.Visible = true;
                            pnl_frNonfixed.Visible = false;
                        }
                        else // Holiday
                        {
                            pnl_fr.Visible = false;
                            pnl_frNonfixed.Visible = false;
                        }
                    }
                    if (chk_frType.Checked && !chk_frh.Checked) // NonFiexd
                    {
                        pnl_fr.Visible = false;
                        pnl_frNonfixed.Visible = true;
                    }
                    if (!chk_frType.Checked && !chk_frh.Checked) // Fiexd
                    {
                        pnl_fr.Visible = true;
                        pnl_frNonfixed.Visible = false;
                    }
                    break;
                #endregion

            }
        }
        void Var()
        {
            calc_Period();

            #region General
            WorkSys.ID = (txt_ID.Text != "" )? Convert.ToInt16(txt_ID.Text) : 0;
            WorkSys.Name = txt_Name.Text;
            #endregion

            #region sa
            WorkSys.saPeriod_Hours = dtp_saHours.Value.ToString("HH:mm");
            WorkSys.saNonFixed = chk_saType.Checked;
            WorkSys.sah = chk_sah.Checked;
            WorkSys.saBonus = chk_saBonus.Checked;

            WorkSys.saf = chk_saf.Checked;
            WorkSys.safs = dtp_safs.Value;
            WorkSys.safe = dtp_safe.Value;
            WorkSys.safa = dtp_safa.Value;
            WorkSys.sas = chk_sas.Checked;
            WorkSys.sass = dtp_sass.Value;
            WorkSys.sase = dtp_sase.Value;
            WorkSys.sasa = dtp_sasa.Value;
            #endregion

            #region su
            WorkSys.suPeriod_Hours = dtp_suHours.Value.ToString("HH:mm");
            WorkSys.suNonFixed = chk_suType.Checked;
            WorkSys.suh = chk_suh.Checked;
            WorkSys.suBonus = chk_suBonus.Checked;

            WorkSys.suf = chk_suf.Checked;
            WorkSys.sufs = dtp_sufs.Value;
            WorkSys.sufe = dtp_sufe.Value;
            WorkSys.sufa = dtp_sufa.Value;
            WorkSys.sus = chk_sus.Checked;
            WorkSys.suss = dtp_suss.Value;
            WorkSys.suse = dtp_suse.Value;
            WorkSys.susa = dtp_susa.Value;
            #endregion

            #region mo
            WorkSys.moPeriod_Hours = dtp_moHours.Value.ToString("HH:mm");
            WorkSys.moNonFixed = chk_moType.Checked;
            WorkSys.moh = chk_moh.Checked;
            WorkSys.moBonus = chk_moBonus.Checked;

            WorkSys.mof = chk_mof.Checked;
            WorkSys.mofs = dtp_mofs.Value;
            WorkSys.mofe = dtp_mofe.Value;
            WorkSys.mofa = dtp_mofa.Value;
            WorkSys.mos = chk_mos.Checked;
            WorkSys.moss = dtp_moss.Value;
            WorkSys.mose = dtp_mose.Value;
            WorkSys.mosa = dtp_mosa.Value;
            #endregion

            #region tu
            WorkSys.tuPeriod_Hours = dtp_tuHours.Value.ToString("HH:mm");
            WorkSys.tuNonFixed = chk_tuType.Checked;
            WorkSys.tuh = chk_tuh.Checked;
            WorkSys.tuBonus = chk_tuBonus.Checked;

            WorkSys.tuf = chk_tuf.Checked;
            WorkSys.tufs = dtp_tufs.Value;
            WorkSys.tufe = dtp_tufe.Value;
            WorkSys.tufa = dtp_tufa.Value;
            WorkSys.tus = chk_tus.Checked;
            WorkSys.tuss = dtp_tuss.Value;
            WorkSys.tuse = dtp_tuse.Value;
            WorkSys.tusa = dtp_tusa.Value;
            #endregion

            #region we
            WorkSys.wePeriod_Hours = dtp_weHours.Value.ToString("HH:mm");
            WorkSys.weNonFixed = chk_weType.Checked;
            WorkSys.weh = chk_weh.Checked;
            WorkSys.weBonus = chk_weBonus.Checked;

            WorkSys.wef = chk_wef.Checked;
            WorkSys.wefs = dtp_wefs.Value;
            WorkSys.wefe = dtp_wefe.Value;
            WorkSys.wefa = dtp_wefa.Value;
            WorkSys.wes = chk_wes.Checked;
            WorkSys.wess = dtp_wess.Value;
            WorkSys.wese = dtp_wese.Value;
            WorkSys.wesa = dtp_wesa.Value;
            #endregion

            #region th
            WorkSys.thPeriod_Hours = dtp_thHours.Value.ToString("HH:mm");
            WorkSys.thNonFixed = chk_thType.Checked;
            WorkSys.thh = chk_thh.Checked;
            WorkSys.thBonus = chk_thBonus.Checked;

            WorkSys.thf = chk_thf.Checked;
            WorkSys.thfs = dtp_thfs.Value;
            WorkSys.thfe = dtp_thfe.Value;
            WorkSys.thfa = dtp_thfa.Value;
            WorkSys.ths = chk_ths.Checked;
            WorkSys.thss = dtp_thss.Value;
            WorkSys.thse = dtp_thse.Value;
            WorkSys.thsa = dtp_thsa.Value;
            #endregion

            #region fr
            WorkSys.frPeriod_Hours = dtp_frHours.Value.ToString("HH:mm");
            WorkSys.frNonFixed = chk_frType.Checked;
            WorkSys.frh = chk_frh.Checked;
            WorkSys.frBonus = chk_frBonus.Checked;

            WorkSys.frf = chk_frf.Checked;
            WorkSys.frfs = dtp_frfs.Value;
            WorkSys.frfe = dtp_frfe.Value;
            WorkSys.frfa = dtp_frfa.Value;
            WorkSys.frs = chk_frs.Checked;
            WorkSys.frss = dtp_frss.Value;
            WorkSys.frse = dtp_frse.Value;
            WorkSys.frsa = dtp_frsa.Value;
            #endregion

        }
        void calc_Period()
        {
            #region var
            TimeSpan safperiod = dtp_safe.Value - dtp_safs.Value; 
            TimeSpan sasperiod = dtp_sase.Value - dtp_sass.Value;
            TimeSpan saperiod = safperiod + sasperiod;
            int safh = Math.Abs(safperiod.Hours);
            int sash = Math.Abs(sasperiod.Hours);
            int safm = Math.Abs(safperiod.Minutes);
            int sasm = Math.Abs(sasperiod.Minutes);

            TimeSpan sufperiod = dtp_sufe.Value - dtp_sufs.Value;
            TimeSpan susperiod = dtp_suse.Value - dtp_suss.Value;
            TimeSpan superiod = sufperiod + susperiod;
            int sufh = Math.Abs(sufperiod.Hours);
            int sush = Math.Abs(susperiod.Hours);
            int sufm = Math.Abs(sufperiod.Minutes);
            int susm = Math.Abs(susperiod.Minutes);

            TimeSpan mofperiod = dtp_mofe.Value - dtp_mofs.Value;
            TimeSpan mosperiod = dtp_mose.Value - dtp_moss.Value;
            TimeSpan moperiod = mofperiod + mosperiod;
            int mofh = Math.Abs(mofperiod.Hours);
            int mosh = Math.Abs(mosperiod.Hours);
            int mofm = Math.Abs(mofperiod.Minutes);
            int mosm = Math.Abs(mosperiod.Minutes);

            TimeSpan tufperiod = dtp_tufe.Value - dtp_tufs.Value;
            TimeSpan tusperiod = dtp_tuse.Value - dtp_tuss.Value;
            TimeSpan tuperiod = tufperiod + tusperiod;
            int tufh = Math.Abs(tufperiod.Hours);
            int tush = Math.Abs(tusperiod.Hours);
            int tufm = Math.Abs(tufperiod.Minutes);
            int tusm = Math.Abs(tusperiod.Minutes);

            TimeSpan wefperiod = dtp_wefe.Value - dtp_wefs.Value;
            TimeSpan wesperiod = dtp_wese.Value - dtp_wess.Value;
            TimeSpan weperiod = wefperiod + wesperiod;
            int wefh = Math.Abs(wefperiod.Hours);
            int wesh = Math.Abs(wesperiod.Hours);
            int wefm = Math.Abs(wefperiod.Minutes);
            int wesm = Math.Abs(wesperiod.Minutes);

            TimeSpan thfperiod = dtp_thfe.Value - dtp_thfs.Value;
            TimeSpan thsperiod = dtp_thse.Value - dtp_thss.Value;
            TimeSpan thperiod = thfperiod + thsperiod;
            int thfh = Math.Abs(thfperiod.Hours);
            int thsh = Math.Abs(thsperiod.Hours);
            int thfm = Math.Abs(thfperiod.Minutes);
            int thsm = Math.Abs(thsperiod.Minutes);

            TimeSpan frfperiod = dtp_frfe.Value - dtp_frfs.Value;
            TimeSpan frsperiod = dtp_frse.Value - dtp_frss.Value;
            TimeSpan frperiod = frfperiod + frsperiod;
            int frfh = Math.Abs(frfperiod.Hours);
            int frsh = Math.Abs(frsperiod.Hours);
            int frfm = Math.Abs(frfperiod.Minutes);
            int frsm = Math.Abs(frsperiod.Minutes);
            #endregion

            #region sa
            if (!chk_saType.Checked)
            {
                if (chk_saf.Checked && !chk_sas.Checked)
                {
                    dtp_saHours.Value = Convert.ToDateTime("01-01-2016 " + safh.ToString()+":"+ Positive(safm).ToString()+":00");
                }
                else if (chk_saf.Checked && chk_sas.Checked)
                {
                    dtp_saHours.Value = Convert.ToDateTime("01/01/2016 " + (safh+sash).ToString() + ":" + (safm+ sasm).ToString() + ":00");
                }
                else if (!chk_saf.Checked && chk_sas.Checked)
                {
                    dtp_saHours.Value = Convert.ToDateTime("01-01-2016 " + sash + ":" + Positive(sasm) + ":00");
                }
                else if (!chk_sas.Checked && !chk_saf.Checked)
                {
                    dtp_saHours.Value = Convert.ToDateTime("01-01-2016 00:00:00");
                }
            }
            #endregion

            #region su
            if (!chk_suType.Checked)
            {
                if (chk_suf.Checked && !chk_sus.Checked)
                {
                    dtp_suHours.Value = Convert.ToDateTime("01-01-2016 " + sufh.ToString() + ":" + Positive(sufm).ToString() + ":00");
                }
                else if (chk_suf.Checked && chk_sus.Checked)
                {
                    dtp_suHours.Value = Convert.ToDateTime("01-01-2016 " + (sufh + sush).ToString() + ":" + (sufm + susm).ToString() + ":00");
                }
                else if (!chk_suf.Checked && chk_sus.Checked)
                {
                    dtp_suHours.Value = Convert.ToDateTime("01-01-2016 " + sush + ":" + Positive(susm) + ":00");
                }
                else if (!chk_sus.Checked && !chk_suf.Checked)
                {
                    dtp_suHours.Value = Convert.ToDateTime("01-01-2016 00:00:00");
                }
            }
            #endregion

            #region mo
            if (!chk_moType.Checked)
            {
                if (chk_mof.Checked && !chk_mos.Checked)
                {
                    dtp_moHours.Value = Convert.ToDateTime("01-01-2016 " + mofh.ToString() + ":" + Positive(mofm).ToString() + ":00");
                }
                else if (chk_mof.Checked && chk_mos.Checked)
                {
                    dtp_moHours.Value = Convert.ToDateTime("01-01-2016 " + (mofh + mosh).ToString() + ":" + (mofm + mosm).ToString() + ":00");
                }
                else if (!chk_mof.Checked && chk_mos.Checked)
                {
                    dtp_moHours.Value = Convert.ToDateTime("01-01-2016 " + mosh + ":" + Positive(mosm) + ":00");
                }
                else if (!chk_mos.Checked && !chk_mof.Checked)
                {
                    dtp_moHours.Value = Convert.ToDateTime("01-01-2016 00:00:00");
                }
            }
            #endregion

            #region tu
            if (!chk_tuType.Checked)
            {
                if (chk_tuf.Checked && !chk_tus.Checked)
                {
                    dtp_tuHours.Value = Convert.ToDateTime("01-01-2016 " + tufh.ToString() + ":" + Positive(tufm).ToString() + ":00");
                }
                else if (chk_tuf.Checked && chk_tus.Checked)
                {
                    dtp_tuHours.Value = Convert.ToDateTime("01-01-2016 " + (tufh + tush).ToString() + ":" + (tufm + tusm).ToString() + ":00");
                }
                else if (!chk_tuf.Checked && chk_tus.Checked)
                {
                    dtp_tuHours.Value = Convert.ToDateTime("01-01-2016 " + tush + ":" + Positive(tusm) + ":00");
                }
                else if (!chk_tus.Checked && !chk_tuf.Checked)
                {
                    dtp_tuHours.Value = Convert.ToDateTime("01-01-2016 00:00:00");
                }
            }
            #endregion

            #region we
            if (!chk_weType.Checked)
            {
                if (chk_wef.Checked && !chk_wes.Checked)
                {
                    dtp_weHours.Value = Convert.ToDateTime("01-01-2016 " + wefh.ToString() + ":" + Positive(wefm).ToString() + ":00");
                }
                else if (chk_wef.Checked && chk_wes.Checked)
                {
                    dtp_weHours.Value = Convert.ToDateTime("01-01-2016 " + (wefh + wesh).ToString() + ":" + (wefm + wesm).ToString() + ":00");
                }
                else if (!chk_wef.Checked && chk_wes.Checked)
                {
                    dtp_weHours.Value = Convert.ToDateTime("01-01-2016 " + wesh + ":" + Positive(wesm) + ":00");
                }
                else if (!chk_wes.Checked && !chk_wef.Checked)
                {
                    dtp_weHours.Value = Convert.ToDateTime("01-01-2016 00:00:00");
                }
            }
            #endregion

            #region th
            if (!chk_thType.Checked)
            {
                if (chk_thf.Checked && !chk_ths.Checked)
                {
                    dtp_thHours.Value = Convert.ToDateTime("01-01-2016 " + thfh.ToString() + ":" + Positive(thfm).ToString() + ":00");
                }
                else if (chk_thf.Checked && chk_ths.Checked)
                {
                    dtp_thHours.Value = Convert.ToDateTime("01-01-2016 " + (thfh + thsh).ToString() + ":" + (thfm + thsm).ToString() + ":00");
                }
                else if (!chk_thf.Checked && chk_ths.Checked)
                {
                    dtp_thHours.Value = Convert.ToDateTime("01-01-2016 " + thsh + ":" + Positive(thsm) + ":00");
                }
                else if (!chk_ths.Checked && !chk_thf.Checked)
                {
                    dtp_thHours.Value = Convert.ToDateTime("01-01-2016 00:00:00");
                }
            }
            #endregion

            #region fr
            if (!chk_frType.Checked)
            {
                if (chk_frf.Checked && !chk_frs.Checked)
                {
                    dtp_frHours.Value = Convert.ToDateTime("01-01-2016 " + frfh.ToString() + ":" + Positive(frfm).ToString() + ":00");
                }
                else if (chk_frf.Checked && chk_frs.Checked)
                {
                    dtp_frHours.Value = Convert.ToDateTime("01-01-2016 " + (frfh + frsh).ToString() + ":" + (frfm + frsm).ToString() + ":00");
                }
                else if (!chk_frf.Checked && chk_frs.Checked)
                {
                    dtp_frHours.Value = Convert.ToDateTime("01-01-2016 " + frsh + ":" + Positive(frsm) + ":00");
                }
                else if (!chk_frs.Checked && !chk_frf.Checked)
                {
                    dtp_frHours.Value = Convert.ToDateTime("01-01-2016 00:00:00");
                }
            }
            #endregion
        }
        void Refresh_Data()
        {
            dt_WorkSys = WorkSys.Select();
            dgv_WorkSys.DataSource = dt_WorkSys;
            if(dgv_WorkSys.Rows.Count > 0)
            {
                dgv_WorkSys.CurrentCell = dgv_WorkSys.Rows[0].Cells[0];
                Form_Mode("Select");
            }
            else
            {
                Form_Mode("Empty");
            }
        }
        int Positive(int n)
        {
            return n >= 0 ? n : (n*-1);
        }
        #endregion

        #region Control
        private void btn_New_Click(object sender, EventArgs e)
        {
            if (Demo)
            {
                if (WorkSys.Select_Cout() >= 2)
                {
                    MessageBox.Show("هذه نسخة تجريبية ولا يمكن اضافة أكثر من نظامين للدوام", "نسخة تجريبية", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            record_index = dgv_WorkSys.SelectedRows[0].Index;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text.Trim() == "")
            {
                MessageBox.Show("يجب إدخال أسم النظام", "حفظ نظام دوام", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_Name.Focus();
                return;
            }
            Var();
            if (Tag.ToString() == "New")
            {
                WorkSys.Insert();
                Refresh_Data();
                if(dgv_WorkSys.RowCount>0) dgv_WorkSys.CurrentCell = dgv_WorkSys.Rows[dgv_WorkSys.RowCount - 1].Cells[0];
            }
            else if (Tag.ToString() == "Edit")
            {
                WorkSys.Update();
                Refresh_Data();
                if (dgv_WorkSys.RowCount > 0) dgv_WorkSys.CurrentCell = dgv_WorkSys.Rows[record_index].Cells[0];
            }

            Tag = "Select";
            Form_Mode("Select");
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل بالفعل تريد حذف هذا النظام ؟", "حذف نظام دوام", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                return;
            }

            Var();
            if(WorkSys.Delete()=="1") return;
            Refresh_Data();
            Tag = "Select";
            Form_Mode("Select");
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

        private void btn_AllDays_Click(object sender, EventArgs e)
        {
            #region su
            chk_suh.Checked = chk_sah.Checked;
            chk_suBonus.Checked = chk_saBonus.Checked;
            chk_suType.Checked = chk_saType.Checked;
            chk_suf.Checked = chk_saf.Checked;
            chk_sus.Checked = chk_sas.Checked;
            dtp_sufs.Value = dtp_safs.Value;
            dtp_sufe.Value = dtp_safe.Value;
            dtp_sufa.Value = dtp_safa.Value;
            dtp_suss.Value = dtp_sass.Value;
            dtp_suse.Value = dtp_sase.Value;
            dtp_susa.Value = dtp_sasa.Value;
            dtp_suHours.Value = dtp_saHours.Value;
            #endregion

            #region mo
            chk_moh.Checked = chk_sah.Checked;
            chk_moBonus.Checked = chk_saBonus.Checked;
            chk_moType.Checked = chk_saType.Checked;
            chk_mof.Checked = chk_saf.Checked;
            chk_mos.Checked = chk_sas.Checked;
            dtp_mofs.Value = dtp_safs.Value;
            dtp_mofe.Value = dtp_safe.Value;
            dtp_mofa.Value = dtp_safa.Value;
            dtp_moss.Value = dtp_sass.Value;
            dtp_mose.Value = dtp_sase.Value;
            dtp_mosa.Value = dtp_sasa.Value;
            dtp_moHours.Value = dtp_saHours.Value;
            #endregion

            #region tu
            chk_tuh.Checked = chk_sah.Checked;
            chk_tuBonus.Checked = chk_saBonus.Checked;
            chk_tuType.Checked = chk_saType.Checked;
            chk_tuf.Checked = chk_saf.Checked;
            chk_tus.Checked = chk_sas.Checked;
            dtp_tufs.Value = dtp_safs.Value;
            dtp_tufe.Value = dtp_safe.Value;
            dtp_tufa.Value = dtp_safa.Value;
            dtp_tuss.Value = dtp_sass.Value;
            dtp_tuse.Value = dtp_sase.Value;
            dtp_tusa.Value = dtp_sasa.Value;
            dtp_tuHours.Value = dtp_saHours.Value;
            #endregion

            #region we
            chk_weh.Checked = chk_sah.Checked;
            chk_weBonus.Checked = chk_saBonus.Checked;
            chk_weType.Checked = chk_saType.Checked;
            chk_wef.Checked = chk_saf.Checked;
            chk_wes.Checked = chk_sas.Checked;
            dtp_wefs.Value = dtp_safs.Value;
            dtp_wefe.Value = dtp_safe.Value;
            dtp_wefa.Value = dtp_safa.Value;
            dtp_wess.Value = dtp_sass.Value;
            dtp_wese.Value = dtp_sase.Value;
            dtp_wesa.Value = dtp_sasa.Value;
            dtp_weHours.Value = dtp_saHours.Value;
            #endregion

            #region th
            chk_thh.Checked = chk_sah.Checked;
            chk_thBonus.Checked = chk_saBonus.Checked;
            chk_thType.Checked = chk_saType.Checked;
            chk_thf.Checked = chk_saf.Checked;
            chk_ths.Checked = chk_sas.Checked;
            dtp_thfs.Value = dtp_safs.Value;
            dtp_thfe.Value = dtp_safe.Value;
            dtp_thfa.Value = dtp_safa.Value;
            dtp_thss.Value = dtp_sass.Value;
            dtp_thse.Value = dtp_sase.Value;
            dtp_thsa.Value = dtp_sasa.Value;
            dtp_thHours.Value = dtp_saHours.Value;
            #endregion

            #region fr
            chk_frh.Checked = chk_sah.Checked;
            chk_frBonus.Checked = chk_saBonus.Checked;
            chk_frType.Checked = chk_saType.Checked;
            chk_frf.Checked = chk_saf.Checked;
            chk_frs.Checked = chk_sas.Checked;
            dtp_frfs.Value = dtp_safs.Value;
            dtp_frfe.Value = dtp_safe.Value;
            dtp_frfa.Value = dtp_safa.Value;
            dtp_frss.Value = dtp_sass.Value;
            dtp_frse.Value = dtp_sase.Value;
            dtp_frsa.Value = dtp_sasa.Value;
            dtp_frHours.Value = dtp_saHours.Value;
            #endregion
        }
        private void btn_AdvancedOptions_Click(object sender, EventArgs e)
        {
            frm_WS_AdvancedOptions ao = new frm_WS_AdvancedOptions();
            ao.Day_Hours = WorkSys.Day_Hours;
            ao.Day_Min = WorkSys.Day_Min;
            ao.WS_Tag = Tag.ToString();

            ao.chk_BonusCheck.Checked = WorkSys.BonusCheck;
            ao.chk_LateCheck.Checked = WorkSys.LateCheck;
            ao.chk_AttEarly.Checked = WorkSys.AttEarly;
            ao.chk_LeaveEarly.Checked = WorkSys.LeaveEarly;
            ao.ti = WorkSys.ti;
            ao.fas = WorkSys.first_as;
            ao.fae = WorkSys.first_ae;
            ao.fls = WorkSys.first_ls;
            ao.fle = WorkSys.first_le;
            ao.sas = WorkSys.second_as;
            ao.sae = WorkSys.second_ae;
            ao.sls = WorkSys.second_ls;
            ao.sle = WorkSys.second_le;
            ao.WSID = txt_ID.Text;

            ao.ShowDialog();

            WorkSys.Day_Hours = Convert.ToUInt16(ao.txt_Hours.Text);
            WorkSys.Day_Min = Convert.ToUInt16(ao.txt_Min.Text);

            WorkSys.BonusCheck = ao.chk_BonusCheck.Checked;
            WorkSys.LateCheck = ao.chk_LateCheck.Checked;
            WorkSys.AttEarly = ao.chk_AttEarly.Checked;
            WorkSys.LeaveEarly = ao.chk_LeaveEarly.Checked;
            WorkSys.ti = ao.chk_ti.Checked;
            WorkSys.first_as = Convert.ToInt32(ao.num_fas.Value);
            WorkSys.first_ae = Convert.ToInt32(ao.num_fae.Value);
            WorkSys.first_ls = Convert.ToInt32(ao.num_fls.Value);
            WorkSys.first_le = Convert.ToInt32(ao.num_fle.Value);
            WorkSys.second_as = Convert.ToInt32(ao.num_sas.Value);
            WorkSys.second_ae = Convert.ToInt32(ao.num_sae.Value);
            WorkSys.second_ls = Convert.ToInt32(ao.num_sls.Value);
            WorkSys.second_le = Convert.ToInt32(ao.num_sle.Value);
        }
        private void btn_Vac_Click(object sender, EventArgs e)
        {
            frm_VacWS vacws = new frm_VacWS();
            vacws.Text += " / " + txt_Name.Text;
            vacws.WSID = txt_ID.Text;
            vacws.ShowDialog();
        }
        #endregion

        #region dgv_Userd
        public void dgv_Users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Tag = "Select";
            Form_Mode("Select");
        }
        #endregion

        #region tab
        #region sa
        private void chk_saBonus_CheckedChanged(object sender, EventArgs e)
        {
            pnl_Visible("sa");
        }
        private void chk_saType_CheckedChanged(object sender, EventArgs e)
        {
            pnl_Visible("sa");
        }
        private void chk_sah_CheckedChanged(object sender, EventArgs e)
        {
            chk_saBonus.Visible = chk_sah.Checked;
            chk_saBonus.Checked = (!chk_sah.Checked) ? false : chk_saBonus.Checked;
            pnl_Visible("sa");
        }
        private void chk_saf_CheckedChanged(object sender, EventArgs e)
        {
            dtp_safs.Visible = chk_saf.Checked;
            dtp_safe.Visible = chk_saf.Checked;
        }
        private void chk_sas_CheckedChanged(object sender, EventArgs e)
        {
            dtp_sass.Visible = chk_sas.Checked;
            dtp_sase.Visible = chk_sas.Checked;
        }
        #endregion

        #region su
        private void chk_suType_CheckedChanged(object sender, EventArgs e)
        {
            pnl_Visible("su");
        }
        private void chk_suh_CheckedChanged(object sender, EventArgs e)
        {
            chk_suBonus.Visible = chk_suh.Checked;
            chk_suBonus.Checked = (!chk_sah.Checked) ? false : chk_suBonus.Checked;
            pnl_Visible("su");
        }
        private void chk_suBonus_CheckedChanged(object sender, EventArgs e)
        {
            pnl_Visible("su");
        }
        private void chk_suf_CheckedChanged(object sender, EventArgs e)
        {
            dtp_sufs.Visible = chk_suf.Checked;
            dtp_sufe.Visible = chk_suf.Checked;
        }
        private void chk_sus_CheckedChanged(object sender, EventArgs e)
        {
            dtp_suss.Visible = chk_sus.Checked;
            dtp_suse.Visible = chk_sus.Checked;
        }
        #endregion

        #region mo
        private void chk_moType_CheckedChanged(object sender, EventArgs e)
        {
            pnl_Visible("mo");
        }
        private void chk_moh_CheckedChanged(object sender, EventArgs e)
        {
            chk_moBonus.Visible = chk_moh.Checked;
            chk_moBonus.Checked = (!chk_moh.Checked) ? false : chk_moBonus.Checked;
            pnl_Visible("mo");
        }
        private void chk_moBonus_CheckedChanged(object sender, EventArgs e)
        {
            pnl_Visible("mo");
        }
        private void chk_mof_CheckedChanged(object sender, EventArgs e)
        {
            dtp_mofs.Visible = chk_mof.Checked;
            dtp_mofe.Visible = chk_mof.Checked;
        }
        private void chk_mos_CheckedChanged(object sender, EventArgs e)
        {
            dtp_moss.Visible = chk_mos.Checked;
            dtp_mose.Visible = chk_mos.Checked;
        }

        #endregion

        #region tu
        private void chk_tuType_CheckedChanged(object sender, EventArgs e)
        {
            pnl_Visible("tu");
        }
        private void chk_tuh_CheckedChanged(object sender, EventArgs e)
        {
            chk_tuBonus.Visible = chk_tuh.Checked;
            chk_tuBonus.Checked = (!chk_sah.Checked) ? false : chk_tuBonus.Checked;
            pnl_Visible("tu");
        }
        private void chk_tuBonus_CheckedChanged(object sender, EventArgs e)
        {
            pnl_Visible("tu");
        }
        private void chk_tuf_CheckedChanged(object sender, EventArgs e)
        {
            dtp_tufs.Visible = chk_tuf.Checked;
            dtp_tufe.Visible = chk_tuf.Checked;
        }
        private void chk_tus_CheckedChanged(object sender, EventArgs e)
        {
            dtp_tuss.Visible = chk_tus.Checked;
            dtp_tuse.Visible = chk_tus.Checked;
        }
        #endregion

        #region we
        private void chk_weType_CheckedChanged(object sender, EventArgs e)
        {
            pnl_Visible("we");
        }
        private void chk_weh_CheckedChanged(object sender, EventArgs e)
        {
            chk_weBonus.Visible = chk_weh.Checked;
            chk_weBonus.Checked = (!chk_sah.Checked) ? false : chk_weBonus.Checked;
            pnl_Visible("we");
        }
        private void chk_weBonus_CheckedChanged(object sender, EventArgs e)
        {
            pnl_Visible("we");
        }
        private void chk_wef_CheckedChanged(object sender, EventArgs e)
        {
            dtp_wefs.Visible = chk_wef.Checked;
            dtp_wefe.Visible = chk_wef.Checked;
        }
        private void chk_wes_CheckedChanged(object sender, EventArgs e)
        {
            dtp_wess.Visible = chk_wes.Checked;
            dtp_wese.Visible = chk_wes.Checked;
        }
        #endregion

        #region th
        private void chk_thType_CheckedChanged(object sender, EventArgs e)
        {
            pnl_Visible("th");
        }
        private void chk_thh_CheckedChanged(object sender, EventArgs e)
        {
            chk_thBonus.Visible = chk_thh.Checked;
            chk_thBonus.Checked = (!chk_sah.Checked) ? false : chk_thBonus.Checked;
            pnl_Visible("th");
        }
        private void chk_thBonus_CheckedChanged(object sender, EventArgs e)
        {
            pnl_Visible("th");
        }
        private void chk_thf_CheckedChanged(object sender, EventArgs e)
        {
            dtp_thfs.Visible = chk_thf.Checked;
            dtp_thfe.Visible = chk_thf.Checked;
        }
        private void chk_ths_CheckedChanged(object sender, EventArgs e)
        {
            dtp_thss.Visible = chk_ths.Checked;
            dtp_thse.Visible = chk_ths.Checked;
        }
        #endregion

        #region fr
        private void chk_frType_CheckedChanged(object sender, EventArgs e)
        {
            pnl_Visible("fr");
        }
        private void chk_frh_CheckedChanged(object sender, EventArgs e)
        {
            chk_frBonus.Visible = chk_frh.Checked;
            chk_frBonus.Checked = (!chk_sah.Checked) ? false : chk_frBonus.Checked;
            pnl_Visible("fr");
        }
        private void chk_frBonus_CheckedChanged(object sender, EventArgs e)
        {
            pnl_Visible("fr");
        }
        private void chk_frf_CheckedChanged(object sender, EventArgs e)
        {
            dtp_frfs.Visible = chk_frf.Checked;
            dtp_frfe.Visible = chk_frf.Checked;
        }
        private void chk_frs_CheckedChanged(object sender, EventArgs e)
        {
            dtp_frss.Visible = chk_frs.Checked;
            dtp_frse.Visible = chk_frs.Checked;
        }
        #endregion

        #endregion
    }
}
