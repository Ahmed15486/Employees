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
    public partial class frm_Backup : Form
    {
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        OpenFileDialog ofd = new OpenFileDialog();
        public frm_Main frm_Main;

        public frm_Backup()
        {
            InitializeComponent();

            txt_Backup.Text = AppDomain.CurrentDomain.BaseDirectory + "BACKUP";
            fbd.SelectedPath = txt_Backup.Text;
            ofd.InitialDirectory = txt_Backup.Text;
        }

        private void btn_BrowseBackup_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txt_Backup.Text = fbd.SelectedPath;
            }
        }

        private void btn_Backup_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(txt_Backup.Text.Trim()))
            {
                cls_BL.General g = new cls_BL.General();
                g.BackupData();
            }
            else
            {
                MessageBox.Show("المسار غير موجود");
                return;
            }
        }

        private void btn_BrowseRestore_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txt_Restore.Text = ofd.FileName;
            }
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(txt_Restore.Text.Trim()))
            {
                cls_BL.General g = new cls_BL.General();
                g.RestoreData(txt_Restore.Text.Trim());
            }
            else
            {
                MessageBox.Show("مسار الملف غير صحيح");
                return;
            }
        }
    }
}
