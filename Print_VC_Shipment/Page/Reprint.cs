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
    public partial class Reprint : Form
    {
        Packing.Model model
        {
            get
            {
                if (rbtnTray.Checked)
                    return Packing.Model.tray;
                else if (rbtnPack.Checked)
                    return Packing.Model.pack;
                else if (rbtnCarton.Checked)
                    return Packing.Model.carton;
                else if (rbtnPallet.Checked)
                    return Packing.Model.pallet;
                else
                    return Packing.Model.error;
            }
        }
        string sn { get { return txtSN.Text; } }
        int printQTY;
        

        public Reprint()
        {
            InitializeComponent();
        }

        private void btnReprint_Click(object sender, EventArgs e)
        {
            if (txtSN.Text == "")
            {
                MessageBox.Show($"SN不能为空", "SN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            #region 查询成品数量
            printQTY = 0;
            string sqlQTY = Print_VC_Shipment.Unit.DB.QTYsql.sql(model, sn);
            printQTY = (int)new Unit.DB.Help().ExecuteScalar(sqlQTY);
            if (printQTY == 0)
            {
                MessageBox.Show($"该SN在数据库中的成品数量为空", "Database", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion

            #region 打印
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.PrinterSettings = printDialog.PrinterSettings;
                printDoc.Print();
            }
            #endregion
        }

        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Unit.Code.Help.QRcode(sn, ZXing.BarcodeFormat.DATA_MATRIX, 0, 0);
            e.Graphics.DrawImage(image, 5, 5);
            Brush b = new SolidBrush(Color.Black);
            e.Graphics.DrawString(sn + " " + printQTY, new Font("Arial", 8), b, 35, 5);
        }
    }
}
