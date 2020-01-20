namespace Print_VC_Shipment.Page
{
    partial class Setting
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
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.numTray = new System.Windows.Forms.NumericUpDown();
            this.numPack = new System.Windows.Forms.NumericUpDown();
            this.numCarton = new System.Windows.Forms.NumericUpDown();
            this.numPallet = new System.Windows.Forms.NumericUpDown();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPallet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProduct
            // 
            this.txtProduct.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtProduct.Location = new System.Drawing.Point(136, 6);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(204, 35);
            this.txtProduct.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 24);
            this.label8.TabIndex = 57;
            this.label8.Text = "物料代码:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(356, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 62);
            this.btnSave.TabIndex = 81;
            this.btnSave.Text = "保存设置默认值";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numPallet);
            this.groupBox2.Controls.Add(this.numCarton);
            this.groupBox2.Controls.Add(this.numPack);
            this.groupBox2.Controls.Add(this.numTray);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(12, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 199);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "包装";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(22, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 24);
            this.label12.TabIndex = 58;
            this.label12.Text = "Pallet:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(22, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 24);
            this.label13.TabIndex = 58;
            this.label13.Text = "Carton:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(22, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 24);
            this.label14.TabIndex = 58;
            this.label14.Text = "Pack:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(22, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 24);
            this.label15.TabIndex = 58;
            this.label15.Text = "Tray:";
            // 
            // numTray
            // 
            this.numTray.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numTray.Location = new System.Drawing.Point(129, 22);
            this.numTray.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numTray.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTray.Name = "numTray";
            this.numTray.Size = new System.Drawing.Size(90, 35);
            this.numTray.TabIndex = 62;
            this.numTray.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPack
            // 
            this.numPack.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numPack.Location = new System.Drawing.Point(129, 64);
            this.numPack.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numPack.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPack.Name = "numPack";
            this.numPack.Size = new System.Drawing.Size(90, 35);
            this.numPack.TabIndex = 62;
            this.numPack.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numCarton
            // 
            this.numCarton.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numCarton.Location = new System.Drawing.Point(129, 106);
            this.numCarton.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numCarton.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCarton.Name = "numCarton";
            this.numCarton.Size = new System.Drawing.Size(90, 35);
            this.numCarton.TabIndex = 62;
            this.numCarton.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPallet
            // 
            this.numPallet.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numPallet.Location = new System.Drawing.Point(129, 148);
            this.numPallet.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numPallet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPallet.Name = "numPallet";
            this.numPallet.Size = new System.Drawing.Size(90, 35);
            this.numPallet.TabIndex = 62;
            this.numPallet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 259);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.label8);
            this.Name = "Setting";
            this.Text = "Setting";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPallet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numTray;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numPallet;
        private System.Windows.Forms.NumericUpDown numCarton;
        private System.Windows.Forms.NumericUpDown numPack;
    }
}