namespace Bilp224_Hafta2_Lab01
{
    partial class Form1
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
            this.lblYariCap = new System.Windows.Forms.Label();
            this.txtYariCap = new System.Windows.Forms.TextBox();
            this.btnCap = new System.Windows.Forms.Button();
            this.btnCevre = new System.Windows.Forms.Button();
            this.btnAlan = new System.Windows.Forms.Button();
            this.lblCap = new System.Windows.Forms.Label();
            this.lblCevre = new System.Windows.Forms.Label();
            this.lblAlan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblYariCap
            // 
            this.lblYariCap.AutoSize = true;
            this.lblYariCap.Location = new System.Drawing.Point(36, 27);
            this.lblYariCap.Name = "lblYariCap";
            this.lblYariCap.Size = new System.Drawing.Size(43, 13);
            this.lblYariCap.TabIndex = 0;
            this.lblYariCap.Text = "Yarıçap";
            // 
            // txtYariCap
            // 
            this.txtYariCap.Location = new System.Drawing.Point(39, 43);
            this.txtYariCap.Name = "txtYariCap";
            this.txtYariCap.Size = new System.Drawing.Size(100, 20);
            this.txtYariCap.TabIndex = 1;
            // 
            // btnCap
            // 
            this.btnCap.Location = new System.Drawing.Point(39, 108);
            this.btnCap.Name = "btnCap";
            this.btnCap.Size = new System.Drawing.Size(260, 45);
            this.btnCap.TabIndex = 2;
            this.btnCap.Text = "Dairenin Çapı";
            this.btnCap.UseVisualStyleBackColor = true;
            this.btnCap.Click += new System.EventHandler(this.btnCap_Click);
            // 
            // btnCevre
            // 
            this.btnCevre.Location = new System.Drawing.Point(39, 159);
            this.btnCevre.Name = "btnCevre";
            this.btnCevre.Size = new System.Drawing.Size(260, 45);
            this.btnCevre.TabIndex = 3;
            this.btnCevre.Text = "Dairenin Çevresi";
            this.btnCevre.UseVisualStyleBackColor = true;
            this.btnCevre.Click += new System.EventHandler(this.btnCevre_Click);
            // 
            // btnAlan
            // 
            this.btnAlan.Location = new System.Drawing.Point(39, 210);
            this.btnAlan.Name = "btnAlan";
            this.btnAlan.Size = new System.Drawing.Size(260, 45);
            this.btnAlan.TabIndex = 4;
            this.btnAlan.Text = "Dairenin Alanı";
            this.btnAlan.UseVisualStyleBackColor = true;
            this.btnAlan.Click += new System.EventHandler(this.btnAlan_Click);
            // 
            // lblCap
            // 
            this.lblCap.AutoSize = true;
            this.lblCap.Location = new System.Drawing.Point(337, 124);
            this.lblCap.Name = "lblCap";
            this.lblCap.Size = new System.Drawing.Size(16, 13);
            this.lblCap.TabIndex = 5;
            this.lblCap.Text = "...";
            // 
            // lblCevre
            // 
            this.lblCevre.AutoSize = true;
            this.lblCevre.Location = new System.Drawing.Point(337, 175);
            this.lblCevre.Name = "lblCevre";
            this.lblCevre.Size = new System.Drawing.Size(16, 13);
            this.lblCevre.TabIndex = 6;
            this.lblCevre.Text = "...";
            // 
            // lblAlan
            // 
            this.lblAlan.AutoSize = true;
            this.lblAlan.Location = new System.Drawing.Point(337, 226);
            this.lblAlan.Name = "lblAlan";
            this.lblAlan.Size = new System.Drawing.Size(16, 13);
            this.lblAlan.TabIndex = 7;
            this.lblAlan.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 333);
            this.Controls.Add(this.lblAlan);
            this.Controls.Add(this.lblCevre);
            this.Controls.Add(this.lblCap);
            this.Controls.Add(this.btnAlan);
            this.Controls.Add(this.btnCevre);
            this.Controls.Add(this.btnCap);
            this.Controls.Add(this.txtYariCap);
            this.Controls.Add(this.lblYariCap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYariCap;
        private System.Windows.Forms.TextBox txtYariCap;
        private System.Windows.Forms.Button btnCap;
        private System.Windows.Forms.Button btnCevre;
        private System.Windows.Forms.Button btnAlan;
        private System.Windows.Forms.Label lblCap;
        private System.Windows.Forms.Label lblCevre;
        private System.Windows.Forms.Label lblAlan;
    }
}

