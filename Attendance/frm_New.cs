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
    public partial class frm_New : Form
    {
        public frm_Emp emp;
        public frm_Device device;

        public frm_New()
        {
            InitializeComponent();
        }

        private void list_New_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(Tag.ToString() == "Emp" && list_New.SelectedItem != null)
            {
                Hide();
                emp.btn_New_Click(null,null);
                emp.txt_EmpName.Select();
                emp.txt_EmpID2.Text = list_New.SelectedValue.ToString();
            }
            else if (Tag.ToString() == "Device" && list_New.SelectedItem != null)
            {
                Hide();
                device.btn_New_Click(null, null);
                device.txt_DeviceName.Select();
                device.txt_ID2.Text = list_New.SelectedValue.ToString();
            }
        }
    }
}
