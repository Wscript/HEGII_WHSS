using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace HEGII_WHSS
{
    public partial class formOrderQuery : Form
    {
        private DataTable dtStoreList, dtOrderQuery;
        private SqlDataAdapter daStoreList, daOrderQuery;
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
                if (dtEngineerList.Rows.Count > 0)
                {
                    for (int i = 0; i < dtEngineerList.Rows.Count; i++)
                    {
                        comboEngineerList.Items.Add(dtEngineerList.Rows[i]["EngineerName"].ToString());
                    }
                }
                daSalesStoreCategory.Fill(dtStoreCategory);
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
                if (dtOrderQuery.Rows.Count > 0)
                {
                    //dataGridOrderList.DataSource = dtOrderQuery;
                    dataGridOrderList.ColumnCount = dtOrderQuery.Columns.Count;
                    for (int i = 0; i < dtOrderQuery.Columns.Count; i++)
                    {
                        dataGridOrderList.Columns[i].Name = dtOrderQuery.Columns[i].Caption;
                    }
                    for (int i = 0; i < dtOrderQuery.Rows.Count; i++)
                    {
                        dataGridOrderList.Rows.Add();
                        for (int j = 0; j < dtOrderQuery.Columns.Count; j++)
                        {
                            dataGridOrderList.Rows[i].Cells[j].Value = dtOrderQuery.Rows[i][j];
                        }
                    }

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
