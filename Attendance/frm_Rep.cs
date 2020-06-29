using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Attendance
{
    public partial class frm_Rep : Form
    {
        #region Declaration    
        public bool Demo;
        public int User_ID;
        public DataTable dt_GSet;
        frm_EmpSelect frm_EmpSelect = new frm_EmpSelect();
        cls_BL.GSet GSet = new cls_BL.GSet();
        cls_BL.Emp Emp = new cls_BL.Emp();
        DataTable dt_Emp = new DataTable();
        cls_BL.WorkSys WS = new cls_BL.WorkSys();
        cls_BL.Depart Depart = new cls_BL.Depart();
        cls_BL.Sec Sec = new cls_BL.Sec();
        cls_BL.Device Device = new cls_BL.Device();
        cls_BL.Rep Rep = new cls_BL.Rep();
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        Microsoft.Office.Interop.Excel.Range myRange;
        Microsoft.Office.Interop.Excel.Range lastcol;
        Microsoft.Office.Interop.Excel.Range firstrow;
        #endregion

        public frm_Rep()
        {
            InitializeComponent();

            DGV.AutoGenerateColumns = false;
            dtp_From.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 0, 0, 0);
            dtp_To.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month), 23, 59, 59);

            dt_Emp = Emp.Select();
            com_Emp.DataSource = dt_Emp;
            com_WS.DataSource = WS.Select();
            com_Depart.DataSource = Depart.Select();
            com_Sec.DataSource = Sec.Select();
        }

        #region Form
        private void frm_Rep_Shown(object sender, EventArgs e)
        {
            com_Emp_SelectedIndexChanged(null, null);
            com_Emp.Select();
        }
        #endregion

        #region Pro
        DialogResult OFD()
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;
            
            return openFileDialog1.ShowDialog();
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

            var Priority = new DataGridViewCheckBoxColumn();
            Priority.Name = "Priority";
            Priority.DataPropertyName = "Priority";
            Priority.HeaderText = "أولوية";
            Priority.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Priority.Width = 50;
            DGV.Columns.Add(Priority);

            var Deleted = new DataGridViewCheckBoxColumn();
            Deleted.Name = "Deleted";
            Deleted.DataPropertyName = "Deleted";
            Deleted.HeaderText = "تجاهل";
            Deleted.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Deleted.Width = 50;
            DGV.Columns.Add(Deleted);

            var Edit = new DataGridViewTextBoxColumn();
            Edit.Name = "Edit";
            Edit.DataPropertyName = "تعديل";
            Edit.HeaderText = "تعديل";
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Edit.Width = 50;
            DGV.Columns.Add(Edit);
            #endregion

            DGV.Tag = "IO";
        }
        void Att_GSet()
        {
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
        string Events(int i)
        {
            List<string> list = new List<string>();
            list.Add("حضور دوام 1");
            list.Add("إنصراف دوام 1");
            list.Add("حضور دوام 2");
            list.Add("إنصراف دوام 2");

            return list[i];
        }
        #endregion

        #region Controls
        private void btn_IO_Click(object sender, EventArgs e)
        {
            if (com_Emp.SelectedValue == null)
            {
                MessageBox.Show("يجب تحديد موظف", "تقرير حركات موظف", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            cls_BL.Rep Rep = new cls_BL.Rep();

            dgv_IO();
            DGV.DataSource = Rep.SelectIO(com_Emp.SelectedValue.ToString(), com_WS.SelectedValue.ToString(), dtp_From.Value, dtp_To.Value);
            DGV.ClearSelection();

            foreach (DataGridViewRow r in DGV.Rows)
            {
                if (r.Cells["Event"].Value.ToString() == "0" || r.Cells["Event"].Value.ToString() == "2")
                {
                    r.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#EFF6EF");
                }
                else if (r.Cells["Event"].Value.ToString() == "1" || r.Cells["Event"].Value.ToString() == "3")
                {
                    r.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#F6EFEF");
                }
            }
        }
        private void btn_Att_Click(object sender, EventArgs e)
        {
            if (com_Emp.SelectedValue == null)
            {
                MessageBox.Show("يجب تحديد موظف", "تقرير الحضور والإنصراف", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            cls_BL.Rep Rep = new cls_BL.Rep();

            DGV.Columns.Clear();
            DGV.DataSource = null;
            DGV.AutoGenerateColumns = true;
            DGV.DataSource = Rep.AttLeave2(com_Emp.SelectedValue.ToString(), com_WS.SelectedValue.ToString(), dtp_From.Value, dtp_To.Value);

            DGV.Columns["حضور مبكر1"].DefaultCellStyle.ForeColor = Color.DarkGreen;
            DGV.Columns["تأخير1"].DefaultCellStyle.ForeColor = Color.Crimson;
            DGV.Columns["إنصراف مبكر1"].DefaultCellStyle.ForeColor = Color.Crimson;
            DGV.Columns["إضافي1"].DefaultCellStyle.ForeColor = Color.DarkGreen;

            DGV.Columns["حضور مبكر2"].DefaultCellStyle.ForeColor = Color.DarkGreen;
            DGV.Columns["تأخير2"].DefaultCellStyle.ForeColor = Color.Crimson;
            DGV.Columns["إنصراف مبكر2"].DefaultCellStyle.ForeColor = Color.Crimson;
            DGV.Columns["إضافي2"].DefaultCellStyle.ForeColor = Color.DarkGreen;

            DGV.Columns["حضور مبكر"].DefaultCellStyle.ForeColor = Color.DarkGreen;
            DGV.Columns["إنصراف مبكر"].DefaultCellStyle.ForeColor = Color.Crimson;
            DGV.Columns["تأخير"].DefaultCellStyle.ForeColor = Color.Crimson;
            DGV.Columns["إضافي"].DefaultCellStyle.ForeColor = Color.DarkGreen;

            DGV.Columns["إجمالي المستقطع"].DefaultCellStyle.ForeColor = Color.Crimson;
            DGV.Columns["إجمالي المضاف"].DefaultCellStyle.ForeColor = Color.DarkGreen;

            foreach (DataGridViewRow r in DGV.Rows)
            {
                if (r.Cells["أجازة ؟"].Value.ToString() == "أجازة")
                {
                    r.DefaultCellStyle.BackColor = Color.AntiqueWhite;
                }
            }
            DGV.Rows[DGV.RowCount - 1].DefaultCellStyle.BackColor = Color.Silver;
            DGV.Rows[DGV.RowCount - 1].DefaultCellStyle.ForeColor = Color.Navy;
            DGV.Rows[DGV.RowCount - 1].DefaultCellStyle.Font = new Font("Verdana", 12);
            DGV.ClearSelection();
            DGV.Tag = "Att";

            Att_GSet();
        }
        private void btn_ExportTOExcel_Click(object sender, EventArgs e)
        {
            if (DGV.Rows.Count == 0) { return; }
            //try
            //{
            Dictionary<string, string> myDict = new Dictionary<string, string>();
            foreach (DataRow r in Device.Select().Rows)
            {
                myDict.Add(r["ID2"].ToString(), r["Name"].ToString());
            }
            string Device_Name;

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            excel.DefaultSheetDirection = (int)DGV.RightToLeft;
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 4;
            int j = 0, i = 0;
            int indexcol = 0;
            if (DGV.Columns[0].Visible == true) { indexcol = 0; } else { indexcol = 1; }

            myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Range["A1", "Z10000"];
            myRange.RowHeight = 20;
            myRange.HorizontalAlignment = 3;
            myRange.VerticalAlignment = 2;
            myRange.Font.Name = "Tahoma";
            myRange.Font.Size = 8;

            // Report Title
            if (com_Emp.Text != "")
            {
                lastcol = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, DGV.Columns.GetColumnCount(DataGridViewElementStates.Visible) - indexcol];
                myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Range["A1", lastcol];
                myRange.MergeCells = true;
                myRange.Value2 = "تقرير الحضور والإنصراف لـ " + com_Emp.Text + "    حسب نظام :  " + com_WS.Text;
                myRange.RowHeight = 30;
                myRange.HorizontalAlignment = 3;
                myRange.VerticalAlignment = 2;
                myRange.Font.Name = "Tahoma";
                myRange.Font.Color = com_Emp.ForeColor;
                myRange.Font.Size = 12;
            }
            else
            {
                StartRow--;
            }

            // Report Conditions
            lastcol = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow - 2, DGV.Columns.GetColumnCount(DataGridViewElementStates.Visible) - indexcol];
            firstrow = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow - 2, 1];

            if (dtp_From.Visible == true)
            {
                myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Range[firstrow, lastcol];
                myRange.MergeCells = true;
                string from = dtp_From.Value.ToString("dd-MM-yyyy");
                string to = dtp_To.Value.ToString("dd-MM-yyyy");
                myRange.Value2 = "من تاريخ " + from + "  " + "إلى تاريخ " + to;
                myRange.RowHeight = 30;
                myRange.HorizontalAlignment = 3;
                //myRange.Interior.Color = dtp_From.BackColor;
                myRange.Font.Color = dtp_From.ForeColor;
            }
            else
            {
                StartRow--;
            }

            //Write Headers           
            int h = 0;
            for (j = 1; j <= DGV.Columns.Count - indexcol; j++)
            {
                if (DGV.Columns[j + indexcol - 1].Visible == true)
                {
                    myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow - 1, j - h];
                    myRange.Value2 = DGV.Columns[j + indexcol - 1].HeaderText;
                    myRange.RowHeight = 30;
                    myRange.ColumnWidth = DGV.Columns[j + indexcol - 1].Width / 6;
                    myRange.Font.Size = 10;
                    myRange.Font.FontStyle = FontStyle.Bold;
                    myRange.Borders.Color = Color.Gray;
                    myRange.Interior.Color = Color.Silver;
                }
                else
                {
                    h++;
                }
            }

            //Write datagridview content
            indexcol = 0;
            for (i = 0; i < DGV.Rows.Count; i++)
            {
                h = 0;
                for (j = 0; j < DGV.Columns.Count - indexcol; j++)
                {
                    if (DGV.Columns[j].Visible == true)
                    {
                        myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j - h];
                        if (DGV.Tag.ToString() == "IO" && j == 2) // Event
                        {
                            if (DGV[j + indexcol, i].Value.ToString() == "")
                            {
                                myRange.Value2 = "";
                            }
                            else
                            {
                                myRange.Value2 = Events(Convert.ToInt16(DGV[j + indexcol, i].Value));
                            }
                        }
                        else if (DGV.Tag.ToString() == "IO" && j == 3) // Device
                        {
                            myDict.TryGetValue(DGV[j + indexcol, i].Value.ToString(), out Device_Name);
                            myRange.Value2 = Device_Name;
                        }
                        else
                        {
                            myRange.Value2 = (DGV[j + indexcol, i].Value == null) ? "" : DGV[j + indexcol, i].Value.ToString();
                        }
                    }
                    else
                    {
                        h++;
                    }
                }

                firstrow = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, 1];
                myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Range[firstrow, myRange];
                myRange.Borders.Color = Color.Gray;

                myRange.Interior.Color = (DGV.Rows[i].DefaultCellStyle.BackColor == Color.AntiqueWhite) ? DGV.Rows[i].DefaultCellStyle.BackColor : myRange.Interior.Color;

                if (i == DGV.Rows.Count - 1 && DGV.Tag.ToString() == "Att")
                {
                    myRange.Font.Color = Color.Navy;
                    myRange.Interior.Color = Color.Silver;
                    myRange.Font.Size = 10;
                }
            }

            lastcol = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[DGV.RowCount + StartRow - 1, DGV.Columns.GetColumnCount(DataGridViewElementStates.Visible) - indexcol];
            myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Range["A1", lastcol];
            myRange.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic,
            Excel.XlColorIndex.xlColorIndexAutomatic);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        private void btn_Settings_Click(object sender, EventArgs e)
        {
            frm_RepSet set = new frm_RepSet();
            set.User_ID = User_ID;
            set.DGV = DGV;
            set.ShowDialog();
        }
        private void com_Emp_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow r in dt_Emp.Rows)
            {
                if (r["ID2"].ToString() == com_Emp.SelectedValue.ToString())
                {
                    com_WS.SelectedValue = r["WS"];
                    com_Depart.SelectedValue = r["Depart"];
                    com_Sec.SelectedValue = r["Sec"];
                }
            }
        }
        private void btn_Print_Click(object sender, EventArgs e)
        {
            frm_EmpSelect.User_ID = User_ID;
            frm_EmpSelect.Emp_ID = com_Emp.SelectedValue.ToString();
            frm_EmpSelect.Demo = Demo;
            frm_EmpSelect.dtp_From.Value = dtp_From.Value;
            frm_EmpSelect.dtp_To.Value = dtp_To.Value;
            frm_EmpSelect.ShowDialog();
        }
        private void btn_WSShow_Click(object sender, EventArgs e)
        {
            if (com_WS.SelectedValue == null) return;

            frm_WorkSys ws = new frm_WorkSys();
            foreach (DataGridViewRow r in ws.dgv_WorkSys.Rows)
            {
                if (r.Cells[0].Value.ToString() == com_WS.SelectedValue.ToString())
                {
                    ws.dgv_WorkSys.CurrentCell = r.Cells[0];
                    ws.dgv_Users_CellClick(null, null);
                    break;
                }
            }
            ws.Show();
        }
        #endregion

        #region DGV
        private void DGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
        private void DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV.Tag.ToString() == "Att") { return; }
            frm_IOEdit edit = new frm_IOEdit();
            if (e.ColumnIndex == 3)
            {
                if (DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "") return;
                frm_Device device = new frm_Device();
                device.New = true;
                device.txt_ID2.Text = DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                device.ShowDialog();
            }
            else
            {
                if (DGV.Rows[e.RowIndex].Cells[1].Value.ToString() == "") return;
                edit.lbl_IOName.Text = DGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                edit.dtp.Value = Convert.ToDateTime(DGV.Rows[e.RowIndex].Cells[1].Value);
                edit.com_Event.SelectedValue = DGV.Rows[e.RowIndex].Cells[2].Value;
                edit.com_Device.SelectedValue = (DGV.Rows[e.RowIndex].Cells[3].Value == null) ? -1 : DGV.Rows[e.RowIndex].Cells[3].Value;

                edit.ShowDialog();
            }
            btn_IO_Click(null, null);

            for (int i = 0; i < DGV.RowCount; i++)
            {
                if (DGV.Rows[i].Cells[0].Value.ToString() == edit.lbl_IOName.Text)
                {
                    DGV.CurrentCell = DGV.Rows[i].Cells[1];
                    break;
                }
            }
        }
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV.Tag.ToString() == "IO" && DGV.Rows[e.RowIndex].Cells[0].Value.ToString() != "" && e.ColumnIndex == 4 | e.ColumnIndex == 5)
            {
                DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = (Convert.ToBoolean(DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == false) ? true : false;
                cls_BL.IO io = new cls_BL.IO();
                io.Index = DGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                io.Priority = Convert.ToBoolean(DGV.Rows[e.RowIndex].Cells[4].Value);
                io.Deleted = Convert.ToBoolean(DGV.Rows[e.RowIndex].Cells[5].Value);
                io.Update();              
            }
            else if (e.ColumnIndex == 6) DGV_CellDoubleClick(null, e);
        }
        #endregion

        #region Print
        Pen p = new Pen(Brushes.Black, 1);
        Font fh = new Font("Calibri", 8);
        Font fb = new Font("Calibri", 5);
        int i = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            #region Header
            e.Graphics.DrawString("Attendance Report", fh, Brushes.Black, new Rectangle(350 , 30, 200, 30));
            e.Graphics.DrawString("Employee Name : " + com_Emp.Text, fb, Brushes.Black, new Rectangle(100, 90, 200, 30));
            e.Graphics.DrawString("Attendance System : " + com_WS.Text, fb, Brushes.Black, new Rectangle(400 , 90, 200, 30));
            e.Graphics.DrawString("Department : " + com_Depart.Text, fb, Brushes.Black, new Rectangle(100, 110, 200, 30));
            e.Graphics.DrawString("Section : " + com_Sec.Text, fb, Brushes.Black, new Rectangle(400 , 110, 200, 30));
            e.Graphics.DrawString("From : " + dtp_From.Value.ToString("dd_MM_yyyy"), fb, Brushes.Black, new Rectangle(100, 130, 300, 30));
            e.Graphics.DrawString("To : " + dtp_To.Value.ToString("dd_MM_yyyy"), fb, Brushes.Black, new Rectangle(400, 130, 300, 30));
            #endregion

            #region Columns
            int left = 100;
            int top = 170;
            int last_width = 0;
            foreach (DataGridViewColumn c in DGV.Columns)
            {
                if (c.Visible == false) continue;

                e.Graphics.DrawRectangle(p, new Rectangle(left, top, DGV.Columns[c.Index].Width, DGV.Rows[0].Height));
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(left, top, DGV.Columns[c.Index].Width, DGV.Rows[0].Height));
                e.Graphics.DrawString(DGV.Columns[c.Index].HeaderText.ToString(), fb, Brushes.Black, new Rectangle(left + 8, top + 8, DGV.Columns[c.Index].Width, DGV.Rows[0].Height));

                last_width = DGV.Columns[c.Index].Width;
                left += last_width;
            }
            #endregion

            #region Rows
            top = 170;
            while(i < DGV.RowCount)
            {
                if (top > e.MarginBounds.Height)
                {
                    e.HasMorePages = true;
                    top = 100;
                    return;
                }

                left = 100;
                last_width = 0;
                top += DGV.Rows[0].Height;
                foreach (DataGridViewColumn c in DGV.Columns)
                {
                    if (c.Visible == false) continue;

                    e.Graphics.DrawRectangle(p, new Rectangle(left, top, DGV.Columns[c.Index].Width, DGV.Rows[i].Height));
                    e.Graphics.DrawString(DGV.Rows[i].Cells[c.Index].Value.ToString(), fb, Brushes.Black, new Rectangle(left + 8, top + 8, DGV.Columns[c.Index].Width, DGV.Rows[i].Height));

                    last_width = DGV.Columns[c.Index].Width;
                    left += last_width;
                }
                i++;
            }
            #endregion
        }
        #endregion
    }
}
