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
    public partial class frm_LoadFromDevice : Form
    {
        cls_BL.Device Device = new cls_BL.Device();

        DeviceManipulator manipulator = new DeviceManipulator();
        public ZkemClient objZkeeper;
        private bool isDeviceConnected = false;

        cls_BL.Rep Rep = new cls_BL.Rep();

        public frm_LoadFromDevice()
        {
            InitializeComponent();
        }

        #region Pro
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

        void Excute(int RowIndex)
        {
            objZkeeper = new ZkemClient(RaiseDeviceEvent);

            string ip = ""; int port = 0;
            if(!string.IsNullOrEmpty(dgv.Rows[RowIndex].Cells["ip"].Value.ToString()))
            {
                ip = dgv.Rows[RowIndex].Cells["ip"].Value.ToString();
            }
            if(!string.IsNullOrEmpty(dgv.Rows[RowIndex].Cells["port"].Value.ToString()))
            {
                port = Convert.ToInt32(dgv.Rows[RowIndex].Cells["port"].Value);
            }
            if (string.IsNullOrEmpty(ip) || port == 0) return;

            IsDeviceConnected = objZkeeper.Connect_Net(ip, port);

            Rep.LoadFromDevice(manipulator.GetLogData(objZkeeper, int.Parse("1")));
            Hide();
        }
        #endregion

        private void frm_LoadFromDevice_Shown(object sender, EventArgs e)
        {
            foreach (DataRow r in Device.Select().Rows)
            {
                dgv.Rows.Add(r["id2"], r["name"], r["ip"], r["port"], "Import");
            }
        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv.Columns.Count - 1)
            {
                Excute(e.RowIndex);
            }
        }

        private void btn_ImportFromAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                Excute(row.Index);
            }
        }
    }
}
