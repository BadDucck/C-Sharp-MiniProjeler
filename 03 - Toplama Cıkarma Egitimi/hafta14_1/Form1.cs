using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta14_1
{
    public partial class Form1 : Form
    {
        int sayi1;
        int sayi2;
        int islem;
        int sonuc;

        void oyna()
        {
            Random random = new Random();

            if(cmbZorluk.SelectedIndex == 0)
            {
                sayi1 = random.Next(1, 10);
                sayi2 = random.Next(1, 10);
            }
            if (cmbZorluk.SelectedIndex == 1)
            {
                sayi1 = random.Next(10, 100);
                sayi2 = random.Next(10, 100);
            }
            if (cmbZorluk.SelectedIndex == 2)
            {
                sayi1 = random.Next(100, 1000);
                sayi2 = random.Next(100, 100);
            }

            /* islem = random.Next(1, 3);
             if (islem == 1)
             {
                 sonuc = sayi1 + sayi2;
             }
             else
             {
                 sonuc = sayi1 - sayi2;
             }*/

            islem = random.Next(1, 3);
            if (islem == 1)
                sonuc = sayi1 + sayi2;
            else
            {
                if (cbNegatif.Checked)
                {
                    int baslangic;
                    if (cmbZorluk.SelectedIndex == 0)
                    {
                        baslangic = 1;
                    }else if (cmbZorluk.SelectedIndex == 1)
                    {
                        baslangic = 10;
                    }
                    else
                    {
                        baslangic = 100;
                    }

                    sayi2 = random.Next(baslangic, sayi1);
                    sonuc = sayi1 - sayi2;
                }
                else
                {
                    sonuc = sayi1 - sayi2;
                }
            }
            


            txtRakam.Text = Convert.ToString(sayi1);
            txtRakam2.Text = Convert.ToString(sayi2);
            txtSonuc.Text=Convert.ToString(sonuc);

            rdbCıkarma.Checked = false;
            rdbToplama.Checked = false;

            return;


        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(6, 9);
        }

        private void lblOynananYazi_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Kayıt",

               MessageBoxButtons.YesNoCancel) == DialogResult.Yes)

                Application.Exit();

            {

                // İptal tuşuna basıldığı zaman 

                // buraya girilir.

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbZorluk.SelectedIndex = 0;
            oyna();

        }

        private void rdbToplama_CheckedChanged(object sender, EventArgs e)
        {
            int puan = Convert.ToInt32(lblPuan.Text);
            int oyun = Convert.ToInt32(lblOynanan.Text);
            if (rdbToplama.Checked)
            {
                if (islem == 1)
                {
                    puan += 10;
                    oyun += 1;
                    MessageBox.Show("Tebrikler Bildiniz");              
                }
                else
                {
                    puan -= 10;
                    oyun += 1;
                    MessageBox.Show("Maalesef Yanlış");
                    rdbCıkarma.Checked = false;
                   
                }

                lblPuan.Text = Convert.ToString(puan);
                lblOynanan.Text = Convert.ToString(oyun);
                oyna();
            }
        }

        private void rdbCıkarma_CheckedChanged(object sender, EventArgs e)
        {
            int puan = Convert.ToInt32(lblPuan.Text);
            int oyun = Convert.ToInt32(lblOynanan.Text);
            if (rdbCıkarma.Checked)
            {
                if (islem == 2)
                {
                    puan += 10;
                    oyun += 1;
                    MessageBox.Show("Tebrikler Bildiniz");
                }
                else
                {
                    puan -= 10;
                    oyun += 1;
                    MessageBox.Show("Maalesef Yanlış");
                 

                }
  
                lblPuan.Text = Convert.ToString(puan);
                lblOynanan.Text = Convert.ToString(oyun);
                oyna();
            }
        }

        private void cmbZorluk_SelectedIndexChanged(object sender, EventArgs e)
        {
            oyna();
        }
    }
    }

