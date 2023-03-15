namespace hafta10_1
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
            this.chkListBox = new System.Windows.Forms.CheckedListBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.txtUrun = new System.Windows.Forms.TextBox();
            this.btnGec = new System.Windows.Forms.Button();
            this.lblAlınacaklar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkListBox
            // 
            this.chkListBox.FormattingEnabled = true;
            this.chkListBox.Location = new System.Drawing.Point(163, 131);
            this.chkListBox.Name = "chkListBox";
            this.chkListBox.Size = new System.Drawing.Size(144, 191);
            this.chkListBox.TabIndex = 0;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(498, 126);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(144, 196);
            this.listBox.TabIndex = 1;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(163, 56);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(61, 16);
            this.lblUrunAdi.TabIndex = 2;
            this.lblUrunAdi.Text = "Ürün Adı:";
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(199, 102);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(75, 23);
            this.btnUrunEkle.TabIndex = 3;
            this.btnUrunEkle.Text = "EKLE";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // txtUrun
            // 
            this.txtUrun.Location = new System.Drawing.Point(230, 56);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.Size = new System.Drawing.Size(100, 22);
            this.txtUrun.TabIndex = 4;
            // 
            // btnGec
            // 
            this.btnGec.Location = new System.Drawing.Point(363, 195);
            this.btnGec.Name = "btnGec";
            this.btnGec.Size = new System.Drawing.Size(75, 23);
            this.btnGec.TabIndex = 5;
            this.btnGec.Text = ">>>";
            this.btnGec.UseVisualStyleBackColor = true;
            this.btnGec.Click += new System.EventHandler(this.btnGec_Click);
            // 
            // lblAlınacaklar
            // 
            this.lblAlınacaklar.AutoSize = true;
            this.lblAlınacaklar.Location = new System.Drawing.Point(498, 85);
            this.lblAlınacaklar.Name = "lblAlınacaklar";
            this.lblAlınacaklar.Size = new System.Drawing.Size(77, 16);
            this.lblAlınacaklar.TabIndex = 6;
            this.lblAlınacaklar.Text = "Alınacaklar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAlınacaklar);
            this.Controls.Add(this.btnGec);
            this.Controls.Add(this.txtUrun);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.chkListBox);
            this.Name = "Form1";
            this.Text = "Alışveriş Listesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkListBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.TextBox txtUrun;
        private System.Windows.Forms.Button btnGec;
        private System.Windows.Forms.Label lblAlınacaklar;
    }
}

