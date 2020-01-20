namespace Print_VC_Shipment.Page
{
    partial class Unpack
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
            this.txtSN = new System.Windows.Forms.TextBox();
            this.rbtnNormalUnpack = new System.Windows.Forms.RadioButton();
            this.rbtnDeepUnpack = new System.Windows.Forms.RadioButton();
            this.btnUnpack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(36, 28);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(200, 21);
            this.txtSN.TabIndex = 1;
            this.txtSN.Text = "N_4878595_0116_T_0005";
            // 
            // rbtnNormalUnpack
            // 
            this.rbtnNormalUnpack.AutoSize = true;
            this.rbtnNormalUnpack.Checked = true;
            this.rbtnNormalUnpack.Location = new System.Drawing.Point(281, 20);
            this.rbtnNormalUnpack.Name = "rbtnNormalUnpack";
            this.rbtnNormalUnpack.Size = new System.Drawing.Size(71, 16);
            this.rbtnNormalUnpack.TabIndex = 3;
            this.rbtnNormalUnpack.TabStop = true;
            this.rbtnNormalUnpack.Text = "单层拆包";
            this.rbtnNormalUnpack.UseVisualStyleBackColor = true;
            // 
            // rbtnDeepUnpack
            // 
            this.rbtnDeepUnpack.AutoSize = true;
            this.rbtnDeepUnpack.Location = new System.Drawing.Point(281, 42);
            this.rbtnDeepUnpack.Name = "rbtnDeepUnpack";
            this.rbtnDeepUnpack.Size = new System.Drawing.Size(71, 16);
            this.rbtnDeepUnpack.TabIndex = 3;
            this.rbtnDeepUnpack.Text = "深度拆包";
            this.rbtnDeepUnpack.UseVisualStyleBackColor = true;
            // 
            // btnUnpack
            // 
            this.btnUnpack.Location = new System.Drawing.Point(192, 84);
            this.btnUnpack.Name = "btnUnpack";
            this.btnUnpack.Size = new System.Drawing.Size(75, 23);
            this.btnUnpack.TabIndex = 4;
            this.btnUnpack.Text = "确定拆包";
            this.btnUnpack.UseVisualStyleBackColor = true;
            this.btnUnpack.Click += new System.EventHandler(this.btnUnpack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "SN:";
            // 
            // Unpack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 135);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUnpack);
            this.Controls.Add(this.rbtnDeepUnpack);
            this.Controls.Add(this.rbtnNormalUnpack);
            this.Controls.Add(this.txtSN);
            this.Name = "Unpack";
            this.Text = "Unpack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.RadioButton rbtnNormalUnpack;
        private System.Windows.Forms.RadioButton rbtnDeepUnpack;
        private System.Windows.Forms.Button btnUnpack;
        private System.Windows.Forms.Label label1;
    }
}