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
    public partial class frm_IOEdit : Form
    {
        cls_BL.Device Device = new cls_BL.Device();
        cls_BL.Rep Rep = new cls_BL.Rep();

        public frm_IOEdit()
        {
            InitializeComponent();

            com_Event.DataSource = Rep.EventCol();
            com_Device.DataSource = Device.Select();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            cls_BL.Rep Rep = new cls_BL.Rep();
            Rep.Update(lbl_IOName.Text, dtp.Value.ToString("yyyy-MM-dd HH:mm:ss"),Convert.ToInt16(com_Event.SelectedValue),(com_Device.SelectedValue == null)?"-1": com_Device.SelectedValue.ToString());
            Hide();
        }
    }
}
