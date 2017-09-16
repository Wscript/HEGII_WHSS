using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HEGII_WHSS
{
    public partial class formWarehouseMgt : Form
    {
        private DataTable dtWarehouseQuery,dtWarehouseChange;
        private SqlConnection conWarehouseMgt;
        private SqlDataAdapter daWarehouseQuery,daWarehouseChange;
        int intNewRowIndex = -1, intChangeRowIndex = -1;
        string sqlWarehouseChange;

        public formWarehouseMgt()
        {
            InitializeComponent();
        }

        private void formWarehouseMgt_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            buttonChangeSave.Enabled = false;
            buttonWarehouseAdd.Enabled = false;
            string conSQLServer = ConfigurationManager.ConnectionStrings["HGWHConnectionString"].ToString() + ";Password=" + Global.stringSQLPassword + ";";
            conWarehouseMgt = new SqlConnection(conSQLServer);
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            dtWarehouseQuery = new DataTable();
            string sqlWarehouseQuery = getSQLWarehouseQuery();
            daWarehouseQuery = new SqlDataAdapter(sqlWarehouseQuery, conWarehouseMgt);
            try
            {
                dtWarehouseQuery.Clear();
                daWarehouseQuery.Fill(dtWarehouseQuery);
                if (dtWarehouseQuery.Rows.Count > 0)
                {
                    dataGridWarehouse.Rows.Clear();
                    dataGridWarehouse.ColumnCount = dtWarehouseQuery.Columns.Count;
                    for (int i = 0; i < dtWarehouseQuery.Columns.Count; i++)
                    {
                        dataGridWarehouse.Columns[i].Name = dtWarehouseQuery.Columns[i].Caption;
                    }
                    for (int i = 0; i < dtWarehouseQuery.Rows.Count; i++)
                    {
                        dataGridWarehouse.Rows.Add();
                        for (int j = 0; j < dtWarehouseQuery.Columns.Count; j++)
                        {
                            dataGridWarehouse.Rows[i].Cells[j].Value = dtWarehouseQuery.Rows[i][j];
                        }
                    }
                    dataGridWarehouse.ReadOnly = true;
                    dataGridWarehouse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridWarehouse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridWarehouse.AllowUserToAddRows = false;
                    buttonChangeSave.Enabled = true;
                    buttonWarehouseAdd.Enabled = true;
                }
                else
                {
                    dataGridWarehouse.DataSource = null;
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
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

        private void buttonWarehouseAdd_Click(object sender, EventArgs e)
        {
            if (intNewRowIndex == -1 & intChangeRowIndex == -1)
            {
                intNewRowIndex = dataGridWarehouse.Rows.Add();
                dataGridWarehouse.ReadOnly = false;
                dataGridWarehouse.Columns[0].ReadOnly = true;
                dataGridWarehouse.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
            else
            {
                MessageBox.Show("当前的修改尚未保存，无法新增！");
            }

        }

        private void dataGridWerahouse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (intNewRowIndex == -1)
            {
                if (intChangeRowIndex == -1)
                {
                    dataGridWarehouse.ReadOnly = false;
                    dataGridWarehouse.Columns[0].ReadOnly = true;
                    dataGridWarehouse.SelectionMode = DataGridViewSelectionMode.CellSelect;
                    intChangeRowIndex = e.RowIndex;
                }
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
                dtWarehouseChange = new DataTable();
                if (intChangeRowIndex >= 0)
                {
                    sqlWarehouseChange = getSQLUpdate();
                }
                if (intNewRowIndex >= 0)
                {
                    sqlWarehouseChange = getSQLInsert();
                }
                daWarehouseChange = new SqlDataAdapter(sqlWarehouseChange,conWarehouseMgt);
                try
                {
                    daWarehouseChange.Fill(dtWarehouseChange);
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
                    MessageBox.Show(msg.Message);
                }
            }
        }

        private void formWerahouseMgt_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dtWarehouseQuery != null)
            {
                dtWarehouseQuery.Dispose();
            }
            if (daWarehouseQuery != null)
            {
                daWarehouseQuery.Dispose();
            }
            if (conWarehouseMgt != null)
            {
                conWarehouseMgt.Close();
                conWarehouseMgt.Dispose();
            }
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
