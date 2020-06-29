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
                objZkeeper = new ZkemClient(RaiseDeviceEvent);

                string ip = dgv.Rows[e.RowIndex].Cells["ip"].Value.ToString();
                int port = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["port"].Value);

                IsDeviceConnected = objZkeeper.Connect_Net(ip, port);

                Rep.LoadFromDevice(manipulator.GetLogData(objZkeeper, int.Parse("1")));
                Hide();
            }
        }
    }
}
