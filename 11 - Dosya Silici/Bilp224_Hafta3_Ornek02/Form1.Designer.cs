namespace Bilp224_Hafta3_Ornek02
{
    partial class FolderRemover
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
            components = new System.ComponentModel.Container();
            lblİndirilenler = new Label();
            lstDowloads = new ListBox();
            btnGetir = new Button();
            btnSil = new Button();
            btnTemizle = new Button();
            ımageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // lblİndirilenler
            // 
            lblİndirilenler.AutoSize = true;
            lblİndirilenler.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblİndirilenler.Location = new Point(47, 9);
            lblİndirilenler.Name = "lblİndirilenler";
            lblİndirilenler.Size = new Size(267, 32);
            lblİndirilenler.TabIndex = 0;
            lblİndirilenler.Text = "İndirilenler (Downloads)";
            lblİndirilenler.Click += label1_Click;
            // 
            // lstDowloads
            // 
            lstDowloads.FormattingEnabled = true;
            lstDowloads.ItemHeight = 15;
            lstDowloads.Location = new Point(47, 44);
            lstDowloads.Name = "lstDowloads";
            lstDowloads.Size = new Size(498, 304);
            lstDowloads.TabIndex = 1;
            // 
            // btnGetir
            // 
            btnGetir.Location = new Point(551, 44);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(237, 51);
            btnGetir.TabIndex = 2;
            btnGetir.Text = "İndirilenleri Getir";
            btnGetir.UseVisualStyleBackColor = true;
            btnGetir.Click += btnGetir_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(551, 101);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(237, 51);
            btnSil.TabIndex = 3;
            btnSil.Text = "Seçileni Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(551, 158);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(237, 51);
            btnTemizle.TabIndex = 4;
            btnTemizle.Text = "Listeyi Temzie";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageSize = new Size(16, 16);
            ımageList1.TransparentColor = Color.Transparent;
            // 
            // FolderRemover
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 365);
            Controls.Add(btnTemizle);
            Controls.Add(btnSil);
            Controls.Add(btnGetir);
            Controls.Add(lstDowloads);
            Controls.Add(lblİndirilenler);
            Name = "FolderRemover";
            Text = "Folder Remover";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblİndirilenler;
        private ListBox lstDowloads;
        private Button btnGetir;
        private Button btnSil;
        private Button btnTemizle;
        private ImageList ımageList1;
    }
}