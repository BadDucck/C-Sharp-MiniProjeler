namespace hafta12_1
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
            this.lblSayı1 = new System.Windows.Forms.Label();
            this.lblSayı2 = new System.Windows.Forms.Label();
            this.lblSayı3 = new System.Windows.Forms.Label();
            this.lblSayı4 = new System.Windows.Forms.Label();
            this.lblSayı5 = new System.Windows.Forms.Label();
            this.lblSayı6 = new System.Windows.Forms.Label();
            this.btnSayı = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSayı1
            // 
            this.lblSayı1.AutoSize = true;
            this.lblSayı1.Location = new System.Drawing.Point(148, 164);
            this.lblSayı1.Name = "lblSayı1";
            this.lblSayı1.Size = new System.Drawing.Size(47, 16);
            this.lblSayı1.TabIndex = 0;
            this.lblSayı1.Text = "1. Sayı";
            this.lblSayı1.Click += new System.EventHandler(this.lblSayı1_Click);
            // 
            // lblSayı2
            // 
            this.lblSayı2.AutoSize = true;
            this.lblSayı2.Location = new System.Drawing.Point(236, 164);
            this.lblSayı2.Name = "lblSayı2";
            this.lblSayı2.Size = new System.Drawing.Size(47, 16);
            this.lblSayı2.TabIndex = 1;
            this.lblSayı2.Text = "2. Sayı";
            this.lblSayı2.Click += new System.EventHandler(this.lblSayı2_Click);
            // 
            // lblSayı3
            // 
            this.lblSayı3.AutoSize = true;
            this.lblSayı3.Location = new System.Drawing.Point(327, 163);
            this.lblSayı3.Name = "lblSayı3";
            this.lblSayı3.Size = new System.Drawing.Size(47, 16);
            this.lblSayı3.TabIndex = 2;
            this.lblSayı3.Text = "3. Sayı";
            this.lblSayı3.Click += new System.EventHandler(this.lblSayı3_Click);
            // 
            // lblSayı4
            // 
            this.lblSayı4.AutoSize = true;
            this.lblSayı4.Location = new System.Drawing.Point(405, 163);
            this.lblSayı4.Name = "lblSayı4";
            this.lblSayı4.Size = new System.Drawing.Size(47, 16);
            this.lblSayı4.TabIndex = 3;
            this.lblSayı4.Text = "4. Sayı";
            this.lblSayı4.Click += new System.EventHandler(this.lblSayı4_Click);
            // 
            // lblSayı5
            // 
            this.lblSayı5.AutoSize = true;
            this.lblSayı5.Location = new System.Drawing.Point(488, 162);
            this.lblSayı5.Name = "lblSayı5";
            this.lblSayı5.Size = new System.Drawing.Size(47, 16);
            this.lblSayı5.TabIndex = 4;
            this.lblSayı5.Text = "5. Sayı";
            this.lblSayı5.Click += new System.EventHandler(this.lblSayı5_Click);
            // 
            // lblSayı6
            // 
            this.lblSayı6.AutoSize = true;
            this.lblSayı6.Location = new System.Drawing.Point(574, 164);
            this.lblSayı6.Name = "lblSayı6";
            this.lblSayı6.Size = new System.Drawing.Size(47, 16);
            this.lblSayı6.TabIndex = 5;
            this.lblSayı6.Text = "6. Sayı";
            this.lblSayı6.Click += new System.EventHandler(this.lblSayı6_Click);
            // 
            // btnSayı
            // 
            this.btnSayı.Location = new System.Drawing.Point(299, 276);
            this.btnSayı.Name = "btnSayı";
            this.btnSayı.Size = new System.Drawing.Size(174, 33);
            this.btnSayı.TabIndex = 6;
            this.btnSayı.Text = "Sayıları Belirle";
            this.btnSayı.UseVisualStyleBackColor = true;
            this.btnSayı.Click += new System.EventHandler(this.btnSayı_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSayı);
            this.Controls.Add(this.lblSayı6);
            this.Controls.Add(this.lblSayı5);
            this.Controls.Add(this.lblSayı4);
            this.Controls.Add(this.lblSayı3);
            this.Controls.Add(this.lblSayı2);
            this.Controls.Add(this.lblSayı1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayı1;
        private System.Windows.Forms.Label lblSayı2;
        private System.Windows.Forms.Label lblSayı3;
        private System.Windows.Forms.Label lblSayı4;
        private System.Windows.Forms.Label lblSayı5;
        private System.Windows.Forms.Label lblSayı6;
        private System.Windows.Forms.Button btnSayı;
    }
}

