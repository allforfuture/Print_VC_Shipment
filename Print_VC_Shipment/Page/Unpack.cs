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
    public partial class Unpack : Form
    {
        enum Model
        {
            error = -1,
            tray = 0,
            pack = 1,
            carton = 2,
            pallet = 3
        }

        Model model
        {
            get
            {
                //sn的实例：N_4878595_0116_T_0005
                string sn = txtSN.Text;
                //if(sn.Length<21)
                //    return Model.error;
                switch (sn.Substring(15, 1))
                {
                    case "T":
                        return Model.tray;
                    case "P":
                        return Model.pack;
                    case "C":
                        return Model.carton;
                    case "L":
                        return Model.pallet;
                    default:
                        return Model.error;
                }
            }
        }

        public Unpack()
        {
            InitializeComponent();
        }

        private void btnUnpack_Click(object sender, EventArgs e)
        {
            #region 验证
            string sn = txtSN.Text;
            if (sn.Length != 21 )
            {
                MessageBox.Show("SN不是21位", "SN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (model == Model.error)
            {
                MessageBox.Show("SN的格式有误", "SN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //是否数据库已存在打包的
            string checkSQL = 
$@"SELECT COUNT(*)::int
FROM view_packed
WHERE model='{model}'
AND parent_sn='{sn}'";
            if ((int)new Unit.DB.Help().ExecuteScalar(checkSQL) == 0)
            {
                MessageBox.Show("该SN在数据库中不存在入库记录","数据库",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            #endregion

            if (rbtnDeepUnpack.Checked)
            {
                string sql = $"select fn_deep_unpack('{model}','{sn}','{Login.User}')";
                string result=(string)new Unit.DB.Help().ExecuteScalar(sql);
                if (result != "OK")
                {
                    MessageBox.Show($"执行异常：\r\n{sql}", "数据库", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                List<string> sql = new List<string>();
                sql.Add($"UPDATE pnt_{model} SET status = 2 WHERE {model}_id ='{sn}' AND status = 1");
                sql.Add($@"insert into t_pnt_manager (pkg_id, pkg_type, act, pkg_date, pkg_user, status, remark)
values ('{sn}', '{model}', 'normalUnpack', now(), '{Login.User}', 2, '单层拆包')");
                if (!new Unit.DB.Help().ExecuteTran(sql))
                    return;
            }
            MessageBox.Show("已完成拆包","数据库",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
