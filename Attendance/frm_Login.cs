using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Security.Cryptography;
using System.Globalization;

namespace Attendance
{
    public partial class frm_Login : Form
    {
        #region Declarations
        private static string Key = "dofkrfayurdedofkrfaosrdestfkrfao";
        private static string IV = "zxcvbhkdfrasdaeh";
        int user_id;
        string id;
        int CurrentDate;
        #endregion

        public frm_Login()
        {
            InitializeComponent();

            update();
            txt_Name.Text = Properties.Settings.Default.LoginUser;
        }

        #region Form
        private void frm_Login_Shown(object sender, EventArgs e)
        {
            if (txt_Name.Text != "") txt_Password.Focus();
        }
        private void frm_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Pro
        int IntDate(DateTime dd)
        {
            string s = "";

            string m = dd.Month.ToString();
            if (m.Length == 1) m = "0" + m;

            string d = dd.Day.ToString();
            if (d.Length == 1) d = "0" + d;

            s = dd.Year.ToString() + m + d;

            return Convert.ToInt32(s);
        }
        public static string Decrypt(string encrypted)
        {
            byte[] encryptedbytes = Convert.FromBase64String(encrypted);
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = System.Text.ASCIIEncoding.ASCII.GetBytes(Key);
            aes.IV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform crypto = aes.CreateDecryptor(aes.Key, aes.IV);
            byte[] secret = crypto.TransformFinalBlock(encryptedbytes, 0, encryptedbytes.Length);
            crypto.Dispose();
            return System.Text.ASCIIEncoding.ASCII.GetString(secret);

        }
        //string GetMACAddress()
        //{
        //    ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
        //    ManagementObjectCollection moc = mc.GetInstances();

        //    string MACAddress = String.Empty;

        //    foreach (ManagementObject mo in moc)
        //    {
        //        if (MACAddress == String.Empty)
        //        { // only return MAC Address from first card
        //            if ((bool)mo["IPEnabled"] == true) MACAddress = mo["MacAddress"].ToString();
        //        }
        //        mo.Dispose();
        //    }

        //    return MACAddress;
        //}
        string UniqueMachineId()
        {
            StringBuilder builder = new StringBuilder();

            String query = "SELECT * FROM Win32_BIOS";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementClass mc = new ManagementClass("Win32_Processor");
            //  This should only find one
            foreach (ManagementObject item in searcher.Get())
            {
                Object obj = item["Manufacturer"];
                builder.Append(Convert.ToString(obj));
                builder.Append(':');
                obj = item["SerialNumber"];
                builder.Append(Convert.ToString(obj));
            }

            return builder.ToString();
        }
        string cpuID()
        {
            string cpuID = "";
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                if (cpuID == "")
                {
                    //Remark gets only the first CPU ID
                    cpuID = mo.Properties["processorID"].Value.ToString();

                }
            }
            return cpuID;
        }
        string CheckAth()
        {
            //string path = @"x86\SQLite.Interop.txt";
            string value = "";
            int ExpireDate = 0;
            id = UniqueMachineId() + cpuID();
            CurrentDate = IntDate(DateTime.Today);

            //if (!File.Exists(path))
            //{
            //    File.Create(path).Dispose();
            //}
            try
            {
                //value = File.ReadAllText(path);
                //if (Properties.Settings.Default.ID == "")
                //{
                //    Properties.Settings.Default.ID = value;
                //    Properties.Settings.Default.Save();
                //}
                //else if (Properties.Settings.Default.ID != value)
                //{
                //    File.WriteAllText(path, Properties.Settings.Default.ID);
                //}
                value = Decrypt(Properties.Settings.Default.ID);
                ExpireDate = (Properties.Settings.Default.d != "") ?  Convert.ToInt32(Decrypt(Properties.Settings.Default.d)) : ExpireDate;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "error";
            }

            if (id != value)
            {
                return "id";
            }
            else if (CurrentDate > ExpireDate)
            {
                return "date";
            }
            else
            {
                return "OK";
            }

        }
        void update()
        {
            string[] s = new string[0];

            cls_BL.Update u = new cls_BL.Update();
            int m = u.Check();

            while(m < 0)
            {
                m = u.update(s[m],m+1);
            }
        }
        #endregion

        #region Details
        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13) SendKeys.Send("{TAB}");
        }
        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) btn_Login_Click(null,null);
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            cls_BL.Users users = new cls_BL.Users();

            users.Name = txt_Name.Text;
            users.Password = txt_Password.Text;

            DataTable dt = new DataTable();
            dt = users.Select();

            foreach (DataRow r in dt.Rows)
            {
                if (r["Name"].ToString() == users.Name && r["Password"].ToString() == users.Password)
                {                
                    Hide();
                    string c = CheckAth();
                    if (c == "OK")
                    {
                        frm_Main Main = new frm_Main();
                        user_id = Convert.ToInt16(r["ID"]);
                        Main.User_ID = user_id;
                        Main.Show();
                        Properties.Settings.Default.LoginUser = txt_Name.Text;
                        Properties.Settings.Default.Save();
                        return;
                    }
                    else
                    {
                        frm_PreventNo p = new frm_PreventNo();
                        p.User_ID = Convert.ToInt16(r["ID"]);
                        p.Case = c;
                        p.ShowDialog();
                        return;
                    }
                }
            }
            MessageBox.Show("أسم المستخدم أو كلمة المرور غير صحيحة", "خطأ في بيانات الدخول", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }  
        private void btn_Demo_Click(object sender, EventArgs e)
        {
            Hide();
            frm_Main Main = new frm_Main();
            Main.User_ID = 1;
            Main.Demo = true;
            Main.Show();
        }
        #endregion
    }
}
