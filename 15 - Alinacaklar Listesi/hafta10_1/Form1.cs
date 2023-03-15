using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta10_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            chkListBox.Items.Add(txtUrun.Text);
            txtUrun.Clear();
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            if (chkListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("HATA! Lütfen seçim yapınız");
            }else
                listBox.Items.Clear();
            foreach (string secilen in chkListBox.CheckedItems)
                    listBox.Items.Add(secilen);
        }
    }
}
