using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HEGII_WHSS
{
    public partial class formLocationMgt : Form
    {
        private DataTable dtWarehouseList, dtWHStartCode;
        private SqlConnection conformLocationMgt;
        private SqlDataAdapter daWarehouseList, daWHStartCode;

        public formLocationMgt()
        {
            InitializeComponent();
        }

        private void formLocationMgt_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            dtWarehouseList = new DataTable();
            string conSQLServer = ConfigurationManager.ConnectionStrings["HGWHConnectionString"].ToString() + ";Password=" + Global.stringSQLPassword + ";";
            conformLocationMgt = new SqlConnection(conSQLServer);
            string sqlWarehouseList = "SELECT WarehouseName FROM WarehouseList WHERE IsAvailable = 1";
            daWarehouseList = new SqlDataAdapter(sqlWarehouseList, conformLocationMgt);
            try
            {
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

        private void comboRack1Start_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocationChange();
        }

        private void comboRack1End_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocationChange();
        }

        private void comboRack2Start_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocationChange();
        }

        private void comboRack2End_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocationChange();
        }

        private void comboLocation1Start_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocationChange();
        }

        private void comboLocation1End_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocationChange();
        }

        private void comboLocation2Start_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocationChange();
        }

        private void comboLocation2End_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocationChange();
        }

        private void buttonLocationAdd_Click(object sender, EventArgs e)
        {
            int intNewLocationNum = (Convert.ToChar(comboRack1End.Text) - Convert.ToChar(comboRack1Start.Text) + 1) *
                                    (Convert.ToInt32(comboRack2End.Text) - Convert.ToInt32(comboRack2Start.Text) + 1) *
                                    (Convert.ToChar(comboLocation1End.Text) - Convert.ToChar(comboLocation1Start.Text) + 1) *
                                    (Convert.ToInt32(comboLocation2End.Text) - Convert.ToInt32(comboLocation2Start.Text) + 1);
            if (intNewLocationNum > 0)
            {
                DialogResult resultLocationAdd = MessageBox.Show("是否确认添加" + labelStartLocation.Text + "到" + 
                                                    labelEndLocation.Text + "共计" + intNewLocationNum.ToString() + "个货位?", 
                                                    "添加货位",MessageBoxButtons.YesNo);
                if (resultLocationAdd == DialogResult.Yes)
                {

                }
            }
            else
            {
                MessageBox.Show("起始货位必须小于结束货位，请核对后再提交！");
            }
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

            if (comboRack1Start.Text == "")
            {
                labelStartLocation.Text = labelStartLocation.Text + " ";
            }
            else
            {
                labelStartLocation.Text = labelStartLocation.Text+ "" + comboRack1Start.Text;
            }
            if (comboRack2Start.Text == "")
            {
                labelStartLocation.Text = labelStartLocation.Text + " ";
            }
            else
            {
                labelStartLocation.Text = labelStartLocation.Text + comboRack2Start.Text;
            }

            if (comboLocation1Start.Text == "")
            {
                labelStartLocation.Text = labelStartLocation.Text + " ";
            }
            else
            {
                labelStartLocation.Text = labelStartLocation.Text + "" + comboLocation1Start.Text;
            }
            if (comboLocation2Start.Text == "")
            {
                labelStartLocation.Text = labelStartLocation.Text + " ";
            }
            else
            {
                labelStartLocation.Text = labelStartLocation.Text + comboLocation2Start.Text;
            }

            if (comboRack1End.Text == "")
            {
                labelEndLocation.Text = labelEndLocation.Text + " ";
            }
            else
            {
                labelEndLocation.Text = labelEndLocation.Text + "" + comboRack1End.Text;
            }
            if (comboRack2End.Text == "")
            {
                labelEndLocation.Text = labelEndLocation.Text + " ";
            }
            else
            {
                labelEndLocation.Text = labelEndLocation.Text + comboRack2End.Text;
            }

            if (comboLocation1End.Text == "")
            {
                labelEndLocation.Text = labelEndLocation.Text + " ";
            }
            else
            {
                labelEndLocation.Text = labelEndLocation.Text + "" + comboLocation1End.Text;
            }
            if (comboLocation2End.Text == "")
            {
                labelEndLocation.Text = labelEndLocation.Text + " ";
            }
            else
            {
                labelEndLocation.Text = labelEndLocation.Text + comboLocation2End.Text;
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


    }
}
