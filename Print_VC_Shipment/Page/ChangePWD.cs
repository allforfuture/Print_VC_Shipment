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
    public partial class ChangePWD : Form
    {
        string OldPWD { get { return txtOldPWD.Text; } }
        string NewPWD1 { get { return txtNewPWD1.Text; } }
        string NewPWD2 { get { return txtNewPWD2.Text; } }

        public ChangePWD()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (OldPWD == "" || NewPWD1 == "" || NewPWD2 == "")
            {
                MessageBox.Show("所有信息不能为空","修改密码",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (NewPWD1 !=NewPWD2)
            {
                MessageBox.Show("两次新密码不一致", "修改密码", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sql = $@"UPDATE PUBLIC.m_user SET pass_wd='{NewPWD2}'
WHERE user_id='{Login.User}'
AND pass_wd='{OldPWD}'";
            if (new Unit.DB.Help().ExecuteSQL(sql) ==1)
            {
                MessageBox.Show("修改密码成功");
            }
            else
            {
                MessageBox.Show("旧密码错误!", "修改密码", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
