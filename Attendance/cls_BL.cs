using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using zkemkeeper;
using Attendance.Info;

namespace Attendance
{
    class cls_BL
    {
        CZKEM objCZKEM = new CZKEM();

        public struct General
        {
            string lbl;
            Thread thread;

            #region Pro
            void Start_Waiting()
            {
                thread = new Thread(Waiting);
                thread.IsBackground = true;
                thread.Start();
            }
            void Waiting()
            {
                frm_Witing w = new frm_Witing();
                w.lbl.Text = lbl;

                w.ShowDialog();
            }
            void Abort_Waiting()
            {
                thread.Abort();
            }
            #endregion

            public DataTable Select(string s)
            {
                cls_DAL DAL = new cls_DAL();
                DataTable dt = new DataTable();

                dt = DAL.SelectData(s);

                return dt;
            }
            public string RestData()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                string F;
                F = DAL.ExecuteCommand( 
                                         "delete from Depart;"
                                        +"delete from sqlite_sequence where name = 'Depart';"
                                        +"delete from Device;"
                                        +"delete from sqlite_sequence where name = 'Device';"
                                        +"delete from Emp;"
                                        +"delete from sqlite_sequence where name = 'Emp';"
                                        +"delete from IOEdit;"
                                        +"delete from sqlite_sequence where name = 'IOEdit';"
                                        +"delete from Sec;"
                                        +"delete from sqlite_sequence where name = 'Sec';"
                                        +"delete from Vac;"
                                        +"delete from sqlite_sequence where name = 'Vac';"
                                        +"delete from VacWS;"
                                        +"delete from sqlite_sequence where name = 'VacWS';"
                                        +"delete from `[IO]`;"
                                        +"delete from `[WorkSys]`;"
                                        +"delete from sqlite_sequence where name ='[WorkSys]';"
                                        , null);
                DAL.Close();

                return F;
            }
            public string RestIO()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                string F;
                F = DAL.ExecuteCommand("delete from `[IO]`", null);
                DAL.Close();

                return F;
            }
            public void BackupData()
            {
                string d = DateTime.Now.ToString("yyyy_MM_dd hh_mm_ss");
                try
                {
                    lbl = "جارٍ النسخ ...";
                    Start_Waiting();

                    using (var source = new SQLiteConnection(@"Data Source = Att.db; Version=3;"))
                    using (var destination = new SQLiteConnection(@"Data Source=Backup\Att.db; Version=3;"))
                    {
                        source.Open();
                        destination.Open();
                        source.BackupDatabase(destination, "main", "main", -1, null, 0);

                        using (ZipFile zip = new ZipFile())
                        {
                            zip.AddFile(@"Backup\Att.db");
                            zip.Save(@"Backup\" + d + ".zip");
                        }
                    }

                    Abort_Waiting();
                    MessageBox.Show("تم حفظ النسخة الإحتياطية بنجاح", "حفظ نسخة إحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "حفظ نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            public void RestoreData(string f)
            {
                //File.Move("Att.db", "Restored\\" + DateTime.Now.ToString("yyyy_MM_dd hh_mm_ss"));
                //File.Copy("", "");
            }
        }

        public struct Update
        {
            public int Check()
            {
                cls_DAL DAL = new cls_DAL();
                DataTable dt = new DataTable();

                dt = DAL.SelectData("Select max(last_Update) from sys;", null);
                if (dt.Rows[0][0].ToString() == "") return 0;
                return Convert.ToInt32(dt.Rows[0][0]);
            }
            public int update(string s,int max)
            {
                string select = "  insert into sys (last_Update) values(@max);  select max(last_Update) from sys;";
                cls_DAL DAL = new cls_DAL();
                DataTable dt = new DataTable();
                SQLiteParameter[] param = new SQLiteParameter[1];

                param[0] = new SQLiteParameter("@max");
                param[0].Value = max;
                dt = DAL.SelectData(s+select, param);

                if (dt.Rows.Count == 0) return 0;
                if (dt.Rows[0][0].ToString() == "") return 0;
                return Convert.ToInt32(dt.Rows[0][0]);
            }
        }
        public struct Users
        {
            #region Var
            public int ID;
            public string Name;
            public string Password;
            #endregion

            public DataTable Select()
            {
                cls_DAL DAL = new cls_DAL();
                DataTable Users = new DataTable();
                Users = DAL.SelectData("Select * From Users", null);

                return Users;
            }
            public string Insert()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                SQLiteParameter[] param = new SQLiteParameter[2];

                param[0] = new SQLiteParameter("@Name");
                param[0].Value = Name;

                param[1] = new SQLiteParameter("@Password");
                param[1].Value = Password;

                string F;
                F = DAL.ExecuteCommand("Insert Into Users (Name,Password) Values (@Name , @Password)", param);

                DAL.Close();

                return F;
            }
            public string Update()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                SQLiteParameter[] param = new SQLiteParameter[3];

                param[0] = new SQLiteParameter("@ID");
                param[0].Value = ID;

                param[1] = new SQLiteParameter("@Name");
                param[1].Value = Name;

                param[2] = new SQLiteParameter("@Password");
                param[2].Value = Password;

                string F;
                F = DAL.ExecuteCommand("Update Users Set Name = @Name , Password = @Password Where ID = @ID", param);

                DAL.Close();

                return F;
            }
            public string Delete()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                SQLiteParameter[] param = new SQLiteParameter[1];

                param[0] = new SQLiteParameter("@ID");
                param[0].Value = ID;

                string f;
                f = DAL.ExecuteCommand("delete from users where id = @ID", param);

                DAL.Close();

                return f;
            }
        }

        public struct Emp
        {
            #region Var
            public int ID;
            public string ID2;
            public string Name;
            public string Device;
            public string Depart;
            public string Sec;
            public int WS;
            #endregion

            public int Select_Cout()
            {
                cls_DAL DAL = new cls_DAL();
                DataTable dt = new DataTable();
                dt = DAL.SelectData("Select Count(ID2) From Emp", null);

                if (dt.Rows[0][0].ToString() == "") return 0;
                return Convert.ToInt32(dt.Rows[0][0]);
            }
            public DataTable Select()
            {
                cls_DAL DAL = new cls_DAL();
                DataTable Emp = new DataTable();
                Emp = DAL.SelectData("Select * From Emp", null);

                return Emp;
            }
            public DataTable SelectNew()
            {
                cls_DAL DAL = new cls_DAL();
                DataTable Emp = new DataTable();
                Emp = DAL.SelectData("select distinct emp_id from `[io]` where emp_id not in (select ID2 from emp) order by emp_id", null);

                return Emp;
            }
            public DataTable Select_Print(string ws, string  device, string depart, string sec)
            {
                string all = ws;
                all = (all.Length > 0) ? " WS in " + ws : "";
                all = (all.Length > 0 && device.Length > 0) ? all + " and " : all;
                if(device.Length > 0) all += " Device in " + device;
                all = (all.Length > 0 && depart.Length > 0) ? all + " and " : all;
                if(depart.Length > 0) all += " Depart in " + depart;
                all = (all.Length > 0 && sec.Length > 0) ? all + " and " : all;
                if(sec.Length > 0) all += " Sec in " + sec;
                all = (all.Length > 0 ) ? " Where " + all : all;


                cls_DAL DAL = new cls_DAL();
                DataTable dt = new DataTable();
                if (all.Length == 0) return dt;

                dt = DAL.SelectData("Select * From Emp " + all  , null);

                return dt;
            }
            public string Insert()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                SQLiteParameter[] param = new SQLiteParameter[6];

                param[0] = new SQLiteParameter("@ID2");
                param[0].Value = ID2;

                param[1] = new SQLiteParameter("@Name");
                param[1].Value = Name;

                param[2] = new SQLiteParameter("@Device");
                param[2].Value = Device;

                param[3] = new SQLiteParameter("@WS");
                param[3].Value = WS;

                param[4] = new SQLiteParameter("@Depart");
                param[4].Value = Depart;

                param[5] = new SQLiteParameter("@Sec");
                param[5].Value = Sec;

                string F;
                F = DAL.ExecuteCommand("Insert Into Emp (ID2,Name,Device,WS,Depart,Sec) Values (@ID2, @Name, @Device, @WS,@Depart,@Sec)", param);

                DAL.Close();

                return F;
            }
            public string Update()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                SQLiteParameter[] param = new SQLiteParameter[7];

                param[0] = new SQLiteParameter("@ID");
                param[0].Value = ID;

                param[1] = new SQLiteParameter("@ID2");
                param[1].Value = ID2;

                param[2] = new SQLiteParameter("@Name");
                param[2].Value = Name;

                param[3] = new SQLiteParameter("@Device");
                param[3].Value = Device;

                param[4] = new SQLiteParameter("@WS");
                param[4].Value = WS;

                param[5] = new SQLiteParameter("@Depart");
                param[5].Value = Depart;

                param[6] = new SQLiteParameter("@Sec");
                param[6].Value = Sec;

                string F;
                F = DAL.ExecuteCommand("Update Emp Set ID2 = @ID2,  Name = @Name, Device = @Device, WS = @WS, Depart = @Depart, Sec = @Sec Where ID = @ID", param);

                DAL.Close();

