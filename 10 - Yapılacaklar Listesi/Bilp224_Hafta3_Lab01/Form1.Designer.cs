namespace Bilp224_Hafta3_Lab01
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
            this.lblYapilacaklar = new System.Windows.Forms.Label();
            this.txtbListe = new System.Windows.Forms.TextBox();
            this.btnYaz = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblYapilacaklar
            // 
            this.lblYapilacaklar.AutoSize = true;
            this.lblYapilacaklar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYapilacaklar.Location = new System.Drawing.Point(25, 28);
            this.lblYapilacaklar.Name = "lblYapilacaklar";
            this.lblYapilacaklar.Size = new System.Drawing.Size(131, 25);
            this.lblYapilacaklar.TabIndex = 0;
            this.lblYapilacaklar.Text = "Yapılacaklar";
            // 
            // txtbListe
            // 
            this.txtbListe.Location = new System.Drawing.Point(30, 56);
            this.txtbListe.Multiline = true;
            this.txtbListe.Name = "txtbListe";
            this.txtbListe.Size = new System.Drawing.Size(243, 294);
            this.txtbListe.TabIndex = 1;
            // 
            // btnYaz
            // 
            this.btnYaz.Location = new System.Drawing.Point(30, 367);
            this.btnYaz.Name = "btnYaz";
            this.btnYaz.Size = new System.Drawing.Size(243, 34);
            this.btnYaz.TabIndex = 2;
            this.btnYaz.Text = "Yapılacaklar.txt Dosyasına Yaz";
            this.btnYaz.UseVisualStyleBackColor = true;
            this.btnYaz.Click += new System.EventHandler(this.btnYaz_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(279, 367);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(243, 34);
            this.btnGetir.TabIndex = 4;
            this.btnGetir.Text = "Yapılacaklar Listesini Göster";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(274, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Yapılacaklar Listesi";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(279, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 290);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 439);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.btnYaz);
            this.Controls.Add(this.txtbListe);
            this.Controls.Add(this.lblYapilacaklar);
            this.Name = "Form1";
            this.Text = "Yapılacaklar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYapilacaklar;
        private System.Windows.Forms.TextBox txtbListe;
        private System.Windows.Forms.Button btnYaz;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

