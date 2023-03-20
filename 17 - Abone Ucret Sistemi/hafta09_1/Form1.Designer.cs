namespace hafta09_1
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
            this.lblacilistutari = new System.Windows.Forms.Label();
            this.txtacilistutari = new System.Windows.Forms.TextBox();
            this.lblTl = new System.Windows.Forms.Label();
            this.chkKdv = new System.Windows.Forms.CheckBox();
            this.chOzelVergi = new System.Windows.Forms.CheckBox();
            this.chkAbone = new System.Windows.Forms.CheckBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtHesap = new System.Windows.Forms.TextBox();
            this.lblTL2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblacilistutari
            // 
            this.lblacilistutari.AutoSize = true;
            this.lblacilistutari.Location = new System.Drawing.Point(195, 92);
            this.lblacilistutari.Name = "lblacilistutari";
            this.lblacilistutari.Size = new System.Drawing.Size(76, 16);
            this.lblacilistutari.TabIndex = 0;
            this.lblacilistutari.Text = "Açılış Tutarı";
            // 
            // txtacilistutari
            // 
            this.txtacilistutari.Location = new System.Drawing.Point(291, 92);
            this.txtacilistutari.Name = "txtacilistutari";
            this.txtacilistutari.Size = new System.Drawing.Size(100, 22);
            this.txtacilistutari.TabIndex = 1;
            this.txtacilistutari.TextChanged += new System.EventHandler(this.txtacilistutari_TextChanged);
            // 
            // lblTl
            // 
            this.lblTl.AutoSize = true;
            this.lblTl.Location = new System.Drawing.Point(409, 92);
            this.lblTl.Name = "lblTl";
            this.lblTl.Size = new System.Drawing.Size(23, 16);
            this.lblTl.TabIndex = 2;
            this.lblTl.Text = "TL";
            // 
            // chkKdv
            // 
            this.chkKdv.AutoSize = true;
            this.chkKdv.Location = new System.Drawing.Point(291, 152);
            this.chkKdv.Name = "chkKdv";
            this.chkKdv.Size = new System.Drawing.Size(85, 20);
            this.chkKdv.TabIndex = 3;
            this.chkKdv.Text = "KDV %18";
            this.chkKdv.UseVisualStyleBackColor = true;
            this.chkKdv.CheckedChanged += new System.EventHandler(this.chkKdv_CheckedChanged);
            // 
            // chOzelVergi
            // 
            this.chOzelVergi.AutoSize = true;
            this.chOzelVergi.Location = new System.Drawing.Point(291, 190);
            this.chOzelVergi.Name = "chOzelVergi";
            this.chOzelVergi.Size = new System.Drawing.Size(182, 20);
            this.chOzelVergi.TabIndex = 4;
            this.chOzelVergi.TabStop = false;
            this.chOzelVergi.Text = "Özel iletişim vergisi 4 %25";
            this.chOzelVergi.ThreeState = true;
            this.chOzelVergi.UseVisualStyleBackColor = true;
            this.chOzelVergi.CheckedChanged += new System.EventHandler(this.chOzelVergi_CheckedChanged);
            // 
            // chkAbone
            // 
            this.chkAbone.AutoSize = true;
            this.chkAbone.Location = new System.Drawing.Point(291, 229);
            this.chkAbone.Name = "chkAbone";
            this.chkAbone.Size = new System.Drawing.Size(137, 20);
            this.chkAbone.TabIndex = 5;
            this.chkAbone.Text = "Abone Kayıt 22 TL";
            this.chkAbone.UseVisualStyleBackColor = true;
            this.chkAbone.CheckedChanged += new System.EventHandler(this.chkAbone_CheckedChanged);
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(233, 277);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(38, 16);
            this.lblTutar.TabIndex = 6;
            this.lblTutar.Text = "Tutar";
            this.lblTutar.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHesap
            // 
            this.txtHesap.Location = new System.Drawing.Point(291, 277);
            this.txtHesap.Name = "txtHesap";
            this.txtHesap.Size = new System.Drawing.Size(100, 22);
            this.txtHesap.TabIndex = 7;
            // 
            // lblTL2
            // 
            this.lblTL2.AutoSize = true;
            this.lblTL2.Location = new System.Drawing.Point(409, 277);
            this.lblTL2.Name = "lblTL2";
            this.lblTL2.Size = new System.Drawing.Size(23, 16);
            this.lblTL2.TabIndex = 8;
            this.lblTL2.Text = "TL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTL2);
            this.Controls.Add(this.txtHesap);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.chkAbone);
            this.Controls.Add(this.chOzelVergi);
            this.Controls.Add(this.chkKdv);
            this.Controls.Add(this.lblTl);
            this.Controls.Add(this.txtacilistutari);
            this.Controls.Add(this.lblacilistutari);
            this.Name = "Form1";
            this.Text = "Abone Ucreti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblacilistutari;
        private System.Windows.Forms.TextBox txtacilistutari;
        private System.Windows.Forms.Label lblTl;
        private System.Windows.Forms.CheckBox chkKdv;
        private System.Windows.Forms.CheckBox chOzelVergi;
        private System.Windows.Forms.CheckBox chkAbone;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtHesap;
        private System.Windows.Forms.Label lblTL2;
    }
}

