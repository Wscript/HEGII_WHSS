﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HEGII_WHSS
{
    public partial class formWarehouseMgt : Form
    {
        private SqlConnection conWarehouseMgt;
        private int intNewRowIndex = -1, intChangeRowIndex = -1;
        private int intIDColumn, intIsAvailableColmun;
        private string sqlWarehouseChange,sqlUsedLocation;

        public formWarehouseMgt()
        {
            InitializeComponent();
        }

        private void formWarehouseMgt_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            buttonChangeSave.Enabled = false;
            buttonWarehouseAdd.Enabled = false;
            buttonWarehouseDisable.Enabled = false;

            string conSQLServer = ConfigurationManager.ConnectionStrings["HGWHConnectionString"].ToString() + ";Password=" + Global.stringSQLPassword + ";";
            conWarehouseMgt = new SqlConnection(conSQLServer);
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            DataTable dtWarehouseQuery = new DataTable();
            string sqlWarehouseQuery = getSQLWarehouseQuery();
            SqlDataAdapter daWarehouseQuery = new SqlDataAdapter(sqlWarehouseQuery, conWarehouseMgt);
            try
            {
                dtWarehouseQuery.Clear();
                daWarehouseQuery.Fill(dtWarehouseQuery);
                Global.ExecutionLog("formWarehouseMgt", "buttonQuery_Click", sqlWarehouseQuery);
                dataGridWarehouse.Rows.Clear();
                dataGridWarehouse.Columns.Clear();
                if (dtWarehouseQuery.Rows.Count > 0)
                {
                    Global.DataGridFill(dataGridWarehouse, dtWarehouseQuery);
                    for (int i = 0; i < dataGridWarehouse.ColumnCount ; i++)
                    {
                        if (dataGridWarehouse.Columns[i].Name == "序号")
                        {
                            intIDColumn = i;
                        }
                        if (dataGridWarehouse.Columns[i].Name == "是否可用")
                        {
                            intIsAvailableColmun = i;
                        }
                    }
                    dataGridWarehouse.ReadOnly = true;
                    dataGridWarehouse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridWarehouse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridWarehouse.AllowUserToAddRows = false;

                    buttonChangeSave.Enabled = true;
                    buttonWarehouseAdd.Enabled = true;
                    buttonWarehouseDisable.Enabled = true;
                }
                else
                {
                    dataGridWarehouse.DataSource = null;
                }
            }
            catch (Exception msg)
            {
                Global.ExceptionLog("formWarehouseMgt", "buttonQuery_Click", sqlWarehouseQuery, msg.Message);
                MessageBox.Show(msg.Message);
            }
            finally
            {
                dtWarehouseQuery.Dispose();
                daWarehouseQuery.Dispose();
            }
        }

        private void buttonWarehouseAdd_Click(object sender, EventArgs e)
        {
            if (intNewRowIndex == -1 & intChangeRowIndex == -1)
            {
                intNewRowIndex = dataGridWarehouse.Rows.Add();
                dataGridWarehouse.ReadOnly = false;
                dataGridWarehouse.Columns[intIDColumn].ReadOnly = true;
                dataGridWarehouse.Columns[intIsAvailableColmun].ReadOnly = true;
                dataGridWarehouse.SelectionMode = DataGridViewSelectionMode.CellSelect;
                dataGridWarehouse.Rows[intNewRowIndex].Cells[intIsAvailableColmun].Value = "是";
            }
            else
            {
                MessageBox.Show("当前的修改尚未保存，无法新增仓库！");
            }
        }

        private void buttonChangeSave_Click(object sender, EventArgs e)
        {
            if (intNewRowIndex == -1 & intChangeRowIndex == -1)
            {
                MessageBox.Show("没有需要更改的内容");
            }
            else
            {
                DataTable dtWarehouseChange = new DataTable();
                if (intChangeRowIndex >= 0)
                {
                    sqlWarehouseChange = getSQLUpdate();
                }
                if (intNewRowIndex >= 0)
                {
                    sqlWarehouseChange = getSQLInsert();
                }
                SqlDataAdapter daWarehouseChange = new SqlDataAdapter(sqlWarehouseChange,conWarehouseMgt);
                try
                {
                    daWarehouseChange.Fill(dtWarehouseChange);
                    Global.ExecutionLog("formWarehouseMgt", "buttonChangeSave_Click", sqlWarehouseChange);
                    if (dtWarehouseChange.Rows.Count > 0)
                    {
                        buttonQuery.PerformClick();
                        intChangeRowIndex = -1;
                        intNewRowIndex = -1;
                        dataGridWarehouse.ReadOnly = true;
                        dataGridWarehouse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                }
                catch (Exception msg)
                {
                    Global.ExceptionLog("formWarehouseMgt", "buttonChangeSave_Click", sqlWarehouseChange, msg.Message);
                    MessageBox.Show(msg.Message);
                }
                finally
                {
                    dtWarehouseChange.Dispose();
                    daWarehouseChange.Dispose();
                }
            }
        }

        private void buttonWarehouseDisable_Click(object sender, EventArgs e)
        {
            if (intNewRowIndex == -1 & intChangeRowIndex == -1)
            {
                if (dataGridWarehouse.SelectedRows.Count > 0)
                {
                    DataTable dtUsedLocation = new DataTable();
                    for (int i = 0; i < dataGridWarehouse.SelectedRows.Count; i++)
                    {
                        sqlUsedLocation = "EXEC progGetUsedLocation " + dataGridWarehouse.SelectedRows[i].Cells[intIDColumn].Value.ToString();
                        SqlDataAdapter daUsedLocation = new SqlDataAdapter(sqlUsedLocation,conWarehouseMgt);
                        try
                        {
                            daUsedLocation.Fill(dtUsedLocation);
                            Global.ExecutionLog("formWarehouseMgt", "buttonWarehouseDisable_Click", sqlUsedLocation);
                            if (dtUsedLocation.Rows.Count >0)
                            {
                                MessageBox.Show("仓库还有" + dtUsedLocation.Rows.Count.ToString() +"个型号的产品没有清空，请清空后再禁用！");
                            }
                            else
                            {
                                if (dataGridWarehouse.SelectedRows[i].Cells[intIsAvailableColmun].Value.ToString() == "是")
                                {
                                    dataGridWarehouse.SelectedRows[i].Cells[intIsAvailableColmun].Value = "否";
                                }
                                else
                                {
                                    dataGridWarehouse.SelectedRows[i].Cells[intIsAvailableColmun].Value = "是";
                                }
                                intChangeRowIndex = dataGridWarehouse.SelectedRows[i].Index;
                                buttonChangeSave.PerformClick();
                            }
                        }
                        catch (Exception msg)
                        {
                            Global.ExceptionLog("formWarehouseMgt", "buttonWarehouseDisable_Click", sqlUsedLocation, msg.Message);
                            MessageBox.Show(msg.Message);
                        }
                        finally
                        {
                            dtUsedLocation.Dispose();
                            daUsedLocation.Dispose();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("没有选择需要禁用的仓库!");
                }
            }
            else
            {
                MessageBox.Show("当前的修改尚未保存，无法禁用仓库！");
            }
        }

        private void dataGridWerahouse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (intNewRowIndex == -1 & intChangeRowIndex == -1)
            {
                dataGridWarehouse.ReadOnly = false;
                dataGridWarehouse.Columns[intIDColumn].ReadOnly = true;
                dataGridWarehouse.Columns[intIsAvailableColmun].ReadOnly = true;
                dataGridWarehouse.SelectionMode = DataGridViewSelectionMode.CellSelect;
                intChangeRowIndex = e.RowIndex;
            }
        }

        private void formWerahouseMgt_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conWarehouseMgt != null)
            {
                conWarehouseMgt.Close();
                conWarehouseMgt.Dispose();
            }
        }

        private string getSQLWarehouseQuery()
        {
            string sqlWarehouseQuery = "EXEC progWarehouseQuery ";
            if (textWarehouseName.Text == "")
            {
                sqlWarehouseQuery = sqlWarehouseQuery + "NULL";
            }
            else
            {
                sqlWarehouseQuery = sqlWarehouseQuery + "'" + textWarehouseName.Text + "'";
            }
            if (textWarehouseCode.Text == "")
            {
                sqlWarehouseQuery = sqlWarehouseQuery + ",NULL";
            }
            else
            {
                sqlWarehouseQuery = sqlWarehouseQuery + ",'" + textWarehouseCode.Text + "'";
            }
            if (checkIsAvailable.Checked)
            {
                sqlWarehouseQuery = sqlWarehouseQuery + ",0";
            }
            else
            {
                sqlWarehouseQuery = sqlWarehouseQuery + ",1";
            }

            return sqlWarehouseQuery;
        }

        private string getSQLInsert()
        {
            string stringSQLInsert = "EXEC [dbo].[progInsertWarehouse] ";
            stringSQLInsert = stringSQLInsert + "'" + dataGridWarehouse.Rows[intNewRowIndex].Cells[1].Value.ToString() + "',";
            stringSQLInsert = stringSQLInsert + "'" + dataGridWarehouse.Rows[intNewRowIndex].Cells[2].Value.ToString() + "',";
            stringSQLInsert = stringSQLInsert + "'" + dataGridWarehouse.Rows[intNewRowIndex].Cells[3].Value.ToString() + "',";
            if (dataGridWarehouse.Rows[intNewRowIndex].Cells[4].Value == null)
            {
                stringSQLInsert = stringSQLInsert + "null,";
            }
            else
            {
                stringSQLInsert = stringSQLInsert + "'" + dataGridWarehouse.Rows[intNewRowIndex].Cells[4].Value.ToString() + "',";
            }
            if (dataGridWarehouse.Rows[intNewRowIndex].Cells[5].Value.ToString() == "是")
            {
                stringSQLInsert = stringSQLInsert + "1";
            }
            else
            {
                stringSQLInsert = stringSQLInsert + "0";
            }

            return stringSQLInsert;
        }

        private string getSQLUpdate()
        {
            string stringSQLUpdate = "EXEC [dbo].[progUpdateWarehouse] ";
            stringSQLUpdate = stringSQLUpdate + dataGridWarehouse.Rows[intChangeRowIndex].Cells[0].Value.ToString() + ",";
            stringSQLUpdate = stringSQLUpdate + "'" + dataGridWarehouse.Rows[intChangeRowIndex].Cells[1].Value.ToString() + "',";
            stringSQLUpdate = stringSQLUpdate + "'" + dataGridWarehouse.Rows[intChangeRowIndex].Cells[2].Value.ToString() + "',";
            stringSQLUpdate = stringSQLUpdate + "'" + dataGridWarehouse.Rows[intChangeRowIndex].Cells[3].Value.ToString() + "',";
            if (dataGridWarehouse.Rows[intChangeRowIndex].Cells[4].Value == null)
            {
                stringSQLUpdate = stringSQLUpdate + "null,";
            }
            else
            {
                stringSQLUpdate = stringSQLUpdate + "'" + dataGridWarehouse.Rows[intChangeRowIndex].Cells[4].Value.ToString() + "',";
            }
            if (dataGridWarehouse.Rows[intChangeRowIndex].Cells[5].Value.ToString() == "是")
            {
                stringSQLUpdate = stringSQLUpdate + "1";
            }
            else
            {
                stringSQLUpdate = stringSQLUpdate + "0";
            }
            return stringSQLUpdate;
        }
    }
}
