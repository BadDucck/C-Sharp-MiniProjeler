namespace hafta10_4
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.musteri = new System.Windows.Forms.TabPage();
            this.siparis = new System.Windows.Forms.TabPage();
            this.lblHesap = new System.Windows.Forms.TabPage();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblCorba = new System.Windows.Forms.Label();
            this.lblSalata = new System.Windows.Forms.Label();
            this.lblAnaYemek = new System.Windows.Forms.Label();
            this.lblTatlı = new System.Windows.Forms.Label();
            this.nCorba = new System.Windows.Forms.NumericUpDown();
            this.nSalata = new System.Windows.Forms.NumericUpDown();
            this.nYemek = new System.Windows.Forms.NumericUpDown();
            this.nTatlı = new System.Windows.Forms.NumericUpDown();
            this.lblTutar = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.musteri.SuspendLayout();
            this.siparis.SuspendLayout();
            this.lblHesap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCorba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSalata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nYemek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTatlı)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.musteri);
            this.tabControl1.Controls.Add(this.siparis);
            this.tabControl1.Controls.Add(this.lblHesap);
            this.tabControl1.Location = new System.Drawing.Point(119, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(580, 324);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.lblHesap_Click);
            // 
            // musteri
            // 
            this.musteri.Controls.Add(this.txtAdres);
            this.musteri.Controls.Add(this.txtTelefon);
            this.musteri.Controls.Add(this.txtAdSoyad);
            this.musteri.Controls.Add(this.lblAdres);
            this.musteri.Controls.Add(this.lblTelefon);
            this.musteri.Controls.Add(this.lblAdSoyad);
            this.musteri.Location = new System.Drawing.Point(4, 25);
            this.musteri.Name = "musteri";
            this.musteri.Padding = new System.Windows.Forms.Padding(3);
            this.musteri.Size = new System.Drawing.Size(572, 295);
            this.musteri.TabIndex = 0;
            this.musteri.Text = "Muşteri";
            this.musteri.UseVisualStyleBackColor = true;
            // 
            // siparis
            // 
            this.siparis.Controls.Add(this.nTatlı);
            this.siparis.Controls.Add(this.nYemek);
            this.siparis.Controls.Add(this.nSalata);
            this.siparis.Controls.Add(this.nCorba);
            this.siparis.Controls.Add(this.lblTatlı);
            this.siparis.Controls.Add(this.lblAnaYemek);
            this.siparis.Controls.Add(this.lblSalata);
            this.siparis.Controls.Add(this.lblCorba);
            this.siparis.Location = new System.Drawing.Point(4, 25);
            this.siparis.Name = "siparis";
            this.siparis.Padding = new System.Windows.Forms.Padding(3);
            this.siparis.Size = new System.Drawing.Size(572, 295);
            this.siparis.TabIndex = 1;
            this.siparis.Text = "Sipariş";
            this.siparis.UseVisualStyleBackColor = true;
            // 
            // lblHesap
            // 
            this.lblHesap.Controls.Add(this.lblTutar);
            this.lblHesap.Location = new System.Drawing.Point(4, 25);
            this.lblHesap.Name = "lblHesap";
            this.lblHesap.Size = new System.Drawing.Size(572, 295);
            this.lblHesap.TabIndex = 2;
            this.lblHesap.Tag = "asd";
            this.lblHesap.Text = "Hesap";
            this.lblHesap.UseVisualStyleBackColor = true;
            this.lblHesap.Click += new System.EventHandler(this.lblHesap_Click);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(97, 75);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(70, 16);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "Ad Soyad:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(97, 109);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(56, 16);
            this.lblTelefon.TabIndex = 1;
            this.lblTelefon.Text = "Telefon:";
            this.lblTelefon.Click += new System.EventHandler(this.lblTelefon_Click);
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(97, 143);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(46, 16);
            this.lblAdres.TabIndex = 2;
            this.lblAdres.Text = "Adres:";
            this.lblAdres.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(173, 75);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(173, 109);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 4;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(173, 143);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(277, 22);
            this.txtAdres.TabIndex = 5;
            // 
            // lblCorba
            // 
            this.lblCorba.AutoSize = true;
            this.lblCorba.Location = new System.Drawing.Point(146, 65);
            this.lblCorba.Name = "lblCorba";
            this.lblCorba.Size = new System.Drawing.Size(47, 16);
            this.lblCorba.TabIndex = 0;
            this.lblCorba.Text = "Çorba:";
            // 
            // lblSalata
            // 
            this.lblSalata.AutoSize = true;
            this.lblSalata.Location = new System.Drawing.Point(146, 102);
            this.lblSalata.Name = "lblSalata";
            this.lblSalata.Size = new System.Drawing.Size(49, 16);
            this.lblSalata.TabIndex = 1;
            this.lblSalata.Text = "Salata:";
            // 
            // lblAnaYemek
            // 
            this.lblAnaYemek.AutoSize = true;
            this.lblAnaYemek.Location = new System.Drawing.Point(146, 139);
            this.lblAnaYemek.Name = "lblAnaYemek";
            this.lblAnaYemek.Size = new System.Drawing.Size(80, 16);
            this.lblAnaYemek.TabIndex = 2;
            this.lblAnaYemek.Text = "Ana Yemek:";
            this.lblAnaYemek.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTatlı
            // 
            this.lblTatlı.AutoSize = true;
            this.lblTatlı.Location = new System.Drawing.Point(146, 177);
            this.lblTatlı.Name = "lblTatlı";
            this.lblTatlı.Size = new System.Drawing.Size(36, 16);
            this.lblTatlı.TabIndex = 3;
            this.lblTatlı.Text = "Tatlı:";
            // 
            // nCorba
            // 
            this.nCorba.Location = new System.Drawing.Point(243, 65);
            this.nCorba.Name = "nCorba";
            this.nCorba.Size = new System.Drawing.Size(120, 22);
            this.nCorba.TabIndex = 4;
            // 
            // nSalata
            // 
            this.nSalata.Location = new System.Drawing.Point(243, 102);
            this.nSalata.Name = "nSalata";
            this.nSalata.Size = new System.Drawing.Size(120, 22);
            this.nSalata.TabIndex = 5;
            // 
            // nYemek
            // 
            this.nYemek.Location = new System.Drawing.Point(243, 139);
            this.nYemek.Name = "nYemek";
            this.nYemek.Size = new System.Drawing.Size(120, 22);
            this.nYemek.TabIndex = 6;
            // 
            // nTatlı
            // 
            this.nTatlı.Location = new System.Drawing.Point(243, 177);
            this.nTatlı.Name = "nTatlı";
            this.nTatlı.Size = new System.Drawing.Size(120, 22);
            this.nTatlı.TabIndex = 7;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(16, 23);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(38, 16);
            this.lblTutar.TabIndex = 0;
            this.lblTutar.Text = "Tutar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.musteri.ResumeLayout(false);
            this.musteri.PerformLayout();
            this.siparis.ResumeLayout(false);
            this.siparis.PerformLayout();
            this.lblHesap.ResumeLayout(false);
            this.lblHesap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCorba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSalata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nYemek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTatlı)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage musteri;
        private System.Windows.Forms.TabPage siparis;
        private System.Windows.Forms.TabPage lblHesap;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblTatlı;
        private System.Windows.Forms.Label lblAnaYemek;
        private System.Windows.Forms.Label lblSalata;
        private System.Windows.Forms.Label lblCorba;
        private System.Windows.Forms.NumericUpDown nTatlı;
        private System.Windows.Forms.NumericUpDown nYemek;
        private System.Windows.Forms.NumericUpDown nSalata;
        private System.Windows.Forms.NumericUpDown nCorba;
        private System.Windows.Forms.Label lblTutar;
    }
}

