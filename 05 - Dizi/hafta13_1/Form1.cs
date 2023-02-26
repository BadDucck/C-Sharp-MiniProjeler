using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta13_1
{
    public partial class Form1 : Form
    {
        int[,] matris = new int[50, 50];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDiziyiGoster_Click(object sender, EventArgs e)
        {
            int satir2 = Convert.ToInt32(txtSatir.Text);
            int sutun = Convert.ToInt32(txtSutun.Text);
            int max = Convert.ToInt32(txtMaksimum.Text);
            int minimum = Convert.ToInt32(txtMinimum.Text);

            Random r = new Random();
            String satir = "";
            richTextBox1.Text = "";

            for (int i = 0; i < satir2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matris[i, j] = r.Next(minimum,max);

                    satir += matris[i, j].ToString() + " ";
                }
                satir += "\n";
            }
            richTextBox1.Text = satir;
        }

        private void btnDiziOlustur_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int satir2 = Convert.ToInt32(txtSatir.Text);
            int sutun = Convert.ToInt32(txtSutun.Text);
            int max = Convert.ToInt32(txtMaksimum.Text);
            int minimum = Convert.ToInt32(txtMinimum.Text);
            String satir = "";

            for (int i = 0; i <satir2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matris[i, j] = r.Next(minimum,max);

                }
            }
            richTextBox1.Text = satir;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSutun_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSatir_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaksimum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMinimum_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMinimum_Click(object sender, EventArgs e)
        {

        }

        private void lblMaksimum_Click(object sender, EventArgs e)
        {

        }

        private void lblSutunSayisi_Click(object sender, EventArgs e)
        {

        }

        private void lblSatırSayısı_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtMinimum_Validated(object sender, EventArgs e)
        {

        }
    }
}
