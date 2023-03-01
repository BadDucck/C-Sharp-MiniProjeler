using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta10_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefon_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblHesap_Click(object sender, EventArgs e)
        {
            int tutar;
            tutar = Convert.ToInt32(nSalata.Value) * 10 + Convert.ToInt32(nCorba.Value) * 10 + Convert.ToInt32(nYemek.Value) * 50 + Convert.ToInt32(nSalata.Value) * 10;
            lblTutar.Text = "Sayın " + txtAdSoyad.Text + " Ödemeniz Gereken Tutar: " + Convert.ToString(tutar);
        }
    }
}
