namespace Print_VC_Shipment.Page
{
    partial class ChangePWD
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewPWD2 = new System.Windows.Forms.TextBox();
            this.txtOldPWD = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewPWD1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "确认新密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "旧密码：";
            // 
            // txtNewPWD2
            // 
            this.txtNewPWD2.Location = new System.Drawing.Point(96, 82);
            this.txtNewPWD2.Name = "txtNewPWD2";
            this.txtNewPWD2.PasswordChar = '*';
            this.txtNewPWD2.Size = new System.Drawing.Size(121, 21);
            this.txtNewPWD2.TabIndex = 19;
            // 
            // txtOldPWD
            // 
            this.txtOldPWD.Location = new System.Drawing.Point(96, 20);
            this.txtOldPWD.Name = "txtOldPWD";
            this.txtOldPWD.Size = new System.Drawing.Size(121, 21);
            this.txtOldPWD.TabIndex = 18;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(92, 121);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 20;
            this.btnChange.Text = "确认修改";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "新密码：";
            // 
            // txtNewPWD1
            // 
            this.txtNewPWD1.Location = new System.Drawing.Point(96, 51);
            this.txtNewPWD1.Name = "txtNewPWD1";
            this.txtNewPWD1.PasswordChar = '*';
            this.txtNewPWD1.Size = new System.Drawing.Size(121, 21);
            this.txtNewPWD1.TabIndex = 24;
            // 
            // ChangePWD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewPWD1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewPWD2);
            this.Controls.Add(this.txtOldPWD);
            this.Controls.Add(this.btnChange);
            this.Name = "ChangePWD";
            this.Text = "ChangePWD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewPWD2;
        private System.Windows.Forms.TextBox txtOldPWD;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewPWD1;
    }
}