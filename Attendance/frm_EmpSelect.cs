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
    public partial class frm_EmpSelect : Form
    {
        #region Declarations
        public bool Demo;
        public int User_ID;
        public string Emp_ID;
        cls_BL.GSet GSet = new cls_BL.GSet();
        cls_BL.WorkSys WS = new cls_BL.WorkSys();
        cls_BL.Device Device = new cls_BL.Device();
        cls_BL.Depart Depart = new cls_BL.Depart();
        cls_BL.Sec Sec = new cls_BL.Sec();
        cls_BL.Emp Emp = new cls_BL.Emp();
        DataTable dt_AvailableEmp = new DataTable();
        DataTable dt_SelectedEmp = new DataTable();
        public DataTable dt_GSet;
        cls_BL.Rep Rep = new cls_BL.Rep();
        #endregion

        public frm_EmpSelect()
        {
            InitializeComponent();

            com_Emp.DataSource = Emp.Select();
            com_WS.DataSource = WS.Select();
            com_Depart.DataSource = Depart.Select();
            com_Sec.DataSource = Sec.Select();

            dgv_WS.AutoGenerateColumns = false;
            dgv_Device.AutoGenerateColumns = false;
            dgv_Depart.AutoGenerateColumns = false;
            dgv_Sec.AutoGenerateColumns = false;
            dgv_SelectedEmp.AutoGenerateColumns = false;
            dgv_AvailableEmp.AutoGenerateColumns = false;

            dgv_WS.DataSource = WS.Select();
            dgv_Device.DataSource = Device.Select();
            dgv_Depart.DataSource = Depart.Select();
            dgv_Sec.DataSource = Sec.Select();
            dt_AvailableEmp = Emp.Select();
            FillAvailable();
        }

        #region Pro
        void FillAvailable()
        {
            dgv_AvailableEmp.Rows.Clear();
            foreach (DataRow r in dt_AvailableEmp.Rows)
            {
                dgv_AvailableEmp.Rows.Add(false, r["Name"].ToString(), r["ID2"].ToString());
            }
        }
        void RemoveFromAvailable()
        {
            foreach (DataGridViewRow r in dgv_SelectedEmp.Rows)
            {
                for (int i = 0; i < dgv_AvailableEmp.RowCount; i++)
                {
                    if(r.Cells[2].Value.ToString() == dgv_AvailableEmp.Rows[i].Cells[2].Value.ToString())
                    {
                        dgv_AvailableEmp.Rows.RemoveAt(i);
                        i--;
                        break;
                    }
                }
            }
        }
        void Att_GSet()
        {
            if (Tag.ToString() == "IO") return;
            GSet.User_ID = User_ID;
            dt_GSet = GSet.Select();
            DGV.Columns["التاريخ"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["Date"]);
            DGV.Columns["اليوم"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["Day"]);
            DGV.Columns["حضور دوام 1"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["Att1"]);
            DGV.Columns["حضور مبكر1"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["AttEarly1"]);
            DGV.Columns["تأخير1"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["Late1"]);
            DGV.Columns["إنصراف دوام 1"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["Leave1"]);
            DGV.Columns["إنصراف مبكر1"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["LeaveEarly1"]);
            DGV.Columns["إضافي1"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["Bonus1"]);
            DGV.Columns["الفترة الأولى"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["Period1"]);
            DGV.Columns["حضور دوام 2"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["Att2"]);
            DGV.Columns["حضور مبكر2"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["AttEarly2"]);
            DGV.Columns["تأخير2"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["Late2"]);
            DGV.Columns["إنصراف دوام 2"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["Leave2"]);
            DGV.Columns["إنصراف مبكر2"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["LeaveEarly2"]);
            DGV.Columns["إضافي2"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["Bonus2"]);
            DGV.Columns["الفترة الثانية"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["Period2"]);
            DGV.Columns["حضور مبكر"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["Come_Early"]);
            DGV.Columns["إنصراف مبكر"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["Leave_Early"]);
            DGV.Columns["تأخير"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["Late"]);
            DGV.Columns["إضافي"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["Bonus"]);
            DGV.Columns["الدوام"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["Period"]);
            DGV.Columns["إجمالي المستقطع"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["TotalSub"]);
            DGV.Columns["إجمالي المضاف"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["TotalSum"]);
            DGV.Columns["عدد الساعات"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["TotalHours"]);
            DGV.Columns["نظام المواعيد"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["TimeType"]);
            DGV.Columns["نوع الإضافي"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["BonusType"]);
            DGV.Columns["أجازة ؟"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["Holiday"]);
            DGV.Columns["جهاز الحضور"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["Device1"]);
            DGV.Columns["جهاز الإنصراف"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["Device2"]);
            DGV.Columns["غائب ؟"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["Absent"]);
            DGV.Columns["حركات معدلة"].Visible = Convert.ToBoolean(dt_GSet.Rows[0]["Edited"]);
        }
        int width(string s)
        {
            if (s == "التاريخ") return 85;
            else if (s == "اليوم") return 50;
            else if (s == "حضور دوام 1" || s == "حضور دوام 2") return 80;
            else if (s == "إنصراف دوام 1" || s == "إنصراف دوام 2") return 140;
            else if (s == "حضور مبكر1" || s == "تأخير1" || s == "إنصراف مبكر1" || s == "إضافي1" || s == "حضور مبكر2" || s == "تأخير2" || s == "إنصراف مبكر2" || s == "إضافي2" || s == "إجمالي المضاف") return 50;
            else if (s == "الفترة الأولى" || s == "الفترة الثانية" || s == "تأخير" || s == "إضافي" || s == "الدوام") return 50;
            else if (s == "عدد الساعات") return 50;
            else if (s == "إجمالي المستقطع") return 60;
            else if (s == "نظام المواعيد" || s == "نوع الإضافي" || s == "أجازة ؟" || s == "حضور مبكر" || s == "إنصراف مبكر" || s == "غائب ؟") return 50;
            else if (s == "الوقت") return 190;
            else if (s == "الحدث") return 140;
            else if (s == "جهاز البصمة") return 200;
            return 100;
        }
        void dgv_IO()
        {
            DGV.Columns.Clear();
            DGV.DataSource = null;
            DGV.AutoGenerateColumns = false;
            #region DGV Fildes
            var Index = new DataGridViewTextBoxColumn();
            Index.Name = "Index";
            Index.DataPropertyName = "Index";
            Index.HeaderText = "رقم الحركة";
            Index.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Index.Width = 100;
            Index.Visible = false;
            DGV.Columns.Add(Index);

            var Time = new DataGridViewTextBoxColumn();
            Time.Name = "Time";
            Time.HeaderText = "الوقت";
            Time.DataPropertyName = "TTime";
            Time.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Time.Width = 300;
            Time.Visible = true;
            DGV.Columns.Add(Time);

            var Event = new DataGridViewComboBoxColumn();
            Event.Name = "Event";
            Event.HeaderText = "الحدث";
            Event.DataPropertyName = "Event";
            Event.DataSource = Rep.EventCol();
            Event.ValueMember = "ID";
            Event.DisplayMember = "Name";
            Event.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Event.Width = 150;
            Event.Visible = true;
            DGV.Columns.Add(Event);

            var Device_Name = new DataGridViewComboBoxColumn();
            Device_Name.Name = "Device_Name";
            Device_Name.DataPropertyName = "Device_ID";
            Device_Name.HeaderText = "جهاز البصمة";
            Device_Name.DataSource = Device.Select();
            Device_Name.ValueMember = "ID2";
            Device_Name.DisplayMember = "Name";
            Device_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Device_Name.Width = 300;
            DGV.Columns.Add(Device_Name);
            #endregion

            DGV.Tag = "IO";
        }
        #endregion

        #region Form
        private void frm_EmpSelect_Shown(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv_AvailableEmp.Rows)
            {
                if (r.Cells[2].Value.ToString() == Emp_ID)
                {
                    r.Cells[0].Value = true;
                    break;
                }
            }
            btn_f_Click(null, null);
        }
        #endregion

        #region Controls
        private void btn_Settings_Click(object sender, EventArgs e)
        {
            frm_RepSet set = new frm_RepSet();
            set.User_ID = User_ID;
            set.DGV = DGV;
            set.ShowDialog();
        }
        private void btn_PrintPreview_Click(object sender, EventArgs e)
        {
            if (dgv_SelectedEmp.RowCount == 0)
            {
                MessageBox.Show("يجب أختيار موظف على الأقل", "معاينة تقرير الحضور", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            if (Demo) ((ToolStripButton)((ToolStrip)printPreviewDialog1.Controls[1]).Items[0]).Enabled = false;
            printPreviewDialog1.ShowDialog();
        }
        private void btn_Print_Click(object sender, EventArgs e)
        {
            if (Demo)
            {
                MessageBox.Show("لا يمكن الطباعة في النسخة التجريبية", "نسخة تجريبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgv_SelectedEmp.RowCount == 0)
            {
                MessageBox.Show("يجب أختيار موظف على الأقل", "طباعة تقرير الحضور", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        #endregion

        #region Details
        private void btn_Select_Click(object sender, EventArgs e)
        {
            #region String
            string ws = "(";
            foreach (DataGridViewRow r in dgv_WS.Rows)
            {
                if (Convert.ToBoolean(r.Cells[0].Value) == true)
                {
                    ws += "," + r.Cells[2].Value.ToString();
                }
            }
            ws += ")";
            ws = (ws.Length > 2) ? "(" + ws.Substring(2) : "";


            string device = "('";
            foreach (DataGridViewRow r in dgv_Device.Rows)
            {
                if (Convert.ToBoolean(r.Cells[0].Value) == true)
                {
                    device += "','" + r.Cells[2].Value.ToString();
                }
            }
            device += "')";
            device = (device.Length > 4) ? "(" + device.Substring(4) : "";



            string depart = "(";
            foreach (DataGridViewRow r in dgv_Depart.Rows)
            {
                if (Convert.ToBoolean(r.Cells[0].Value) == true)
                {
                    depart += "," + r.Cells[2].Value.ToString();
                }
            }


            depart += ")";
            depart = (depart.Length > 2) ? "(" + depart.Substring(2) : "";

            string sec = "(";
            foreach (DataGridViewRow r in dgv_Sec.Rows)
            {
                if (Convert.ToBoolean(r.Cells[0].Value) == true)
                {
                    sec += "," + r.Cells[2].Value.ToString();
                }
            }
            sec += ")";
            sec = (sec.Length > 2) ? "(" + sec.Substring(2) : "";
            #endregion

            dt_SelectedEmp = Emp.Select_Print(ws, device, depart, sec);
            dgv_SelectedEmp.Rows.Clear();
            foreach (DataRow r in dt_SelectedEmp.Rows)
            {
                dgv_SelectedEmp.Rows.Add(false, r["Name"].ToString(), r["ID2"].ToString());
            }
            FillAvailable();
            RemoveFromAvailable();
        }
        private void btn_f_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_AvailableEmp.RowCount; i++)
            {
                if (Convert.ToBoolean(dgv_AvailableEmp.Rows[i].Cells[0].Value) == true)
                {
                    dgv_SelectedEmp.Rows.Add(false, dgv_AvailableEmp.Rows[i].Cells[1].Value.ToString(), dgv_AvailableEmp.Rows[i].Cells[2].Value.ToString());
                    dgv_AvailableEmp.Rows.RemoveAt(i);
                    i--;
                }
            }
        }
        private void btn_b_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_SelectedEmp.RowCount; i++)
            {
                if (Convert.ToBoolean(dgv_SelectedEmp.Rows[i].Cells[0].Value) == true)
                {
                    dgv_AvailableEmp.Rows.Add(false, dgv_SelectedEmp.Rows[i].Cells[1].Value.ToString(), dgv_SelectedEmp.Rows[i].Cells[2].Value.ToString());
                    dgv_SelectedEmp.Rows.RemoveAt(i);
                    i--;
                }
            }
        }
        private void btn_Selected_SelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv_SelectedEmp.Rows)
            {
                r.Cells[0].Value = true;
            }
        }
        private void btn_Selected_DisSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv_SelectedEmp.Rows)
            {
                r.Cells[0].Value = false;
            }
        }
        private void btn_Available_SelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv_AvailableEmp.Rows)
            {
                r.Cells[0].Value = true;
            }
        }
        private void btn_Available_DisSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv_AvailableEmp.Rows)
            {
                r.Cells[0].Value = false;
            }
        }
        #endregion

        string Events(int i)
        {
            List<string> list = new List<string>();
            list.Add("حضور دوام 1");
            list.Add("إنصراف دوام 1");
            list.Add("حضور دوام 2");
            list.Add("إنصراف دوام 2");

            return list[i];
        }
        Dictionary<string, string> myDict = new Dictionary<string, string>(); // Devices

        string Device_Name;
        Pen p = new Pen(Brushes.Black, 1);
        Font fh = new Font("Calibri", 12);
        Font fb = new Font("Calibri", 10);
        int rowh = 24;
        int w = 200;
        int h = 60;
        int row_no = 0;
        int emp_i = 0;
        int page_no = 1;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string ws = "";
            foreach (DataRow dr in dt_AvailableEmp.Rows)
            {
                if (dr["ID2"].ToString() == dgv_SelectedEmp.Rows[emp_i].Cells[2].Value.ToString())
                {
                    ws = dr["WS"].ToString();
                    com_Emp.SelectedValue = dr["ID2"].ToString();
                    com_WS.SelectedValue = dr["WS"].ToString();
                    com_Depart.SelectedValue = dr["Depart"].ToString();
                    com_Sec.SelectedValue = dr["Sec"].ToString();
                    break;
                }
            }

            cls_BL.Rep Rep = new cls_BL.Rep();

            if (rad_Att.Checked)
            {
                DGV.DataSource = null;
                DGV.Columns.Clear();
                DGV.AutoGenerateColumns = true;
                DGV.DataSource = Rep.AttLeave2(dgv_SelectedEmp.Rows[emp_i].Cells[2].Value.ToString(), ws, dtp_From.Value, dtp_To.Value);
                Att_GSet();
            }
            else
            {
                DGV.DataSource = Rep.SelectIO(dgv_SelectedEmp.Rows[emp_i].Cells[2].Value.ToString(), ws, dtp_From.Value, dtp_To.Value);
            }

            if (DGV.RowCount == 0) printDocument1_PrintPage(null,null);

            int left = (Tag.ToString() == "Att") ? 15 : 150;
            decimal total_page_no = Math.Ceiling((decimal)DGV.RowCount / 32);

            #region Header
            e.Graphics.DrawString("Attendance Report", fh, Brushes.Black, new Rectangle(350, 30, 200, 30));
            e.Graphics.DrawString("Employee Name : " + com_Emp.Text, fb, Brushes.Black, new Rectangle(left, 90, 400, 30));
            e.Graphics.DrawString("Attendance System : " + com_WS.Text, fb, Brushes.Black, new Rectangle(left + 300, 90, 400, 30));
            e.Graphics.DrawString("Department : " + com_Depart.Text, fb, Brushes.Black, new Rectangle(left, 110, 400, 30));
            e.Graphics.DrawString("Section : " + com_Sec.Text, fb, Brushes.Black, new Rectangle(left + 300, 110, 400, 30));
            e.Graphics.DrawString("From : " + dtp_From.Value.ToString("dd_MM_yyyy"), fb, Brushes.Black, new Rectangle(left, 130, 300, 30));
            e.Graphics.DrawString("To : " + dtp_To.Value.ToString("dd_MM_yyyy"), fb, Brushes.Black, new Rectangle(left + 300, 130, 300, 30));
            e.Graphics.DrawString(page_no.ToString() + " / " + total_page_no.ToString() , fb, Brushes.Black, new Rectangle(left + 400, 1050, 300, 30));
            #endregion

            #region Columns
            int top = 170;
            int last_width = 0;
            Graphics g = this.CreateGraphics();
            foreach (DataGridViewColumn c in DGV.Columns)
            {
                if (c.Visible == false) continue;

                string sleave = DGV.Columns[c.Index].HeaderText.ToString();
                w = w = width(sleave);
                string s = DGV.Columns[c.Index].HeaderText.ToString();

                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(left, top, w, h));
                e.Graphics.DrawRectangle(p, new Rectangle(left, top, w, h));
                e.Graphics.DrawString(s, fb, Brushes.Black, new Rectangle(left + 10, top + 8, w, h));

                last_width = w;
                left += last_width;
            }
            #endregion

            #region Rows
            top = 170;
            top += 35;
            while (row_no < DGV.RowCount)
            {
                if (top-100 > e.MarginBounds.Height)
                {
                    e.HasMorePages = true;
                    top = 100;
                    page_no++;
                    return;
                }

                left = (Tag.ToString() == "Att") ? 15 : 150;
                last_width = 0;
                top += rowh;
                foreach (DataGridViewColumn c in DGV.Columns)
                {
                    if (c.Visible == false) continue;

                    string s = "";
                    if (c.Name == "Event" && Tag.ToString() == "IO") // Event
                    {
                        if (DGV.Rows[row_no].Cells[c.Index].Value.ToString() == "")
                        {
                            s = "";
                        }
                        else
                        {
                            s = Events(Convert.ToInt16(DGV.Rows[row_no].Cells[c.Index].Value));
                        }
                    }
                    else if (c.Name == "Device_Name" && Tag.ToString() == "IO") // Device
                    {
                        myDict.TryGetValue(DGV.Rows[row_no].Cells[c.Index].Value.ToString(), out Device_Name);
                        s = Device_Name;
                    }
                    else
                    {
                        s = (DGV.Rows[row_no].Cells[c.Index].Value == null) ? "" : DGV.Rows[row_no].Cells[c.Index].Value.ToString();
                    }

                    string sleave = DGV.Columns[c.Index].HeaderText.ToString();
                    w = width(sleave);

                    e.Graphics.DrawRectangle(p, new Rectangle(left, top, w, rowh));
                    e.Graphics.DrawString(s, fb, Brushes.Black, new Rectangle(left + 8, top + 5, w, rowh));

                    last_width = w;
                    left += last_width;
                }
                row_no++;
            }
            emp_i++;
            page_no = 1;
            if (dgv_SelectedEmp.RowCount <= emp_i) return;
            e.HasMorePages = true;
            row_no = 0;
            top = 100;
            return;
            #endregion
        }
        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            row_no = 0;
            emp_i = 0;

            if (rad_Att.Checked)
            {
                Tag = "Att";
            }
            else
            {
                Tag = "IO";
                myDict.Clear();
                myDict.Add("No code", "No code");
                foreach (DataRow r in Device.Select().Rows)
                {
                    myDict.Add(r["ID2"].ToString(), r["Name"].ToString());
                }

                dgv_IO();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            emp_i = 0;
            string ws = "";
            cls_BL.Rep Rep = new cls_BL.Rep();
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();

            foreach (DataRow dr in dt_AvailableEmp.Rows)
            {
                if (dr["ID2"].ToString() == dgv_SelectedEmp.Rows[emp_i].Cells[2].Value.ToString())
                {
                    ws = dr["WS"].ToString();
                    com_Emp.SelectedValue = dr["ID2"].ToString();
                    com_WS.SelectedValue = dr["WS"].ToString();
                    com_Depart.SelectedValue = dr["Depart"].ToString();
                    com_Sec.SelectedValue = dr["Sec"].ToString();

                    dt = Rep.AttLeave2(dgv_SelectedEmp.Rows[emp_i].Cells[2].Value.ToString(), ws, dtp_From.Value, dtp_To.Value);

                    if (dt2.Columns.Count == 0)
                    {
                        foreach (DataColumn c in dt.Columns)
                        {
                            dt2.Columns.Add(c.ColumnName);
                        }
                    }
                    dt2.Rows.Add(dt.Rows[dt.Rows.Count - 1].ItemArray);
                    emp_i++;
                }
            }
        }
    }
}
