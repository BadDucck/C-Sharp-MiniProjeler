using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bilp224_Hafta3_Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"D:\Yapilacaklar.txt", txtbListe.Text);
            MessageBox.Show("Yapılacaklar Kaydedildi!");
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            string[] satirlar = File.ReadAllLines(@"D:\Yapilacaklar.txt");
            for(int i = 0; i < satirlar.Length; i++)
            {
                listBox1.Items.Add(satirlar[i]);
            }
        }
    }
}
