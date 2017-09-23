using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HEGII_WHSS
{
    public partial class formLocationMgt : Form
    {
        private DataTable dtWarehouseList, dtWHStartCode, dtAlphabetNum, dtLocationQuery;
        private SqlConnection conformLocationMgt;
        private SqlDataAdapter daWarehouseList, daWHStartCode, daAlphabetNum, daLocationQuery;

        public formLocationMgt()
        {
            InitializeComponent();
        }

        private void formLocationMgt_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            dtWarehouseList = new DataTable();
            dtAlphabetNum = new DataTable();
            string conSQLServer = ConfigurationManager.ConnectionStrings["HGWHConnectionString"].ToString() + ";Password=" + Global.stringSQLPassword + ";";
            conformLocationMgt = new SqlConnection(conSQLServer);
            string sqlWarehouseList = "SELECT WarehouseName FROM WarehouseList WHERE IsAvailable = 1";
            string sqlAlphabetNum = "SELECT * FROM AlphabetNum";
            daWarehouseList = new SqlDataAdapter(sqlWarehouseList, conformLocationMgt);
            daAlphabetNum = new SqlDataAdapter(sqlAlphabetNum, conformLocationMgt);
            try
            {
                daAlphabetNum.Fill(dtAlphabetNum);
                daWarehouseList.Fill(dtWarehouseList);
                if (dtWarehouseList.Rows.Count > 0)
                {
                    for (int i = 0; i < dtWarehouseList.Rows.Count; i++)
                    {
                        comboWarehouseName1.Items.Add(dtWarehouseList.Rows[i]["WarehouseName"].ToString());
                        comboWarehouseName2.Items.Add(dtWarehouseList.Rows[i]["WarehouseName"].ToString());
                    }
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }

        private void buttonLocationAdd_Click(object sender, EventArgs e)
        {
            if (labelStartLocation.Text.Length == 6 & labelEndLocation.Text.Length == 6)
            {
                DataRow[] dataRowRack1Start = dtAlphabetNum.Select("AlphabetNum = '" + textRack1Start.Text + "'");
                DataRow[] dataRowRack1End = dtAlphabetNum.Select("AlphabetNum = '" + textRack1End.Text + "'");
                DataRow[] dataRowRack2Start = dtAlphabetNum.Select("AlphabetNum = '" + textRack2Start.Text + "'");
                DataRow[] dataRowRack2End = dtAlphabetNum.Select("AlphabetNum = '" + textRack2End.Text + "'");
                DataRow[] dataRowLocation1Start = dtAlphabetNum.Select("AlphabetNum = '" + textLocation1Start.Text + "'");
                DataRow[] dataRowLocation1End = dtAlphabetNum.Select("AlphabetNum = '" + textLocation1End.Text + "'");
                DataRow[] dataRowLocation2Start = dtAlphabetNum.Select("AlphabetNum = '" + textLocation2Start.Text + "'");
                DataRow[] dataRowLocation2End = dtAlphabetNum.Select("AlphabetNum = '" + textLocation2End.Text + "'");

                int intNewLocationNum = (Convert.ToInt32(dataRowRack1End[0][0].ToString()) - Convert.ToInt32(dataRowRack1Start[0][0].ToString()) + 1) *
                                        (Convert.ToInt32(dataRowRack2End[0][0].ToString()) - Convert.ToInt32(dataRowRack2Start[0][0].ToString()) + 1) *
                                        (Convert.ToInt32(dataRowLocation1End[0][0].ToString()) - Convert.ToInt32(dataRowLocation1Start[0][0].ToString()) + 1) *
                                        (Convert.ToInt32(dataRowLocation2End[0][0].ToString()) - Convert.ToInt32(dataRowLocation2Start[0][0].ToString()) + 1);

                if (intNewLocationNum > 0)
                {
                    DialogResult resultLocationAdd = MessageBox.Show("是否确认添加" + labelStartLocation.Text + "到" +
                                                        labelEndLocation.Text + "共计" + intNewLocationNum.ToString() + "个货位?",
                                                        "添加货位", MessageBoxButtons.YesNo);
                    if (resultLocationAdd == DialogResult.Yes)
                    {
                        DataTable dtCheckLocation = new DataTable();
                        string sqlCheckLocation = "EXEC progCheckLocation '" + labelStartLocation.Text + "','" + labelEndLocation.Text + "'";
                        SqlDataAdapter daCheckLocation = new SqlDataAdapter(sqlCheckLocation, conformLocationMgt);
                        try
                        {
                            daCheckLocation.Fill(dtCheckLocation);
                            if (dtCheckLocation.Rows.Count > 0)
                            {
                                MessageBox.Show("需要添加的货位与现有货位有重复，请核对后再提交！");
                            }
                            else
                            {
                                int intLocationAddQty = LocationAdd();
                                MessageBox.Show("已添加" + intLocationAddQty.ToString() + "个货位");
                            }
                        }
                         catch (Exception msg)
                        {
                            MessageBox.Show(msg.Message);
                        }
                        finally
                        {
                            dtCheckLocation.Dispose();
                            daCheckLocation.Dispose();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("起始货位必须小于结束货位，请核对后再提交！");
                }
            }
            else
            {
                MessageBox.Show("货位信息输入不完整，请核对后再提交！");
            }

        }

        private void textRack1Start_TextChanged(object sender, EventArgs e)
        {
            LocationChange();
        }

        private void textRack1End_TextChanged(object sender, EventArgs e)
        {
            LocationChange();
        }

        private void textRack2Start_TextChanged(object sender, EventArgs e)
        {
            LocationChange();
        }

        private void textRack2End_TextChanged(object sender, EventArgs e)
        {
            LocationChange();
        }

        private void textLocation1Start_TextChanged(object sender, EventArgs e)
        {
            LocationChange();
        }

        private void buttonLocationQuery_Click(object sender, EventArgs e)
        {
            dtLocationQuery = new DataTable();
            string sqlLocationQuery = "";
            daLocationQuery = new SqlDataAdapter(sqlLocationQuery, conformLocationMgt);
        }

        private void textLocation1End_TextChanged(object sender, EventArgs e)
        {
            LocationChange();
        }

        private void textLocation2Start_TextChanged(object sender, EventArgs e)
        {
            LocationChange();
        }

        private void textLocation2End_TextChanged(object sender, EventArgs e)
        {
            LocationChange();
        }

        private void comboWarehouseName2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocationChange();
        }

        private void LocationChange()
        {
            dtWHStartCode = new DataTable();
            labelStartLocation.Text = "";
            labelEndLocation.Text = "";

            if (textRack1Start.Text == "")
            {
                labelStartLocation.Text = labelStartLocation.Text + " ";
            }
            else
            {
                labelStartLocation.Text = labelStartLocation.Text+ "" + textRack1Start.Text;
            }
            if (textRack2Start.Text == "")
            {
                labelStartLocation.Text = labelStartLocation.Text + " ";
            }
            else
            {
                labelStartLocation.Text = labelStartLocation.Text + textRack2Start.Text;
            }

            if (textLocation1Start.Text == "")
            {
                labelStartLocation.Text = labelStartLocation.Text + " ";
            }
            else
            {
                labelStartLocation.Text = labelStartLocation.Text + "" + textLocation1Start.Text;
            }
            if (textLocation2Start.Text == "")
            {
                labelStartLocation.Text = labelStartLocation.Text + " ";
            }
            else
            {
                labelStartLocation.Text = labelStartLocation.Text + textLocation2Start.Text;
            }

            if (textRack1End.Text == "")
            {
                labelEndLocation.Text = labelEndLocation.Text + " ";
            }
            else
            {
                labelEndLocation.Text = labelEndLocation.Text + "" + textRack1End.Text;
            }
            if (textRack2End.Text == "")
            {
                labelEndLocation.Text = labelEndLocation.Text + " ";
            }
            else
            {
                labelEndLocation.Text = labelEndLocation.Text + textRack2End.Text;
            }

            if (textLocation1End.Text == "")
            {
                labelEndLocation.Text = labelEndLocation.Text + " ";
            }
            else
            {
                labelEndLocation.Text = labelEndLocation.Text + "" + textLocation1End.Text;
            }
            if (textLocation2End.Text == "")
            {
                labelEndLocation.Text = labelEndLocation.Text + " ";
            }
            else
            {
                labelEndLocation.Text = labelEndLocation.Text + textLocation2End.Text;
            }

            if (comboWarehouseName2.Text == "")
            {
                MessageBox.Show("仓库名称不能为空！");
            }
            else
            {
                string sqldtWHStartCode = "SELECT WHStartCode FROM WarehouseList WHERE WarehouseName = '" + comboWarehouseName2.Text + "'";
                daWHStartCode = new SqlDataAdapter(sqldtWHStartCode, conformLocationMgt);
                try
                {
                    daWHStartCode.Fill(dtWHStartCode);
                    if (dtWHStartCode.Rows.Count > 0)
                    {
                        labelStartLocation.Text = dtWHStartCode.Rows[0]["WHStartCode"].ToString() + labelStartLocation.Text;
                        labelEndLocation.Text = dtWHStartCode.Rows[0]["WHStartCode"].ToString() + labelEndLocation.Text;
                    }
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.Message);
                }
            }
        }

        private int LocationAdd()
        {
            DataTable dtLocationAdd = new DataTable();
            string sqlLocationAdd = "EXEC progLocationAdd '" + labelStartLocation.Text + "','" + labelEndLocation.Text + "'";
            SqlDataAdapter daLocationAdd = new SqlDataAdapter(sqlLocationAdd, conformLocationMgt);
            try
            {
                daLocationAdd.Fill(dtLocationAdd);
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }

            return dtLocationAdd.Rows.Count;
        }
    }
}
