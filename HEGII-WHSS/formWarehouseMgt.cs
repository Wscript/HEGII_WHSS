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
        DataTable dtWarehouseQuery = new DataTable();
        SqlConnection con;
        SqlDataAdapter daWarehouseQuery;

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
            string consqlserver = ConfigurationManager.ConnectionStrings["HGWHConnectionString"].ToString() + ";Password=" + Global.stringSQLPassword + ";";
            string sqlWarehouseQuery = getSQLWarehouseQuery();
            con = new SqlConnection(consqlserver);
            daWarehouseQuery = new SqlDataAdapter(sqlWarehouseQuery, con);
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

        private void dataGridWerahouse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridWerahouse.ReadOnly)
            {
                dataGridWerahouse.ReadOnly = false;
                dataGridWerahouse.Columns[0].ReadOnly = true;
                dataGridWerahouse.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
        }

        private void buttonChangeSave_Click(object sender, EventArgs e)
        {
            if (dataGridWerahouse.ReadOnly)
            {
                MessageBox.Show("没有需要更改的内容");
            }
            else
            {
                daWarehouseQuery.Update(dtWarehouseQuery);
            }
        }

        private void formWerahouseMgt_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtWarehouseQuery.Dispose();
            daWarehouseQuery.Dispose();
            con.Close();
            con.Dispose();
        }
    }
}
