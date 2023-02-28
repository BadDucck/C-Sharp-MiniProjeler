namespace hafta11_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imList = new System.Windows.Forms.ImageList(this.components);
            this.pcb1 = new System.Windows.Forms.PictureBox();
            this.pcb2 = new System.Windows.Forms.PictureBox();
            this.btnZarAt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).BeginInit();
            this.SuspendLayout();
            // 
            // imList
            // 
            this.imList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imList.ImageStream")));
            this.imList.TransparentColor = System.Drawing.Color.Transparent;
            this.imList.Images.SetKeyName(0, "donen_zar.gif");
            this.imList.Images.SetKeyName(1, "zar_1.png");
            this.imList.Images.SetKeyName(2, "zar_2.png");
            this.imList.Images.SetKeyName(3, "zar_3.png");
            this.imList.Images.SetKeyName(4, "zar_4.png");
            this.imList.Images.SetKeyName(5, "zar_5.png");
            this.imList.Images.SetKeyName(6, "zar_6.png");
            // 
            // pcb1
            // 
            this.pcb1.Location = new System.Drawing.Point(88, 56);
            this.pcb1.Name = "pcb1";
            this.pcb1.Size = new System.Drawing.Size(272, 251);
            this.pcb1.TabIndex = 0;
            this.pcb1.TabStop = false;
            // 
            // pcb2
            // 
            this.pcb2.Location = new System.Drawing.Point(440, 56);
            this.pcb2.Name = "pcb2";
            this.pcb2.Size = new System.Drawing.Size(272, 251);
            this.pcb2.TabIndex = 1;
            this.pcb2.TabStop = false;
            // 
            // btnZarAt
            // 
            this.btnZarAt.Location = new System.Drawing.Point(329, 351);
            this.btnZarAt.Name = "btnZarAt";
            this.btnZarAt.Size = new System.Drawing.Size(137, 51);
            this.btnZarAt.TabIndex = 2;
            this.btnZarAt.Text = "Zar At";
            this.btnZarAt.UseVisualStyleBackColor = true;
            this.btnZarAt.Click += new System.EventHandler(this.btnZarAt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZarAt);
            this.Controls.Add(this.pcb2);
            this.Controls.Add(this.pcb1);
            this.Name = "Form1";
            this.Text = "Zar at";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imList;
        private System.Windows.Forms.PictureBox pcb1;
        private System.Windows.Forms.PictureBox pcb2;
        private System.Windows.Forms.Button btnZarAt;
    }
}

