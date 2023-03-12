using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta10_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value < 7 && trackBar1.Value > 0)
            {
                lblSesSeviyesi.ForeColor = Color.White;
                lblSesSeviyesi.Text = "Ses Seviyesi: Çok Düşük";
            }
            else if(trackBar1.Value < 10 && trackBar1.Value > 7)
            {
                lblSesSeviyesi.ForeColor = Color.Green;
                lblSesSeviyesi.Text = "Ses Seviyesi: Normal";
            }else
                lblSesSeviyesi.ForeColor = Color.Red;
            lblSesSeviyesi.Text = "Ses Seviyesi: Çok Yüksek!";
        }
    }
}
