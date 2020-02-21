using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Print_VC_Shipment.Page
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string User { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUser.Text = txtPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("用户名不能为空", "登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CheckUser();
        }

        void CheckUser()
        {
            //string sql = "Select user_id From SHIP.t_user Where user_id='" + txtUser.Text + "' and pass='" + txtPassword.Text + "'";
            string sql = "Select user_id From PUBLIC.m_user Where user_id='" + txtUser.Text + "' and pass_wd='" + txtPassword.Text + "'";
            DataTable dt = new DataTable();
            new Unit.DB.Help().ExecuteDataTable(sql, ref dt);
            if (dt.Rows.Count > 0)
            {
                //登陆成功
                User = dt.Rows[0]["user_id"].ToString();
                DialogResult = DialogResult.OK;
            }
            else
            {
                //登陆失败
                MessageBox.Show("用户名或密码错误!", "登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            btnLogin_Click(sender, new EventArgs());
        }
    }
}
