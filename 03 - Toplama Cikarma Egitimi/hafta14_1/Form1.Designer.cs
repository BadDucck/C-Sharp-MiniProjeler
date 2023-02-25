namespace hafta14_1
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
            this.lblPuanYazi = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblOynananYazi = new System.Windows.Forms.Label();
            this.lblOynanan = new System.Windows.Forms.Label();
            this.cmbZorluk = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRakam = new System.Windows.Forms.TextBox();
            this.txtRakam2 = new System.Windows.Forms.TextBox();
            this.txtSoru = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCıkarma = new System.Windows.Forms.RadioButton();
            this.rdbToplama = new System.Windows.Forms.RadioButton();
            this.lblEsittir = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.cbNegatif = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPuanYazi
            // 
            this.lblPuanYazi.AutoSize = true;
            this.lblPuanYazi.Location = new System.Drawing.Point(39, 27);
            this.lblPuanYazi.Name = "lblPuanYazi";
            this.lblPuanYazi.Size = new System.Drawing.Size(63, 16);
            this.lblPuanYazi.TabIndex = 0;
            this.lblPuanYazi.Text = "Puanınız: ";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Location = new System.Drawing.Point(108, 27);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(14, 16);
            this.lblPuan.TabIndex = 1;
            this.lblPuan.Text = "0";
            this.lblPuan.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblOynananYazi
            // 
            this.lblOynananYazi.AutoSize = true;
            this.lblOynananYazi.Location = new System.Drawing.Point(39, 59);
            this.lblOynananYazi.Name = "lblOynananYazi";
            this.lblOynananYazi.Size = new System.Drawing.Size(89, 16);
            this.lblOynananYazi.TabIndex = 2;
            this.lblOynananYazi.Text = "Oynana oyun:";
            this.lblOynananYazi.Click += new System.EventHandler(this.lblOynananYazi_Click);
            // 
            // lblOynanan
            // 
            this.lblOynanan.AutoSize = true;
            this.lblOynanan.Location = new System.Drawing.Point(134, 59);
            this.lblOynanan.Name = "lblOynanan";
            this.lblOynanan.Size = new System.Drawing.Size(14, 16);
            this.lblOynanan.TabIndex = 3;
            this.lblOynanan.Text = "1";
            // 
            // cmbZorluk
            // 
            this.cmbZorluk.FormattingEnabled = true;
            this.cmbZorluk.Items.AddRange(new object[] {
            "Kolay",
            "Orta",
            "Zor"});
            this.cmbZorluk.Location = new System.Drawing.Point(142, 95);
            this.cmbZorluk.Name = "cmbZorluk";
            this.cmbZorluk.Size = new System.Drawing.Size(121, 24);
            this.cmbZorluk.TabIndex = 4;
            this.cmbZorluk.SelectedIndexChanged += new System.EventHandler(this.cmbZorluk_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zorluk seviyesi";
            // 
            // txtRakam
            // 
            this.txtRakam.Location = new System.Drawing.Point(184, 238);
            this.txtRakam.Name = "txtRakam";
            this.txtRakam.Size = new System.Drawing.Size(107, 22);
            this.txtRakam.TabIndex = 6;
            this.txtRakam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRakam2
            // 
            this.txtRakam2.Location = new System.Drawing.Point(395, 238);
            this.txtRakam2.Name = "txtRakam2";
            this.txtRakam2.Size = new System.Drawing.Size(107, 22);
            this.txtRakam2.TabIndex = 7;
            this.txtRakam2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRakam2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSoru
            // 
            this.txtSoru.Location = new System.Drawing.Point(313, 238);
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(60, 22);
            this.txtSoru.TabIndex = 8;
            this.txtSoru.Text = "?";
            this.txtSoru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCıkarma);
            this.groupBox1.Controls.Add(this.rdbToplama);
            this.groupBox1.Location = new System.Drawing.Point(313, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 154);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cevbınız:";
            // 
            // rdbCıkarma
            // 
            this.rdbCıkarma.AutoSize = true;
            this.rdbCıkarma.Location = new System.Drawing.Point(27, 76);
            this.rdbCıkarma.Name = "rdbCıkarma";
            this.rdbCıkarma.Size = new System.Drawing.Size(93, 20);
            this.rdbCıkarma.TabIndex = 1;
            this.rdbCıkarma.Text = "Çıkarma (-)";
            this.rdbCıkarma.UseVisualStyleBackColor = true;
            this.rdbCıkarma.CheckedChanged += new System.EventHandler(this.rdbCıkarma_CheckedChanged);
            // 
            // rdbToplama
            // 
            this.rdbToplama.AutoSize = true;
            this.rdbToplama.Location = new System.Drawing.Point(27, 39);
            this.rdbToplama.Name = "rdbToplama";
            this.rdbToplama.Size = new System.Drawing.Size(101, 20);
            this.rdbToplama.TabIndex = 0;
            this.rdbToplama.TabStop = true;
            this.rdbToplama.Text = "Toplama (+)";
            this.rdbToplama.UseVisualStyleBackColor = true;
            this.rdbToplama.CheckedChanged += new System.EventHandler(this.rdbToplama_CheckedChanged);
            // 
            // lblEsittir
            // 
            this.lblEsittir.AutoSize = true;
            this.lblEsittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEsittir.Location = new System.Drawing.Point(522, 235);
            this.lblEsittir.Name = "lblEsittir";
            this.lblEsittir.Size = new System.Drawing.Size(24, 25);
            this.lblEsittir.TabIndex = 10;
            this.lblEsittir.Text = "=";
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(12, 415);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 11;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(552, 239);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(100, 22);
            this.txtSonuc.TabIndex = 12;
            // 
            // cbNegatif
            // 
            this.cbNegatif.AutoSize = true;
            this.cbNegatif.Location = new System.Drawing.Point(615, 415);
            this.cbNegatif.Name = "cbNegatif";
            this.cbNegatif.Size = new System.Drawing.Size(173, 20);
            this.cbNegatif.TabIndex = 13;
            this.cbNegatif.Text = "Negatif Değer Gelmesin";
            this.cbNegatif.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbNegatif);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.lblEsittir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoru);
            this.Controls.Add(this.txtRakam2);
            this.Controls.Add(this.txtRakam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbZorluk);
            this.Controls.Add(this.lblOynanan);
            this.Controls.Add(this.lblOynananYazi);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.lblPuanYazi);
            this.Name = "Form1";
            this.Text = "l";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPuanYazi;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblOynananYazi;
        private System.Windows.Forms.Label lblOynanan;
        private System.Windows.Forms.ComboBox cmbZorluk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRakam;
        private System.Windows.Forms.TextBox txtRakam2;
        private System.Windows.Forms.TextBox txtSoru;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEsittir;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.RadioButton rdbCıkarma;
        private System.Windows.Forms.RadioButton rdbToplama;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.CheckBox cbNegatif;
    }
}

