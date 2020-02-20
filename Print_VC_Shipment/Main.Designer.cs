namespace Print_VC_Shipment
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUnpack = new System.Windows.Forms.Button();
            this.btnReprint = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.tabModel = new System.Windows.Forms.TabControl();
            this.tabTray = new System.Windows.Forms.TabPage();
            this.tabPack = new System.Windows.Forms.TabPage();
            this.tabCarton = new System.Windows.Forms.TabPage();
            this.tabPallet = new System.Windows.Forms.TabPage();
            this.tabModel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUnpack
            // 
            this.btnUnpack.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUnpack.Location = new System.Drawing.Point(137, 12);
            this.btnUnpack.Name = "btnUnpack";
            this.btnUnpack.Size = new System.Drawing.Size(119, 49);
            this.btnUnpack.TabIndex = 0;
            this.btnUnpack.Text = "拆包";
            this.btnUnpack.UseVisualStyleBackColor = true;
            this.btnUnpack.Click += new System.EventHandler(this.btnUnpack_Click);
            // 
            // btnReprint
            // 
            this.btnReprint.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReprint.Location = new System.Drawing.Point(387, 12);
            this.btnReprint.Name = "btnReprint";
            this.btnReprint.Size = new System.Drawing.Size(119, 49);
            this.btnReprint.TabIndex = 1;
            this.btnReprint.Text = "重新打印";
            this.btnReprint.UseVisualStyleBackColor = true;
            this.btnReprint.Click += new System.EventHandler(this.btnReprint_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetting.Location = new System.Drawing.Point(12, 12);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(119, 49);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.Text = "参数设定";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInvoice.Location = new System.Drawing.Point(262, 12);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(119, 49);
            this.btnInvoice.TabIndex = 0;
            this.btnInvoice.Text = "出货";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // tabModel
            // 
            this.tabModel.Controls.Add(this.tabTray);
            this.tabModel.Controls.Add(this.tabPack);
            this.tabModel.Controls.Add(this.tabCarton);
            this.tabModel.Controls.Add(this.tabPallet);
            this.tabModel.Location = new System.Drawing.Point(12, 67);
            this.tabModel.Name = "tabModel";
            this.tabModel.SelectedIndex = 0;
            this.tabModel.Size = new System.Drawing.Size(685, 445);
            this.tabModel.TabIndex = 1;
            this.tabModel.SelectedIndexChanged += new System.EventHandler(this.tabModel_SelectedIndexChanged);
            // 
            // tabTray
            // 
            this.tabTray.Location = new System.Drawing.Point(4, 22);
            this.tabTray.Name = "tabTray";
            this.tabTray.Padding = new System.Windows.Forms.Padding(3);
            this.tabTray.Size = new System.Drawing.Size(677, 419);
            this.tabTray.TabIndex = 0;
            this.tabTray.Text = "装盘";
            this.tabTray.UseVisualStyleBackColor = true;
            // 
            // tabPack
            // 
            this.tabPack.Location = new System.Drawing.Point(4, 22);
            this.tabPack.Name = "tabPack";
            this.tabPack.Padding = new System.Windows.Forms.Padding(3);
            this.tabPack.Size = new System.Drawing.Size(677, 419);
            this.tabPack.TabIndex = 1;
            this.tabPack.Text = "装包";
            this.tabPack.UseVisualStyleBackColor = true;
            // 
            // tabCarton
            // 
            this.tabCarton.Location = new System.Drawing.Point(4, 22);
            this.tabCarton.Name = "tabCarton";
            this.tabCarton.Padding = new System.Windows.Forms.Padding(3);
            this.tabCarton.Size = new System.Drawing.Size(677, 419);
            this.tabCarton.TabIndex = 2;
            this.tabCarton.Text = "装箱";
            this.tabCarton.UseVisualStyleBackColor = true;
            // 
            // tabPallet
            // 
            this.tabPallet.Location = new System.Drawing.Point(4, 22);
            this.tabPallet.Name = "tabPallet";
            this.tabPallet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPallet.Size = new System.Drawing.Size(677, 419);
            this.tabPallet.TabIndex = 3;
            this.tabPallet.Text = "装板";
            this.tabPallet.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 522);
            this.Controls.Add(this.tabModel);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnReprint);
            this.Controls.Add(this.btnUnpack);
            this.Name = "Main";
            this.Text = "Main";
            this.tabModel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnpack;
        private System.Windows.Forms.Button btnReprint;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.TabControl tabModel;
        private System.Windows.Forms.TabPage tabTray;
        private System.Windows.Forms.TabPage tabPack;
        private System.Windows.Forms.TabPage tabCarton;
        private System.Windows.Forms.TabPage tabPallet;
    }
}