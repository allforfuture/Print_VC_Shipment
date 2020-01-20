using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Print_VC_Shipment.Unit.Setting;

namespace Print_VC_Shipment.Page
{
    public partial class Setting : Form
    {
        public static string Product
        { get { return Config.GetAppSetting("Product"); } }

        public static int NumTray
        { get { return Convert.ToUInt16(Config.GetAppSetting("NumTray")); } }
        public static int NumPack
        { get { return Convert.ToUInt16(Config.GetAppSetting("NumPack")); } }
        public static int NumCarton
        { get { return Convert.ToUInt16(Config.GetAppSetting("NumCarton")); } }
        public static int NumPallet
        { get { return Convert.ToUInt16(Config.GetAppSetting("NumPallet")); } }

        public Setting()
        {
            InitializeComponent();
            txtProduct.Text = Product;
            numTray.Value = NumTray;
            numPack.Value = NumPack;
            numCarton.Value = NumCarton;
            numPallet.Value = NumPallet;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region UPN转化Barcode.CODE_128的验证
            //if (txtUPN.Text == "")
            //{
            //    MessageBox.Show("UPN不能为空", "UPN输入：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //foreach (char s in txtUPN.Text)
            //{
            //    int i = Convert.ToInt32(s); //把字符类型转换成数值类型，如：a——>97；输出是整型隐式转换为字符串型输出；
            //    bool isASCII = i <= 127 ? true : false;
            //    if (!isASCII)
            //    {
            //        MessageBox.Show("UPN不能转化为Barcode.CODE_128,请输入ASCII字符", "UPN输入：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //}
            #endregion
            Config.SetAppSetting("Product", txtProduct.Text);
            Config.SetAppSetting("NumTray", numTray.Text);
            Config.SetAppSetting("NumPack", numPack.Text);
            Config.SetAppSetting("NumCarton", numCarton.Text);
            Config.SetAppSetting("NumPallet", numPallet.Text);
            //Main.main.RefreshTxt();
            //Main.main.RefreshImage();
            MessageBox.Show("修改成功");
            Close();
        }
    }
}
