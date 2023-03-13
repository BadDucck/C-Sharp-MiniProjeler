using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace hafta10_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nmrSaat.Value = DateTime.Now.Hour;
            nmrDakika.Value = DateTime.Now.Minute;
            nmrGun.Value = DateTime.Now.Day;
            nmrAy.Value = DateTime.Now.Month;
            nmrYıl.Value = DateTime.Now.Year;
        }

        private void btnKur_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MessageBox.Show("ALARM KURULDU \n" + nmrSaat.Value +":"+ nmrDakika.Value + " " + nmrGun.Value +"/"+ nmrAy.Value +"/"+ nmrYıl.Value + " Tarihinde Alarm Çalacaktır");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nmrSaat.Value == DateTime.Now.Hour && nmrDakika.Value == DateTime.Now.Minute && nmrGun.Value == DateTime.Now.Day && nmrAy.Value == DateTime.Now.Month && nmrYıl.Value == DateTime.Now.Year)
            {
                timer1.Stop();
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + @"C:\Users\zekib\Downloads\ses.wav";
                ses.SoundLocation = dizin;
                ses.Play();
                MessageBox.Show("ALARM");
                
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
