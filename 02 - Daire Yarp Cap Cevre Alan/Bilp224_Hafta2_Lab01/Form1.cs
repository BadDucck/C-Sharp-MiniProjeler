using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilp224_Hafta2_Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCap_Click(object sender, EventArgs e)
        {
            Daire daire1 = new Daire(0);
            daire1.YariCap = Convert.ToDouble(txtYariCap.Text);
            lblCap.Text = daire1.daireCap().ToString();
        }

        private void btnCevre_Click(object sender, EventArgs e)
        {
            Daire daire1 = new Daire(0);
            daire1.YariCap = Convert.ToDouble(txtYariCap.Text);
            lblCevre.Text= daire1.daireCevre().ToString("F2");
        }

        private void btnAlan_Click(object sender, EventArgs e)
        {
            Daire daire1 = new Daire(0);
            daire1.YariCap = Convert.ToDouble(txtYariCap.Text);
            lblAlan.Text= daire1.daireAlan().ToString("F2");
        }
    }
}
