namespace Print_VC_Shipment.Page
{
    partial class Reprint
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.btnReprint = new System.Windows.Forms.Button();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.rbtnTray = new System.Windows.Forms.RadioButton();
            this.rbtnPack = new System.Windows.Forms.RadioButton();
            this.rbtnCarton = new System.Windows.Forms.RadioButton();
            this.rbtnPallet = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "SN:";
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(69, 44);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(200, 21);
            this.txtSN.TabIndex = 1;
            // 
            // btnReprint
            // 
            this.btnReprint.Location = new System.Drawing.Point(291, 44);
            this.btnReprint.Name = "btnReprint";
            this.btnReprint.Size = new System.Drawing.Size(75, 23);
            this.btnReprint.TabIndex = 2;
            this.btnReprint.Text = "重新打印";
            this.btnReprint.UseVisualStyleBackColor = true;
            this.btnReprint.Click += new System.EventHandler(this.btnReprint_Click);
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // rbtnTray
            // 
            this.rbtnTray.AutoSize = true;
            this.rbtnTray.Checked = true;
            this.rbtnTray.Location = new System.Drawing.Point(70, 14);
            this.rbtnTray.Name = "rbtnTray";
            this.rbtnTray.Size = new System.Drawing.Size(47, 16);
            this.rbtnTray.TabIndex = 3;
            this.rbtnTray.TabStop = true;
            this.rbtnTray.Text = "tray";
            this.rbtnTray.UseVisualStyleBackColor = true;
            // 
            // rbtnPack
            // 
            this.rbtnPack.AutoSize = true;
            this.rbtnPack.Location = new System.Drawing.Point(145, 14);
            this.rbtnPack.Name = "rbtnPack";
            this.rbtnPack.Size = new System.Drawing.Size(47, 16);
            this.rbtnPack.TabIndex = 3;
            this.rbtnPack.Text = "pack";
            this.rbtnPack.UseVisualStyleBackColor = true;
            // 
            // rbtnCarton
            // 
            this.rbtnCarton.AutoSize = true;
            this.rbtnCarton.Location = new System.Drawing.Point(220, 14);
            this.rbtnCarton.Name = "rbtnCarton";
            this.rbtnCarton.Size = new System.Drawing.Size(59, 16);
            this.rbtnCarton.TabIndex = 3;
            this.rbtnCarton.Text = "carton";
            this.rbtnCarton.UseVisualStyleBackColor = true;
            // 
            // rbtnPallet
            // 
            this.rbtnPallet.AutoSize = true;
            this.rbtnPallet.Location = new System.Drawing.Point(307, 14);
            this.rbtnPallet.Name = "rbtnPallet";
            this.rbtnPallet.Size = new System.Drawing.Size(59, 16);
            this.rbtnPallet.TabIndex = 3;
            this.rbtnPallet.Text = "pallet";
            this.rbtnPallet.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Model:";
            // 
            // Reprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 83);
            this.Controls.Add(this.rbtnPallet);
            this.Controls.Add(this.rbtnCarton);
            this.Controls.Add(this.rbtnPack);
            this.Controls.Add(this.rbtnTray);
            this.Controls.Add(this.btnReprint);
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Reprint";
            this.Text = "Reprint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.Button btnReprint;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.RadioButton rbtnTray;
        private System.Windows.Forms.RadioButton rbtnPack;
        private System.Windows.Forms.RadioButton rbtnCarton;
        private System.Windows.Forms.RadioButton rbtnPallet;
        private System.Windows.Forms.Label label2;
    }
}