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

        private void LocationChange()
        {
            dtWHStartCode = new DataTable();
            if (comboLocation1Start.Text == "")
            {
                labelStartLocation.Text = labelStartLocation.Text + "- ";
            }
            else
            {
                labelStartLocation.Text = labelStartLocation.Text + "-" + comboLocation1Start.Text;
            }
            if (comboRack1Start.Text == "")
            {
                labelStartLocation.Text = "";
            }
            else
            {
                labelStartLocation.Text = comboRack1Start.Text;
            }
            if (comboRack2Start.Text == "")
            {
                labelStartLocation.Text = labelStartLocation.Text + "";
            }
            else
            {
                labelStartLocation.Text = comboRack2Start.Text;
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
                        labelStartLocation.Text = dtWHStartCode.Rows[0]["WHStartCode"].ToString();
                        labelEndLocation.Text = dtWHStartCode.Rows[0]["WHStartCode"].ToString();
                    }
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.Message);
                }
            }
        }

        private void comboWarehouseName2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
