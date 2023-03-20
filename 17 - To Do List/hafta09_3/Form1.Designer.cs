namespace hafta09_3
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
            this.txtTxt = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCıkar = new System.Windows.Forms.Button();
            this.btnHepsiniSil = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.lbBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtTxt
            // 
            this.txtTxt.Location = new System.Drawing.Point(231, 102);
            this.txtTxt.Name = "txtTxt";
            this.txtTxt.Size = new System.Drawing.Size(149, 22);
            this.txtTxt.TabIndex = 0;
            this.txtTxt.TextChanged += new System.EventHandler(this.txtTxt_TextChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(231, 130);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(149, 37);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnCıkar
            // 
            this.btnCıkar.Location = new System.Drawing.Point(231, 173);
            this.btnCıkar.Name = "btnCıkar";
            this.btnCıkar.Size = new System.Drawing.Size(149, 37);
            this.btnCıkar.TabIndex = 2;
            this.btnCıkar.Text = "Çıkar";
            this.btnCıkar.UseVisualStyleBackColor = true;
            this.btnCıkar.Click += new System.EventHandler(this.btnCıkar_Click);
            // 
            // btnHepsiniSil
            // 
            this.btnHepsiniSil.Location = new System.Drawing.Point(231, 216);
            this.btnHepsiniSil.Name = "btnHepsiniSil";
            this.btnHepsiniSil.Size = new System.Drawing.Size(149, 37);
            this.btnHepsiniSil.TabIndex = 3;
            this.btnHepsiniSil.Text = "Hespnini Sil";
            this.btnHepsiniSil.UseVisualStyleBackColor = true;
            this.btnHepsiniSil.Click += new System.EventHandler(this.btnHepsiniSil_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.Location = new System.Drawing.Point(231, 259);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(149, 37);
            this.btnCıkıs.TabIndex = 4;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.UseVisualStyleBackColor = true;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // lbBox
            // 
            this.lbBox.FormattingEnabled = true;
            this.lbBox.ItemHeight = 16;
            this.lbBox.Location = new System.Drawing.Point(406, 102);
            this.lbBox.Name = "lbBox";
            this.lbBox.Size = new System.Drawing.Size(120, 196);
            this.lbBox.TabIndex = 5;
            this.lbBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbBox);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.btnHepsiniSil);
            this.Controls.Add(this.btnCıkar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTxt;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCıkar;
        private System.Windows.Forms.Button btnHepsiniSil;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.ListBox lbBox;
    }
}

