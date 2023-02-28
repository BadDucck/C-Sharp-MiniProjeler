using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta11_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pcb1.Image = imList.Images[0];
            pcb2.Image = imList.Images[0];
        }

        private void btnZarAt_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            pcb1.Image = imList.Images[r.Next(1,6)];
            
            pcb2.Image = imList.Images[r.Next(1, 6)];
        }
    }
}
