using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace HEGII_WHSS
{
    public partial class formLogin : Form
    {
        private DataTable dtLogin;
        private SqlConnection conLogin;
        private SqlDataAdapter daLogin;

        public formLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == "" || textPassword.Text == "")
            {
                MessageBox.Show("用户名或密码不能为空!");
            }
            else
            {
                dtLogin = new DataTable();
                string conSQLServer = ConfigurationManager.ConnectionStrings["HGWHConnectionString"].ToString() + ";Password=" + Global.stringSQLPassword + ";";
                string sqlLogin = "SELECT * FROM UserList WHERE LoginID='" + textUsername.Text + "'";
                conLogin = new SqlConnection(conSQLServer);
                daLogin = new SqlDataAdapter(sqlLogin, conLogin);

                try
                {
                    daLogin.Fill(dtLogin);
                    if (dtLogin.Rows.Count > 0)
                    {
                        if (dtLogin.Rows[0]["LoginPWD"].ToString() == textPassword.Text)
                        {
                            Global.stringUserName = dtLogin.Rows[0]["UserName"].ToString();
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("密码不正确!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("用户名不存在!");
                    }
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.Message);
                }
            }
        }

        private void formLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dtLogin != null)
            {
                dtLogin.Dispose();
            }
            if (daLogin != null)
            {
                daLogin.Dispose();
            }
            if (conLogin != null)
            {
                conLogin.Close();
                conLogin.Dispose();
            }
        }
    }
}
