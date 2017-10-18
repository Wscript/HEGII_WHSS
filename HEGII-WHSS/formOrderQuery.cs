using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace HEGII_WHSS
{
    public partial class formOrderQuery : Form
    {
        private SqlConnection conOrderQuery;

        public formOrderQuery()
        {
            InitializeComponent();
        }

        private void formOrderQuery_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            DataTable dtEngineerList = new DataTable();
            DataTable dtStoreCategory = new DataTable();
            string conSQLServer = ConfigurationManager.ConnectionStrings["HGWHConnectionString"].ToString() + ";Password=" + Global.stringSQLPassword + ";";
            conOrderQuery = new SqlConnection(conSQLServer);
            string sqlEngineerList = "SELECT EngineerName FROM EngineerList";
            SqlDataAdapter daEngineerList = new SqlDataAdapter(sqlEngineerList, conOrderQuery);
            string sqlSalesStoreCategory = "SELECT SalesStoreCategory FROM SalesStoreCategory";
            SqlDataAdapter daSalesStoreCategory = new SqlDataAdapter(sqlSalesStoreCategory, conOrderQuery);

            try
            {
                daEngineerList.Fill(dtEngineerList);
                Global.ExecutionLog("formOrderQuery", "formOrderQuery_Load", sqlEngineerList);
                if (dtEngineerList.Rows.Count > 0)
                {
                    for (int i = 0; i < dtEngineerList.Rows.Count; i++)
                    {
                        comboEngineerList.Items.Add(dtEngineerList.Rows[i]["EngineerName"].ToString());
                    }
                }
                daSalesStoreCategory.Fill(dtStoreCategory);
                Global.ExecutionLog("formOrderQuery", "formOrderQuery_Load", sqlSalesStoreCategory);
                if (dtStoreCategory.Rows.Count > 0)
                {
                    for (int i = 0; i < dtStoreCategory.Rows.Count; i++)
                    {
                        comboStoreCategory.Items.Add(dtStoreCategory.Rows[i]["SalesStoreCategory"].ToString());
                    }
                }
            }
            catch (Exception msg)
            {
                Global.ExceptionLog("formOrderQuery", "formOrderQuery_Load", sqlEngineerList + "|" + sqlSalesStoreCategory, msg.Message);
                MessageBox.Show(msg.Message);
            }
            finally
            {
                dtEngineerList.Dispose();
                dtStoreCategory.Dispose();
                daEngineerList.Dispose();
                daSalesStoreCategory.Dispose();
            }
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            DataTable dtOrderQuery = new DataTable();
            string sqlOrderQuery = getSQLOrderQuery();
            SqlDataAdapter daOrderQuery = new SqlDataAdapter(sqlOrderQuery, conOrderQuery);

            try
            {
                dataGridOrderList.Rows.Clear();
                dataGridOrderList.Columns.Clear();
                daOrderQuery.Fill(dtOrderQuery);
                Global.ExecutionLog("formOrderQuery", "buttonQuery_Click", sqlOrderQuery);
                if (dtOrderQuery.Rows.Count > 0)
                {
                    Global.DataGridFill(dataGridOrderList, dtOrderQuery);
                    dataGridOrderList.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dataGridOrderList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridOrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridOrderList.ReadOnly = true;
                    dataGridOrderList.AllowUserToAddRows = false;
                }
                else
                {
                    dataGridOrderList.DataSource = null;
                }
            }
            catch (Exception msg)
            {
                Global.ExceptionLog("formOrderQuery", "buttonQuery_Click", sqlOrderQuery, msg.Message);
                MessageBox.Show(msg.Message);
            }
            finally
            {
                dtOrderQuery.Dispose();
                daOrderQuery.Dispose();
            }
        }
        
        private void comboStoreCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtStoreList = new DataTable();
            string sqlStoreList = "SELECT SalesStoreName " +
                                  "FROM SalesStoreList AS A " +
                                    "LEFT JOIN SalesStoreCategory AS B " +
                                        "ON A.StoreCategoryID = B.ID " +
                                   "WHERE B.SalesStoreCategory = '" + comboStoreCategory.Text + "'";
            SqlDataAdapter daStoreList = new SqlDataAdapter(sqlStoreList, conOrderQuery);
            try
            {
                daStoreList.Fill(dtStoreList);
                Global.ExecutionLog("formOrderQuery", "comboStoreCategory_SelectedIndexChanged", sqlStoreList);
                comboStoreList.Items.Clear();
                comboStoreList.Text = "";
                if (dtStoreList.Rows.Count>0)
                {

                    for (int i = 0; i < dtStoreList.Rows.Count; i++)
                    {
                        comboStoreList.Items.Add(dtStoreList.Rows[i]["SalesStoreName"].ToString());
                    }
                }
            }
            catch (Exception msg)
            {
                Global.ExceptionLog("formOrderQuery", "comboStoreCategory_SelectedIndexChanged", sqlStoreList, msg.Message);
                MessageBox.Show(msg.Message);
            }
            finally
            {
                dtStoreList.Dispose();
                daStoreList.Dispose();
            }
        }

        private string getSQLOrderQuery()
        {
            DateTime.TryParse(dateTimeReserveStart.Text.ToString(), out DateTime dtReserveStart);
            DateTime.TryParse(dateTimeReserveEnd.Text.ToString(), out DateTime dtReserveEnd);
            string sqlOrderQuery = "EXEC progOrderQuery '" +
                       dtReserveStart.ToString() + "','" +
                       dtReserveEnd.ToString() + "'";
            if (comboEngineerList.Text == "")
            {
                sqlOrderQuery = sqlOrderQuery + ",NULL";
            }
            else
            {
                sqlOrderQuery = sqlOrderQuery + ",'" + comboEngineerList.Text + "'";
            }
            if (comboStoreCategory.Text == "")
            {
                sqlOrderQuery = sqlOrderQuery + ",NULL";
            }
            else
            {
                sqlOrderQuery = sqlOrderQuery + ",'" + comboStoreCategory.Text + "'";
            }
            if (comboStoreList.Text == "")
            {
                sqlOrderQuery = sqlOrderQuery + ",NULL";
            }
            else
            {
                sqlOrderQuery = sqlOrderQuery + ",'" + comboStoreList.Text + "'";
            }
            if (textCustAddress.Text == "")
            {
                sqlOrderQuery = sqlOrderQuery + ",NULL";
            }
            else
            {
                sqlOrderQuery = sqlOrderQuery + ",'" + textCustAddress.Text + "'";
            }
            if (textCustPhone.Text == "")
            {
                sqlOrderQuery = sqlOrderQuery + ",NULL";
            }
            else
            {
                sqlOrderQuery = sqlOrderQuery + ",'" + textCustPhone.Text + "'";
            }

            return sqlOrderQuery;
        }

        private void formOrderQuery_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conOrderQuery != null)
            {
                conOrderQuery.Close();
                conOrderQuery.Dispose();
            }
        }
    }
}
