using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace HEGII_WHSS
{
    public partial class formOrderQuery : Form
    {
        public formOrderQuery()
        {
            InitializeComponent();
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            DataTable dtOrderQuery = new DataTable();
            string consqlserver = ConfigurationManager.ConnectionStrings["HGWHConnectionString"].ToString() + ";Password=" + Global.stringSQLPassword + ";";
            SqlConnection con = new SqlConnection(consqlserver);
            string sqlOrderQuery = getSQLOrderQuery();
            SqlDataAdapter daOrderQuery = new SqlDataAdapter(sqlOrderQuery, con);
            try
            {
                daOrderQuery.Fill(dtOrderQuery);
                if (dtOrderQuery.Rows.Count > 0)
                {
                    dataGridOrderList.DataSource = dtOrderQuery;
                    dataGridOrderList.ReadOnly = true;
                    dataGridOrderList.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dataGridOrderList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
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

            }
        }

        private void formOrderQuery_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            DataTable dtEngineerList = new DataTable();
            DataTable dtStoreCategory = new DataTable();
            string consqlserver = ConfigurationManager.ConnectionStrings["HGWHConnectionString"].ToString() + ";Password=" + Global.stringSQLPassword + ";";
            SqlConnection con = new SqlConnection(consqlserver);
            string sqlEngineerList = "SELECT EngineerName FROM EngineerList";
            SqlDataAdapter daEngineerList = new SqlDataAdapter(sqlEngineerList, con);
            string sqlStoreCategory = "SELECT StoreCategory FROM StoreCategory";
            SqlDataAdapter daStoreCategory = new SqlDataAdapter(sqlStoreCategory, con);

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
            finally
            {
                dtEngineerList.Dispose();
                dtStoreCategory.Dispose();
                daEngineerList.Dispose();
                daStoreCategory.Dispose();
                con.Close();
                con.Dispose();
            }
        }

        private void comboStoreCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtStoreList = new DataTable();
            string consqlserver = ConfigurationManager.ConnectionStrings["HGWHConnectionString"].ToString() + ";Password=" + Global.stringSQLPassword + ";";
            SqlConnection con = new SqlConnection(consqlserver);
            string sqlStoreList = "SELECT SalesStoreName " +
                                  "FROM SalesStoreList AS A " +
                                    "LEFT JOIN StoreCategory AS B " +
                                        "ON A.StoreCategoryID = B.ID " +
                                   "WHERE B.StoreCategory = '" + comboStoreCategory.Text + "'";
            SqlDataAdapter daStoreList = new SqlDataAdapter(sqlStoreList, con);

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
            finally
            {
                dtStoreList.Dispose();
                daStoreList.Dispose();
                con.Close();
                con.Dispose();
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
