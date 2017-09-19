using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace HEGII_WHSS
{
    public partial class formOrderQuery : Form
    {
        private DataTable dtEngineerList, dtStoreCategory, dtStoreList, dtOrderQuery;
        private SqlDataAdapter daEngineerList,daStoreCategory, daStoreList, daOrderQuery;
        private SqlConnection conOrderQuery;

        public formOrderQuery()
        {
            InitializeComponent();
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            dtOrderQuery = new DataTable();
            string sqlOrderQuery = getSQLOrderQuery();
            daOrderQuery = new SqlDataAdapter(sqlOrderQuery, conOrderQuery);

            try
            {
                daOrderQuery.Fill(dtOrderQuery);
                if (dtOrderQuery.Rows.Count > 0)
                {
                    dataGridOrderList.DataSource = dtOrderQuery;
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
        }

        private void formOrderQuery_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            dtEngineerList = new DataTable();
            dtStoreCategory = new DataTable();
            string conSQLServer = ConfigurationManager.ConnectionStrings["HGWHConnectionString"].ToString() + ";Password=" + Global.stringSQLPassword + ";";
            conOrderQuery = new SqlConnection(conSQLServer);
            string sqlEngineerList = "SELECT EngineerName FROM EngineerList";
            daEngineerList = new SqlDataAdapter(sqlEngineerList, conOrderQuery);
            string sqlStoreCategory = "SELECT StoreCategory FROM StoreCategory";
            daStoreCategory = new SqlDataAdapter(sqlStoreCategory, conOrderQuery);

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
                daStoreCategory.Fill(dtStoreCategory);
                if (dtStoreCategory.Rows.Count > 0)
                {
                    for (int i = 0; i < dtStoreCategory.Rows.Count; i++)
                    {
                        comboStoreCategory.Items.Add(dtStoreCategory.Rows[i]["StoreCategory"].ToString());
                    }
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }

        private void formOrderQuery_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dtEngineerList != null)
            {
                dtEngineerList.Dispose();
            }
            if (dtStoreCategory != null)
            {
                dtStoreCategory.Dispose();
            }
            if (dtStoreList != null)
            {
                dtStoreList.Dispose();
            }
            if (dtOrderQuery != null)
            {
                dtOrderQuery.Dispose();
            }

            if (daEngineerList != null)
            {
                daEngineerList.Dispose();
            }
            if (daStoreCategory != null)
            {
                daStoreCategory.Dispose();
            }
            if (daStoreList != null)
            {
                daStoreList.Dispose();
            }
            if (daOrderQuery != null)
            {
                daOrderQuery.Dispose();
            }

            if (conOrderQuery != null)
            {
                conOrderQuery.Close();
                conOrderQuery.Dispose();
            }
        }

        private void comboStoreCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtStoreList = new DataTable();
            string sqlStoreList = "SELECT SalesStoreName " +
                                  "FROM SalesStoreList AS A " +
                                    "LEFT JOIN StoreCategory AS B " +
                                        "ON A.StoreCategoryID = B.ID " +
                                   "WHERE B.StoreCategory = '" + comboStoreCategory.Text + "'";
            daStoreList = new SqlDataAdapter(sqlStoreList, conOrderQuery);

            try
            {
                daStoreList.Fill(dtStoreList);
                if (dtStoreList.Rows.Count>0)
                {
                    comboStoreList.Text = "";
                    comboStoreList.Items.Clear();
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
    }
}
