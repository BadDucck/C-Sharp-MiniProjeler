namespace hafta10_2
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKur = new System.Windows.Forms.Button();
            this.nmrDakika = new System.Windows.Forms.NumericUpDown();
            this.nmrSaat = new System.Windows.Forms.NumericUpDown();
            this.lblSaat = new System.Windows.Forms.Label();
            this.nmrYıl = new System.Windows.Forms.NumericUpDown();
            this.nmrAy = new System.Windows.Forms.NumericUpDown();
            this.nmrGun = new System.Windows.Forms.NumericUpDown();
            this.lblTarih = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDakika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrYıl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGun)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKur);
            this.groupBox1.Controls.Add(this.nmrDakika);
            this.groupBox1.Controls.Add(this.nmrSaat);
            this.groupBox1.Controls.Add(this.lblSaat);
            this.groupBox1.Controls.Add(this.nmrYıl);
            this.groupBox1.Controls.Add(this.nmrAy);
            this.groupBox1.Controls.Add(this.nmrGun);
            this.groupBox1.Controls.Add(this.lblTarih);
            this.groupBox1.Location = new System.Drawing.Point(130, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarih/Saat ayarla";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnKur
            // 
            this.btnKur.Location = new System.Drawing.Point(315, 194);
            this.btnKur.Name = "btnKur";
            this.btnKur.Size = new System.Drawing.Size(114, 39);
            this.btnKur.TabIndex = 7;
            this.btnKur.Text = "ALARM KUR";
            this.btnKur.UseVisualStyleBackColor = true;
            this.btnKur.Click += new System.EventHandler(this.btnKur_Click);
            // 
            // nmrDakika
            // 
            this.nmrDakika.Location = new System.Drawing.Point(215, 125);
            this.nmrDakika.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nmrDakika.Name = "nmrDakika";
            this.nmrDakika.Size = new System.Drawing.Size(41, 22);
            this.nmrDakika.TabIndex = 6;
            // 
            // nmrSaat
            // 
            this.nmrSaat.Location = new System.Drawing.Point(168, 126);
            this.nmrSaat.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nmrSaat.Name = "nmrSaat";
            this.nmrSaat.Size = new System.Drawing.Size(41, 22);
            this.nmrSaat.TabIndex = 5;
            this.nmrSaat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Location = new System.Drawing.Point(84, 126);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(38, 16);
            this.lblSaat.TabIndex = 4;
            this.lblSaat.Text = "Saat:";
            // 
            // nmrYıl
            // 
            this.nmrYıl.Location = new System.Drawing.Point(262, 62);
            this.nmrYıl.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.nmrYıl.Minimum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.nmrYıl.Name = "nmrYıl";
            this.nmrYıl.Size = new System.Drawing.Size(80, 22);
            this.nmrYıl.TabIndex = 3;
            this.nmrYıl.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // nmrAy
            // 
            this.nmrAy.Location = new System.Drawing.Point(215, 62);
            this.nmrAy.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nmrAy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrAy.Name = "nmrAy";
            this.nmrAy.Size = new System.Drawing.Size(41, 22);
            this.nmrAy.TabIndex = 2;
            this.nmrAy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmrGun
            // 
            this.nmrGun.Location = new System.Drawing.Point(168, 62);
            this.nmrGun.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nmrGun.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrGun.Name = "nmrGun";
            this.nmrGun.Size = new System.Drawing.Size(41, 22);
            this.nmrGun.TabIndex = 1;
            this.nmrGun.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(84, 62);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(41, 16);
            this.lblTarih.TabIndex = 0;
            this.lblTarih.Text = "Tarih:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Alarm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDakika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrYıl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKur;
        private System.Windows.Forms.NumericUpDown nmrDakika;
        private System.Windows.Forms.NumericUpDown nmrSaat;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.NumericUpDown nmrYıl;
        private System.Windows.Forms.NumericUpDown nmrAy;
        private System.Windows.Forms.NumericUpDown nmrGun;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Timer timer1;
    }
}

