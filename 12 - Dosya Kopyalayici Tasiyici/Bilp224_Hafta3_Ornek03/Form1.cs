namespace Bilp224_Hafta3_Ornek03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTasi_Click(object sender, EventArgs e)
        {
            string yol = txtKaynak.Text;
            if (Directory.Exists(yol))
            {
                try
                {
                    Directory.Move(yol, txtKaynak.Text);
                    MessageBox.Show("Ba�ar�l� �ekilde Ta��nd�");
                }
                catch
                {
                    MessageBox.Show("Hata Olu�tu, Ta��namad�!");
                }


            }
            else
            {
                MessageBox.Show("Kaynak Klas�r Bulunamad�");
            }

        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtKaynak.Text))
            {
                DirectoryInfo kaynakKlasor = new DirectoryInfo(txtKaynak.Text);
                DirectoryInfo hedefKlasor = new DirectoryInfo(txtHedef.Text);

                if (!hedefKlasor.Exists)
                {
                    Directory.CreateDirectory(txtHedef.Text);
                }
                foreach (FileInfo fi in kaynakKlasor.GetFiles())
                        fi.CopyTo(Path.Combine(hedefKlasor.ToString(), fi.Name), true);
                    MessageBox.Show("Kaynak klas�r kopyaland�");
                
            }
            else MessageBox.Show("Kaynak klas�r bulunamad�");
        }
    }
}