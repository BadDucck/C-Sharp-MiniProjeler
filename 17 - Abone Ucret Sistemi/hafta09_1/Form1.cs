using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta09_1
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
        private void hesapla()
        {
            double tutar;

            tutar = Convert.ToDouble(txtacilistutari.Text);
            if (chkKdv.Checked)
                tutar += tutar * 0.18;
            if (chOzelVergi.Checked)
                tutar += tutar * 0.25;
            if (chkAbone.Checked)
                tutar += 22;
            txtHesap.Text = Convert.ToString(tutar);
        }

        private void txtacilistutari_TextChanged(object sender, EventArgs e)
        {
            hesapla();
        }

        private void chkKdv_CheckedChanged(object sender, EventArgs e)
        {
            hesapla();
        }

        private void chOzelVergi_CheckedChanged(object sender, EventArgs e)
        {
            hesapla();
        }

        private void chkAbone_CheckedChanged(object sender, EventArgs e)
        {
            hesapla();
        }
    }
}
