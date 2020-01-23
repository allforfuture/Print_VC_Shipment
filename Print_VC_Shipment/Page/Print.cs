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
    public partial class Print : Form
    {
        public Print(string PKG_ID, string QTY, string DateCode, string LotNo)
        {
            InitializeComponent();
            //lblC_PN.Text = LabelPrintGlobal.g_Config.HH;
            lblQTY.Text = QTY;
            //lblMfr_PN.Text = LabelPrintGlobal.g_Config.Mfr;
            lblDateCode.Text = DateCode;
            lblLotNo.Text = LotNo;
            lblPKG_ID.Text = PKG_ID;
            ShowQR_Code();
        }

        private void ShowQR_Code()
        {
            picC_PN.Image = Unit.Code.Help.Barcode(lblC_PN.Text, picC_PN.Height);
            picQTY.Image = Unit.Code.Help.Barcode(lblQTY.Text, picQTY.Height);
            picMfr_PN.Image = Unit.Code.Help.Barcode(lblMfr_PN.Text, picMfr_PN.Height);
            picDateCode.Image = Unit.Code.Help.Barcode(lblDateCode.Text, picDateCode.Height);
            picLotNo.Image = Unit.Code.Help.Barcode(lblLotNo.Text, picLotNo.Height);
            picPKG_ID.Image = Unit.Code.Help.Barcode(lblPKG_ID.Text, picPKG_ID.Height);
            string QRcode = lblC_PN.Text;
            QRcode += "," + lblQTY.Text;
            QRcode += "," + lblMfr_PN.Text;
            QRcode += "," + lblDateCode.Text;
            QRcode += "," + lblLotNo.Text;
            QRcode += "," + lblPKG_ID.Text;
            picQRcode.Image = Unit.Code.Help.QRcode(QRcode, ZXing.BarcodeFormat.QR_CODE, picQRcode.Width, picQRcode.Height);
        }

        public bool PrintDoc (System.Drawing.Printing.PrinterSettings setting)
        {
            try
            {
                printDoc.PrinterSettings = setting;
                printDoc.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "打印标签", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            e.Graphics.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
        }
    }
}
