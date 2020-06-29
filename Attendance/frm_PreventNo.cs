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

namespace Attendance
{
    public partial class frm_PreventNo : Form
    {
        #region Declarations
        public int User_ID;
        public string Case;
        string id;
        //string path;
        private static string Key = "dofkrfayurdedofkrfaosrdestfkrfao";
        private static string IV = "zxcvbhkdfrasdaeh";
        #endregion

        public frm_PreventNo()
        {
            InitializeComponent();

            //path = @"x86\SQLite.Interop.txt";
            id = UniqueMachineId() + cpuID();

            //if(!File.Exists(path))
            //{
            //    File.Create(path).Dispose();
            //}
            //string value = File.ReadAllText(path);
        }

        #region Pro
        private static string Encrypt(string text)
        {
            byte[] plaintextbytes = System.Text.ASCIIEncoding.ASCII.GetBytes(text);
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = System.Text.ASCIIEncoding.ASCII.GetBytes(Key);
            aes.IV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform crypto = aes.CreateEncryptor(aes.Key, aes.IV);
            byte[] encrypted = crypto.TransformFinalBlock(plaintextbytes, 0, plaintextbytes.Length);
            crypto.Dispose();
            return Convert.ToBase64String(encrypted);
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
        string ExpireDate(int addDays)
        {
            string s = "";
            DateTime exd = DateTime.Today.AddDays(addDays);

            string m = exd.Month.ToString();
            if (m.Length == 1) m = "0" + m;

            string d = exd.Day.ToString();
            if (d.Length == 1) d = "0" + d;

            s = exd.Year.ToString() + m + d;

            return s;
        }
        #endregion

        #region Form
        private void frm_PreventNo_Shown(object sender, EventArgs e)
        {
            Random r = new Random();
            txt_Authorization.Text = Case.Substring(0, 1) + r.Next(1, 9).ToString() + r.Next(1, 9).ToString() + r.Next(1, 9).ToString() + r.Next(1, 9).ToString();
        }
        #endregion

        private void btn_Run_Click(object sender, EventArgs e)
        {
            if (txt_Run.Text.Length != 6) return;

            int q = (Convert.ToInt32(txt_Authorization.Text.Substring(1, 1)) * 5);
            int w = (Convert.ToInt32(txt_Authorization.Text.Substring(2, 1)) * 4);
            int t = (Convert.ToInt32(txt_Authorization.Text.Substring(3, 1)) * 8);
            int r = (Convert.ToInt32(txt_Authorization.Text.Substring(4, 1)) * 6);


            string txt = txt_Run.Text.Substring(0, 4);
            int AddDays = Convert.ToInt32(txt_Run.Text.Substring(4, 2));
            string run = q.ToString().Substring(0, 1) + w.ToString().Substring(0, 1) + t.ToString().Substring(0, 1) + r.ToString().Substring(0, 1);

            if (AddDays == 38) AddDays = 3650;
            else if (AddDays > 70) AddDays = 70;

            if (txt == run)
            {
                string i = Encrypt(id);
                //File.WriteAllText(path,i);
                Properties.Settings.Default.ID = i;
                Properties.Settings.Default.d = Encrypt(ExpireDate(AddDays));
                Properties.Settings.Default.LoginUser = "Admin";
                Properties.Settings.Default.Save();

                Hide();
                frm_Main Main = new frm_Main();
                Main.Show();
            }
            else
            {
                Application.Exit();
            }
        }
        private void frm_PreventNo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
