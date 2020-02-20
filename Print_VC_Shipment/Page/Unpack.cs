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

            #region 数据库中该SN存在已入库的，且没有下一级包装入库记录
            string checkSQL2 =
$@"WITH tray AS(
	SELECT child_sn,parent_sn
	FROM view_packed
	WHERE model='tray'
)
,pack AS(
	SELECT child_sn,parent_sn
	FROM view_packed
	WHERE model='pack'
)
,carton AS(
	SELECT child_sn,parent_sn
	FROM view_packed
	WHERE model='carton'
)
,pallet AS(
	SELECT child_sn,parent_sn
	FROM view_packed
	WHERE model='pallet'
)
,dt AS(
	SELECT tray.child_sn AS sn
	,tray.parent_sn AS tray
	,pack.parent_sn AS pack
	,carton.parent_sn AS carton
	,pallet.parent_sn AS pallet
	FROM tray
	LEFT JOIN pack ON tray.parent_sn=pack.child_sn
	LEFT JOIN carton ON pack.parent_sn=carton.child_sn
	LEFT JOIN pallet ON carton.parent_sn=pallet.child_sn
)
SELECT*
FROM dt
WHERE {model}='{sn}'";
            DataTable dt = new DataTable();
            new Unit.DB.Help().ExecuteDataTable(checkSQL2, ref dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("该SN在数据库中不存在入库记录", "数据库", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataRow dr in dt.Rows)
            {
                if (model != Model.pallet)
                {
                    string unpackSN = dr[model.ToString()].ToString();
                    string unpackParent = dr[(model + 1).ToString()].ToString();
                    if (unpackSN == "")
                    {
                        MessageBox.Show("该SN在数据库中不存在入库记录", "数据库", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (unpackParent != "")
                    {
                        MessageBox.Show("该SN在数据库中存在下一级的包装记录", "数据库", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else 
                {
                    string unpackSN = dr[model.ToString()].ToString();
                    if (unpackSN == "")
                    {
                        MessageBox.Show("该SN在数据库中不存在入库记录", "数据库", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            #endregion
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
