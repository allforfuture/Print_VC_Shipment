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
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            #region sql语句
            string sql =
@"WITH pallet AS(
SELECT parent_sn,MAX(p_date) pack_time
FROM view_packed
WHERE model='pallet'
GROUP BY parent_sn)

SELECT pallet.parent_sn 卡板号,pallet.pack_time 打包时间,
_t.invoice_code 发票号,_t.ship_qty 成品数,_t.ship_date 发票时间,_t.ship_destination 备注
FROM pallet
LEFT JOIN t_invoice _t ON pallet.parent_sn=_t.pallet_id";
            bool firstWhere = true;
            if (txtPallet_Q.Text!="")
            {
                if (firstWhere)
                    sql += "\r\nWHERE";
                else
                    sql += "\r\nAND";
                sql += $" parent_sn LIKE '%{txtPallet_Q.Text}%'";
                firstWhere = false;
            }
            if (txtInvoice_Q.Text != "")
            {
                if (firstWhere)
                    sql += "\r\nWHERE";
                else
                    sql += "\r\nAND";
                sql += $" _t.invoice_code LIKE '%{txtInvoice_Q.Text}%'";
                firstWhere = false;
            }
            if (chkPackTime_Q.Checked)
            {
                if (firstWhere)
                    sql += "\r\nWHERE";
                else
                    sql += "\r\nAND";
                sql += $" pack_time>= TO_DATE('{dtpPackStart_Q.Value.ToShortDateString()}','yyyy/MM/dd') AND pack_time< TO_DATE('{dtpPackEnd_Q.Value.ToShortDateString()}','yyyy/MM/dd')+INTERVAL '1 D'";
                firstWhere = false;
            }
            if (chkInvoiceTime_Q.Checked)
            {
                if (firstWhere)
                    sql += "\r\nWHERE";
                else
                    sql += "\r\nAND";
                sql += $" _t.ship_date>= TO_DATE('{dtpInvoiceStart_Q.Value.ToShortDateString()}','yyyy/MM/dd') AND _t.ship_date< TO_DATE('{dtpInvoiceEnd_Q.Value.ToShortDateString()}','yyyy/MM/dd')+INTERVAL '1 D'";
                //firstWhere = false;
            }
            #endregion
            new Unit.DB.Help().ExecuteDataTable(sql,ref dt);
            dgvDisplay.DataSource = dt;
            dgvDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPallet_S.Text == "" || txtInvoice_S.Text == "")
            {
                MessageBox.Show("卡板号和发票号不能为空","入库",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            string sn = txtPallet_S.Text;
            #region 检验
            string sql =
$@"WITH pallet AS(
SELECT child_sn
FROM view_packed
WHERE model='pallet'
AND parent_sn='{sn}')

,carton AS(
SELECT view_packed.child_sn
FROM view_packed
JOIN pallet ON view_packed.parent_sn=pallet.child_sn
WHERE view_packed.model='carton')

,pack AS(
SELECT view_packed.child_sn
FROM view_packed
JOIN carton ON view_packed.parent_sn=carton.child_sn
WHERE view_packed.model='pack')

,tray AS(
SELECT view_packed.child_sn,view_packed.p_date
FROM view_packed
JOIN pack ON view_packed.parent_sn=pack.child_sn
WHERE view_packed.model='tray')

SELECT COUNT(*)::INT FROM tray";
            int countModule = (int)new Unit.DB.Help().ExecuteScalar(sql);
            if (countModule == 0)
            {
                MessageBox.Show("该卡板号没有与任何成品捆绑", "数据库", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion
            sql = $@"INSERT INTO t_invoice(pallet_id,invoice_code,ship_qty,ship_destination,ship_date)
VALUES('{sn}','{txtInvoice_S.Text}',{countModule},'{txtDestination_S.Text}',NOW())";
            if (new Unit.DB.Help().ExecuteSQL(sql)==1)
            {
                MessageBox.Show("出货成功", "出货", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPallet_S.Text = txtInvoice_S.Text = txtDestination_S.Text = "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!chkInvoice_U.Checked && !chkCount_U.Checked && !chkInvoiceTime_U.Checked && !chktxtDestination_U.Checked)
            {
                MessageBox.Show("请勾选需要修改的项目", "修改出货信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("UPDATE t_invoice");
            sql.Append("SET ");
            if (chkInvoice_U.Checked)
                sql.AppendLine($"invoice_code = '{txtInvoice_U.Text}'");
            if (chkCount_U.Checked)
                sql.AppendLine($",ship_qty = {numCount_U.Value}");
            if (chkInvoiceTime_U.Checked)
                sql.AppendLine($",ship_date = '{dtpInvoiceTime_U.Value.ToString("yyyy-MM-dd hh:mm:ss")}'");
            if (chktxtDestination_U.Checked)
                sql.AppendLine($",ship_destination = '{txtDestination_U.Text}'");
            sql.AppendFormat("WHERE pallet_id = '{0}'",txtPallet_U.Text);
            switch (new Unit.DB.Help().ExecuteSQL(sql.ToString()))
            {
                case 0:
                    MessageBox.Show("该卡板号不存在", "修改出货信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                case 1:
                    MessageBox.Show("已修改", "修改出货信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
            }
        }
    }
}
