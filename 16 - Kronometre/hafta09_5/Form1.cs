using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta09_5
{
    public partial class cmbHız : Form
    {
        public cmbHız()
        {
            InitializeComponent();
            int saniye = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            int saniye;

            lblSayac.Text = txtSaniye.Text;
            if (comboBox1.Text == "Hızlı")
            {
                timer1.Interval = 300;
            }else if (comboBox1.Text == "Orta")
            {
                timer1.Interval = 600;
            }else if (comboBox1.Text == "Yavaş")
            {
                timer1.Interval = 1000;
            }
            listBox1.Items.Add("Başlama Zamanı " + DateTime.Now.ToLongTimeString());
            timer1.Start();
            
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblSayac.Text = "0";
            listBox1.Items.Add("Durma Zamanı " + DateTime.Now.ToLongTimeString());
        }

        private void cmbHız_Load(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int saniye;

            saniye = Convert.ToInt32(lblSayac.Text);
            if (saniye > 0)
                lblSayac.Text = Convert.ToString(saniye - 1);
            else
              
                timer1.Stop();
        }
    }
}
