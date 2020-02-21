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
    public partial class Packing : Form
    {
        public enum Model
        {
            error = -1,
            tray = 0,
            pack = 1,
            carton = 2,
            pallet = 3
        }

        Model model;
        int printQTY;
        public Packing(Model selectModel)
        {
            InitializeComponent();
            model = selectModel;
            switch (selectModel)
            {
                case Model.tray:
                    lblParent.Text = "tray:";
                    numQTY.Value = Setting.NumTray;
                    break;
                case Model.pack:
                    lblParent.Text = "pack:";
                    numQTY.Value = Setting.NumPack;
                    break;
                case Model.carton:
                    lblParent.Text = "carton:";
                    numQTY.Value = Setting.NumCarton;
                    break;
                case Model.pallet:
                    lblParent.Text = "pallet:";
                    numQTY.Value = Setting.NumPallet;
                    break;
                default:
                    MessageBox.Show("获取不到设定的Model");
                    Close();
                    break;
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            string sql = $"select SHIP.fn_apply_no('N', '{Page.Setting.Product}' ,to_char(now(),'yyyyMMdd'), '{model}','{Login.User}')";
            txtParent.Text = (string)new Unit.DB.Help().ExecuteScalar(sql);

            #region 控件初始化
            txtPacked.Text = "";
            txtChild.Text = "";
            listvSN.Items.Clear();
            numPacked.Value = 0;
            #endregion
        }

        private void txtChile_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtChild.Text != "" && e.KeyCode == Keys.Return)
            {
                if (txtParent.Text == "")
                {
                    MessageBox.Show($"{model}号不能为空", "SN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string sn = txtChild.Text;
                #region 验证
                //填成品SN的时候检验是否合法
                if (model == Model.tray)
                {
                    if (sn.Length != 17 || !checkSN(sn))
                    {
                        MessageBox.Show("该SN不是有效格式的17位号码", "SN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    bool checkSN(string str)
                    {
                        string ok = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                        foreach (char c in str)
                        {
                            if (!ok.Contains(c))
                                return false;
                        }
                        return true;
                    }
                }

                //列表个数超出预设数量
                if (listvSN.Items.Count>= numQTY.Value)
                {
                    MessageBox.Show("列表个数超出预设数量", "SN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //列表中已存在该SN
                foreach (ListViewItem var in listvSN.Items)
                {
                    if (sn == var.SubItems["SN"].Text)
                    {
                        MessageBox.Show("下面列表中已存在该SN");
                        return;
                    }
                }

                //在数据库子表存在，在母表不存在状态是1
                if (!CheckSN(sn))
                {
                    MessageBox.Show("该SN已入库或不存在，请检查", "数据库", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                #endregion

                #region 显示
                ListViewItem item = new ListViewItem();
                item.Text = (listvSN.Items.Count + 1).ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "SN", Text = sn });
                listvSN.Items.Insert(0,item);

                numPacked.Value = numPacked.Value+1;
                txtChild.SelectAll();
                #endregion
            }
        }

        bool CheckSN(string sn)
        {
            string sql;
            if (model == Model.tray)
            {
                sql =
$@"SELECT COUNT(*)=0
FROM SHIP.pnt_{model}
WHERE module_id='{sn}'
AND status =1";
            }
            else
            {
                sql =
$@"SELECT COUNT(*)>0 print
FROM SHIP.pnt_{model} Parent
RIGHT JOIN SHIP.pnt_{model - 1} Child ON Parent.{model - 1}_id=Child.{model - 1}_id
WHERE Child.{model - 1}_id='{sn}'
AND (Parent.status !=1 OR Parent.status IS NULL)
AND Child.status=1";
            }

            return (bool)(new Unit.DB.Help().ExecuteScalar(sql));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            #region 检验
            if (txtParent.Text == "")
            {
                MessageBox.Show($"{model}号不能为空", "SN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (listvSN.Items.Count==0)
            {
                MessageBox.Show("列表中没有新输入的SN", "SN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (numPacked.Value != numQTY.Value)
            {
                DialogResult dialogResult=MessageBox.Show("实际输入的SN个数与预设值不相等，是否继续录入数据库", "数据库", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult== DialogResult.No)
                    return;
            }
            #endregion

            List<string> sql = new List<string>();
            foreach (ListViewItem var in listvSN.Items)
            {
                sql.Add($"INSERT INTO SHIP.pnt_{model} VALUES('{txtParent.Text}', '{var.SubItems["SN"].Text}', NOW(), 1)");
            }
            sql.Add($@"insert into SHIP.t_pnt_manager (pkg_id, pkg_type, act, pkg_date,  pkg_user, status,remark)
values ('{txtParent.Text}', '{model}', 'printed', NOW(), '{Login.User}', 1,'打印入库')");

            if (new Unit.DB.Help().ExecuteTran(sql))
                MessageBox.Show("已录入数据库","数据库",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                return;

            #region 打印
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                #region 查询成品数量
                printQTY = 0;
                string sqlQTY = Print_VC_Shipment.Unit.DB.QTYsql.sql(model, txtParent.Text);
                printQTY = (int)new Unit.DB.Help().ExecuteScalar(sqlQTY);
                #endregion

                //if (model == Model.tray)
                //{
                    printDocTray.PrinterSettings = printDialog.PrinterSettings;
                    printDocTray.Print();
                //}
                //else
                //{
                //    Print print = new Print("", "", "", "");
                //    print.Show();//预览，不显示的话，全是空白
                //    if (!print.PrintDoc(printDialog.PrinterSettings))
                //    {
                //        print.Dispose();
                //        return;
                //    }
                //    print.Dispose();
                //}
            }
            #endregion

            #region 控件初始化
            txtParent.Text = "";
            txtPacked.Text = "";
            txtChild.Text = "";
            listvSN.Items.Clear();
            numPacked.Value = 0;
            #endregion
        }

        private void txtPacked_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtPacked.Text != "" && e.KeyCode == Keys.Return)
            {
                string sql =
  $@"select count(*)::int
from SHIP.view_packed
where model='{model}'
and parent_sn='{txtPacked.Text}'";
                int countSN = (int)new Unit.DB.Help().ExecuteScalar(sql);
                if (countSN == 0)
                {
                    MessageBox.Show($"该{model}没有入库，请输入已入库的{model}号", "数据库", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtParent.SelectAll();
                    return;
                }

                txtParent.Text = txtPacked.Text;
                numPacked.Value = countSN;
                #region 控件初始化
                txtPacked.Text = "";
                txtChild.Text = "";
                listvSN.Items.Clear();
                #endregion
            }
        }
        
        private void printDocTray_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string sn = txtParent.Text;
            //string sn = "N_4878595_0122_T_0001";
            Image image = Unit.Code.Help.QRcode(sn, ZXing.BarcodeFormat.DATA_MATRIX, 0, 0);
            e.Graphics.DrawImage(image, 5, 5);
            Brush b = new SolidBrush(Color.Black);
            e.Graphics.DrawString(sn+" " +printQTY, new Font("Arial", 8), b, 35, 5);
        }
    }
}
