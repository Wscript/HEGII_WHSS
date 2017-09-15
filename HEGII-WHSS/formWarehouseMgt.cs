using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HEGII_WHSS
{
    public partial class formWarehouseMgt : Form
    {
        public formWarehouseMgt()
        {
            InitializeComponent();
        }

        private void formWarehouseMgt_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            DataTable dtWarehouseQuery = new DataTable();
            string consqlserver = ConfigurationManager.ConnectionStrings["HGWHConnectionString"].ToString() + ";Password=" + Global.stringSQLPassword + ";";
            SqlConnection con = new SqlConnection(consqlserver);
            string sqlWarehouseQuery = getSQLWarehouseQuery();
            SqlDataAdapter daWarehouseQuery = new SqlDataAdapter(sqlWarehouseQuery, con);
            try
            {
                daWarehouseQuery.Fill(dtWarehouseQuery);
                if (dtWarehouseQuery.Rows.Count > 0)
                {
                    dataGridWerahouse.DataSource = dtWarehouseQuery;
                    dataGridWerahouse.ReadOnly = true;
                    dataGridWerahouse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridWerahouse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridWerahouse.AllowUserToAddRows = false;
                }
                else
                {
                    dataGridWerahouse.DataSource = null;
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
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
            if (dataGridWerahouse.ReadOnly)
            {
                dataGridWerahouse.ReadOnly = false;
                dataGridWerahouse.AllowUserToAddRows = true;
            }
            else
            {
                MessageBox.Show("之前的修改尚未保存，无法新增！");
            }

        }

        private void formWerahouseMgt_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridWerahouse.ReadOnly)
            {
                dataGridWerahouse.ReadOnly = false;
                dataGridWerahouse.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
        }
    }
}
