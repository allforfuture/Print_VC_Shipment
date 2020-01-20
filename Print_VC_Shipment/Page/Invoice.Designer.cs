namespace Print_VC_Shipment.Page
{
    partial class Invoice
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkPackTime_Q = new System.Windows.Forms.CheckBox();
            this.dtpPackStart_Q = new System.Windows.Forms.DateTimePicker();
            this.dtpPackEnd_Q = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPallet_Q = new System.Windows.Forms.TextBox();
            this.txtInvoice_Q = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpInvoiceEnd_Q = new System.Windows.Forms.DateTimePicker();
            this.dtpInvoiceStart_Q = new System.Windows.Forms.DateTimePicker();
            this.chkInvoiceTime_Q = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPallet_S = new System.Windows.Forms.TextBox();
            this.txtInvoice_S = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDestination_S = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDestination_U = new System.Windows.Forms.TextBox();
            this.txtInvoice_U = new System.Windows.Forms.TextBox();
            this.txtPallet_U = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.chkCount_U = new System.Windows.Forms.CheckBox();
            this.chkInvoiceTime_U = new System.Windows.Forms.CheckBox();
            this.numCount_U = new System.Windows.Forms.NumericUpDown();
            this.dtpInvoiceTime_U = new System.Windows.Forms.DateTimePicker();
            this.chkInvoice_U = new System.Windows.Forms.CheckBox();
            this.chktxtDestination_U = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount_U)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpInvoiceEnd_Q);
            this.groupBox1.Controls.Add(this.dtpInvoiceStart_Q);
            this.groupBox1.Controls.Add(this.chkInvoiceTime_Q);
            this.groupBox1.Controls.Add(this.txtInvoice_Q);
            this.groupBox1.Controls.Add(this.txtPallet_Q);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpPackEnd_Q);
            this.groupBox1.Controls.Add(this.dtpPackStart_Q);
            this.groupBox1.Controls.Add(this.chkPackTime_Q);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Location = new System.Drawing.Point(15, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(107, 147);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "搜索";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(12, 347);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.RowTemplate.Height = 23;
            this.dgvDisplay.Size = new System.Drawing.Size(850, 177);
            this.dgvDisplay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "卡板号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "发票号:";
            // 
            // chkPackTime_Q
            // 
            this.chkPackTime_Q.AutoSize = true;
            this.chkPackTime_Q.Location = new System.Drawing.Point(26, 61);
            this.chkPackTime_Q.Name = "chkPackTime_Q";
            this.chkPackTime_Q.Size = new System.Drawing.Size(78, 16);
            this.chkPackTime_Q.TabIndex = 21;
            this.chkPackTime_Q.Text = "打包时间:";
            this.chkPackTime_Q.UseVisualStyleBackColor = true;
            // 
            // dtpPackStart_Q
            // 
            this.dtpPackStart_Q.Location = new System.Drawing.Point(107, 58);
            this.dtpPackStart_Q.Name = "dtpPackStart_Q";
            this.dtpPackStart_Q.Size = new System.Drawing.Size(118, 21);
            this.dtpPackStart_Q.TabIndex = 22;
            // 
            // dtpPackEnd_Q
            // 
            this.dtpPackEnd_Q.Location = new System.Drawing.Point(257, 58);
            this.dtpPackEnd_Q.Name = "dtpPackEnd_Q";
            this.dtpPackEnd_Q.Size = new System.Drawing.Size(118, 21);
            this.dtpPackEnd_Q.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "至";
            // 
            // txtPallet_Q
            // 
            this.txtPallet_Q.Location = new System.Drawing.Point(107, 27);
            this.txtPallet_Q.Name = "txtPallet_Q";
            this.txtPallet_Q.Size = new System.Drawing.Size(138, 21);
            this.txtPallet_Q.TabIndex = 24;
            // 
            // txtInvoice_Q
            // 
            this.txtInvoice_Q.Location = new System.Drawing.Point(107, 89);
            this.txtInvoice_Q.Name = "txtInvoice_Q";
            this.txtInvoice_Q.Size = new System.Drawing.Size(138, 21);
            this.txtInvoice_Q.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 28;
            this.label4.Text = "至";
            // 
            // dtpInvoiceEnd_Q
            // 
            this.dtpInvoiceEnd_Q.Location = new System.Drawing.Point(254, 120);
            this.dtpInvoiceEnd_Q.Name = "dtpInvoiceEnd_Q";
            this.dtpInvoiceEnd_Q.Size = new System.Drawing.Size(118, 21);
            this.dtpInvoiceEnd_Q.TabIndex = 26;
            // 
            // dtpInvoiceStart_Q
            // 
            this.dtpInvoiceStart_Q.Location = new System.Drawing.Point(107, 120);
            this.dtpInvoiceStart_Q.Name = "dtpInvoiceStart_Q";
            this.dtpInvoiceStart_Q.Size = new System.Drawing.Size(118, 21);
            this.dtpInvoiceStart_Q.TabIndex = 27;
            // 
            // chkInvoiceTime_Q
            // 
            this.chkInvoiceTime_Q.AutoSize = true;
            this.chkInvoiceTime_Q.Location = new System.Drawing.Point(26, 127);
            this.chkInvoiceTime_Q.Name = "chkInvoiceTime_Q";
            this.chkInvoiceTime_Q.Size = new System.Drawing.Size(78, 16);
            this.chkInvoiceTime_Q.TabIndex = 25;
            this.chkInvoiceTime_Q.Text = "发票时间:";
            this.chkInvoiceTime_Q.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDestination_S);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtInvoice_S);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPallet_S);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(17, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 156);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "出货";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "卡板号:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(70, 125);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "提交";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPallet_S
            // 
            this.txtPallet_S.Location = new System.Drawing.Point(70, 21);
            this.txtPallet_S.Name = "txtPallet_S";
            this.txtPallet_S.Size = new System.Drawing.Size(155, 21);
            this.txtPallet_S.TabIndex = 25;
            // 
            // txtInvoice_S
            // 
            this.txtInvoice_S.Location = new System.Drawing.Point(70, 47);
            this.txtInvoice_S.Name = "txtInvoice_S";
            this.txtInvoice_S.Size = new System.Drawing.Size(155, 21);
            this.txtInvoice_S.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "发票号:";
            // 
            // txtDestination_S
            // 
            this.txtDestination_S.Location = new System.Drawing.Point(70, 73);
            this.txtDestination_S.Name = "txtDestination_S";
            this.txtDestination_S.Size = new System.Drawing.Size(155, 21);
            this.txtDestination_S.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 28;
            this.label7.Text = "备注:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chktxtDestination_U);
            this.groupBox3.Controls.Add(this.chkInvoice_U);
            this.groupBox3.Controls.Add(this.dtpInvoiceTime_U);
            this.groupBox3.Controls.Add(this.numCount_U);
            this.groupBox3.Controls.Add(this.chkInvoiceTime_U);
            this.groupBox3.Controls.Add(this.chkCount_U);
            this.groupBox3.Controls.Add(this.txtDestination_U);
            this.groupBox3.Controls.Add(this.txtInvoice_U);
            this.groupBox3.Controls.Add(this.txtPallet_U);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(445, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 210);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "修改出货信息";
            // 
            // txtDestination_U
            // 
            this.txtDestination_U.Location = new System.Drawing.Point(105, 149);
            this.txtDestination_U.Name = "txtDestination_U";
            this.txtDestination_U.Size = new System.Drawing.Size(155, 21);
            this.txtDestination_U.TabIndex = 29;
            // 
            // txtInvoice_U
            // 
            this.txtInvoice_U.Location = new System.Drawing.Point(105, 53);
            this.txtInvoice_U.Name = "txtInvoice_U";
            this.txtInvoice_U.Size = new System.Drawing.Size(155, 21);
            this.txtInvoice_U.TabIndex = 27;
            // 
            // txtPallet_U
            // 
            this.txtPallet_U.Location = new System.Drawing.Point(105, 21);
            this.txtPallet_U.Name = "txtPallet_U";
            this.txtPallet_U.Size = new System.Drawing.Size(155, 21);
            this.txtPallet_U.TabIndex = 25;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(105, 181);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "卡板号:";
            // 
            // chkCount_U
            // 
            this.chkCount_U.AutoSize = true;
            this.chkCount_U.Location = new System.Drawing.Point(18, 86);
            this.chkCount_U.Name = "chkCount_U";
            this.chkCount_U.Size = new System.Drawing.Size(66, 16);
            this.chkCount_U.TabIndex = 30;
            this.chkCount_U.Text = "成品数:";
            this.chkCount_U.UseVisualStyleBackColor = true;
            // 
            // chkInvoiceTime_U
            // 
            this.chkInvoiceTime_U.AutoSize = true;
            this.chkInvoiceTime_U.Location = new System.Drawing.Point(18, 119);
            this.chkInvoiceTime_U.Name = "chkInvoiceTime_U";
            this.chkInvoiceTime_U.Size = new System.Drawing.Size(78, 16);
            this.chkInvoiceTime_U.TabIndex = 30;
            this.chkInvoiceTime_U.Text = "发票时间:";
            this.chkInvoiceTime_U.UseVisualStyleBackColor = true;
            // 
            // numCount_U
            // 
            this.numCount_U.Location = new System.Drawing.Point(105, 85);
            this.numCount_U.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numCount_U.Name = "numCount_U";
            this.numCount_U.Size = new System.Drawing.Size(49, 21);
            this.numCount_U.TabIndex = 31;
            // 
            // dtpInvoiceTime_U
            // 
            this.dtpInvoiceTime_U.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpInvoiceTime_U.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceTime_U.Location = new System.Drawing.Point(105, 117);
            this.dtpInvoiceTime_U.Name = "dtpInvoiceTime_U";
            this.dtpInvoiceTime_U.Size = new System.Drawing.Size(155, 21);
            this.dtpInvoiceTime_U.TabIndex = 32;
            // 
            // chkInvoice_U
            // 
            this.chkInvoice_U.AutoSize = true;
            this.chkInvoice_U.Location = new System.Drawing.Point(18, 53);
            this.chkInvoice_U.Name = "chkInvoice_U";
            this.chkInvoice_U.Size = new System.Drawing.Size(66, 16);
            this.chkInvoice_U.TabIndex = 33;
            this.chkInvoice_U.Text = "发票号:";
            this.chkInvoice_U.UseVisualStyleBackColor = true;
            // 
            // chktxtDestination_U
            // 
            this.chktxtDestination_U.AutoSize = true;
            this.chktxtDestination_U.Location = new System.Drawing.Point(18, 152);
            this.chktxtDestination_U.Name = "chktxtDestination_U";
            this.chktxtDestination_U.Size = new System.Drawing.Size(54, 16);
            this.chktxtDestination_U.TabIndex = 34;
            this.chktxtDestination_U.Text = "备注:";
            this.chktxtDestination_U.UseVisualStyleBackColor = true;
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 536);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvDisplay);
            this.Controls.Add(this.groupBox1);
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount_U)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkPackTime_Q;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpPackEnd_Q;
        private System.Windows.Forms.DateTimePicker dtpPackStart_Q;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpInvoiceEnd_Q;
        private System.Windows.Forms.DateTimePicker dtpInvoiceStart_Q;
        private System.Windows.Forms.CheckBox chkInvoiceTime_Q;
        private System.Windows.Forms.TextBox txtInvoice_Q;
        private System.Windows.Forms.TextBox txtPallet_Q;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtInvoice_S;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPallet_S;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDestination_S;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDestination_U;
        private System.Windows.Forms.TextBox txtInvoice_U;
        private System.Windows.Forms.TextBox txtPallet_U;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkInvoiceTime_U;
        private System.Windows.Forms.CheckBox chkCount_U;
        private System.Windows.Forms.NumericUpDown numCount_U;
        private System.Windows.Forms.DateTimePicker dtpInvoiceTime_U;
        private System.Windows.Forms.CheckBox chktxtDestination_U;
        private System.Windows.Forms.CheckBox chkInvoice_U;
    }
}