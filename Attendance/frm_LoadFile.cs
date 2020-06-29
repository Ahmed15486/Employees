using Attendance.Info;
using Attendance.Utilities;
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
    public partial class frm_LoadFile : Form
    {
        cls_BL.Rep Rep = new cls_BL.Rep();
        OpenFileDialog openFileDialog1 = new OpenFileDialog();

        DeviceManipulator manipulator = new DeviceManipulator();
        public ZkemClient objZkeeper;
        private bool isDeviceConnected = false;

        public frm_LoadFile()
        {
            InitializeComponent();
        }

        #region Pro
        DialogResult OFD()
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            return openFileDialog1.ShowDialog();
        }
        private void RaiseDeviceEvent(object sender, string actionType)
        {
            switch (actionType)
            {
                case UniversalStatic.acx_Disconnect:
                    {
                        //ShowStatusBar("The device is switched off", true);
                        //DisplayEmpty();
                        //btnConnect.Text = "Connect";
                        //ToggleControls(false);
                        break;
                    }

                default:
                    break;
            }

        }
        public bool IsDeviceConnected
        {
            get { return isDeviceConnected; }
            set
            {
                isDeviceConnected = value;
                if (isDeviceConnected)
                {
                    //ShowStatusBar("The device is connected !!", true);
                    //btnConnect.Text = "Disconnect";
                    //ToggleControls(true);
                }
                else
                {
                    //ShowStatusBar("The device is diconnected !!", true);
                    objZkeeper.Disconnect();
                //    btnConnect.Text = "Connect";
                //    ToggleControls(false);
                }
            }
        }
        #endregion

        private void btn_Dat_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "DAT files (*.dat)|*.dat";
            if (OFD() == DialogResult.OK)
            {
                Rep.LoadFromDAT2(openFileDialog1.FileName);
            }
            Hide();
        }
        //private void btn_Dat_Click(object sender, EventArgs e)
        //{
        //    objZkeeper = new ZkemClient(RaiseDeviceEvent);
        //    IsDeviceConnected = objZkeeper.Connect_Net("192.168.15.201", 4370);

        //    Rep.LoadFromDevice(manipulator.GetLogData(objZkeeper, int.Parse("1")));      
        //    Hide();
        //}
        private void btn_Txt_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "TXT files (*.txt)|*.txt";
            if (OFD() == DialogResult.OK)
            {
                Rep.LoadFromTXT(openFileDialog1.FileName);
            }
            Hide();
        }
    }
}
