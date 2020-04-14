namespace Print_VC_Shipment.Page
{
    partial class Packing
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
            this.lblParent = new System.Windows.Forms.Label();
            this.lblChild = new System.Windows.Forms.Label();
            this.txtParent = new System.Windows.Forms.TextBox();
            this.txtChild = new System.Windows.Forms.TextBox();
            this.btnReserve = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numQTY = new System.Windows.Forms.NumericUpDown();
            this.numPacked = new System.Windows.Forms.NumericUpDown();
            this.listvSN = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPacked = new System.Windows.Forms.TextBox();
            this.printDocTray = new System.Drawing.Printing.PrintDocument();
            this.rbtnNow = new System.Windows.Forms.RadioButton();
            this.dtpSelect = new System.Windows.Forms.DateTimePicker();
            this.rbtnSelect = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numQTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPacked)).BeginInit();
            this.SuspendLayout();
            // 
            // lblParent
            // 
            this.lblParent.AutoSize = true;
            this.lblParent.Location = new System.Drawing.Point(21, 37);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(59, 12);
            this.lblParent.TabIndex = 0;
            this.lblParent.Text = "lblParent";
            // 
            // lblChild
            // 
            this.lblChild.AutoSize = true;
            this.lblChild.Location = new System.Drawing.Point(21, 83);
            this.lblChild.Name = "lblChild";
            this.lblChild.Size = new System.Drawing.Size(23, 12);
            this.lblChild.TabIndex = 0;
            this.lblChild.Text = "SN:";
            // 
            // txtParent
            // 
            this.txtParent.Location = new System.Drawing.Point(86, 34);
            this.txtParent.Name = "txtParent";
            this.txtParent.ReadOnly = true;
            this.txtParent.Size = new System.Drawing.Size(200, 21);
            this.txtParent.TabIndex = 1;
            // 
            // txtChild
            // 
            this.txtChild.Location = new System.Drawing.Point(86, 80);
            this.txtChild.Name = "txtChild";
            this.txtChild.Size = new System.Drawing.Size(200, 21);
            this.txtChild.TabIndex = 0;
            this.txtChild.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChile_KeyDown);
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(294, 32);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(75, 23);
            this.btnReserve.TabIndex = 2;
            this.btnReserve.Text = "预约";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 18F);
            this.label4.Location = new System.Drawing.Point(322, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "打包数量:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F);
            this.label1.Location = new System.Drawing.Point(543, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "/";
            // 
            // numQTY
            // 
            this.numQTY.Enabled = false;
            this.numQTY.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numQTY.Location = new System.Drawing.Point(571, 71);
            this.numQTY.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numQTY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQTY.Name = "numQTY";
            this.numQTY.Size = new System.Drawing.Size(90, 35);
            this.numQTY.TabIndex = 63;
            this.numQTY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPacked
            // 
            this.numPacked.Enabled = false;
            this.numPacked.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numPacked.Location = new System.Drawing.Point(447, 71);
            this.numPacked.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numPacked.Name = "numPacked";
            this.numPacked.Size = new System.Drawing.Size(90, 35);
            this.numPacked.TabIndex = 64;
            // 
            // listvSN
            // 
            this.listvSN.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.colSN});
            this.listvSN.HideSelection = false;
            this.listvSN.Location = new System.Drawing.Point(12, 112);
            this.listvSN.Name = "listvSN";
            this.listvSN.Size = new System.Drawing.Size(649, 266);
            this.listvSN.TabIndex = 65;
            this.listvSN.UseCompatibleStateImageBehavior = false;
            this.listvSN.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            // 
            // colSN
            // 
            this.colSN.Text = "SN编码";
            this.colSN.Width = 400;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(586, 384);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 66;
            this.btnPrint.Text = "打印入库";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 67;
            this.label2.Text = "继续打包";
            // 
            // txtPacked
            // 
            this.txtPacked.Location = new System.Drawing.Point(461, 34);
            this.txtPacked.Name = "txtPacked";
            this.txtPacked.Size = new System.Drawing.Size(200, 21);
            this.txtPacked.TabIndex = 0;
            this.txtPacked.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPacked_KeyDown);
            // 
            // printDocTray
            // 
            this.printDocTray.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocTray_PrintPage);
            // 
            // rbtnNow
            // 
            this.rbtnNow.AutoSize = true;
            this.rbtnNow.Checked = true;
            this.rbtnNow.Location = new System.Drawing.Point(86, 10);
            this.rbtnNow.Name = "rbtnNow";
            this.rbtnNow.Size = new System.Drawing.Size(71, 16);
            this.rbtnNow.TabIndex = 68;
            this.rbtnNow.TabStop = true;
            this.rbtnNow.Text = "当前时间";
            this.rbtnNow.UseVisualStyleBackColor = true;
            // 
            // dtpSelect
            // 
            this.dtpSelect.Location = new System.Drawing.Point(239, 8);
            this.dtpSelect.Name = "dtpSelect";
            this.dtpSelect.Size = new System.Drawing.Size(130, 21);
            this.dtpSelect.TabIndex = 69;
            // 
            // rbtnSelect
            // 
            this.rbtnSelect.AutoSize = true;
            this.rbtnSelect.Location = new System.Drawing.Point(176, 10);
            this.rbtnSelect.Name = "rbtnSelect";
            this.rbtnSelect.Size = new System.Drawing.Size(59, 16);
            this.rbtnSelect.TabIndex = 68;
            this.rbtnSelect.Text = "自定义";
            this.rbtnSelect.UseVisualStyleBackColor = true;
            // 
            // Packing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 422);
            this.Controls.Add(this.dtpSelect);
            this.Controls.Add(this.rbtnSelect);
            this.Controls.Add(this.rbtnNow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.listvSN);
            this.Controls.Add(this.numQTY);
            this.Controls.Add(this.numPacked);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.txtPacked);
            this.Controls.Add(this.txtChild);
            this.Controls.Add(this.txtParent);
            this.Controls.Add(this.lblChild);
            this.Controls.Add(this.lblParent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Packing";
            this.Text = "PackingForm";
            ((System.ComponentModel.ISupportInitialize)(this.numQTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPacked)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.Label lblChild;
        private System.Windows.Forms.TextBox txtParent;
        private System.Windows.Forms.TextBox txtChild;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numQTY;
        private System.Windows.Forms.NumericUpDown numPacked;
        private System.Windows.Forms.ListView listvSN;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader colSN;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPacked;
        private System.Drawing.Printing.PrintDocument printDocTray;
        private System.Windows.Forms.RadioButton rbtnNow;
        private System.Windows.Forms.DateTimePicker dtpSelect;
        private System.Windows.Forms.RadioButton rbtnSelect;
    }
}