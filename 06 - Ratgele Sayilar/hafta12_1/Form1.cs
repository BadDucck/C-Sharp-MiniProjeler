using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta12_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblSayı6_Click(object sender, EventArgs e)
        {

        }

        private void lblSayı5_Click(object sender, EventArgs e)
        {

        }

        private void lblSayı4_Click(object sender, EventArgs e)
        {

        }

        private void lblSayı3_Click(object sender, EventArgs e)
        {

        }

        private void lblSayı2_Click(object sender, EventArgs e)
        {

        }

        private void lblSayı1_Click(object sender, EventArgs e)
        {

        }

        private void btnSayı_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[7];
            int sayi;
            Random rnd = new Random();

            for (int i = 0; i < sayilar.Length; i++)
            {
                do { 
                sayi = rnd.Next(1, 49);
                } while (Array.IndexOf(sayilar,sayi) != -1);
                sayilar[i] = sayi;
            }
            Array.Sort(sayilar);
            lblSayı1.Text = Convert.ToString(sayilar[1]);
            lblSayı2.Text = Convert.ToString(sayilar[2]);
            lblSayı3.Text = Convert.ToString(sayilar[3]);
            lblSayı4.Text = Convert.ToString(sayilar[4]);
            lblSayı5.Text = Convert.ToString(sayilar[5]);
            lblSayı6.Text = Convert.ToString(sayilar[6]);

        }
    }
}
