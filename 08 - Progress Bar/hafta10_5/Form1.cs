using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta10_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void lblYazılım_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            progressBar1.Value+=5;
            lblYazılım.Text=Convert.ToString("Yazılım Yükleniyor %" + progressBar1.Value);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                lblYazılım.Text = "İndirme işlemi tamamlandı.";
            }
        }
    }
}
