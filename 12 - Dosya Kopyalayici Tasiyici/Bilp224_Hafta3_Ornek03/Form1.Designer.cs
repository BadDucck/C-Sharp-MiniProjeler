namespace Bilp224_Hafta3_Ornek03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblKaynak = new Label();
            lblHedef = new Label();
            txtKaynak = new TextBox();
            txtHedef = new TextBox();
            btnTasi = new Button();
            btnKopyala = new Button();
            SuspendLayout();
            // 
            // lblKaynak
            // 
            lblKaynak.AutoSize = true;
            lblKaynak.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblKaynak.Location = new Point(78, 28);
            lblKaynak.Name = "lblKaynak";
            lblKaynak.Size = new Size(107, 21);
            lblKaynak.TabIndex = 0;
            lblKaynak.Text = "Kaynak Klasör";
            // 
            // lblHedef
            // 
            lblHedef.AutoSize = true;
            lblHedef.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHedef.Location = new Point(78, 63);
            lblHedef.Name = "lblHedef";
            lblHedef.Size = new Size(94, 21);
            lblHedef.TabIndex = 1;
            lblHedef.Text = "Hefef Klasör";
            // 
            // txtKaynak
            // 
            txtKaynak.Location = new Point(191, 31);
            txtKaynak.Name = "txtKaynak";
            txtKaynak.Size = new Size(246, 20);
            txtKaynak.TabIndex = 2;
            // 
            // txtHedef
            // 
            txtHedef.Location = new Point(191, 66);
            txtHedef.Name = "txtHedef";
            txtHedef.Size = new Size(246, 20);
            txtHedef.TabIndex = 3;
            // 
            // btnTasi
            // 
            btnTasi.Location = new Point(191, 100);
            btnTasi.Name = "btnTasi";
            btnTasi.Size = new Size(107, 23);
            btnTasi.TabIndex = 4;
            btnTasi.Text = "Taşı";
            btnTasi.UseVisualStyleBackColor = true;
            btnTasi.Click += btnTasi_Click;
            // 
            // btnKopyala
            // 
            btnKopyala.Location = new Point(338, 100);
            btnKopyala.Name = "btnKopyala";
            btnKopyala.Size = new Size(99, 23);
            btnKopyala.TabIndex = 5;
            btnKopyala.Text = "Kopyala";
            btnKopyala.UseVisualStyleBackColor = true;
            btnKopyala.Click += btnKopyala_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 149);
            Controls.Add(btnKopyala);
            Controls.Add(btnTasi);
            Controls.Add(txtHedef);
            Controls.Add(txtKaynak);
            Controls.Add(lblHedef);
            Controls.Add(lblKaynak);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Dosya Kopyalayıcı Taşıyıcı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKaynak;
        private Label lblHedef;
        private TextBox txtKaynak;
        private TextBox txtHedef;
        private Button btnTasi;
        private Button btnKopyala;
    }
}