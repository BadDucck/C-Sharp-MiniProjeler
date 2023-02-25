using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilp224_Hafta2_Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKosegen_Click(object sender, EventArgs e)
        {
            Dikdörtgen dikdörtgen1 = new Dikdörtgen();
            dikdörtgen1.UzunKenar = Convert.ToDouble(txtUzunKenar.Text);
            dikdörtgen1.KisaKenar=Convert.ToDouble(txtKısaKenar.Text);
            lblKosegen.Text = dikdörtgen1.kosegen().ToString("F2");
        }

        private void btnCevre_Click(object sender, EventArgs e)
        {
            Dikdörtgen dikdörtgen1 = new Dikdörtgen();
            dikdörtgen1.UzunKenar = Convert.ToDouble(txtUzunKenar.Text);
            dikdörtgen1.KisaKenar = Convert.ToDouble(txtKısaKenar.Text);
            lblCevre.Text = dikdörtgen1.cevre().ToString("F2");
        }

        private void btnAlan_Click(object sender, EventArgs e)
        {
            Dikdörtgen dikdörtgen1 = new Dikdörtgen();
            dikdörtgen1.UzunKenar = Convert.ToDouble(txtUzunKenar.Text);
            dikdörtgen1.KisaKenar = Convert.ToDouble(txtKısaKenar.Text);
            lblAlan.Text= dikdörtgen1.alan().ToString("F2");
        }
    }
}
