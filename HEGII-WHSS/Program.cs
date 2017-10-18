using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;

namespace HEGII_WHSS
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formLogin formLogin = new formLogin();
            formLogin.ShowDialog();
            if (formLogin.DialogResult == DialogResult.OK)
            {
                Application.Run(new formMDIMain());
            }
        }
    }

    public class Global
    {
        public static string stringUserName;
        public static string stringSQLPassword = "Ymlixxc1";

        public static void DataGridFill(DataGridView dataGridView, DataTable dataTable)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            dataGridView.ColumnCount = dataTable.Columns.Count;

            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                dataGridView.Columns[i].Name = dataTable.Columns[i].Caption;
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataGridView.Rows.Add();
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = dataTable.Rows[i][j];
                }
            }
        }

        public static void ExecutionLog(String FormName, String ModuleName, String SQLString)
        {
            string conSQLServer = ConfigurationManager.ConnectionStrings["HGWHConnectionString"].ToString() + ";Password=" + Global.stringSQLPassword + ";";
            SqlConnection conExecutionLog = new SqlConnection(conSQLServer);
            SqlCommand sqlCommandExecutionLog = new SqlCommand();
            sqlCommandExecutionLog.Connection = conExecutionLog;
            SQLString = SQLString.Replace("'", "''");
            string sqlExecutionLog = String.Format("INSERT INTO ExecutionLog (UserName, ComputerName, FormName, ModuleName, SQLString, ExecutionTime) " +
                                                   "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', GETDATE())",
                                                   Global.stringUserName,
                                                   Dns.GetHostName(),
                                                   FormName,
                                                   ModuleName,
                                                   SQLString);
            sqlCommandExecutionLog.CommandText = sqlExecutionLog;
            try
            {
                conExecutionLog.Open();
                sqlCommandExecutionLog.ExecuteNonQuery();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
            finally
            {
                sqlCommandExecutionLog.Dispose();
                conExecutionLog.Close();
                conExecutionLog.Dispose();
            }
        }

        public static void ExceptionLog(String FormName, String ModuleName, String SQLString, String ExceptionMsg)
        {
            string conSQLServer = ConfigurationManager.ConnectionStrings["HGWHConnectionString"].ToString() + ";Password=" + Global.stringSQLPassword + ";";
            SqlConnection conExceptionLog = new SqlConnection(conSQLServer);
            SqlCommand sqlCommandExceptionLog = new SqlCommand();
            sqlCommandExceptionLog.Connection = conExceptionLog;
            SQLString = SQLString.Replace("'", "''");
            string sqlExecutionLog = String.Format("INSERT INTO ExecutionLog (UserName, ComputerName, FormName, ModuleName, SQLString, ExceptionMsg, ExecutionTime) " +
                                                   "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', GETDATE())",
                                                   Global.stringUserName,
                                                   Dns.GetHostName(),
                                                   FormName,
                                                   ModuleName,
                                                   SQLString,
                                                   ExceptionMsg);
            sqlCommandExceptionLog.CommandText = sqlExecutionLog;
            try
            {
                conExceptionLog.Open();
                sqlCommandExceptionLog.ExecuteNonQuery();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
            finally
            {
                sqlCommandExceptionLog.Dispose();
                conExceptionLog.Close();
                conExceptionLog.Dispose();
            }
        }
    }
}
