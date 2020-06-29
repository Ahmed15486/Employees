using System;
using System.Windows.Forms;

namespace Attendance
{
    public partial class frm_Command : Form
    {
        public frm_Command()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if(txt_Command.Text == "resetdata")
            {
                cls_BL.General g = new cls_BL.General();
                g.RestData();
                Dispose();
            }
            else if (txt_Command.Text == "resetio")
            {
                cls_BL.General g = new cls_BL.General();
                g.RestIO();
                Dispose();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
