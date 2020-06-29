using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Attendance
{
    public class cls_DAL
    {
        SQLiteConnection con;

        // This Constractor Inisialize The connection object
        public cls_DAL()
        {
            con = new SQLiteConnection(@"Data Source = Att.db");
        }

        // Method to open the connecton
        public void open()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        // Method to close the connecton
        public void Close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        // Method To Read Data From Database
        public DataTable SelectData(string Text, SQLiteParameter[] param)
        {
            DataTable dt = new DataTable();
            try
            {
                SQLiteCommand sqlcmd = new SQLiteCommand();
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.CommandText = Text;
                sqlcmd.Connection = con;

                if (param != null)
                {
                    for (int i = 0; i < param.Length; i++)
                    {
                        sqlcmd.Parameters.Add(param[i]);
                    }
                }

                SQLiteDataAdapter da = new SQLiteDataAdapter(sqlcmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Access", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return dt;
        }
        public DataTable SelectData(string Text)
        {
            DataTable dt = new DataTable();
            try
            {
                SQLiteCommand sqlcmd = new SQLiteCommand();
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.CommandText = Text;
                sqlcmd.Connection = con;

                SQLiteDataAdapter da = new SQLiteDataAdapter(sqlcmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Access", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return dt;
        }

        // Method To Insert, Update and Delete Data From Database
        public string ExecuteCommand(string Text, SQLiteParameter[] param)
        {
            SQLiteCommand sqlcmd = new SQLiteCommand();
            string s;
            try
            {
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.CommandText = Text;
                sqlcmd.Connection = con;

                if (param != null)
                {
                    sqlcmd.Parameters.AddRange(param);
                }

                foreach (IDataParameter p in sqlcmd.Parameters)
                {
                    if (p.Value == null) p.Value = DBNull.Value;
                }
                s = (string)sqlcmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExecuteCommand", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                s = "!" + ex.Message;
            }
            return s;
        }
    }
}
