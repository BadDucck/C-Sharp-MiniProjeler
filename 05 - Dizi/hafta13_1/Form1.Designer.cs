namespace hafta13_1
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
            this.lblSatırSayısı = new System.Windows.Forms.Label();
            this.lblSutunSayisi = new System.Windows.Forms.Label();
            this.lblMaksimum = new System.Windows.Forms.Label();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.txtMinimum = new System.Windows.Forms.TextBox();
            this.txtMaksimum = new System.Windows.Forms.TextBox();
            this.txtSatir = new System.Windows.Forms.TextBox();
            this.txtSutun = new System.Windows.Forms.TextBox();
            this.btnDiziOlustur = new System.Windows.Forms.Button();
            this.btnDiziyiGoster = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblSatırSayısı
            // 
            this.lblSatırSayısı.AutoSize = true;
            this.lblSatırSayısı.Location = new System.Drawing.Point(152, 77);
            this.lblSatırSayısı.Name = "lblSatırSayısı";
            this.lblSatırSayısı.Size = new System.Drawing.Size(75, 16);
            this.lblSatırSayısı.TabIndex = 0;
            this.lblSatırSayısı.Text = "Satır sayısı:";
            this.lblSatırSayısı.Click += new System.EventHandler(this.lblSatırSayısı_Click);
            // 
            // lblSutunSayisi
            // 
            this.lblSutunSayisi.AutoSize = true;
            this.lblSutunSayisi.Location = new System.Drawing.Point(152, 114);
            this.lblSutunSayisi.Name = "lblSutunSayisi";
            this.lblSutunSayisi.Size = new System.Drawing.Size(81, 16);
            this.lblSutunSayisi.TabIndex = 1;
            this.lblSutunSayisi.Text = "Sütun sayısı:";
            this.lblSutunSayisi.Click += new System.EventHandler(this.lblSutunSayisi_Click);
            // 
            // lblMaksimum
            // 
            this.lblMaksimum.AutoSize = true;
            this.lblMaksimum.Location = new System.Drawing.Point(152, 244);
            this.lblMaksimum.Name = "lblMaksimum";
            this.lblMaksimum.Size = new System.Drawing.Size(113, 16);
            this.lblMaksimum.TabIndex = 2;
            this.lblMaksimum.Text = "Maksimum Değer";
            this.lblMaksimum.Click += new System.EventHandler(this.lblMaksimum_Click);
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Location = new System.Drawing.Point(152, 204);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(101, 16);
            this.lblMinimum.TabIndex = 3;
            this.lblMinimum.Text = "Minimum Değer";
            this.lblMinimum.Click += new System.EventHandler(this.lblMinimum_Click);
            // 
            // txtMinimum
            // 
            this.txtMinimum.Location = new System.Drawing.Point(285, 204);
            this.txtMinimum.Name = "txtMinimum";
            this.txtMinimum.Size = new System.Drawing.Size(100, 22);
            this.txtMinimum.TabIndex = 4;
            this.txtMinimum.TextChanged += new System.EventHandler(this.txtMinimum_TextChanged);
            this.txtMinimum.Validated += new System.EventHandler(this.txtMinimum_Validated);
            // 
            // txtMaksimum
            // 
            this.txtMaksimum.Location = new System.Drawing.Point(285, 244);
            this.txtMaksimum.Name = "txtMaksimum";
            this.txtMaksimum.Size = new System.Drawing.Size(100, 22);
            this.txtMaksimum.TabIndex = 5;
            this.txtMaksimum.TextChanged += new System.EventHandler(this.txtMaksimum_TextChanged);
            // 
            // txtSatir
            // 
            this.txtSatir.Location = new System.Drawing.Point(285, 77);
            this.txtSatir.Name = "txtSatir";
            this.txtSatir.Size = new System.Drawing.Size(100, 22);
            this.txtSatir.TabIndex = 6;
            this.txtSatir.TextChanged += new System.EventHandler(this.txtSatir_TextChanged);
            // 
            // txtSutun
            // 
            this.txtSutun.Location = new System.Drawing.Point(285, 114);
            this.txtSutun.Name = "txtSutun";
            this.txtSutun.Size = new System.Drawing.Size(100, 22);
            this.txtSutun.TabIndex = 7;
            this.txtSutun.TextChanged += new System.EventHandler(this.txtSutun_TextChanged);
            // 
            // btnDiziOlustur
            // 
            this.btnDiziOlustur.Location = new System.Drawing.Point(151, 301);
            this.btnDiziOlustur.Name = "btnDiziOlustur";
            this.btnDiziOlustur.Size = new System.Drawing.Size(234, 41);
            this.btnDiziOlustur.TabIndex = 9;
            this.btnDiziOlustur.Text = "Diziyi Oluştur";
            this.btnDiziOlustur.UseVisualStyleBackColor = true;
            this.btnDiziOlustur.Click += new System.EventHandler(this.btnDiziOlustur_Click);
            // 
            // btnDiziyiGoster
            // 
            this.btnDiziyiGoster.Location = new System.Drawing.Point(452, 74);
            this.btnDiziyiGoster.Name = "btnDiziyiGoster";
            this.btnDiziyiGoster.Size = new System.Drawing.Size(185, 23);
            this.btnDiziyiGoster.TabIndex = 11;
            this.btnDiziyiGoster.Text = "Diziyi Göster";
            this.btnDiziyiGoster.UseVisualStyleBackColor = true;
            this.btnDiziyiGoster.Click += new System.EventHandler(this.btnDiziyiGoster_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(452, 114);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(185, 228);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnDiziyiGoster);
            this.Controls.Add(this.btnDiziOlustur);
            this.Controls.Add(this.txtSutun);
            this.Controls.Add(this.txtSatir);
            this.Controls.Add(this.txtMaksimum);
            this.Controls.Add(this.txtMinimum);
            this.Controls.Add(this.lblMinimum);
            this.Controls.Add(this.lblMaksimum);
            this.Controls.Add(this.lblSutunSayisi);
            this.Controls.Add(this.lblSatırSayısı);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSatırSayısı;
        private System.Windows.Forms.Label lblSutunSayisi;
        private System.Windows.Forms.Label lblMaksimum;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.TextBox txtMinimum;
        private System.Windows.Forms.TextBox txtMaksimum;
        private System.Windows.Forms.TextBox txtSatir;
        private System.Windows.Forms.TextBox txtSutun;
        private System.Windows.Forms.Button btnDiziOlustur;
        private System.Windows.Forms.Button btnDiziyiGoster;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

