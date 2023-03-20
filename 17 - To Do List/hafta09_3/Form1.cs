using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta09_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lbBox.Items.Add(txtTxt.Text);
            txtTxt.Clear();
            txtTxt.Focus();
        }

        private void btnCıkar_Click(object sender, EventArgs e)
        {
            if (lbBox.SelectedIndex != -1)
                lbBox.Items.RemoveAt(lbBox.SelectedIndex);
            else
                MessageBox.Show("Seçim Yapmadınız");
        }

        private void btnHepsiniSil_Click(object sender, EventArgs e)
        {
            lbBox.Items.Clear();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
