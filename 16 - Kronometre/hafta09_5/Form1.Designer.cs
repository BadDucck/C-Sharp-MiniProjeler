namespace hafta09_5
{
    partial class cmbHız
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
            this.components = new System.ComponentModel.Container();
            this.lblKronometrem = new System.Windows.Forms.Label();
            this.txtSaniye = new System.Windows.Forms.TextBox();
            this.lblSüre = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.lblKalan = new System.Windows.Forms.Label();
            this.lblSayac = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblKronometrem
            // 
            this.lblKronometrem.AutoSize = true;
            this.lblKronometrem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKronometrem.Location = new System.Drawing.Point(206, 9);
            this.lblKronometrem.Name = "lblKronometrem";
            this.lblKronometrem.Size = new System.Drawing.Size(433, 58);
            this.lblKronometrem.TabIndex = 0;
            this.lblKronometrem.Text = "KRONOMETREM";
            // 
            // txtSaniye
            // 
            this.txtSaniye.Location = new System.Drawing.Point(282, 109);
            this.txtSaniye.Name = "txtSaniye";
            this.txtSaniye.Size = new System.Drawing.Size(100, 22);
            this.txtSaniye.TabIndex = 2;
            // 
            // lblSüre
            // 
            this.lblSüre.AutoSize = true;
            this.lblSüre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSüre.Location = new System.Drawing.Point(101, 105);
            this.lblSüre.Name = "lblSüre";
            this.lblSüre.Size = new System.Drawing.Size(175, 25);
            this.lblSüre.TabIndex = 3;
            this.lblSüre.Text = "Süre girin (Saniye)";
            this.lblSüre.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hızlı",
            "Orta",
            "Yavaş"});
            this.comboBox1.Location = new System.Drawing.Point(106, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(276, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Hız Seçiniz";
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(106, 243);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(135, 42);
            this.btnBasla.TabIndex = 5;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.Location = new System.Drawing.Point(247, 243);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(135, 42);
            this.btnDurdur.TabIndex = 6;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // lblKalan
            // 
            this.lblKalan.AutoSize = true;
            this.lblKalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalan.Location = new System.Drawing.Point(465, 105);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(116, 25);
            this.lblKalan.TabIndex = 7;
            this.lblKalan.Text = "Kalan Süre:";
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayac.Location = new System.Drawing.Point(528, 149);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(53, 58);
            this.lblSayac.TabIndex = 8;
            this.lblSayac.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(470, 243);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(206, 148);
            this.listBox1.TabIndex = 9;
            // 
            // cmbHız
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblSayac);
            this.Controls.Add(this.lblKalan);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSüre);
            this.Controls.Add(this.txtSaniye);
            this.Controls.Add(this.lblKronometrem);
            this.Name = "cmbHız";
            this.Text = "Kronometre";
            this.Load += new System.EventHandler(this.cmbHız_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKronometrem;
        private System.Windows.Forms.TextBox txtSaniye;
        private System.Windows.Forms.Label lblSüre;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Label lblKalan;
        private System.Windows.Forms.Label lblSayac;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

