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
    public partial class frm_Chart : Form
    {
        public frm_Chart()
        {
            InitializeComponent();

            chart1.Series[1].Points.Add();
        }
    }
}