                return F;
            }
            public string Delete()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                SQLiteParameter[] param = new SQLiteParameter[1];

                param[0] = new SQLiteParameter("@ID");
                param[0].Value = ID;

                string f;
                f = DAL.ExecuteCommand("delete from emp where id = @ID", param);

                DAL.Close();

                return f;
            }
        }

        public struct Device
        {
            #region Var
            public int ID;
            public string ID2;
            public string Name;
            public string ip;
            public string port;
            #endregion

            public DataTable SelectNew()
            {
                cls_DAL DAL = new cls_DAL();
                DataTable dt = new DataTable();
                dt = DAL.SelectData("select distinct device_id from `[io]` where device_id not in (select ID2 from device) order by device_id", null);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["device_id"].ToString() == "-1" || dt.Rows[i]["device_id"].ToString() == "No Device Code")
                    {
                        dt.Rows.RemoveAt(i);
                        i--;
                    }
                }

                return dt;
            }
            public DataTable Select()
            {
                cls_DAL DAL = new cls_DAL();
                DataTable Emp = new DataTable();
                Emp = DAL.SelectData("Select * From Device", null);

                return Emp;
            }
            public string Insert()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                SQLiteParameter[] param = new SQLiteParameter[2];

                param[0] = new SQLiteParameter("@ID2");
                param[0].Value = ID2;

                param[1] = new SQLiteParameter("@Name");
                param[1].Value = Name;

                string F;
                F = DAL.ExecuteCommand("Insert Into Device (ID2,Name, ip, port) Values (@ID2, @Name, '"+ip+"', '"+port+"')", param);

                DAL.Close();

                return F;
            }
            public string Update()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                SQLiteParameter[] param = new SQLiteParameter[3];

                param[0] = new SQLiteParameter("@ID");
                param[0].Value = ID;

                param[1] = new SQLiteParameter("@ID2");
                param[1].Value = ID2;

                param[2] = new SQLiteParameter("@Name");
                param[2].Value = Name;

                string F;
                F = DAL.ExecuteCommand("Update Device Set ID2 = @ID2,  Name = @Name, ip = '"+ip+"', port = '"+port+"' Where ID = @ID", param);

                DAL.Close();

                return F;
            }
            public string Delete()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                SQLiteParameter[] param = new SQLiteParameter[1];

                param[0] = new SQLiteParameter("@ID");
                param[0].Value = ID;

                string f;
                f = DAL.ExecuteCommand("delete from Device where id = @ID", param);

                DAL.Close();

                return f;
            }
        }

        public struct WorkSys
        {
            #region Var

            #region General
            public int ID;
            public string Name;
            public int Day_Hours;
            public int Day_Min;
            public bool BonusCheck;
            public bool LateCheck;
            public bool AttEarly;
            public bool LeaveEarly;
            public bool ti;
            public int first_as;
            public int first_ae;
            public int first_ls;
            public int first_le;
            public int second_as;
            public int second_ae;
            public int second_ls;
            public int second_le;
            #endregion

            public string saPeriod_Hours;
            public bool saNonFixed;
            public bool sah;
            public bool saBonus;
            public bool saf;
            public DateTime safs;
            public DateTime safe;
            public DateTime safa;
            public bool sas;
            public DateTime sass;
            public DateTime sase;
            public DateTime sasa;

            public string suPeriod_Hours;
            public bool suNonFixed;
            public bool suh;
            public bool suBonus;
            public bool suf;
            public DateTime sufs;
            public DateTime sufe;
            public DateTime sufa;
            public bool sus;
            public DateTime suss;
            public DateTime suse;
            public DateTime susa;

            public string moPeriod_Hours;
            public bool moNonFixed;
            public bool moh;
            public bool moBonus;
            public bool mof;
            public DateTime mofs;
            public DateTime mofe;
            public DateTime mofa;
            public bool mos;
            public DateTime moss;
            public DateTime mose;
            public DateTime mosa;

            public string tuPeriod_Hours;
            public bool tuNonFixed;
            public bool tuh;
            public bool tuBonus;
            public bool tuf;
            public DateTime tufs;
            public DateTime tufe;
            public DateTime tufa;
            public bool tus;
            public DateTime tuss;
            public DateTime tuse;
            public DateTime tusa;

            public string wePeriod_Hours;
            public bool weNonFixed;
            public bool weh;
            public bool weBonus;
            public bool wef;
            public DateTime wefs;
            public DateTime wefe;
            public DateTime wefa;
            public bool wes;
            public DateTime wess;
            public DateTime wese;
            public DateTime wesa;

            public string thPeriod_Hours;
            public bool thNonFixed;
            public bool thh;
            public bool thBonus;
            public bool thf;
            public DateTime thfs;
            public DateTime thfe;
            public DateTime thfa;
            public bool ths;
            public DateTime thss;
            public DateTime thse;
            public DateTime thsa;

            public string frPeriod_Hours;
            public bool frNonFixed;
            public bool frh;
            public bool frBonus;
            public bool frf;
            public DateTime frfs;
            public DateTime frfe;
            public DateTime frfa;
            public bool frs;
            public DateTime frss;
            public DateTime frse;
            public DateTime frsa;
            #endregion

            public int Select_Cout()
            {
                cls_DAL DAL = new cls_DAL();
                DataTable dt = new DataTable();
                dt = DAL.SelectData("Select Count(ID) From `[WorkSys]`", null);

                if (dt.Rows[0][0].ToString() == "") return 0;
                return Convert.ToInt32(dt.Rows[0][0]);
            }
            public DataTable Select()
            {
                cls_DAL DAL = new cls_DAL();
                DataTable Emp = new DataTable();
                Emp = DAL.SelectData("select * from `[WorkSys]`", null);

                return Emp;
            }
            public string Insert()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                string F;
                F = DAL.ExecuteCommand("Insert Into `[WorkSys]` (Name,Day_Hours,Day_Min,"
                 + "ti,BonusCheck,LateCheck,AttEarly,LeaveEarly,First_as,First_ae,First_ls,First_le,Second_as,Second_ae,Second_ls,Second_le,"
                 + "saPeriod_Hours, saType, sah, saBonus, saf, safs, safe, safa, sas, sass, sase, sasa,"
                 + "suPeriod_Hours, suType, suh, suBonus, suf, sufs, sufe, sufa, sus, suss, suse, susa,"
                 + "moPeriod_Hours, moType, moh, moBonus, mof, mofs, mofe, mofa, mos, moss, mose, mosa,"
                 + "tuPeriod_Hours, tuType, tuh, tuBonus, tuf, tufs, tufe, tufa, tus, tuss, tuse, tusa,"
                 + "wePeriod_Hours, weType, weh, weBonus, wef, wefs, wefe, wefa, wes, wess, wese, wesa,"
                 + "thPeriod_Hours, thType, thh, thBonus, thf, thfs, thfe, thfa, ths, thss, thse, thsa,"
                 + "frPeriod_Hours, frType, frh, frBonus, frf, frfs, frfe, frfa, frs, frss, frse, frsa"
                 + ") Values "
                 + "('" + Name + "'," + ((Day_Hours == 0) ? 24 : Day_Hours) +","+Day_Min+","
                 + Convert.ToInt32(ti) + "," + Convert.ToInt32(BonusCheck) + "," + Convert.ToInt32(LateCheck) + "," + Convert.ToInt32(AttEarly) + "," + Convert.ToInt32(LeaveEarly) + "," + first_as + "," + first_ae + "," + first_ls + "," + first_le + "," + second_as + "," + second_ae + "," + second_ls + "," + second_le + ",'"
                 + saPeriod_Hours + "'," + Convert.ToInt32(saNonFixed) + "," + Convert.ToInt32(sah) + "," + Convert.ToInt32(saBonus) + "," + Convert.ToInt32(saf) + ",'" + safs.ToString("yyyy-MM-dd HH:mm") + "','" + safe.ToString("yyyy-MM-dd HH:mm") + "','" + safa.ToString("yyyy-MM-dd HH:mm") + "'," + Convert.ToInt32(sas) + ",'" + sass.ToString("yyyy-MM-dd HH:mm") + "','" + sase.ToString("yyyy-MM-dd HH:mm") + "','" + sasa.ToString("yyyy-MM-dd HH:mm") + "','"
                 + suPeriod_Hours + "'," + Convert.ToInt32(suNonFixed) + "," + Convert.ToInt32(suh) + "," + Convert.ToInt32(suBonus) + "," + Convert.ToInt32(suf) + ",'" + sufs.ToString("yyyy-MM-dd HH:mm") + "','" + sufe.ToString("yyyy-MM-dd HH:mm") + "','" + sufa.ToString("yyyy-MM-dd HH:mm") + "'," + Convert.ToInt32(sus) + ",'" + suss.ToString("yyyy-MM-dd HH:mm") + "','" + suse.ToString("yyyy-MM-dd HH:mm") + "','" + susa.ToString("yyyy-MM-dd HH:mm") + "','"
                 + moPeriod_Hours + "'," + Convert.ToInt32(moNonFixed) + "," + Convert.ToInt32(moh) + "," + Convert.ToInt32(moBonus) + "," + Convert.ToInt32(mof) + ",'" + mofs.ToString("yyyy-MM-dd HH:mm") + "','" + mofe.ToString("yyyy-MM-dd HH:mm") + "','" + mofa.ToString("yyyy-MM-dd HH:mm") + "'," + Convert.ToInt32(mos) + ",'" + moss.ToString("yyyy-MM-dd HH:mm") + "','" + mose.ToString("yyyy-MM-dd HH:mm") + "','" + mosa.ToString("yyyy-MM-dd HH:mm") + "','"
                 + tuPeriod_Hours + "'," + Convert.ToInt32(tuNonFixed) + "," + Convert.ToInt32(tuh) + "," + Convert.ToInt32(tuBonus) + "," + Convert.ToInt32(tuf) + ",'" + tufs.ToString("yyyy-MM-dd HH:mm") + "','" + tufe.ToString("yyyy-MM-dd HH:mm") + "','" + tufa.ToString("yyyy-MM-dd HH:mm") + "'," + Convert.ToInt32(tus) + ",'" + tuss.ToString("yyyy-MM-dd HH:mm") + "','" + tuse.ToString("yyyy-MM-dd HH:mm") + "','" + tusa.ToString("yyyy-MM-dd HH:mm") + "','"
                 + wePeriod_Hours + "'," + Convert.ToInt32(weNonFixed) + "," + Convert.ToInt32(weh) + "," + Convert.ToInt32(weBonus) + "," + Convert.ToInt32(wef) + ",'" + wefs.ToString("yyyy-MM-dd HH:mm") + "','" + wefe.ToString("yyyy-MM-dd HH:mm") + "','" + wefa.ToString("yyyy-MM-dd HH:mm") + "'," + Convert.ToInt32(wes) + ",'" + wess.ToString("yyyy-MM-dd HH:mm") + "','" + wese.ToString("yyyy-MM-dd HH:mm") + "','" + wesa.ToString("yyyy-MM-dd HH:mm") + "','"
                 + thPeriod_Hours + "'," + Convert.ToInt32(thNonFixed) + "," + Convert.ToInt32(thh) + "," + Convert.ToInt32(thBonus) + "," + Convert.ToInt32(thf) + ",'" + thfs.ToString("yyyy-MM-dd HH:mm") + "','" + thfe.ToString("yyyy-MM-dd HH:mm") + "','" + thfa.ToString("yyyy-MM-dd HH:mm") + "'," + Convert.ToInt32(ths) + ",'" + thss.ToString("yyyy-MM-dd HH:mm") + "','" + thse.ToString("yyyy-MM-dd HH:mm") + "','" + thsa.ToString("yyyy-MM-dd HH:mm") + "','"
                 + frPeriod_Hours + "'," + Convert.ToInt32(frNonFixed) + "," + Convert.ToInt32(frh) + "," + Convert.ToInt32(frBonus) + "," + Convert.ToInt32(frf) + ",'" + frfs.ToString("yyyy-MM-dd HH:mm") + "','" + frfe.ToString("yyyy-MM-dd HH:mm") + "','" + frfa.ToString("yyyy-MM-dd HH:mm") + "'," + Convert.ToInt32(frs) + ",'" + frss.ToString("yyyy-MM-dd HH:mm") + "','" + frse.ToString("yyyy-MM-dd HH:mm") + "','" + frsa.ToString("yyyy-MM-dd HH:mm") + "'"
                 + ")"
                 , null);

                DAL.Close();

                return F;
            }
            public string Update()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                string F;
                F = DAL.ExecuteCommand("Update `[WorkSys]` Set Name = '" + Name + "',  Day_Hours = " + ((Day_Hours == 0) ? 24 : Day_Hours) + ", Day_Min = " + Day_Min
                    + ",BonusCheck = " + Convert.ToInt32(BonusCheck)
                    + ",LateCheck = " + Convert.ToInt32(LateCheck)
                    + ",AttEarly = " + Convert.ToInt32(AttEarly)
                    + ",LeaveEarly = " + Convert.ToInt32(LeaveEarly)
                    + ",ti = " + Convert.ToInt32(ti)
                    + ",First_as = " + first_as
                    + ",First_ae = " + first_ae
                    + ",First_ls = " + first_ls
                    + ",First_le = " + first_le
                    + ",Second_as = " + second_as
                    + ",Second_ae = " + second_ae
                    + ",Second_ls = " + second_ls
                    + ",Second_le = " + second_le
                    + ",saPeriod_Hours = '" + saPeriod_Hours + "', saType = " + Convert.ToInt32(saNonFixed) + ", sah = " + Convert.ToInt32(sah) + ", saBonus = " + Convert.ToInt32(saBonus) + ", saf = " + Convert.ToInt32(saf) + ", safs = '" + safs.ToString("yyyy-MM-dd HH:mm") + "', safe = '" + safe.ToString("yyyy-MM-dd HH:mm") + "', safa = '" + safa.ToString("yyyy-MM-dd HH:mm") + "', sas = " + Convert.ToInt32(sas) + ", sass = '" + sass.ToString("yyyy-MM-dd HH:mm") + "', sase = '" + sase.ToString("yyyy-MM-dd HH:mm") + "', sasa = '" + sasa.ToString("yyyy-MM-dd HH:mm") + "',"
                    + "suPeriod_Hours = '" + suPeriod_Hours + "', suType = " + Convert.ToInt32(suNonFixed) + ", suh = " + Convert.ToInt32(suh) + ", suBonus = " + Convert.ToInt32(suBonus) + ", suf = " + Convert.ToInt32(suf) + ", sufs = '" + sufs.ToString("yyyy-MM-dd HH:mm") + "', sufe = '" + sufe.ToString("yyyy-MM-dd HH:mm") + "', sufa = '" + sufa.ToString("yyyy-MM-dd HH:mm") + "', sus = " + Convert.ToInt32(sus) + ", suss = '" + suss.ToString("yyyy-MM-dd HH:mm") + "', suse = '" + suse.ToString("yyyy-MM-dd HH:mm") + "', susa = '" + susa.ToString("yyyy-MM-dd HH:mm") + "',"
                    + "moPeriod_Hours = '" + moPeriod_Hours + "', moType = " + Convert.ToInt32(moNonFixed) + ", moh = " + Convert.ToInt32(moh) + ", moBonus = " + Convert.ToInt32(moBonus) + ", mof = " + Convert.ToInt32(mof) + ", mofs = '" + mofs.ToString("yyyy-MM-dd HH:mm") + "', mofe = '" + mofe.ToString("yyyy-MM-dd HH:mm") + "', mofa = '" + mofa.ToString("yyyy-MM-dd HH:mm") + "', mos = " + Convert.ToInt32(mos) + ", moss = '" + moss.ToString("yyyy-MM-dd HH:mm") + "', mose = '" + mose.ToString("yyyy-MM-dd HH:mm") + "', mosa = '" + mosa.ToString("yyyy-MM-dd HH:mm") + "',"
                    + "tuPeriod_Hours = '" + tuPeriod_Hours + "', tuType = " + Convert.ToInt32(tuNonFixed) + ", tuh = " + Convert.ToInt32(tuh) + ", tuBonus = " + Convert.ToInt32(tuBonus) + ", tuf = " + Convert.ToInt32(tuf) + ", tufs = '" + tufs.ToString("yyyy-MM-dd HH:mm") + "', tufe = '" + tufe.ToString("yyyy-MM-dd HH:mm") + "', tufa = '" + tufa.ToString("yyyy-MM-dd HH:mm") + "', tus = " + Convert.ToInt32(tus) + ", tuss = '" + tuss.ToString("yyyy-MM-dd HH:mm") + "', tuse = '" + tuse.ToString("yyyy-MM-dd HH:mm") + "', tusa = '" + tusa.ToString("yyyy-MM-dd HH:mm") + "',"
                    + "wePeriod_Hours = '" + wePeriod_Hours + "', weType = " + Convert.ToInt32(weNonFixed) + ", weh = " + Convert.ToInt32(weh) + ", weBonus = " + Convert.ToInt32(weBonus) + ", wef = " + Convert.ToInt32(wef) + ", wefs = '" + wefs.ToString("yyyy-MM-dd HH:mm") + "', wefe = '" + wefe.ToString("yyyy-MM-dd HH:mm") + "', wefa = '" + wefa.ToString("yyyy-MM-dd HH:mm") + "', wes = " + Convert.ToInt32(wes) + ", wess = '" + wess.ToString("yyyy-MM-dd HH:mm") + "', wese = '" + wese.ToString("yyyy-MM-dd HH:mm") + "', wesa = '" + wesa.ToString("yyyy-MM-dd HH:mm") + "',"
                    + "thPeriod_Hours = '" + thPeriod_Hours + "', thType = " + Convert.ToInt32(thNonFixed) + ", thh = " + Convert.ToInt32(thh) + ", thBonus = " + Convert.ToInt32(thBonus) + ", thf = " + Convert.ToInt32(thf) + ", thfs = '" + thfs.ToString("yyyy-MM-dd HH:mm") + "', thfe = '" + thfe.ToString("yyyy-MM-dd HH:mm") + "', thfa = '" + thfa.ToString("yyyy-MM-dd HH:mm") + "', ths = " + Convert.ToInt32(ths) + ", thss = '" + thss.ToString("yyyy-MM-dd HH:mm") + "', thse = '" + thse.ToString("yyyy-MM-dd HH:mm") + "', thsa = '" + thsa.ToString("yyyy-MM-dd HH:mm") + "',"
                    + "frPeriod_Hours = '" + frPeriod_Hours + "', frType = " + Convert.ToInt32(frNonFixed) + ", frh = " + Convert.ToInt32(frh) + ", frBonus = " + Convert.ToInt32(frBonus) + ", frf = " + Convert.ToInt32(frf) + ", frfs = '" + frfs.ToString("yyyy-MM-dd HH:mm") + "', frfe = '" + frfe.ToString("yyyy-MM-dd HH:mm") + "', frfa = '" + frfa.ToString("yyyy-MM-dd HH:mm") + "', frs = " + Convert.ToInt32(frs) + ", frss = '" + frss.ToString("yyyy-MM-dd HH:mm") + "', frse = '" + frse.ToString("yyyy-MM-dd HH:mm") + "', frsa = '" + frsa.ToString("yyyy-MM-dd HH:mm") + "'"
                    + " Where ID = " + Convert.ToInt32(ID), null);

                DAL.Close();

                return F;
            }
            public string Delete()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                SQLiteParameter[] param = new SQLiteParameter[1];

                param[0] = new SQLiteParameter("@ID");
                param[0].Value = ID;

                DataTable dt = new DataTable();
                dt = DAL.SelectData("Select Count(ID2) From Emp Where WS = @ID", param);

                if (dt.Rows[0][0].ToString() != "0")
                {
                    MessageBox.Show("لا يمكن حذف هذا النظام لأنه خاص بأحد الموظفين", "حذف نظام دوام", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return "1";
                }
            

            string f;
                f = DAL.ExecuteCommand("delete from `[WorkSys]` where id = @ID", param);

                DAL.Close();

                return f;
            }
        }

        public struct IO
        {
            #region Var
            public string Index;
            public bool Priority;
            public bool Deleted;
            #endregion

            public string Update()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                SQLiteParameter[] param = new SQLiteParameter[3];

                param[0] = new SQLiteParameter("@Index");
                param[0].Value = Index;

                param[1] = new SQLiteParameter("@Priority");
                param[1].Value = Priority;

                param[2] = new SQLiteParameter("@Deleted");
                param[2].Value = Deleted;

                string F = DAL.ExecuteCommand("Update `[IO]` Set `Priority` = @Priority ,`Deleted` = @Deleted  Where `Index` = @Index", param);

                DAL.Close();
                return F;
            }
            public int Select_Cout(string s)
            {
                cls_DAL DAL = new cls_DAL();
                DataTable dt = new DataTable();
                dt = DAL.SelectData("Select Count(`Index`) From IOEdit Where `Index` = '" + s +"'", null);

                if (dt.Rows[0][0].ToString() == "") return 0;
                return Convert.ToInt32(dt.Rows[0][0]);
            }
        }

        public struct Rep
        {
            #region Var
            Thread thread;
            string Event;
            string statment;
            public string Index { get; set; }
            public string Pin { get; set; }
            public string DateTime { get; set; }
            public string Date { get; set; }
            public string Time { get; set; }        
            public string State(string io)
            {
                string x = "0";
                if (io == "Check out" || io == "1") { x = "1"; }
                return x;
            }
            public string Device { get; set; }

            public string Attend1 { get; set; }
            public string Leave1 { get; set; }
            public string Period1 { get; set; }
            public string Attend2 { get; set; }
            public string Leave2 { get; set; }
            public string Period2 { get; set; }
            public string Deduction { get; set; }
            public string Over { get; set; }
            public string AllPeriod { get; set; }           

            #endregion

            #region Pro
            public DateTime ToDateTime(object txt)
            {
                DateTime newDate = System.DateTime.ParseExact(
                    txt.ToString(),
                    "yyyy-MM-dd HH-mm-ss",
                    CultureInfo.InvariantCulture);
                return newDate;
            }
            public DataTable EventCol()
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(string));
                dt.Columns.Add("Name", typeof(string));
                dt.Rows.Add(0, "حضور");
                dt.Rows.Add(1, "إنصراف");
                return dt;
            }
            public string Day(string d)
            {
                switch (d)
                {
                    case "Saturday":
                        return "السبت";
                    case "Sunday":
                        return "الأحد";
                    case "Monday":
                        return "الأثنين";
                    case "Tuesday":
                        return "الثلاثاء";
                    case "Wednesday":
                        return "الأربعاء";
                    case "Thursday":
                        return "الخميس";
                    case "Friday":
                        return "الجمعة";

                    default:
                        return "";
                }
            }
            public string Per_Hours(string d, DataTable dt)
            {
                switch (d)
                {
                    case "Saturday":
                        return dt.Rows[0]["saPeriod_Hours"].ToString();
                    case "Sunday":
                        return dt.Rows[0]["suPeriod_Hours"].ToString();
                    case "Monday":
                        return dt.Rows[0]["moPeriod_Hours"].ToString();
                    case "Tuesday":
                        return dt.Rows[0]["tuPeriod_Hours"].ToString();
                    case "Wednesday":
                        return dt.Rows[0]["wePeriod_Hours"].ToString();
                    case "Thursday":
                        return dt.Rows[0]["thPeriod_Hours"].ToString();
                    case "Friday":
                        return dt.Rows[0]["frPeriod_Hours"].ToString();

                    default:
                        return "";
                }
            }
            public DataTable AnnHoliday(string date, DataTable dt)
            {
                DataTable dt_result = new DataTable();
                dt_result.Columns.Add("Name", typeof(string));
                dt_result.Columns.Add("Bonus", typeof(string));

                string MM = Convert.ToDateTime(date).ToString("MM");
                string dd = Convert.ToDateTime(date).ToString("dd");

                foreach (DataRow r in dt.Rows)
                {
                    if(r["MM"].ToString() == MM && r["dd"].ToString() == dd)
                    {
                        dt_result.Rows.Add(r["Name"], r["Bonus"]);
                        return dt_result;
                    }
                }

                return dt_result;
            }
            public bool Holiday(string d,DataTable dt)
            {
                switch (d)
                {
                    case "Saturday":
                        return Convert.ToBoolean(dt.Rows[0]["sah"]);
                    case "Sunday":
                        return Convert.ToBoolean(dt.Rows[0]["suh"]);
                    case "Monday":
                        return Convert.ToBoolean(dt.Rows[0]["moh"]);
                    case "Tuesday":
                        return Convert.ToBoolean(dt.Rows[0]["tuh"]);
                    case "Wednesday":
                        return Convert.ToBoolean(dt.Rows[0]["weh"]);
                    case "Thursday":
                        return Convert.ToBoolean(dt.Rows[0]["thh"]);
                    case "Friday":
                        return Convert.ToBoolean(dt.Rows[0]["frh"]);

                    default:
                        return false;
                }
            }
            public bool Bonus(string d, DataTable dt)
            {
                switch (d)
                {
                    case "Saturday":
                        return Convert.ToBoolean(dt.Rows[0]["saBonus"]);
                    case "Sunday":
                        return Convert.ToBoolean(dt.Rows[0]["suBonus"]);
                    case "Monday":
                        return Convert.ToBoolean(dt.Rows[0]["moBonus"]);
                    case "Tuesday":
                        return Convert.ToBoolean(dt.Rows[0]["tuBonus"]);
                    case "Wednesday":
                        return Convert.ToBoolean(dt.Rows[0]["weBonus"]);
                    case "Thursday":
                        return Convert.ToBoolean(dt.Rows[0]["thBonus"]);
                    case "Friday":
                        return Convert.ToBoolean(dt.Rows[0]["frBonus"]);

                    default:
                        return true;
                }
            }
            public bool Fixed(string d, DataTable dt)
            {
                switch (d)
                {
                    case "Saturday":
                        return Convert.ToBoolean(dt.Rows[0]["saType"]);
                    case "Sunday":
                        return Convert.ToBoolean(dt.Rows[0]["suType"]);
                    case "Monday":
                        return Convert.ToBoolean(dt.Rows[0]["moType"]);
                    case "Tuesday":
                        return Convert.ToBoolean(dt.Rows[0]["tuType"]);
                    case "Wednesday":
                        return Convert.ToBoolean(dt.Rows[0]["weType"]);
                    case "Thursday":
                        return Convert.ToBoolean(dt.Rows[0]["thType"]);
                    case "Friday":
                        return Convert.ToBoolean(dt.Rows[0]["frType"]);

                    default:
                        return true;
                }
            }
            public string WS_start(string d, DataTable dt)
            {
                switch (d)
                {
                    case "Saturday":
                        return Convert.ToDateTime(dt.Rows[0]["safs"]).ToString("HH:mm");
                    case "Sunday":
                        return Convert.ToDateTime(dt.Rows[0]["sufs"]).ToString("HH:mm");
                    case "Monday":
                        return Convert.ToDateTime(dt.Rows[0]["mofs"]).ToString("HH:mm");
                    case "Tuesday":
                        return Convert.ToDateTime(dt.Rows[0]["tufs"]).ToString("HH:mm");
                    case "Wednesday":
                        return Convert.ToDateTime(dt.Rows[0]["wefs"]).ToString("HH:mm");
                    case "Thursday":
                        return Convert.ToDateTime(dt.Rows[0]["thfs"]).ToString("HH:mm");
                    case "Friday":
                        return Convert.ToDateTime(dt.Rows[0]["frfs"]).ToString("HH:mm");
                    default:
                        return Convert.ToDateTime(dt.Rows[0]["safs"]).ToString("HH:mm");
                }
            }
            public string WS_start2(string d, DataTable dt)
            {
                switch (d)
                {
                    case "Saturday":
                        return Convert.ToDateTime(dt.Rows[0]["sass"]).ToString("HH:mm");
                    case "Sunday":
                        return Convert.ToDateTime(dt.Rows[0]["suss"]).ToString("HH:mm");
                    case "Monday":
                        return Convert.ToDateTime(dt.Rows[0]["moss"]).ToString("HH:mm");
                    case "Tuesday":
                        return Convert.ToDateTime(dt.Rows[0]["tuss"]).ToString("HH:mm");
                    case "Wednesday":
                        return Convert.ToDateTime(dt.Rows[0]["wess"]).ToString("HH:mm");
                    case "Thursday":
                        return Convert.ToDateTime(dt.Rows[0]["thss"]).ToString("HH:mm");
                    case "Friday":
                        return Convert.ToDateTime(dt.Rows[0]["frss"]).ToString("HH:mm");
                    default:
                        return Convert.ToDateTime(dt.Rows[0]["sass"]).ToString("HH:mm");
                }
            }
            public string WS_end(string d, DataTable dt)
            {
                switch (d)
                {
                    case "Saturday":
                        return Convert.ToDateTime(dt.Rows[0]["safe"]).ToString("HH:mm");
                    case "Sunday":
                        return Convert.ToDateTime(dt.Rows[0]["sufe"]).ToString("HH:mm");
                    case "Monday":
                        return Convert.ToDateTime(dt.Rows[0]["mofe"]).ToString("HH:mm");
                    case "Tuesday":
                        return Convert.ToDateTime(dt.Rows[0]["tufe"]).ToString("HH:mm");
                    case "Wednesday":
                        return Convert.ToDateTime(dt.Rows[0]["wefe"]).ToString("HH:mm");
                    case "Thursday":
                        return Convert.ToDateTime(dt.Rows[0]["thfe"]).ToString("HH:mm");
                    case "Friday":
                        return Convert.ToDateTime(dt.Rows[0]["frfe"]).ToString("HH:mm");
                    default:
                        return Convert.ToDateTime(dt.Rows[0]["safe"]).ToString("HH:mm");
                }
            }
            public string WS_end2(string d, DataTable dt)
            {
                switch (d)
                {
                    case "Saturday":
                        return Convert.ToDateTime(dt.Rows[0]["sase"]).ToString("HH:mm");
                    case "Sunday":
                        return Convert.ToDateTime(dt.Rows[0]["suse"]).ToString("HH:mm");
                    case "Monday":
                        return Convert.ToDateTime(dt.Rows[0]["mose"]).ToString("HH:mm");
                    case "Tuesday":
                        return Convert.ToDateTime(dt.Rows[0]["tuse"]).ToString("HH:mm");
                    case "Wednesday":
                        return Convert.ToDateTime(dt.Rows[0]["wese"]).ToString("HH:mm");
                    case "Thursday":
                        return Convert.ToDateTime(dt.Rows[0]["thse"]).ToString("HH:mm");
                    case "Friday":
                        return Convert.ToDateTime(dt.Rows[0]["frse"]).ToString("HH:mm");
                    default:
                        return Convert.ToDateTime(dt.Rows[0]["sase"]).ToString("HH:mm");
                }
            }       

            public TimeSpan WS_Start(string d, DataTable dt)
            {
                switch (d)
                {
                    case "Saturday":
                        return Convert.ToDateTime(dt.Rows[0]["safs"]).TimeOfDay;
                    case "Sunday":
                        return Convert.ToDateTime(dt.Rows[0]["sufs"]).TimeOfDay;
                    case "Monday":
                        return Convert.ToDateTime(dt.Rows[0]["mofs"]).TimeOfDay;
                    case "Tuesday":
                        return Convert.ToDateTime(dt.Rows[0]["tufs"]).TimeOfDay;
                    case "Wednesday":
                        return Convert.ToDateTime(dt.Rows[0]["wefs"]).TimeOfDay;
                    case "Thursday":
                        return Convert.ToDateTime(dt.Rows[0]["thfs"]).TimeOfDay;
                    case "Friday":
                        return Convert.ToDateTime(dt.Rows[0]["frfs"]).TimeOfDay;
                    default:
                        return Convert.ToDateTime(dt.Rows[0]["safs"]).TimeOfDay;
                }
            }
            public TimeSpan WS_Start2(string d, DataTable dt)
            {
                switch (d)
                {
                    case "Saturday":
                        return Convert.ToDateTime(dt.Rows[0]["sass"]).TimeOfDay;
                    case "Sunday":
                        return Convert.ToDateTime(dt.Rows[0]["suss"]).TimeOfDay;
                    case "Monday":
                        return Convert.ToDateTime(dt.Rows[0]["moss"]).TimeOfDay;
                    case "Tuesday":
                        return Convert.ToDateTime(dt.Rows[0]["tuss"]).TimeOfDay;
                    case "Wednesday":
                        return Convert.ToDateTime(dt.Rows[0]["wess"]).TimeOfDay;
                    case "Thursday":
                        return Convert.ToDateTime(dt.Rows[0]["thss"]).TimeOfDay;
                    case "Friday":
                        return Convert.ToDateTime(dt.Rows[0]["frss"]).TimeOfDay;
                    default:
                        return Convert.ToDateTime(dt.Rows[0]["sass"]).TimeOfDay;
                }
            }
            public TimeSpan WS_End(string d, DataTable dt)
            {
                switch (d)
                {
                    case "Saturday":
                        return Convert.ToDateTime(dt.Rows[0]["safe"]).TimeOfDay;
                    case "Sunday":
                        return Convert.ToDateTime(dt.Rows[0]["sufe"]).TimeOfDay;
                    case "Monday":
                        return Convert.ToDateTime(dt.Rows[0]["mofe"]).TimeOfDay;
                    case "Tuesday":
                        return Convert.ToDateTime(dt.Rows[0]["tufe"]).TimeOfDay;
                    case "Wednesday":
                        return Convert.ToDateTime(dt.Rows[0]["wefe"]).TimeOfDay;
                    case "Thursday":
                        return Convert.ToDateTime(dt.Rows[0]["thfe"]).TimeOfDay;
                    case "Friday":
                        return Convert.ToDateTime(dt.Rows[0]["frfe"]).TimeOfDay;
                    default:
                        return Convert.ToDateTime(dt.Rows[0]["safe"]).TimeOfDay;
                }
            }
            public TimeSpan WS_End2(string d, DataTable dt)
            {
                switch (d)
                {
                    case "Saturday":
                        return Convert.ToDateTime(dt.Rows[0]["sase"]).TimeOfDay;
                    case "Sunday":
                        return Convert.ToDateTime(dt.Rows[0]["suse"]).TimeOfDay;
                    case "Monday":
                        return Convert.ToDateTime(dt.Rows[0]["mose"]).TimeOfDay;
                    case "Tuesday":
                        return Convert.ToDateTime(dt.Rows[0]["tuse"]).TimeOfDay;
                    case "Wednesday":
                        return Convert.ToDateTime(dt.Rows[0]["wese"]).TimeOfDay;
                    case "Thursday":
                        return Convert.ToDateTime(dt.Rows[0]["thse"]).TimeOfDay;
                    case "Friday":
                        return Convert.ToDateTime(dt.Rows[0]["frse"]).TimeOfDay;
                    default:
                        return Convert.ToDateTime(dt.Rows[0]["sase"]).TimeOfDay;
                }
            }
            void st()
            {
                statment += ",('" + Index + "','" + Pin + "','" + DateTime + "'," + State(Event) + ",'" + Device + "')";
            }
            string Emp_ID(string []emp_id)
            {
                string s = "";

                foreach (string id in emp_id)
                {
                    s += ",'" + id + "'";
                }
                s = (s != "")? s.Substring(1)  : s;
                return " (" + s + ")";
            }
            void Start_Waiting()
            {               
                thread = new Thread(Waiting);
                thread.IsBackground = true;
                thread.Start();              
            }
            void Waiting()
            {
                frm_Witing w = new frm_Witing();
                w.ShowDialog();
            }
            void Abort_Waiting()
            {
                thread.Abort();
            }
            string Per(DataRow r,int i)
            {
                string d = r["التاريخ"].ToString();
                string p = "";

                #region Per1
                if (i == 1) // الفترة الأولى
                {
                    string t = r["حضور دوام 1"].ToString();
                    string dt = d + " " + t;
                    DateTime d1 = Convert.ToDateTime(dt);

                    string d2s = r["إنصراف دوام 1"].ToString();
                    DateTime d2 = Convert.ToDateTime(d2s);
                    if (d2s.Length == 8)
                    {
                        t = r["إنصراف دوام 1"].ToString();
                        dt = d + " " + t;
                        d2 = Convert.ToDateTime(dt);
                    }

                    TimeSpan tt = d2 - d1;
                    p = ttos(tt);
                }
                #endregion

                #region Per2
                else // الفترة الثانية
                {
                    string t = r["حضور دوام 2"].ToString();
                    string dt = d + " " + t;
                    DateTime d1 = Convert.ToDateTime(dt);

                    string d2s = r["إنصراف دوام 2"].ToString();
                    DateTime d2 = Convert.ToDateTime(d2s);
                    if (d2s.Length == 8)
                    {
                        t = r["إنصراف دوام 2"].ToString();
                        dt = d + " " + t;
                        d2 = Convert.ToDateTime(dt);
                    }

                    TimeSpan tt = d2 - d1;

                    p = ttos(tt);
                }
                #endregion

                return p; 
            }
            string ttos(TimeSpan tt)
            {
                int d = tt.Days;
                int h = tt.Hours;
                int m = tt.Minutes;
                while(d > 0)
                {
                    d--;
                    h += 24;
                }
                string hh = addzero(h.ToString());
                string mm = addzero(m.ToString());

                string t = hh + ":" + mm;
                return t;
            }


            TimeSpan t(DataRow r, int i, DateTime m)
            {
                string d = r["التاريخ"].ToString();
                string t = (i == 1) ? r["حضور دوام 1"].ToString() : r["حضور دوام 2"].ToString();
                string dt = d + " " + t;
                DateTime d1 = Convert.ToDateTime(dt);

                DateTime d2 = m;
                if (d2.ToString().Length == 8)
                {
                    t = m.ToString();
                    dt = d + " " + t;
                    d2 = Convert.ToDateTime(dt);
                }
                TimeSpan result = d2 - d1;
                return result;
            }
            string sum(string f, string s)
            {
                if (f == "") f = "00:00";
                if (s == "") s = "00:00";

                int ih = 0;
                while((f.Substring(ih, 1) != ":"))
                {
                    ih++;
                }
                int im = ih + 1;

                int h = Convert.ToInt32(f.Substring(0, ih)) + Convert.ToInt32(s.Substring(0, 2));
                int m = Convert.ToInt32(f.Substring(im, 2)) + Convert.ToInt32(s.Substring(3, 2));
                while(m >= 60)
                {
                    h += 1;
                    m -= 60;
                }

                string hh = addzero(h.ToString());
                string mm = addzero(m.ToString());

                string t = hh + ":" + mm;
                return t;
            }
            string sub(string r, string p)
            {
                if (p == "") p = "00:00";

                int h = Convert.ToUInt16(r.Substring(0, 2)) - Convert.ToUInt16(p.Substring(0, 2));
                int m = Convert.ToUInt16(r.Substring(3, 2)) - Convert.ToUInt16(p.Substring(3, 2));
                while (m < 0)
                {
                    h -= 1;
                    m += 60;
                }

                string hh = addzero(h.ToString());
                string mm = addzero(m.ToString());

                string t = hh + ":" + mm;
                return t;
            }
            private bool com(string r, string p)
            {
                if (r == "") return false;
                if (p == "") p = "00:00";
                if(Convert.ToInt32(r.Substring(0,2)) > Convert.ToInt32(p.Substring(0, 2)))
                {
                    return true;
                }
                else if (Convert.ToInt32(r.Substring(0, 2)) == Convert.ToInt32(p.Substring(0, 2)))
                {
                    if (Convert.ToInt32(r.Substring(3, 2)) > Convert.ToInt32(p.Substring(3, 2)))
                    {
                        return true;
                    }
                }
                return false;
            }
            string addzero(string s)
            {
                s = (s.Length == 1) ? "0" + s : s;
                return s;
            }
            string addzeroEmpID(string s)
            {
                while(s.Length<9)
                {
                    s = "0" + s;
                }
                return s;
            }
            #endregion

            public int Select_Cout()
            {
                cls_DAL DAL = new cls_DAL();
                DataTable dt = new DataTable();
                dt = DAL.SelectData("Select Count('Index') From `[IO]`", null);

                if (dt.Rows[0][0].ToString() == "") return 0;
                return Convert.ToInt32(dt.Rows[0][0]);
            }
            public string Insert()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                SQLiteParameter[] param = new SQLiteParameter[5];

                param[0] = new SQLiteParameter("@Index");
                param[0].Value = Index;

                param[1] = new SQLiteParameter("@Pin");
                param[1].Value = Pin;

                param[2] = new SQLiteParameter("@DateTime");
                param[2].Value = DateTime;

                param[3] = new SQLiteParameter("@State");
                param[3].Value = State(Event);

                param[4] = new SQLiteParameter("@Device");
                param[4].Value = Device;

                string F = statment.Substring(1);
                F = DAL.ExecuteCommand("Insert OR IGNORE Into `[IO]` (`Index`,`Emp_ID`,`TTime`,`Event`,`Device_ID`) Values " + F + "", param);

                if (F == null)
                {
                    Abort_Waiting();
                    //MessageBox.Show("تم إستيراد البيانات بنجاح", "إستيراد من ملف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DAL.Close();

                return F;
            }
            public async Task<string> InsertAsync()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                SQLiteParameter[] param = new SQLiteParameter[5];

                param[0] = new SQLiteParameter("@Index");
                param[0].Value = Index;

                param[1] = new SQLiteParameter("@Pin");
                param[1].Value = Pin;

                param[2] = new SQLiteParameter("@DateTime");
                param[2].Value = DateTime;

                param[3] = new SQLiteParameter("@State");
                param[3].Value = State(Event);

                param[4] = new SQLiteParameter("@Device");
                param[4].Value = Device;

                string F = statment.Substring(1);
                F =  DAL.ExecuteCommand("Insert OR IGNORE Into `[IO]` (`Index`,`Emp_ID`,`TTime`,`Event`,`Device_ID`) Values " + F + "", param);

                DAL.Close();

                return F;
            }
            public List<Rep> LoadFromTXT(string path)
            {
                Start_Waiting();
                var Rep = new List<Rep>();
                int x = 0;

                foreach (var line in File.ReadAllLines(path))
                {
                    var record = line.Split(',');
                    if (x == 0) { x++; continue; }

                    Index = record[1].Trim() + record[3].Trim() + State(record[4].Trim());
                    Pin = record[1].Trim();
                    DateTime = Convert.ToDateTime(record[3]).ToString("yyyy-MM-dd HH:mm:ss");
                    Date = Convert.ToDateTime(record[3]).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                    Time = Convert.ToDateTime(record[3]).ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);
                    Event = record[4].Trim();
                    Device = record[8].Trim();
                    st();
                }
                Insert();
                return Rep;
            }
            public List<Rep> LoadFromDAT(string path)
            {
                Start_Waiting();
                var Rep = new List<Rep>();

                foreach (var line in File.ReadAllLines(path))
                {
                    var record = line.Split();

                    Index = record[0] + record[1] + record[2] + record[5];
                    Pin = record[0].Trim();
                    DateTime = Convert.ToDateTime(record[1] +" "+ record[2]).ToString("yyyy-MM-dd HH:mm:ss");
                    Event = record[5];
                    Device = "No Device Code";
                    st();
                }
                Insert();
                return Rep;
            }
            public List<Rep> LoadFromDAT2(string path)
            {
                Start_Waiting();
                var Rep = new List<Rep>();

                foreach (var line in File.ReadAllLines(path))
                {
                    var record = line.Split('\t');

                    Pin = addzeroEmpID(record[0].Trim());
                    DateTime = record[1].Trim();
                    Event = record[3].Trim();
                    Index = Pin + DateTime + Event;
                    Device = "No Device Code";
                    st();
                }
                Insert();
                return Rep;
            }
            public async Task PullFromFile(string path)
            {
                foreach (var line in File.ReadAllLines(path))
                {
                    var record = line.Split('\t');

                    Pin = addzeroEmpID(record[0].Trim());
                    DateTime = record[1].Trim();
                    Event = record[3].Trim();
                    Index = Pin + DateTime + Event;
                    Device = "No Device Code";
                    st();
                }
                await InsertAsync();
            }
            public ICollection<MachineInfo> LoadFromDevice(ICollection<MachineInfo> lstEnrollData)
            {
                Start_Waiting();

                foreach (var item in lstEnrollData)
                {
                    Pin = addzeroEmpID(item.IndRegID.ToString());
                    DateTime = Convert.ToDateTime(item.DateTimeRecord).ToString("yyyy-MM-dd HH-mm-ss");
                    Event = "0";
                    Index = Pin + DateTime + Event;
                    Device = "No Device Code";
                    st();
                }
 
                Insert();
                return lstEnrollData;
            }

            public string Update(string Index, string DateTime, int Event, string Device_ID)
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                SQLiteParameter[] param = new SQLiteParameter[4];

                param[0] = new SQLiteParameter("@Index");
                param[0].Value = Index;

                param[1] = new SQLiteParameter("@DateTime");
                param[1].Value = DateTime;

                param[2] = new SQLiteParameter("@Event");
                param[2].Value = Event;

                param[3] = new SQLiteParameter("@Device_ID");
                param[3].Value = Device_ID;

                string F = DAL.ExecuteCommand("Update `[IO]` Set `TTime` = @DateTime ,`Event` = @Event , `Device_ID` = @Device_ID Where `Index` = @Index", param);

                DAL.Close();
                return F;
            }

            public DataTable SelectIO(string Emp_ID,string WS, DateTime From, DateTime To)
            {
                DataTable dt_IO = new DataTable();

                #region Prepairing
                cls_DAL DAL = new cls_DAL();
                DataTable IO = new DataTable();
                IO = DAL.SelectData("Select `Index`,ttime, event, Device_ID , Priority , Deleted from `[io]`"
                    + " where emp_id = '" + Emp_ID + "' and (TTime >= '" + From.ToString("yyyy-MM-dd HH:mm:ss") + "' AND TTime <= '" + To.ToString("yyyy-MM-dd HH:mm:ss") + "')"
                    + " order by `TTime`"
                    , null);
                DataTable dt_WS = new DataTable(); // نظام الدوام
                dt_WS = DAL.SelectData("SELECT  * from   Emp, `[WorkSys]` where emp.id2 = '" + Emp_ID + "' and `[Worksys]`.ID = " + WS, null);
                bool ti = Convert.ToBoolean(dt_WS.Rows[0]["ti"]); // تحديد هل يحدد نوع الحركة الحركة بحسب الوقت
                #endregion

                foreach (DataColumn c in IO.Columns)
                {
                    dt_IO.Columns.Add(c.ColumnName);
                }
                dt_IO.Columns.Add("تعديل");

                string CurrentDate = "";

                //DateTime dt;
                //DateTime.TryParseExact(IO.Rows[0]["TTime"]).ToString("yyyy-MM-dd"),
                //                       "yyyy-dd-MM hh:mm tt",
                //                       CultureInfo.InvariantCulture,
                //                       DateTimeStyles.None,
                //                       out dt);

                //DateTime dt12 = DateTime.ParseExact("44", "dd/MM/yyyy", null);

                string LastDate = (IO.Rows.Count>0)?ToDateTime(IO.Rows[0]["TTime"]).ToString("yyyy-MM-dd"):"";
          
                foreach (DataRow r in IO.Rows)
                {
                    CurrentDate = ToDateTime(r["TTime"]).ToString("yyyy-MM-dd");
                    if (CurrentDate != LastDate)
                    {
                        dt_IO.Rows.Add();                      
                        LastDate = ToDateTime(r["TTime"]).ToString("yyyy-MM-dd");
                    }             
                    dt_IO.Rows.Add(r["Index"].ToString(), ToDateTime(r["TTime"]).ToString("yyyy-MM-dd  hh:mm:ss tt"), 0, r["Device_ID"], r["Priority"], r["Deleted"], "تعديل");   
                }
                if(dt_IO.Rows.Count ==0) dt_IO.Rows.Add();
                return dt_IO;
            }
            public DataTable AttLeave2(string emp_id,string WS, DateTime From, DateTime To)
            {
                #region Preparing
                cls_DAL DAL = new cls_DAL();
                cls_BL.Device Device = new cls_BL.Device();
                cls_BL.IO IO = new cls_BL.IO();
                cls_BL.Vac vac = new cls_BL.Vac();
                string sh = "hh:mm tt";
                string sd = "yyyy-MM-dd";
                string l = "yyyy-MM-dd hh:mm tt";

                bool ignore_l1 = false;
                bool ignore_l2 = false;

                Dictionary<string, string> myDict = new Dictionary<string, string>(); // Devices
                myDict.Add("No Device", "No Device");
                foreach (DataRow r in Device.Select().Rows)
                {
                    myDict.Add(r["ID2"].ToString(),r["Name"].ToString());
                }
                string Device_Name;

                DataTable dt_IO = new DataTable(); // الحركات
                dt_IO = DAL.SelectData("Select `Index`,ttime,event,Device_ID ,Priority from `[io]`"
                    + " where Deleted = 0 and emp_id = '" + emp_id + "' and (TTime >= '" + From.ToString("yyyy-MM-dd HH:mm:ss tt") + "' AND TTime <= '" + To.ToString("yyyy-MM-dd HH:mm:ss tt") + "')"
                    + " order by `TTime`"
                    , null);

                DataTable dt_WS = new DataTable(); // نظام الدوام
                dt_WS = DAL.SelectData("SELECT  * from   Emp, `[WorkSys]` where emp.id2 = '" + emp_id + "' and `[Worksys]`.ID = " + WS, null);
                int Day_Hours = Convert.ToInt32(dt_WS.Rows[0]["Day_Hours"]); // لتحديد نهاية البوم
                int Day_Min = Convert.ToInt32(dt_WS.Rows[0]["Day_Min"]); // لتحديد نهاية البوم
                bool ti = Convert.ToBoolean(dt_WS.Rows[0]["ti"]); // تحديد هل يحدد نوع الحركة الحركة بحسب الوقت

                DataTable dt_AnnHoliday = new DataTable(); // الأجازات السنوية
                dt_AnnHoliday = DAL.SelectData("Select Vac.*, VacWS.Bonus From VacWS INNER JOIN Vac ON VacWS.VacID = Vac.ID where WSID = " + WS,null);

                #region dt_att
                DataTable dt_att = new DataTable(); // الحضور والإنصراف
                dt_att.Columns.Add("التاريخ", typeof(string));
                dt_att.Columns.Add("اليوم", typeof(string));

                dt_att.Columns.Add("حضور دوام 1", typeof(string));
                dt_att.Columns.Add("حضور مبكر1", typeof(string));
                dt_att.Columns.Add("تأخير1", typeof(string));
                dt_att.Columns.Add("إنصراف دوام 1", typeof(string));
                dt_att.Columns.Add("إنصراف مبكر1", typeof(string));
                dt_att.Columns.Add("إضافي1", typeof(string));
                dt_att.Columns.Add("الفترة الأولى", typeof(string));

                dt_att.Columns.Add("حضور دوام 2", typeof(string));
                dt_att.Columns.Add("حضور مبكر2", typeof(string));
                dt_att.Columns.Add("تأخير2", typeof(string));
                dt_att.Columns.Add("إنصراف دوام 2", typeof(string));
                dt_att.Columns.Add("إنصراف مبكر2", typeof(string));
                dt_att.Columns.Add("إضافي2", typeof(string));
                dt_att.Columns.Add("الفترة الثانية", typeof(string));

                dt_att.Columns.Add("حضور مبكر", typeof(string));
                dt_att.Columns.Add("تأخير", typeof(string));
                dt_att.Columns.Add("إنصراف مبكر", typeof(string));
                dt_att.Columns.Add("إضافي", typeof(string));

                dt_att.Columns.Add("الدوام", typeof(string));
                dt_att.Columns.Add("إجمالي المستقطع", typeof(string));
                dt_att.Columns.Add("إجمالي المضاف", typeof(string));

                dt_att.Columns.Add("عدد الساعات", typeof(string));
                dt_att.Columns.Add("أجازة ؟", typeof(string));
                dt_att.Columns.Add("غائب ؟", typeof(string));
                dt_att.Columns.Add("جهاز الحضور", typeof(string));
                dt_att.Columns.Add("جهاز الإنصراف", typeof(string));
                dt_att.Columns.Add("نظام المواعيد", typeof(string));
                dt_att.Columns.Add("نوع الإضافي", typeof(string));
                dt_att.Columns.Add("حركات معدلة", typeof(string));
                #endregion

                int days_count = Convert.ToInt32((To - From).TotalDays);
                if (days_count == 0) days_count = 1;
                #endregion

                #region IO
                for (int i = 0; i < days_count; i++) // IO Loop
                {
                    dt_att.Rows.Add(From.AddDays(i).ToString("yyyy-MM-dd"), Day(From.AddDays(i).ToString("dddd"))); // Add Date & Day
                    string day = Convert.ToDateTime(dt_att.Rows[dt_att.Rows.Count-1]["التاريخ"]).ToString("dddd");
                    string y = dt_att.Rows[i][0].ToString(); // تاريخ الصف
                    DateTime ds = Convert.ToDateTime(y); // بداية تاريخ الصف
                    DateTime de = Convert.ToDateTime(y).AddHours(Day_Hours);
                    de = de.AddMinutes(Day_Min); //  نهاية تاريخ الصف



                    for (int p = 0; p < dt_IO.Rows.Count; p++) // IO Loop2
                    {
                        #region Preparing
                        string io_day = ToDateTime(dt_IO.Rows[p]["TTime"]).ToString("dddd"); // يوم الحركة



                        string x = ToDateTime(dt_IO.Rows[p]["TTime"]).ToString("yyyy-MM-dd"); // تاريخ الحركة
                        DateTime m = ToDateTime(dt_IO.Rows[p]["TTime"]); // تاريخ ووقت الحركة
                        int m_action = m.Hour;
                        m_action = (ToDateTime(dt_IO.Rows[p]["TTime"]).ToString(sd) == y) ? m_action : m_action + 24;

                        int fs = Convert.ToDateTime(WS_start(io_day, dt_WS)).Hour;
                        int fe = Convert.ToDateTime(WS_end(io_day, dt_WS)).Hour;
                        int ss = Convert.ToDateTime(WS_start2(io_day, dt_WS)).Hour;
                        int se = Convert.ToDateTime(WS_end2(io_day, dt_WS)).Hour;

                        if (m_action >= 24)
                        {
                            string io_prevday = ToDateTime(dt_IO.Rows[p]["TTime"]).AddDays(-1).ToString("dddd"); // اليوم السابق
                            fs = Convert.ToDateTime(WS_start(io_prevday, dt_WS)).Hour;
                            fe = Convert.ToDateTime(WS_end(io_prevday, dt_WS)).Hour;
                            ss = Convert.ToDateTime(WS_start2(io_prevday, dt_WS)).Hour;
                            se = Convert.ToDateTime(WS_end2(io_prevday, dt_WS)).Hour;
                        }

                        int First_as = fs - Convert.ToInt32(dt_WS.Rows[0]["First_as"]);
                        int First_ae = fs + Convert.ToInt32(dt_WS.Rows[0]["First_ae"]);
                        int First_ls = fe - Convert.ToInt32(dt_WS.Rows[0]["First_ls"]);
                        int First_le = fe + Convert.ToInt32(dt_WS.Rows[0]["First_le"]);
                        int Second_as = ss - Convert.ToInt32(dt_WS.Rows[0]["Second_as"]);
                        int Second_ae = ss + Convert.ToInt32(dt_WS.Rows[0]["Second_ae"]);
                        int Second_ls = se - Convert.ToInt32(dt_WS.Rows[0]["Second_ls"]);
                        int Second_le = se + Convert.ToInt32(dt_WS.Rows[0]["Second_le"]);
                        #endregion

                            if (ti == true && Fixed(day, dt_WS) == false) // يحدد نوع الحركة بحسب الوقت ونظام ثابت
                            {
  
                            if (m_action >= First_as && m_action <= First_ae && x == y) // حضور دوام 1
                            {
                                dt_IO.Rows[p]["event"] = 0;
                            }
                            else if (m_action >= First_ls && m_action <= First_le && m >= ds && m <= de && t(dt_att.Rows[i], 1, m) > TimeSpan.Parse("0.00:00:00")) // إنصراف دوام 1
                            {
                                dt_IO.Rows[p]["event"] = 1;
                            }
                            else if (m_action >= Second_as && m_action <= Second_ae && x == y) // حضور دوام 2
                            {
                                dt_IO.Rows[p]["event"] = 0;
                            }
                            else if (m_action >= Second_ls && m_action <= Second_le && m >= ds && m <= de && t(dt_att.Rows[i], 2, m) > TimeSpan.Parse("0.00:00:00")) // إنصراف دوام 2
                            {
                                dt_IO.Rows[p]["event"] = 1;
                            }

                                #region حضور دوام 1
                                if (dt_IO.Rows[p][2].ToString() == "0" && m_action >= First_as && m_action <= First_ae && x == y) // حضور دوام 1
                            {
                                if (dt_att.Rows[i]["حضور دوام 1"].ToString() == "") // إذا كان لا يوجد حضور
                                {
                                    dt_att.Rows[i]["حضور دوام 1"] = ToDateTime(dt_IO.Rows[p]["TTime"]).ToString(sh);

                                    #region حضور مبكر و تأخير       
                                    string start1 = WS_start(io_day, dt_WS);
                                    if (com(start1, m.ToString("HH:mm")) == true) // إذا كان وقت الحضور في نظام الدوام أكبر من وقت حضور الموظف
                                    {
                                        string attearly = sub(start1, m.ToString("HH:mm"));
                                        dt_att.Rows[i]["حضور مبكر1"] = attearly; // يوجد حضور مبكر
                                    }
                                    else // إحتساب التأخير إن وجد
                                    {
                                        TimeSpan start = WS_Start(Convert.ToDateTime(dt_att.Rows[i]["التاريخ"]).ToString("dddd"), dt_WS);
                                        TimeSpan att1 = Convert.ToDateTime(dt_att.Rows[i]["حضور دوام 1"]).TimeOfDay;

                                        TimeSpan Late = (att1 > start) ? (att1 - start) : TimeSpan.Parse("0.00:00:00");

                                        dt_att.Rows[i]["تأخير1"] = string.Format("{0:hh\\:mm}", Late);
                                        if (dt_att.Rows[i]["تأخير1"].ToString() == "00:00") dt_att.Rows[i]["تأخير1"] = "";
                                    }
                                    #endregion

                                    #region جهاز الحضور
                                    myDict.TryGetValue(dt_IO.Rows[p]["Device_ID"].ToString(), out Device_Name);
                                    dt_att.Rows[i]["جهاز الحضور"] = Device_Name;
                                    #endregion

                                    #region حركات معدلة
                                    if (IO.Select_Cout(dt_IO.Rows[p]["Index"].ToString()) > 0)
                                    {
                                        dt_att.Rows[i]["حركات معدلة"] += " حضور دوام 1 ";
                                    }
                                    #endregion
                                }                                

                                dt_IO.Rows.RemoveAt(p); // حذف الحركة
                                p--;
                            }
                            #endregion

                            #region إنصراف دوام 1
                            else if (dt_IO.Rows[p][2].ToString() == "1" && m_action >= First_ls && m_action <= First_le && m >= ds && m <= de && t(dt_att.Rows[i], 1, m) > TimeSpan.Parse("0.00:00:00")) // إنصراف دوام 1
                            {
                                //if (dt_att.Rows[i]["حضور دوام 1"].ToString() == "") continue;
                                if (dt_att.Rows[i]["إنصراف دوام 1"].ToString() != "" && ignore_l1 == true) continue;

                                string s = (ToDateTime(dt_IO.Rows[p]["TTime"]).ToString(sd) == y) ? sh : l;
                                dt_att.Rows[i]["إنصراف دوام 1"] = ToDateTime(dt_IO.Rows[p]["TTime"]).ToString(s);

                                ignore_l1 = Convert.ToBoolean(dt_IO.Rows[p]["Priority"]);

                                #region  إنصراف مبكر و إضافي   
                                string end1 = WS_end(io_day, dt_WS);
                                if (m.ToString("yyyy-MM-dd") == y && com(end1, m.ToString("HH:mm")) == true) // إنصراف مبكر ؟
                                {
                                    string leavearly = sub(end1, m.ToString("HH:mm"));
                                    dt_att.Rows[i]["إنصراف مبكر1"] = leavearly;
                                }
                                else // إحتساب الإضافي إن وجد
                                {
                                    TimeSpan end = WS_End(Convert.ToDateTime(dt_att.Rows[i]["التاريخ"]).ToString("dddd"), dt_WS);
                                    TimeSpan leave = Convert.ToDateTime(dt_att.Rows[i]["إنصراف دوام 1"]).TimeOfDay;
                                    if (m.ToString("yyyy-MM-dd") != y) leave += TimeSpan.Parse("1.00:00:00"); // إذا كان الانصراف في اليوم التالي

                                    TimeSpan result = (leave > end) ? (leave - end) : TimeSpan.Parse("0.00:00:00");
                                    string sresult = string.Format("{0:hh\\:mm}", result);

                                    dt_att.Rows[i]["إضافي1"] = sresult;
                                    if (dt_att.Rows[i]["إضافي1"].ToString() == "00:00") dt_att.Rows[i]["إضافي1"] = "";
                                }
                                #endregion

                                #region جهاز الإنصراف
                                myDict.TryGetValue(dt_IO.Rows[p]["Device_ID"].ToString(), out Device_Name);
                                dt_att.Rows[i]["جهاز الإنصراف"] = Device_Name;
                                #endregion

                                #region حركات معدلة
                                if (IO.Select_Cout(dt_IO.Rows[p]["Index"].ToString()) > 0)
                                {
                                    dt_att.Rows[i]["حركات معدلة"] += " إنصراف دوام 1 ";
                                }
                                #endregion

                                dt_IO.Rows.RemoveAt(p);
                                p--;
                            }
                            #endregion

                            #region حضور دوام 2
                            else if (dt_IO.Rows[p][2].ToString() == "0" && m_action >= Second_as && m_action <= Second_ae && x == y) // حضور دوام 2
                            {
                                string s = (ToDateTime(dt_IO.Rows[p]["TTime"]).ToString(sd) == y) ? sh : l;
                                if (dt_att.Rows[i]["حضور دوام 2"].ToString() == "") // إذا كان لا يوجد حضور
                                {
                                    dt_att.Rows[i]["حضور دوام 2"] = ToDateTime(dt_IO.Rows[p]["TTime"]).ToString(s);

                                    #region حضور مبكر و تأخير
                                    string start2 = WS_start2(io_day, dt_WS);
                                    if (com(start2, m.ToString("HH:mm")) == true) // إذا كان يوجد حضور مبكر
                                    {
                                        string attearly = sub(start2, m.ToString("HH:mm"));

                                        dt_att.Rows[i]["حضور مبكر2"] = attearly;
                                    }
                                    else // إذا كان لا يوجد حضور مبكر
                                    {
                                        //if (dt_WS.Rows[0]["LateCheck"].ToString() == "True") // إذا كان يحتسب التأخير
                                        //{
                                            TimeSpan start = WS_Start2(Convert.ToDateTime(dt_att.Rows[i]["التاريخ"]).ToString("dddd"), dt_WS);
                                            TimeSpan att = Convert.ToDateTime(dt_att.Rows[i]["حضور دوام 2"]).TimeOfDay;

                                            TimeSpan Late = (att > start) ? (att - start) : TimeSpan.Parse("0.00:00:00");


                                            dt_att.Rows[i]["تأخير2"] = string.Format("{0:hh\\:mm}", Late);
                                            if (dt_att.Rows[i]["تأخير2"].ToString() == "00:00") dt_att.Rows[i]["تأخير2"] = "";
                                        //}
                                    }
                                    #endregion

                                    #region حركات معدلة
                                    if (IO.Select_Cout(dt_IO.Rows[p]["Index"].ToString()) > 0)
                                    {
                                        dt_att.Rows[i]["حركات معدلة"] += " حضور دوام 2 ";
                                    }
                                    #endregion
                                }

                                dt_IO.Rows.RemoveAt(p);
                                p--;
                            }
                            #endregion

                            #region إنصراف دوام 2
                            else if (dt_IO.Rows[p][2].ToString() == "1" && m_action >= Second_ls && m_action <= Second_le && m >= ds && m <= de && t(dt_att.Rows[i], 2, m) > TimeSpan.Parse("0.00:00:00")) // إنصراف دوام 2
                            {
                                if (dt_att.Rows[i]["حضور دوام 2"].ToString() == "") continue;
                                if (dt_att.Rows[i]["إنصراف دوام 2"].ToString() != "" && ignore_l2 == true) continue;

                                string s = (ToDateTime(dt_IO.Rows[p]["TTime"]).ToString(sd) == y) ? sh : l;
                                dt_att.Rows[i]["إنصراف دوام 2"] = ToDateTime(dt_IO.Rows[p]["TTime"]).ToString(s);

                                ignore_l2 = Convert.ToBoolean(dt_IO.Rows[p]["Priority"]);

                                #region إنصراف مبكر و إضافي
                                string end2 = WS_end2(io_day, dt_WS);
                                if (m.ToString("yyyy-MM-dd") == y && com(end2, m.ToString("HH:mm")) == true) // إنصراف مبكر
                                {
                                    string leavearly = sum(dt_att.Rows[i]["إنصراف مبكر"].ToString(), sub(end2, m.ToString("HH:mm")));
                                    dt_att.Rows[i]["إنصراف مبكر2"] = leavearly;
                                }
                                else // إذا لا يوجد إنصراف مبكر
                                {
                                    if (dt_WS.Rows[0]["BonusCheck"].ToString() == "True") // إضافي
                                    {
                                        TimeSpan end = WS_End2(Convert.ToDateTime(dt_att.Rows[i]["التاريخ"]).ToString("dddd"), dt_WS);
                                        TimeSpan leave = Convert.ToDateTime(dt_att.Rows[i]["إنصراف دوام 2"]).TimeOfDay;
                                        if (m.ToString("yyyy-MM-dd") != y) leave += TimeSpan.Parse("1.00:00:00"); // إذا كان الانصراف في اليوم التالي

                                        TimeSpan result = (leave > end) ? (leave - end) : TimeSpan.Parse("0.00:00:00");
                                        string sresult = string.Format("{0:hh\\:mm}", result);

                                        dt_att.Rows[i]["إضافي2"] = sresult;
                                        if (dt_att.Rows[i]["إضافي2"].ToString() == "00:00") dt_att.Rows[i]["إضافي2"] = "";
                                    }
                                }
                                #endregion

                                #region حركات معدلة
                                if (IO.Select_Cout(dt_IO.Rows[p]["Index"].ToString()) > 0)
                                {
                                    dt_att.Rows[i]["حركات معدلة"] += " إنصراف دوام 2";
                                }
                                #endregion

                                dt_IO.Rows.RemoveAt(p);
                                p--;
                            }
                            #endregion
                        }
                        else  // لا يحدد نوع الحركة بحسب الوقت أو نظام غير ثابت
                        {
                            #region حضور دوام 1
                            if (dt_IO.Rows[p][2].ToString() == "0" && x == y) // حضور دوام 1
                            {
                                if (dt_att.Rows[i]["حضور دوام 1"].ToString() == "") // إذا كان لا يوجد حضور
                                {
                                    dt_att.Rows[i]["حضور دوام 1"] = ToDateTime(dt_IO.Rows[p]["TTime"]).ToString(sh);

                                    #region حضور مبكر و تأخير
                                    if (Fixed(io_day, dt_WS) == false) // إذا كان نظام ثابت
                                    {
                                        string start1 = WS_start(io_day, dt_WS);
                                        if (com(start1, m.ToString("HH:mm")) == true)
                                        {
                                            string attearly = sub(start1, m.ToString("HH:mm"));
                                            dt_att.Rows[i]["حضور مبكر"] = attearly; // يوجد حضور مبكر
                                        }
                                        else // إحتساب التأخير إن وجد
                                        {
                                            TimeSpan start = WS_Start(Convert.ToDateTime(dt_att.Rows[i]["التاريخ"]).ToString("dddd"), dt_WS);
                                            TimeSpan att1 = Convert.ToDateTime(dt_att.Rows[i]["حضور دوام 1"]).TimeOfDay;

                                            TimeSpan Late = (att1 > start) ? (att1 - start) : TimeSpan.Parse("0.00:00:00");

                                            dt_att.Rows[i]["تأخير1"] = string.Format("{0:hh\\:mm}", Late);
                                            if (dt_att.Rows[i]["تأخير1"].ToString() == "00:00") dt_att.Rows[i]["تأخير1"] = "";
                                        }
                                    }
                                    #endregion

                                    #region جهاز الحضور
                                    myDict.TryGetValue(dt_IO.Rows[p]["Device_ID"].ToString(), out Device_Name);
                                    dt_att.Rows[i]["جهاز الحضور"] = Device_Name;
                                    #endregion

                                    #region حركات معدلة
                                    if (IO.Select_Cout(dt_IO.Rows[p]["Index"].ToString()) > 0)
                                    {
                                        dt_att.Rows[i]["حركات معدلة"] += " حضور دوام 1 ";
                                    }
                                    #endregion
                                }

                                dt_IO.Rows.RemoveAt(p); // حذف الحركة
                                p--;
                            }
                            #endregion

                            #region إنصراف دوام 1
                            else if (dt_IO.Rows[p][2].ToString() == "1" && m >= ds && m <= de && t(dt_att.Rows[i], 1, m) > TimeSpan.Parse("0.00:00:00")) // إنصراف دوام 1
                            {
                                if (dt_att.Rows[i]["حضور دوام 1"].ToString() == "") continue;
                                if (dt_att.Rows[i]["إنصراف دوام 1"].ToString() != "" && ignore_l1 == true) continue;

                                string s = (ToDateTime(dt_IO.Rows[p]["TTime"]).ToString(sd) == y) ? sh : l;
                                dt_att.Rows[i]["إنصراف دوام 1"] = ToDateTime(dt_IO.Rows[p]["TTime"]).ToString(s);

                                ignore_l1 = Convert.ToBoolean(dt_IO.Rows[p]["Priority"]);

                                #region  إنصراف مبكر و إضافي
                                if (Fixed(io_day, dt_WS) == false) // إذا كان نظام ثابت
                                {
                                    string end1 = WS_end(io_day, dt_WS);
                                    if (m.ToString("yyyy-MM-dd") == y && com(end1, m.ToString("HH:mm")) == true) // إنصراف مبكر ؟
                                    {
                                        string leavearly = sub(end1, m.ToString("HH:mm"));
                                        dt_att.Rows[i]["إنصراف مبكر"] = leavearly;                                      
                                    }
                                    else
                                    {
                                        dt_att.Rows[i]["إنصراف مبكر"] = "";
                                        TimeSpan end = WS_End(Convert.ToDateTime(dt_att.Rows[i]["التاريخ"]).ToString("dddd"), dt_WS);
                                        TimeSpan leave = Convert.ToDateTime(dt_att.Rows[i]["إنصراف دوام 1"]).TimeOfDay;
                                        if (m.ToString("yyyy-MM-dd") != y) leave += TimeSpan.Parse("1.00:00:00"); // إذا كان الانصراف في اليوم التالي

                                        TimeSpan result = (leave > end) ? (leave - end) : TimeSpan.Parse("0.00:00:00");
                                        string sresult = string.Format("{0:hh\\:mm}", result);

                                        dt_att.Rows[i]["إضافي"] = string.Format("{0:hh\\:mm}", sum(dt_att.Rows[i]["إضافي"].ToString(), sresult));
                                        if (dt_att.Rows[i]["إضافي"].ToString() == "00:00") dt_att.Rows[i]["إضافي"] = "";
                                    }
                                }
                                #endregion

                                #region جهاز الإنصراف
                                myDict.TryGetValue(dt_IO.Rows[p]["Device_ID"].ToString(), out Device_Name);
                                dt_att.Rows[i]["جهاز الإنصراف"] = Device_Name;
                                #endregion

                                #region حركات معدلة
                                if (IO.Select_Cout(dt_IO.Rows[p]["Index"].ToString()) > 0)
                                {
                                    dt_att.Rows[i]["حركات معدلة"] += " إنصراف دوام 1 ";
                                }
                                #endregion

                                dt_IO.Rows.RemoveAt(p);
                                p--;
                            }
                            #endregion

                            #region حضور دوام 2
                            else if (dt_IO.Rows[p][2].ToString() == "2" && x == y) // حضور دوام 2
                            {
                                string s = (ToDateTime(dt_IO.Rows[p]["TTime"]).ToString(sd) == y) ? sh : l;
                                dt_att.Rows[i]["حضور دوام 2"] = (dt_att.Rows[i]["حضور دوام 2"].ToString() == "") ? ToDateTime(dt_IO.Rows[p]["TTime"]).ToString(s) : dt_att.Rows[i]["حضور دوام 2"].ToString();

                                #region حضور مبكر و تأخير
                                string start2 = WS_start2(io_day, dt_WS);
                                if (com(start2, m.ToString("HH:mm")) == true)
                                {
                                    string attearly = sub(start2, m.ToString("HH:mm"));
                                    dt_att.Rows[i]["حضور مبكر"] = attearly; // يوجد حضور مبكر

                                    dt_att.Rows[i]["حضور مبكر"] = sum(dt_att.Rows[i]["حضور مبكر"].ToString(), attearly);                             
                                }
                                else
                                {
                                    //if (dt_WS.Rows[0]["LateCheck"].ToString() == "True")
                                    //{
                                    TimeSpan start = WS_Start2(Convert.ToDateTime(dt_att.Rows[i]["التاريخ"]).ToString("dddd"), dt_WS);
                                    TimeSpan att = Convert.ToDateTime(dt_att.Rows[i]["حضور دوام 2"]).TimeOfDay;

                                    TimeSpan Late = (att > start) ? (att - start) : TimeSpan.Parse("0.00:00:00");


                                    dt_att.Rows[i]["تأخير2"] = string.Format("{0:hh\\:mm}", Late);
                                    if (dt_att.Rows[i]["تأخير2"].ToString() == "00:00") dt_att.Rows[i]["تأخير2"] = "";
                                    //}
                                }
                                #endregion

                                #region حركات معدلة
                                if (IO.Select_Cout(dt_IO.Rows[p]["Index"].ToString()) > 0)
                                {
                                    dt_att.Rows[i]["حركات معدلة"] += " حضور دوام 2 ";
                                }
                                #endregion

                                dt_IO.Rows.RemoveAt(p);
                                p--;
                            }
                            #endregion

                            #region إنصراف دوام 2
                            else if (dt_IO.Rows[p][2].ToString() == "3" && m >= ds && m <= de && t(dt_att.Rows[i], 2, m) > TimeSpan.Parse("0.00:00:00")) // إنصراف دوام 2
                            {
                                if (dt_att.Rows[i]["حضور دوام 2"].ToString() == "") continue;
                                if (dt_att.Rows[i]["إنصراف دوام 2"].ToString() != "" && ignore_l2 == true) continue;

                                string s = (ToDateTime(dt_IO.Rows[p]["TTime"]).ToString(sd) == y) ? sh : l;
                                dt_att.Rows[i]["إنصراف دوام 2"] = ToDateTime(dt_IO.Rows[p]["TTime"]).ToString(s);

                                ignore_l2 = Convert.ToBoolean(dt_IO.Rows[p]["Priority"]);

                                #region إنصراف مبكر و إضافي
                                string end2 = WS_end2(io_day, dt_WS);
                                if (m.ToString("yyyy-MM-dd") == y && com(end2, m.ToString("HH:mm")) == true) // إنصراف مبكر
                                {
                                    string leavearly = sum(dt_att.Rows[i]["إنصراف مبكر"].ToString(), sub(end2, m.ToString("HH:mm")));
                                    dt_att.Rows[i]["إنصراف مبكر"] = leavearly;
                                }
                                else
                                {
                                    if (dt_WS.Rows[0]["BonusCheck"].ToString() == "True") // إضافي
                                    {
                                        TimeSpan end = WS_End2(Convert.ToDateTime(dt_att.Rows[i]["التاريخ"]).ToString("dddd"), dt_WS);
                                        TimeSpan leave = Convert.ToDateTime(dt_att.Rows[i]["إنصراف دوام 2"]).TimeOfDay;
                                        if (m.ToString("yyyy-MM-dd") != y) leave += TimeSpan.Parse("1.00:00:00"); // إذا كان الانصراف في اليوم التالي

                                        TimeSpan result = (leave > end) ? (leave - end) : TimeSpan.Parse("0.00:00:00");
                                        string sresult = string.Format("{0:hh\\:mm}", result);

                                        dt_att.Rows[i]["إضافي"] = string.Format("{0:hh\\:mm}", sum(dt_att.Rows[i]["إضافي"].ToString(), sresult));
                                        if (dt_att.Rows[i]["إضافي"].ToString() == "00:00") dt_att.Rows[i]["إضافي"] = "";
                                    }
                                }
                                #endregion

                                #region حركات معدلة
                                if (IO.Select_Cout(dt_IO.Rows[p]["Index"].ToString()) > 0)
                                {
                                    dt_att.Rows[i]["حركات معدلة"] += " إنصراف دوام 2";
                                }
                                #endregion

                                dt_IO.Rows.RemoveAt(p);
                                p--;
                            }
                            #endregion
                        }
                    }
                }
                #endregion
           
                foreach (DataRow r in dt_att.Rows)
                {
                    #region RowTotals

                    #region Per
                    if (r["حضور دوام 1"].ToString() != "" && r["حضور دوام 1"].ToString() != "H" && r["إنصراف دوام 1"].ToString() != "") // الفترة الأولى
                    {
                        r["الفترة الأولى"] = string.Format("{0:hh\\:mm}", Per(r, 1));
                    }
                    if (r["حضور دوام 2"].ToString() != "" && r["إنصراف دوام 2"].ToString() != "") // الفترة الثانية
                    {
                        r["الفترة الثانية"] = string.Format("{0:hh\\:mm}", Per(r, 2));
                    }

                    r["حضور مبكر"] = sum(r["حضور مبكر1"].ToString(), r["حضور مبكر2"].ToString());
                    if (r["حضور مبكر"].ToString() == "00:00") r["حضور مبكر"] = "";
                    r["إنصراف مبكر"] = sum(r["إنصراف مبكر1"].ToString(), r["إنصراف مبكر2"].ToString());
                    if (r["إنصراف مبكر"].ToString() == "00:00") r["إنصراف مبكر"] = "";         
                    r["تأخير"] = sum(r["تأخير1"].ToString(), r["تأخير2"].ToString());
                    if (r["تأخير"].ToString() == "00:00") r["تأخير"] = "";
                    r["إضافي"] = sum(r["إضافي1"].ToString(), r["إضافي2"].ToString());
                    if (r["إضافي"].ToString() == "00:00") r["إضافي"] = "";                  

                    string day = Convert.ToDateTime(r["التاريخ"]).ToString("dddd");
                    #endregion

                    #region Fixed
                    if (Fixed(day,dt_WS) == false) // Fixed?
                    {
                        r["نظام المواعيد"] = "ثابتة"; // نظام المواعيد
                        r["الدوام"] = Per_Hours(day, dt_WS); // الدوام

                        #region إجمالي المستقطع
                        if (dt_WS.Rows[0]["LateCheck"].ToString() == "True" && dt_WS.Rows[0]["LeaveEarly"].ToString() == "False") //  تأخير فقط
                        {
                            r["إجمالي المستقطع"] = r["تأخير"].ToString();
                        }
                        else if (dt_WS.Rows[0]["LateCheck"].ToString() == "False" && dt_WS.Rows[0]["LeaveEarly"].ToString() == "True") //  إنصراف مبكر فقط
                        {
                            r["إجمالي المستقطع"] = r["إنصراف مبكر"].ToString();
                        }
                        else if (dt_WS.Rows[0]["LateCheck"].ToString() == "True" && dt_WS.Rows[0]["LeaveEarly"].ToString() == "True") //   تأخير وإنصراف مبكر
                        {
                            r["إجمالي المستقطع"] = sum(r["تأخير"].ToString(), r["إنصراف مبكر"].ToString());
                        }
                        else // لا تأخير ولا إنصراف مبكر
                        {
                            r["إجمالي المستقطع"] = "";
                        }
                        if (r["إجمالي المستقطع"].ToString() == "00:00") r["إجمالي المستقطع"] = "";
                        #endregion

                        #region إجمالي المضاف
                        if (dt_WS.Rows[0]["AttEarly"].ToString() == "True" && dt_WS.Rows[0]["BonusCheck"].ToString() == "False") //  حضور مبكر فقط
                        {
                            r["إجمالي المضاف"] = r["حضور مبكر"].ToString();
                        }
                        else if (dt_WS.Rows[0]["AttEarly"].ToString() == "False" && dt_WS.Rows[0]["BonusCheck"].ToString() == "True") //  إضافي فقط
                        {
                            r["إجمالي المضاف"] = r["إضافي"].ToString();
                        }
                        else if (dt_WS.Rows[0]["AttEarly"].ToString() == "True" && dt_WS.Rows[0]["BonusCheck"].ToString() == "True") //   حضور مبكر وإضافي
                        {
                            r["إجمالي المضاف"] = sum(r["إضافي"].ToString(), r["حضور مبكر"].ToString());
                        }
                        else // لا حضور مبكر ولا إضافي
                        {
                            r["إجمالي المضاف"] = "";
                        }
                        if (r["إجمالي المضاف"].ToString() == "00:00") r["إجمالي المضاف"] = "";
                        #endregion

                        r["عدد الساعات"] = sub(sum(r["الدوام"].ToString(), r["إجمالي المضاف"].ToString()), r["إجمالي المستقطع"].ToString()); // عدد الساعات


                        if (r["حضور دوام 1"].ToString() != "H" & r["حضور دوام 1"].ToString() != "" || r["الفترة الثانية"].ToString() != "") // إضافي
                        {
                            if (Bonus(day, dt_WS) == true) // Full Bonus ?
                            {
                                r["نوع الإضافي"] = "كل اليوم";
                                r["إضافي"] = r["عدد الساعات"];
                            }
                            else // Normal Bonus
                            {
                                r["نوع الإضافي"] = "عادي";
                            }
                        }
                    }
                    #endregion

                    #region Non Fixed
                    if (Fixed(day, dt_WS) == true) // Non Fixed?
                    {
                        r["نظام المواعيد"] = "غير ثابتة";

                        r["الدوام"] = Per_Hours(day, dt_WS); // الدوام

                        if (r["حضور دوام 1"].ToString() != "H" & r["حضور دوام 1"].ToString() != "" || r["الفترة الثانية"].ToString() != "") // عدد الساعات
                        {
                            string f = (r["الفترة الأولى"].ToString() != "") ? r["الفترة الأولى"].ToString() : "00:00";
                            string s = (r["الفترة الثانية"].ToString() != "") ? r["الفترة الثانية"].ToString() : "00:00";
                            r["عدد الساعات"] = sum(f, s);
                        }

                        #region التأخير
                        if (r["عدد الساعات"].ToString() != "" || r["الدوام"].ToString() != "") // تأخير
                        {
                            if (com(r["الدوام"].ToString(), r["عدد الساعات"].ToString()) == true)
                            {
                                r["تأخير"] = sub(r["الدوام"].ToString(), r["عدد الساعات"].ToString());
                            }
                        }
                        #endregion

                        if (Bonus(day, dt_WS) == true ) // Full Bonus ?
                        {
                            r["نوع الإضافي"] = "كل اليوم";
                            r["إضافي"] = r["عدد الساعات"];
                        }
                        else
                        {
                            if (r["الفترة الأولى"].ToString() != "" || r["الفترة الثانية"].ToString() != "") // Normal Bonus
                            {
                                r["نوع الإضافي"] = "عادي";
                                r["إضافي"] = (com(r["عدد الساعات"].ToString(), r["الدوام"].ToString())) ? sub(r["عدد الساعات"].ToString(), r["الدوام"].ToString()) : "";
                            }
                        }
                    }

                    #endregion

                    #region Holiday
                    if (dt_AnnHoliday.Rows.Count > 0) // إذا كان لهذا النظام أجازات سنوية
                    {
                        DataTable dt = AnnHoliday(r["التاريخ"].ToString(), dt_AnnHoliday);
                        if (dt.Rows.Count > 0)
                        {
                            if(dt.Rows[0]["Bonus"].ToString() == "False") // إذا لا يحتسب إضافي
                            {
                                r["حضور دوام 1"] = "";
                                r["حضور مبكر1"] = "";
                                r["تأخير1"] = "";

                                r["إنصراف دوام 1"] = "";
                                r["إنصراف مبكر1"] = "";
                                r["إضافي1"] = "";

                                r["الفترة الأولى"] = "";

                                r["حضور دوام 2"] = "";
                                r["حضور مبكر2"] = "";
                                r["تأخير2"] = "";

                                r["إنصراف دوام 2"] = "";
                                r["إنصراف مبكر2"] = "";
                                r["تأخير2"] = "";

                                r["الفترة الثانية"] = "";

                                r["حضور مبكر"] = "";
                                r["إنصراف مبكر"] = "";

                                r["تأخير"] = "";
                                r["إضافي"] = "";

                                r["الدوام"] = "";

                                r["إجمالي المستقطع"] = "";
                                r["إجمالي المضاف"] = "";

                                r["عدد الساعات"] = "";
                                r["نظام المواعيد"] = "";
                                r["نوع الإضافي"] = "";
                                r["أجازة ؟"] = dt.Rows[0]["Name"].ToString();
                                r["عدد الساعات"] = "";
                                r["جهاز الحضور"] = "";
                                r["جهاز الإنصراف"] = "";
                                r["غائب ؟"] = "";
                                r["حركات معدلة"] = "";
                            }
                            else // يحتسب إضافي
                            {
                                r["أجازة ؟"] = dt.Rows[0]["Name"].ToString();
                            }
                        }
                    }

                    if (Holiday(day,dt_WS) == true) // أجازة اسبوعية 
                    {
                        if (Bonus(day, dt_WS) == false) // ليس إضافي
                        {
                            r["حضور دوام 1"] = "";
                            r["حضور مبكر1"] = "";
                            r["تأخير1"] = "";

                            r["إنصراف دوام 1"] = "";
                            r["إنصراف مبكر1"] = "";
                            r["إضافي1"] = "";

                            r["الفترة الأولى"] = "";

                            r["حضور دوام 2"] = "";
                            r["حضور مبكر2"] = "";
                            r["تأخير2"] = "";

                            r["إنصراف دوام 2"] = "";
                            r["إنصراف مبكر2"] = "";
                            r["تأخير2"] = "";

                            r["الفترة الثانية"] = "";

                            r["حضور مبكر"] = "";
                            r["إنصراف مبكر"] = "";

                            r["تأخير"] = "";
                            r["إضافي"] = "";

                            r["الدوام"] = "";

                            r["إجمالي المستقطع"] = "";
                            r["إجمالي المضاف"] = "";

                            r["عدد الساعات"] = "";
                            r["نظام المواعيد"] = "";
                            r["نوع الإضافي"] = "";
                            r["أجازة ؟"] = "أجازة";
                            r["عدد الساعات"] = "";
                            r["جهاز الحضور"] = "";
                            r["جهاز الإنصراف"] = "";
                            r["غائب ؟"] = "";
                            r["حركات معدلة"] = "";
                        }
                        else // إضافي
                        {
                            r["أجازة ؟"] = "أجازة";
                        }
                    }
                    #endregion

                    #region Abset
                    if (r["أجازة ؟"].ToString() == "" && r["حضور دوام 1"].ToString() == "" && r["إنصراف دوام 1"].ToString() == "" && r["حضور دوام 2"].ToString() == "" && r["إنصراف دوام 2"].ToString() == "") // غائب
                    {
                        r["غائب ؟"] = "غائب";
                    }
                    #endregion

                    #endregion
                }


                #region ColumnsTotals
                string AttEarly1 = "00:00";
                string Late1 = "00:00";
                string LeaveEarly1 = "00:00";
                string Bonus1 = "00:00";
                string Per1 = "00:00";
                string AttEarly2 = "00:00";
                string Late2 = "00:00";
                string LeaveEarly2 = "00:00";
                string Bonus2 = "00:00";
                string Per2 = "00:00";
                string come_early = "00:00";
                string leave_early = "00:00";
                string total_late = "00:00";
                string total_over = "00:00";
                string total_per = "00:00";
                string TotalSub = "00:00";
                string TotalSum = "00:00";
                string total_hours = "00:00";
                int holiday = 0;
                int absent = 0;
                int edited = 0;
                foreach (DataRow r in dt_att.Rows)
                {
                    AttEarly1 = sum(AttEarly1, r["حضور مبكر1"].ToString());
                    Late1 = sum(Late1, r["تأخير1"].ToString());
                    LeaveEarly1 = sum(LeaveEarly1, r["إنصراف مبكر1"].ToString());
                    Bonus1 = sum(Bonus1, r["إضافي1"].ToString());
                    Per1 = sum(Per1, r["الفترة الأولى"].ToString());
                    AttEarly2 = sum(AttEarly2, r["حضور مبكر2"].ToString());
                    Late2 = sum(Late2, r["تأخير2"].ToString());
                    LeaveEarly2 = sum(LeaveEarly2, r["إنصراف مبكر2"].ToString());
                    Bonus2 = sum(Bonus2, r["إضافي2"].ToString());
                    Per2 = sum(Per2, r["الفترة الثانية"].ToString());
                    come_early = sum(come_early, r["حضور مبكر"].ToString());
                    leave_early = sum(leave_early, r["إنصراف مبكر"].ToString());
                    total_late = sum(total_late,r["تأخير"].ToString());
                    total_over = sum(total_over,r["إضافي"].ToString());
                    total_per = sum(total_per,r["الدوام"].ToString());
                    TotalSub = sum(TotalSub, r["إجمالي المستقطع"].ToString());
                    TotalSum = sum(TotalSum, r["إجمالي المضاف"].ToString());
                    total_hours = sum(total_hours,r["عدد الساعات"].ToString());
                    if (r["أجازة ؟"].ToString() == "أجازة") holiday++;
                    if (r["غائب ؟"].ToString() == "غائب") absent++;
                    if (r["حركات معدلة"].ToString().Length > 0 && r["حركات معدلة"].ToString().Length <= 13)
                    {
                        edited++;
                    }
                    else if(r["حركات معدلة"].ToString().Length > 13 && r["حركات معدلة"].ToString().Length <= 26)
                    {
                        edited = edited + 2;
                    }
                    else if (r["حركات معدلة"].ToString().Length > 26 && r["حركات معدلة"].ToString().Length <= 39)
                    {
                        edited = edited + 3;
                    }
                    else if (r["حركات معدلة"].ToString().Length > 39 && r["حركات معدلة"].ToString().Length <= 52)
                    {
                        edited = edited + 4;
                    }
                }
                dt_att.Rows.Add(
                    "إجمالي", // التاريخ
                    null, // اليوم
                    null, // حضور دوام1
                    AttEarly1, // حضور مبكر1
                    Late1, // تأخير1
                    null, // إنصراف دوام1
                    LeaveEarly1, // إنصراف مبكر1
                    Bonus1, // إضافي1
                    Per1, // الفترة الأول
                    null, // حضور دوام2
                    AttEarly2, // حضور مبكر2
                    Late2, // تأخير2
                    null, // إنصراف دوام2
                    LeaveEarly2, // إنصراف مبكر2
                    Bonus2, // إضافي2
                    Per2, // الفترة الثانية
                    come_early, // حضور مبكر
                    total_late, // تأخير
                    leave_early, // إنصراف مبكر
                    total_over, // إضافي
                    total_per, // الدوام
                    TotalSub, // إجمالي المستقطع
                    TotalSum, // إجمالي المضاف
                    total_hours, // عددالساعات
                    holiday.ToString(),
                    absent.ToString(),
                    null, 
                    null,
                    null,
                    null,
                    edited.ToString()
                    );

                #endregion

                return dt_att;
            }
        }

        public struct GSet
        {
            #region Var
            public int User_ID;
            public bool Date;
            public bool Day;
            public bool Att1;
            public int AttEarly1;
            public int Late1;
            public bool Leave1;
            public int LeaveEarly1;
            public int Bonus1;
            public bool Period1;
            public bool Att2;
            public int AttEarly2;
            public int Late2;
            public bool Leave2;
            public int LeaveEarly2;
            public int Bonus2;
            public bool Period2;
            public bool Come_Early;
            public bool Late;
            public bool Leave_Early;
            public bool Bonus;
            public bool Period;
            public int TotalSum;
            public int TotalSub;            
            public bool TotalHours;
            public bool TimeType;
            public bool BonusType;
            public bool Holiday;
            public bool Device1;
            public bool Device2;
            public bool Absent;
            public bool Edited;
            #endregion

            public DataTable Select()
            {
                cls_DAL DAL = new cls_DAL();
                DataTable dt = new DataTable();
                dt = DAL.SelectData("select * from `[GSet]` Where User_ID = " + User_ID, null);

                return dt;
            }
            public string Update()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                SQLiteParameter[] param = new SQLiteParameter[22];

                param[0] = new SQLiteParameter("@User_ID");
                param[0].Value = User_ID;

                param[1] = new SQLiteParameter("@Date");
                param[1].Value = Date;

                param[2] = new SQLiteParameter("@Day");
                param[2].Value = Day;

                param[3] = new SQLiteParameter("@Att1");
                param[3].Value = Att1;

                param[4] = new SQLiteParameter("@Leave1");
                param[4].Value = Leave1;

                param[5] = new SQLiteParameter("@Period1");
                param[5].Value = Period1;

                param[6] = new SQLiteParameter("@Att2");
                param[6].Value = Att2;

                param[7] = new SQLiteParameter("@Leave2");
                param[7].Value = Leave2;

                param[8] = new SQLiteParameter("@Period2");
                param[8].Value = Period2;

                param[9] = new SQLiteParameter("@Late");
                param[9].Value = Late;

                param[10] = new SQLiteParameter("@Bonus");
                param[10].Value = Bonus;

                param[11] = new SQLiteParameter("@Period");
                param[11].Value = Period;

                param[12] = new SQLiteParameter("@TotalHours");
                param[12].Value = TotalHours;

                param[13] = new SQLiteParameter("@TimeType");
                param[13].Value = TimeType;

                param[14] = new SQLiteParameter("@BonusType");
                param[14].Value = BonusType;

                param[15] = new SQLiteParameter("@Holiday");
                param[15].Value = Holiday;

                param[16] = new SQLiteParameter("@Device1");
                param[16].Value = Device1;

                param[17] = new SQLiteParameter("@Device2");
                param[17].Value = Device2;

                param[18] = new SQLiteParameter("@Come_Early");
                param[18].Value = Come_Early;

                param[19] = new SQLiteParameter("@Leave_Early");
                param[19].Value = Leave_Early;

                param[20] = new SQLiteParameter("@Absent");
                param[20].Value = Absent;

                param[21] = new SQLiteParameter("@Edited");
                param[21].Value = Edited;

                string F;
                F = DAL.ExecuteCommand("Update `[GSet]` Set "
                    + " Date = @Date,"
                    + " Day = @Day,"
                    + " Att1 = @Att1,"
                    + " AttEarly1 = " + AttEarly1 + ","
                    + " Late1 = " + Late1 + ","
                    + " Leave1 = @Leave1,"
                    + " LeaveEarly1 = " + LeaveEarly1 + ","
                    + " Bonus1 = " + Bonus1 + ","
                    + " Period1 = @Period1,"
                    + " Att2 = @Att2,"
                    + " AttEarly2 = " + AttEarly2 + ","
                    + " Late2 = " + Late2 + ","
                    + " Leave2 = @Leave2,"
                    + " LeaveEarly2 = " + LeaveEarly2 + ","
                    + " Bonus2 = " + Bonus2 + ","
                    + " Period2 = @Period2,"
                    + " Late = @Late,"
                    + " Bonus = @Bonus,"
                    + " Period = @Period,"
                    + " TotalSum = " + TotalSum + ","
                    + " TotalSub = " + TotalSub + ","
                    + " TotalHours = @TotalHours,"
                    + " Come_Early = @Come_Early,"
                    + " Leave_Early = @Leave_Early,"
                    + " Absent = @Absent,"
                    + " Edited = @Edited,"
                    + " TimeType = @TimeType,"
                    + " BonusType = @BonusType,"
                    + " Holiday = @Holiday,"
                    + " Device1 = @Device1,"
                    + " Device2 = @Device2"
                    + " Where User_ID = @User_ID"
                    , param);

                DAL.Close();

                return F;
            }
        }

        public struct Depart
        {
            #region Var
            public int ID;
            public string Name;
            #endregion

            public DataTable Select()
            {
                cls_DAL DAL = new cls_DAL();
                DataTable dt = new DataTable();
                dt = DAL.SelectData("Select * From Depart", null);

                return dt;
            }
            public string Insert()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                SQLiteParameter[] param = new SQLiteParameter[1];

                param[0] = new SQLiteParameter("@Name");
                param[0].Value = Name;

                string F;
                F = DAL.ExecuteCommand("Insert Into Depart (Name) Values (@Name)", param);

                DAL.Close();

                return F;
            }
            public string Update()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                SQLiteParameter[] param = new SQLiteParameter[2];

                param[0] = new SQLiteParameter("@ID");
                param[0].Value = ID;

                param[1] = new SQLiteParameter("@Name");
                param[1].Value = Name;

                string F;
                F = DAL.ExecuteCommand("Update Depart Set Name = @Name  Where ID = @ID", param);

                DAL.Close();

                return F;
            }
            public string Delete()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                SQLiteParameter[] param = new SQLiteParameter[1];

                param[0] = new SQLiteParameter("@ID");
                param[0].Value = ID;

                string f;
                f = DAL.ExecuteCommand("delete from Depart where id = @ID", param);

                DAL.Close();

                return f;
            }
        }

        public struct Vac
        {
            #region Var
            public int ID;
            public string Name;
            public string MM;
            public string dd;
            string st;
            #endregion

            public DataTable Select()
            {
                cls_DAL DAL = new cls_DAL();
                DataTable dt = new DataTable();
                dt = DAL.SelectData("Select * From Vac", null);

                return dt;
            }
            public string Insert()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                string F;
                F = DAL.ExecuteCommand("Insert Into Vac (Name,MM,dd) Values ('"
                    + Name + "','"                  
                    + MM + "','"
                    + dd 
                    + "')", null);

                DAL.Close();

                return F;
            }
            public string Update()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                string F;
                F = DAL.ExecuteCommand("Update Vac Set "
                    + "Name = '" + Name + "',"
                    + "MM = '" + MM + "',"
                    + "dd = '" + dd + "' "
                    + "Where ID = " + ID + "" 
                    , null);

                DAL.Close();

                return F;
            }
            public string Delete()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                SQLiteParameter[] param = new SQLiteParameter[1];

                param[0] = new SQLiteParameter("@ID");
                param[0].Value = ID;

                string f;
                f = DAL.ExecuteCommand("delete from Vac where id = @ID", param);

                DAL.Close();

                return f;
            }

            public DataTable Select(string WSID)
            {
                cls_DAL DAL = new cls_DAL();
                DataTable dt = new DataTable();
                dt = DAL.SelectData("Select VacID, Vac.Name,Vac.MM,Vac.dd From VacWS INNER JOIN Vac ON VacWS.VacID = Vac.ID where WSID =" + WSID, null);

                return dt;
            }
            public DataTable Select_SelectedVac(string WSID)
            {
                cls_DAL DAL = new cls_DAL();
                DataTable dt = new DataTable();
                dt = DAL.SelectData("Select VacID, Vac.Name,VacWS.Bonus From VacWS INNER JOIN Vac ON VacWS.VacID = Vac.ID where WSID =" + WSID, null);

                return dt;
            }
            public string Insert(Dictionary<string, int> sv, string w)
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                string F = "";
                st = "";
                if (sv.Count == 0)
                {
                    F = DAL.ExecuteCommand("delete from VacWS where WSID = " + w, null);
                }
                else
                {
                    foreach (KeyValuePair<string, int> entry in sv)
                    {
                        st += ",(" + entry.Key + "," + entry.Value + "," + w + ")";
                    }

                    F = st.Substring(1);
                    F = DAL.ExecuteCommand("delete from VacWS where WSID = " + w + "; Insert Into VacWS (VacID,Bonus,WSID) Values " + F, null);
                }

                DAL.Close();

                return F;
            }
            public string Update_VacWS(string b,string v,string w)
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                string F;
                F = DAL.ExecuteCommand("Update VacWS Set "
                    + " Bonus = " + b
                    + " Where VacID = " + v + " and WSID = " + w
                    , null);

                DAL.Close();

                return F;
            }
        }

        public struct Sec
        {
            #region Var
            public int ID;
            public string Name;
            #endregion

            public DataTable Select()
            {
                cls_DAL DAL = new cls_DAL();
                DataTable dt = new DataTable();
                dt = DAL.SelectData("Select * From Sec", null);

                return dt;
            }
            public string Insert()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                SQLiteParameter[] param = new SQLiteParameter[1];

                param[0] = new SQLiteParameter("@Name");
                param[0].Value = Name;

                string F;
                F = DAL.ExecuteCommand("Insert Into Sec (Name) Values (@Name)", param);

                DAL.Close();

                return F;
            }
            public string Update()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                SQLiteParameter[] param = new SQLiteParameter[2];

                param[0] = new SQLiteParameter("@ID");
                param[0].Value = ID;

                param[1] = new SQLiteParameter("@Name");
                param[1].Value = Name;

                string F;
                F = DAL.ExecuteCommand("Update Sec Set Name = @Name  Where ID = @ID", param);

                DAL.Close();

                return F;
            }
            public string Delete()
            {
                cls_DAL DAL = new cls_DAL();
                DAL.open();

                SQLiteParameter[] param = new SQLiteParameter[1];

                param[0] = new SQLiteParameter("@ID");
                param[0].Value = ID;

                string f;
                f = DAL.ExecuteCommand("delete from Sec where id = @ID", param);

                DAL.Close();

                return f;
            }
        }
    }
}
