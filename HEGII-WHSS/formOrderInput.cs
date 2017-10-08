using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HEGII_WHSS
{
    public partial class formOrderInput : Form
    {
        private SqlConnection conformOrderInput;

        public formOrderInput()
        {
            InitializeComponent();
        }

        private void formOrderInput_Load(object sender, EventArgs e)
        {
            DataTable dtOrderTypeList = new DataTable();
            DataTable dtApplyWayList = new DataTable();
            DataTable dtSalesStoreCategory = new DataTable();
            DataTable dtServiceLocation = new DataTable();

            this.WindowState = FormWindowState.Maximized;

            dateTimeFilingDate.Value = DateTime.Now;
            dateTimeReserveDate.Value = DateTime.Now.AddDays(1);

            string conSQLServer = ConfigurationManager.ConnectionStrings["HGWHConnectionString"].ToString() + ";Password=" + Global.stringSQLPassword + ";";
            conformOrderInput = new SqlConnection(conSQLServer);
            string sqlOrderTypeList = "SELECT OrderType FROM OrderTypeList";
            string sqlApplyWayList = "SELECT ApplyWay FROM ApplyWayList";
            string sqlSalesStoreCategory = "SELECT SalesStoreCategory FROM SalesStoreCategory";
            string sqlServiceLocation = "SELECT ServiceLocation FROM ServiceLocation";
            SqlDataAdapter daOrderTypeList = new SqlDataAdapter(sqlOrderTypeList, conformOrderInput);
            SqlDataAdapter daApplyWayList = new SqlDataAdapter(sqlApplyWayList, conformOrderInput);
            SqlDataAdapter daSalesStoreCategory = new SqlDataAdapter(sqlSalesStoreCategory, conformOrderInput);
            SqlDataAdapter daServiceLocation = new SqlDataAdapter(sqlServiceLocation, conformOrderInput);
            try
            {
                daApplyWayList.Fill(dtApplyWayList);
                if (dtApplyWayList.Rows.Count > 0)
                {
                    for (int i = 0; i < dtApplyWayList.Rows.Count; i++)
                    {
                        comboApplyWayList.Items.Add(dtApplyWayList.Rows[i]["ApplyWay"]);
                    }
                }

                daOrderTypeList.Fill(dtOrderTypeList);
                if (dtOrderTypeList.Rows.Count > 0)
                {
                    for (int i = 0; i < dtOrderTypeList.Rows.Count; i++)
                    {
                        comboOrderTypeList.Items.Add(dtOrderTypeList.Rows[i]["OrderType"]);
                    }
                }

                daSalesStoreCategory.Fill(dtSalesStoreCategory);
                if (dtSalesStoreCategory.Rows.Count > 0)
                {
                    for (int i = 0; i < dtSalesStoreCategory.Rows.Count; i++)
                    {
                        comboSalesStoreCategory.Items.Add(dtSalesStoreCategory.Rows[i]["SalesStoreCategory"]);
                    }
                }

                daServiceLocation.Fill(dtServiceLocation);
                if (dtServiceLocation.Rows.Count > 0)
                {
                    for (int i = 0; i < dtServiceLocation.Rows.Count; i++)
                    {
                        comboServiceLocation.Items.Add(dtServiceLocation.Rows[i]["ServiceLocation"]);
                    }
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
            finally
            {
                dtApplyWayList.Dispose();
                dtOrderTypeList.Dispose();
                dtSalesStoreCategory.Dispose();
                dtServiceLocation.Dispose();

                daApplyWayList.Dispose();
                daOrderTypeList.Dispose();
                daSalesStoreCategory.Dispose();
                daServiceLocation.Dispose();

            }
        }

        private void comboSalesStoreType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtSalesStoreList = new DataTable();
            string sqlSalesStoreList = "SELECT A.SalesStoreName " +
                                       "FROM SalesStoreList AS A " +
                                            "LEFT JOIN SalesStoreCategory AS B " +
                                                "ON A.StoreCategoryID = B.ID " +
                                       "WHERE B.SalesStoreCategory = '" + comboSalesStoreCategory.Text + "'";
            SqlDataAdapter daSalesStoreList = new SqlDataAdapter(sqlSalesStoreList, conformOrderInput);
            try
            {
                daSalesStoreList.Fill(dtSalesStoreList);
                comboSalesStoreList.Items.Clear();
                if (dtSalesStoreList.Rows.Count > 0)
                {
                    for (int i = 0; i < dtSalesStoreList.Rows.Count; i++)
                    {
                        comboSalesStoreList.Items.Add(dtSalesStoreList.Rows[i]["SalesStoreName"]);
                    }
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
            finally
            {
                dtSalesStoreList.Dispose();
                daSalesStoreList.Dispose();
            }
        }

        private void comboServiceLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtServiceLocation = new DataTable();
            string sqlServiceLocation = "SELECT A.ServiceArea " +
                                        "FROM ServiceArea AS A " +
                                            "LEFT JOIN ServiceLocation AS B " +
                                                "ON A.ServiceLocationID = B.ID " +
                                        "WHERE B.ServiceLocation = '" + comboServiceLocation.Text + "'"; ;
            SqlDataAdapter daServiceLocation = new SqlDataAdapter(sqlServiceLocation, conformOrderInput);
            try
            {
                daServiceLocation.Fill(dtServiceLocation);
                comboServiceArea.Items.Clear();
                if (dtServiceLocation.Rows.Count > 0)
                {
                    for (int i = 0; i < dtServiceLocation.Rows.Count; i++)
                    {
                        comboServiceArea.Items.Add(dtServiceLocation.Rows[i]["ServiceArea"]);
                    }
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
            finally
            {
                dtServiceLocation.Dispose();
                daServiceLocation.Dispose();
            }
        }

        private void formOrderInput_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conformOrderInput != null)
            {
                conformOrderInput.Close();
                conformOrderInput.Dispose();
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (ValidityCheck() == true)
            {
                MessageBox.Show("有必填项为空,请核对后再提交！");
            }
            else
            {
                int InsertOrderID = InsertOrder(GetCustInfoID());
                MessageBox.Show(InsertOrderID.ToString());
            }
        }

        private bool ValidityCheck()
        {
            bool ValidityCheck = false;
            if (comboSalesStoreList.Text == "")
            {
                ValidityCheck = true;
            }
            if (textCustPhone.Text == "")
            {
                ValidityCheck = true;
            }
            if (textCustAddress.Text == "")
            {
                ValidityCheck = true;
            }
            if (comboServiceArea.Text == "")
            {
                ValidityCheck = true;
            }
            if (comboOrderTypeList.Text == "")
            {
                ValidityCheck = true;
            }
            if (comboApplyWayList.Text == "")
            {
                ValidityCheck = true;
            }
            if (textPNAndQTY.Text == "")
            {
                ValidityCheck = true;
            }
            return ValidityCheck;
        }

        private int GetCustInfoID()
        {
            int intCustInfoID = 0;
            DataTable dtGetOrderInfo = new DataTable();
            DataTable dtInsertCustInfo = new DataTable();
            string sqlGetOrderInfo = "EXEC progGetCustInfo '" + textCustAddress.Text + "','" + textCustPhone.Text + "'";
            string sqlInsertCustInfo = "EXEC progInsertCustInfo '" + textCustAddress.Text + "', '" + textCustPhone.Text + "'";
            if (textCustName.Text == "")
            {
                sqlInsertCustInfo = sqlInsertCustInfo + ", NULL";
            }
            else
            {
                sqlInsertCustInfo = sqlInsertCustInfo + ", '" + textCustName.Text + "'";
            }
            if (comboServiceArea.Text == null)
            {
                sqlInsertCustInfo = sqlInsertCustInfo + ", NULL";
            }
            else
            {
                sqlInsertCustInfo = sqlInsertCustInfo + ", '" + comboServiceArea.Text + "'";
            }
            SqlDataAdapter daGetOrderInfo = new SqlDataAdapter(sqlGetOrderInfo, conformOrderInput);
            SqlDataAdapter daInsertCustInfo = new SqlDataAdapter(sqlInsertCustInfo, conformOrderInput);
            try
            {
                daGetOrderInfo.Fill(dtGetOrderInfo);
                if (dtGetOrderInfo.Rows.Count > 0)
                {
                    intCustInfoID = (int)dtGetOrderInfo.Rows[0][0];
                }
                else
                {
                    daInsertCustInfo.Fill(dtInsertCustInfo);
                    if (dtInsertCustInfo.Rows.Count > 0)
                    {
                        intCustInfoID = (int)dtInsertCustInfo.Rows[0][0];
                    }
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
            finally
            {
                dtGetOrderInfo.Dispose();
                dtInsertCustInfo.Dispose();
                daGetOrderInfo.Dispose();
                daInsertCustInfo.Dispose();
            }
            return intCustInfoID;
        }

        private int InsertOrder(int intCustInfoID)
        {
            int intInsertOrderID = 0;
            DataTable dtGetOrder = new DataTable();
            DataTable dtInsertOrder = new DataTable();

            string sqlGetOrder = "EXEC progGetOrder " + intCustInfoID.ToString() + " ";
            if (checkReserveHold.Checked)
            {
                sqlGetOrder = sqlGetOrder + ",NULL ";
            }
            else
            {
                sqlGetOrder = sqlGetOrder + ",'" + dateTimeReserveDate.Value.ToString() + "' ";
            }
            if (textPNAndQTY.Text == "")
            {
                sqlGetOrder = sqlGetOrder + ",NULL ";
            }
            else
            {
                sqlGetOrder = sqlGetOrder + ",'" + textPNAndQTY.Text + "' ";
            }
            if (comboOrderTypeList.Text == "")
            {
                sqlGetOrder = sqlGetOrder + ",NULL ";
            }
            else
            {
                sqlGetOrder = sqlGetOrder + ",'" + comboOrderTypeList.Text + "' ";
            }

            string sqlInsertOrder = "EXEC progInsertOrder " + intCustInfoID.ToString() + " ";
            if (comboApplyWayList.Text == "")
            {
                sqlInsertOrder = sqlInsertOrder + ",NULL ";
            }
            else
            {
                sqlInsertOrder = sqlInsertOrder + ",'" + comboApplyWayList.Text + "' ";
            }
            sqlInsertOrder = sqlInsertOrder + ",'" + dateTimeFilingDate.Value.ToString() + "' ";
            if (checkReserveHold.Checked)
            {
                sqlInsertOrder = sqlInsertOrder + ",NULL ";
            }
            else
            {
                sqlInsertOrder = sqlInsertOrder + ",'" + dateTimeReserveDate.Value.ToString() + "' ";
            }
            if (comboSalesStoreList.Text == "")
            {
                sqlInsertOrder = sqlInsertOrder + ",NULL ";
            }
            else
            {
                sqlInsertOrder = sqlInsertOrder + ",'" + comboSalesStoreList.Text + "' ";
            }
            if (comboOrderTypeList.Text == "")
            {
                sqlInsertOrder = sqlInsertOrder + ",NULL ";
            }
            else
            {
                sqlInsertOrder = sqlInsertOrder + ",'" + comboOrderTypeList.Text + "' ";
            }
            if (checkIsTemporary.Checked)
            {
                sqlInsertOrder = sqlInsertOrder + ",1 ";
            }
            else
            {
                sqlInsertOrder = sqlInsertOrder + ",0 ";
            }
            if (textPNAndQTY.Text == "")
            {
                sqlInsertOrder = sqlInsertOrder + ",NULL ";
            }
            else
            {
                sqlInsertOrder = sqlInsertOrder + ",'" + textPNAndQTY.Text + "' ";
            }
            if (textOperatorMemo.Text == "")
            {
                sqlInsertOrder = sqlInsertOrder + ",NULL ";
            }
            else
            {
                sqlInsertOrder = sqlInsertOrder + ",'" + textOperatorMemo.Text + "' ";
            }
            sqlInsertOrder = sqlInsertOrder + ",'待上门' ,NULL";

            SqlDataAdapter daGetOrder = new SqlDataAdapter(sqlGetOrder, conformOrderInput);
            SqlDataAdapter daInsertOrder = new SqlDataAdapter(sqlInsertOrder, conformOrderInput);
            try
            {
                daGetOrder.Fill(dtGetOrder);
                if (dtGetOrder.Rows.Count > 0)
                {
                    intInsertOrderID = (int)dtGetOrder.Rows[0][0];
                }
                else
                {
                    daInsertOrder.Fill(dtInsertOrder);
                    intInsertOrderID = (int)dtInsertOrder.Rows[0][0];
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
            finally
            {
                dtGetOrder.Dispose();
                dtInsertOrder.Dispose();
                daGetOrder.Dispose();
                daGetOrder.Dispose();
            }
            return intInsertOrderID;
        }
    }
}
