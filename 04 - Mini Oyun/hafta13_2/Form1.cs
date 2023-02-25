using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta13_2
{
    public partial class Form1 : Form
    {
        int[,] tahta = new int[4, 4];

        void degistir(int satir, int sutun)
        {
            if (tahta[satir,sutun]==1)
       
            tahta[satir, sutun] = 0;
            else
                tahta[satir, sutun] = 1;

            if(satir + 1 <= 3) {

                if (tahta[satir + 1, sutun] == 1)

                    tahta[satir + 1, sutun] = 0;
                else
                    tahta[satir + 1, sutun] = 1;
            }

            if (satir - 1 >= 0)
            {

                if (tahta[satir - 1, sutun] == 1)

                    tahta[satir - 1, sutun] = 0;
                else
                    tahta[satir - 1, sutun] = 1;
            }

            if (sutun + 1 <= 3)
            {
                if(tahta[satir , sutun+1] == 1)

                    tahta[satir , sutun+1] = 0;
                else
                    tahta[satir, sutun+1] = 1;
            }

            if (sutun - 1 >=0)
            {
                if (tahta[satir, sutun - 1] == 1)

                    tahta[satir, sutun - 1] = 0;
                else
                    tahta[satir, sutun - 1] = 1;
            }

            


        }
        void boya()
        {
            /*Btn00*/
            if (tahta[0,0] == 0)
            {
                btn00.BackColor = Color.Black;
            }
            else
            {
                btn00.BackColor = Color.White;
            }

            /*Btn01*/
            if (tahta[0, 1] == 0)
            {
                btn01.BackColor = Color.Black;
            }
            else
            {
                btn01.BackColor = Color.White;
            }

            /*Btn02*/
            if (tahta[0, 2] == 0)
            {
                btn02.BackColor = Color.Black;
            }
            else
            {
                btn02.BackColor = Color.White;
            }

            /*Btn03*/
            if (tahta[0, 3] == 0)
            {
                btn03.BackColor = Color.Black;
            }
            else
            {
                btn03.BackColor = Color.White;
            }

            /*Btn04*/
            if (tahta[1, 0] == 0)
            {
                btn04.BackColor = Color.Black;
            }
            else
            {
                btn04.BackColor = Color.White;
            }

            /*Btn05*/
            if (tahta[1, 1] == 0)
            {
                btn05.BackColor = Color.Black;
            }
            else
            {
                btn05.BackColor = Color.White;
            }

            /*Btn06*/
            if (tahta[1, 2] == 0)
            {
                btn06.BackColor = Color.Black;
            }
            else
            {
                btn06.BackColor = Color.White;
            }

            /*Btn07*/
            if (tahta[1, 3] == 0)
            {
                btn07.BackColor = Color.Black;
            }
            else
            {
                btn07.BackColor = Color.White;
            }

            /*Btn08*/
            if (tahta[2, 0] == 0)
            {
                btn08.BackColor = Color.Black;
            }
            else
            {
                btn08.BackColor = Color.White;
            }

            /*btn09*/
            if (tahta[2, 1] == 0)
            {
                btn09.BackColor = Color.Black;
            }
            else
            {
                btn09.BackColor = Color.White;
            }

            /*Btn10*/
            if (tahta[2, 2] == 0)
            {
                btn10.BackColor = Color.Black;
            }
            else
            {
                btn10.BackColor = Color.White;
            }

            /*Btn11*/
            if (tahta[2, 3] == 0)
            {
                btn11.BackColor = Color.Black;
            }
            else
            {
                btn11.BackColor = Color.White;
            }

            /*Btn12*/
            if (tahta[3, 0] == 0)
            {
                btn12.BackColor = Color.Black;
            }
            else
            {
                btn12.BackColor = Color.White;
            }

            /*Btn13*/
            if (tahta[3, 1] == 0)
            {
                btn13.BackColor = Color.Black;
            }
            else
            {
                btn13.BackColor = Color.White;
            }

            /*Btn14*/
            if (tahta[3, 2] == 0)
            {
                btn14.BackColor = Color.Black;
            }
            else
            {
                btn14.BackColor = Color.White;
            }

            /*Btn15*/
            if (tahta[3, 3] == 0)
            {
                btn15.BackColor = Color.Black;
            }
            else
            {
                btn15.BackColor = Color.White;
            }


            int toplam = 0;
            for(int i =0; i < 4; i++)
           
                for(int j=0; j< 4 ; j++)
                {
                    toplam = tahta[i,j] + toplam;
                }
            
            if (toplam == 16)
            {
                MessageBox.Show("KAZANDINIZ");
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tahta[0, 0] = 1;
            tahta[0, 3] = 1;
            tahta[3, 0] = 1;
            tahta[3, 3] = 1;

  
            boya();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            degistir(2, 2);
            boya();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            degistir(2, 0);
            boya();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            degistir(2, 1);
            boya();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            degistir(2, 3);
            boya();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            degistir(3, 0);
            boya();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            degistir(3, 1);
            boya();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            degistir(3, 2);
            boya();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            degistir(3, 3);
            boya();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            degistir(1, 3);
            boya();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            degistir(1, 2);
            boya();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            degistir(1, 1);
            boya();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            degistir(1, 0);
            boya();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            degistir(0, 3);
            boya();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            degistir(0, 2);
            boya();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            degistir(0, 1);
            boya();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            degistir(0, 0);
            boya();
        }
    }
}
