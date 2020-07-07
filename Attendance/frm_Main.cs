using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Attendance
{
    public partial class frm_Main : Form
    {
        #region Declaration
        public int User_ID;
        public bool Demo;
        cls_BL.GSet GSet = new cls_BL.GSet();
        cls_BL.Rep Rep = new cls_BL.Rep();
        public DataTable dt_GSet = new DataTable();

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        #endregion

        public frm_Main()
        {
            InitializeComponent();
            User_ID = (User_ID == 0) ? 1 : User_ID;
            OnLoad(null);
        }

        #region Pro
        void CheckPullFromFile()
        {
            cls_BL.General general = new cls_BL.General();
            DataTable dt_Result = general.Select("SELECT * FROM Sys LIMIT 1");

            if (dt_Result.Rows.Count == 0) return;

            tim_PullFromFile.Enabled = Convert.ToBoolean(dt_Result.Rows[0]["AutoPullFromFile"]);
            tim_PullFromFile.Interval = Convert.ToInt32(dt_Result.Rows[0]["AutoPullFromFileTimer"]) * 1000;
        }
        #endregion

        #region Form
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
            MaximizedBounds = Screen.GetWorkingArea(this);
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        private void frm_Main_Shown(object sender, EventArgs e)
        {
            GSet.User_ID = User_ID;
            dt_GSet = GSet.Select();
            CheckPullFromFile();
        }
        private void frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region MenurStrip
        private void أنظمةالدوامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_WorkSystem_Click(null, null);
        }
        private void الموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Emp_Click(null, null);
        }
        private void الإداراتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Depart_Click(null, null);
        }
        private void الأقسامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Sec_Click(null, null);
        }
        private void أجهزةالبصمةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Device_Click(null, null);
        }
        private void التقاريرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Rep_Click(null, null);
        }
        private void المستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Users_Click(null, null);
        }
        private void النسخالإحتياطيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Backup f = new frm_Backup();
            f.ShowDialog();
        }
        #endregion

        #region Buttons

        #region Display
        private void btn_WorkSystem_MouseEnter(object sender, EventArgs e)
        {
            btn_WorkSystem.FlatStyle = FlatStyle.Popup;
        }

        private void btn_WorkSystem_MouseLeave(object sender, EventArgs e)
        {
            btn_WorkSystem.FlatStyle = FlatStyle.Flat;
        }

        private void btn_Emp_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).FlatStyle = FlatStyle.Popup;
        }

        private void btn_Emp_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).FlatStyle = FlatStyle.Flat;
        }

        private void btn_FromFile_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).FlatStyle = FlatStyle.Popup;
        }

        private void btn_FromFile_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).FlatStyle = FlatStyle.Flat;
        }

        private void btn_Depart_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).FlatStyle = FlatStyle.Popup;
        }

        private void btn_Depart_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).FlatStyle = FlatStyle.Flat;
        }

        private void btn_Sec_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).FlatStyle = FlatStyle.Popup;
        }

        private void btn_Sec_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).FlatStyle = FlatStyle.Flat;
        }

        private void btn_Device_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).FlatStyle = FlatStyle.Popup;
        }

        private void btn_Device_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).FlatStyle = FlatStyle.Flat;
        }

        private void btn_Rep_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).FlatStyle = FlatStyle.Popup;
        }

        private void btn_Rep_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).FlatStyle = FlatStyle.Flat;
        }

        private void btn_Users_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).FlatStyle = FlatStyle.Popup;
        }

        private void btn_Users_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).FlatStyle = FlatStyle.Flat;
        }
        #endregion

        private void btn_Rep_Click(object sender, EventArgs e)
        {
            frm_Rep rep = new frm_Rep();
            rep.User_ID = User_ID;
            rep.dt_GSet = dt_GSet;
            rep.Demo = Demo;
            rep.Show();
        }
        private void btn_Users_Click(object sender, EventArgs e)
        {
            frm_Users users = new frm_Users();
            users.ShowDialog();
        }
        private void btn_Emp_Click(object sender, EventArgs e)
        {
            frm_Emp Emp = new frm_Emp();
            Emp.Demo = Demo;
            Emp.ShowDialog();
        }
        private void btn_Device_Click(object sender, EventArgs e)
        {
            frm_Device Device = new frm_Device();
            Device.ShowDialog();
        }
        private void btn_WorkSystem_Click(object sender, EventArgs e)
        {
            frm_WorkSys WorkSys = new frm_WorkSys();
            WorkSys.Demo = Demo;
            WorkSys.ShowDialog();
        }
        private void btn_FromFile_Click(object sender, EventArgs e)
        {
            if (Demo)
            {
                if (Rep.Select_Cout() >= 100000)
                {
                    MessageBox.Show("هذه نسخة تجريبية ولا يمكن اضافة المزيد من البيانات", "نسخة تجريبية", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
            frm_LoadFile load = new frm_LoadFile();
            load.ShowDialog();
        }
        private void btn_Depart_Click(object sender, EventArgs e)
        {
            frm_Depart Depart = new frm_Depart();
            Depart.ShowDialog();
        }
        private void btn_Sec_Click(object sender, EventArgs e)
        {
            frm_Sec Sec = new frm_Sec();
            Sec.ShowDialog();
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("هل تريد حفظ نسخة إحتياطية من البيانات ؟ ...  يجب حفظ نسخ أخرى من البيانات على قرص آخر حتى لا يتم فقدان البيانات نهائياً في حالة عطل القرص الصلب ", "حفظ نسخة احتياطية", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            if (r == DialogResult.Yes)
            {
                cls_BL.General g = new cls_BL.General();
                g.BackupData();
                Application.Exit();
            }
            if (r == DialogResult.No)
            {
                Application.Exit();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void btn_Logo_Click(object sender, EventArgs e)
        {

        }
        private void label1_DoubleClick(object sender, EventArgs e)
        {
            frm_Command cmd = new frm_Command();
            cmd.ShowDialog();
        }
        private void tsm_LoadFromDevice_Click(object sender, EventArgs e)
        {
            if (Demo)
            {
                if (Rep.Select_Cout() >= 100000)
                {
                    MessageBox.Show("هذه نسخة تجريبية ولا يمكن اضافة المزيد من البيانات", "نسخة تجريبية", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
            frm_LoadFromDevice f = new frm_LoadFromDevice();
            f.ShowDialog();
        }
        private void tsm_LoadFromFile_Click(object sender, EventArgs e)
        {
            btn_FromFile_Click(null, null);
        }
        private void tim_PullFromFile_Tick(object sender, EventArgs e)
        {
            Directory.CreateDirectory("C:\\AttendanceDownloads");
            var directory = new DirectoryInfo("C:\\AttendanceDownloads");

            if (directory.GetFiles().Length == 0) return;

            var myFile = directory.GetFiles()
                         .OrderByDescending(f => f.LastWriteTime)
                         .First();

             Rep.PullFromFile(myFile.FullName);


        }
        private void tsm_GeneralSettings_Click(object sender, EventArgs e)
        {
            frm_GeneralSettings f = new frm_GeneralSettings();
            f.ShowDialog();
        }
    }
}
