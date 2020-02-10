using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Print_VC_Shipment
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Text = Application.ProductName + " " + Application.ProductVersion;
            showPage();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            new Page.Setting().ShowDialog();
        }

        private void tabModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            showPage();
        }

        void showPage()
        {
            //清除之前界面
            tabModel.SelectedTab.Controls.Clear();
            //加载当前模式界面
            Page.Packing.Model model = (Page.Packing.Model)tabModel.SelectedIndex;
            Page.Packing page = new Page.Packing(model);
            page.TopLevel = false;
            page.Show();
            tabModel.SelectedTab.Controls.Add(page);
            //清除内存
            GC.Collect();
        }

        private void btnUnpack_Click(object sender, EventArgs e)
        {
            new Page.Unpack().ShowDialog();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            new Page.Invoice().ShowDialog();
        }

        private void btnReprint_Click(object sender, EventArgs e)
        {
            new Page.Reprint().ShowDialog();
        }
    }
}
