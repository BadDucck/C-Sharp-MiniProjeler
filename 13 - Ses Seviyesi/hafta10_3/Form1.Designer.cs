namespace hafta10_3
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblSes = new System.Windows.Forms.Label();
            this.lblSesSeviyesi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(224, 179);
            this.trackBar1.Maximum = 15;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(333, 56);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblSes
            // 
            this.lblSes.AutoSize = true;
            this.lblSes.Location = new System.Drawing.Point(224, 84);
            this.lblSes.Name = "lblSes";
            this.lblSes.Size = new System.Drawing.Size(122, 16);
            this.lblSes.TabIndex = 1;
            this.lblSes.Text = "Ses Seviyesi (0-15)";
            // 
            // lblSesSeviyesi
            // 
            this.lblSesSeviyesi.AutoSize = true;
            this.lblSesSeviyesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSesSeviyesi.Location = new System.Drawing.Point(222, 279);
            this.lblSesSeviyesi.Name = "lblSesSeviyesi";
            this.lblSesSeviyesi.Size = new System.Drawing.Size(167, 29);
            this.lblSesSeviyesi.TabIndex = 2;
            this.lblSesSeviyesi.Text = "Ses Seviyesi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSesSeviyesi);
            this.Controls.Add(this.lblSes);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblSes;
        private System.Windows.Forms.Label lblSesSeviyesi;
    }
}

