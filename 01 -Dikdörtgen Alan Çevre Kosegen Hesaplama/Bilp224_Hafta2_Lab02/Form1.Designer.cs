namespace Bilp224_Hafta2_Lab02
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
            this.lblUzunKenar = new System.Windows.Forms.Label();
            this.lblKısaKenar = new System.Windows.Forms.Label();
            this.txtUzunKenar = new System.Windows.Forms.TextBox();
            this.txtKısaKenar = new System.Windows.Forms.TextBox();
            this.btnKosegen = new System.Windows.Forms.Button();
            this.btnCevre = new System.Windows.Forms.Button();
            this.btnAlan = new System.Windows.Forms.Button();
            this.lblKosegen = new System.Windows.Forms.Label();
            this.lblCevre = new System.Windows.Forms.Label();
            this.lblAlan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUzunKenar
            // 
            this.lblUzunKenar.AutoSize = true;
            this.lblUzunKenar.Location = new System.Drawing.Point(38, 26);
            this.lblUzunKenar.Name = "lblUzunKenar";
            this.lblUzunKenar.Size = new System.Drawing.Size(63, 13);
            this.lblUzunKenar.TabIndex = 0;
            this.lblUzunKenar.Text = "Uzun Kenar";
            // 
            // lblKısaKenar
            // 
            this.lblKısaKenar.AutoSize = true;
            this.lblKısaKenar.Location = new System.Drawing.Point(163, 26);
            this.lblKısaKenar.Name = "lblKısaKenar";
            this.lblKısaKenar.Size = new System.Drawing.Size(58, 13);
            this.lblKısaKenar.TabIndex = 1;
            this.lblKısaKenar.Text = "Kısa Kenar";
            // 
            // txtUzunKenar
            // 
            this.txtUzunKenar.Location = new System.Drawing.Point(41, 42);
            this.txtUzunKenar.Name = "txtUzunKenar";
            this.txtUzunKenar.Size = new System.Drawing.Size(100, 20);
            this.txtUzunKenar.TabIndex = 2;
            // 
            // txtKısaKenar
            // 
            this.txtKısaKenar.Location = new System.Drawing.Point(166, 42);
            this.txtKısaKenar.Name = "txtKısaKenar";
            this.txtKısaKenar.Size = new System.Drawing.Size(100, 20);
            this.txtKısaKenar.TabIndex = 3;
            // 
            // btnKosegen
            // 
            this.btnKosegen.Location = new System.Drawing.Point(41, 105);
            this.btnKosegen.Name = "btnKosegen";
            this.btnKosegen.Size = new System.Drawing.Size(225, 39);
            this.btnKosegen.TabIndex = 4;
            this.btnKosegen.Text = "Dikdörtgenin Köşegen Uzunluğu";
            this.btnKosegen.UseVisualStyleBackColor = true;
            this.btnKosegen.Click += new System.EventHandler(this.btnKosegen_Click);
            // 
            // btnCevre
            // 
            this.btnCevre.Location = new System.Drawing.Point(41, 150);
            this.btnCevre.Name = "btnCevre";
            this.btnCevre.Size = new System.Drawing.Size(225, 39);
            this.btnCevre.TabIndex = 5;
            this.btnCevre.Text = "Dikdörtgenin Çevresi";
            this.btnCevre.UseVisualStyleBackColor = true;
            this.btnCevre.Click += new System.EventHandler(this.btnCevre_Click);
            // 
            // btnAlan
            // 
            this.btnAlan.Location = new System.Drawing.Point(41, 195);
            this.btnAlan.Name = "btnAlan";
            this.btnAlan.Size = new System.Drawing.Size(225, 39);
            this.btnAlan.TabIndex = 6;
            this.btnAlan.Text = "Dikdörtgenin  Alanı";
            this.btnAlan.UseVisualStyleBackColor = true;
            this.btnAlan.Click += new System.EventHandler(this.btnAlan_Click);
            // 
            // lblKosegen
            // 
            this.lblKosegen.AutoSize = true;
            this.lblKosegen.Location = new System.Drawing.Point(311, 118);
            this.lblKosegen.Name = "lblKosegen";
            this.lblKosegen.Size = new System.Drawing.Size(16, 13);
            this.lblKosegen.TabIndex = 7;
            this.lblKosegen.Text = "...";
            // 
            // lblCevre
            // 
            this.lblCevre.AutoSize = true;
            this.lblCevre.Location = new System.Drawing.Point(311, 163);
            this.lblCevre.Name = "lblCevre";
            this.lblCevre.Size = new System.Drawing.Size(16, 13);
            this.lblCevre.TabIndex = 8;
            this.lblCevre.Text = "...";
            // 
            // lblAlan
            // 
            this.lblAlan.AutoSize = true;
            this.lblAlan.Location = new System.Drawing.Point(311, 208);
            this.lblAlan.Name = "lblAlan";
            this.lblAlan.Size = new System.Drawing.Size(16, 13);
            this.lblAlan.TabIndex = 9;
            this.lblAlan.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 294);
            this.Controls.Add(this.lblAlan);
            this.Controls.Add(this.lblCevre);
            this.Controls.Add(this.lblKosegen);
            this.Controls.Add(this.btnAlan);
            this.Controls.Add(this.btnCevre);
            this.Controls.Add(this.btnKosegen);
            this.Controls.Add(this.txtKısaKenar);
            this.Controls.Add(this.txtUzunKenar);
            this.Controls.Add(this.lblKısaKenar);
            this.Controls.Add(this.lblUzunKenar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUzunKenar;
        private System.Windows.Forms.Label lblKısaKenar;
        private System.Windows.Forms.TextBox txtUzunKenar;
        private System.Windows.Forms.TextBox txtKısaKenar;
        private System.Windows.Forms.Button btnKosegen;
        private System.Windows.Forms.Button btnCevre;
        private System.Windows.Forms.Button btnAlan;
        private System.Windows.Forms.Label lblKosegen;
        private System.Windows.Forms.Label lblCevre;
        private System.Windows.Forms.Label lblAlan;
    }
}

