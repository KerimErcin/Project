namespace Slider
{
    partial class frmSlider
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLogin.Location = new System.Drawing.Point(12, 9);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(52, 23);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignUp.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSignUp.Location = new System.Drawing.Point(73, 9);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(66, 23);
            this.lblSignUp.TabIndex = 1;
            this.lblSignUp.Text = "Sign Up";
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLine.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlLine.Location = new System.Drawing.Point(-1, 37);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(354, 1);
            this.pnlLine.TabIndex = 2;
            // 
            // pnlSelect
            // 
            this.pnlSelect.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSelect.Location = new System.Drawing.Point(10, 33);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(57, 8);
            this.pnlSelect.TabIndex = 3;
            // 
            // frmSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(351, 395);
            this.Controls.Add(this.pnlSelect);
            this.Controls.Add(this.pnlLine);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSlider";
            this.Load += new System.EventHandler(this.frmSlider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Panel pnlSelect;
    }
}

