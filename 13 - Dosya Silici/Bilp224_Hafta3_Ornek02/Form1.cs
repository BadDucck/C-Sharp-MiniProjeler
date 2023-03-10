namespace Bilp224_Hafta3_Ornek02
{
    public partial class FolderRemover : Form
    {
        public FolderRemover()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            string yol = Environment.GetEnvironmentVariable("HOMEDRIVE") + Environment.GetEnvironmentVariable("HOMEPATH");
            string[] indirilenler = Directory.GetFiles(yol + @"\Downloads\", "*.*");
            for (int i = 0; i < indirilenler.Length; i++)
            {
                lstDowloads.Items.Add(indirilenler[i]);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstDowloads.SelectedIndex == -1)
            {
                MessageBox.Show("Seçim yapmadýnýz");
            }
            else
            {
                try
                {
                    File.Delete(lstDowloads.SelectedItems.ToString());
                    MessageBox.Show("Seçiminiz baþarýyla silindi!");
                    lstDowloads.Items.RemoveAt(lstDowloads.SelectedIndex);

                }
                catch {
                    MessageBox.Show("Bir hata oluþtu, Silme iþlemi gerçekleþemedi!"+ lstDowloads.SelectedItem.ToString());
                }
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lstDowloads.Items.Clear();
        }
    }
}