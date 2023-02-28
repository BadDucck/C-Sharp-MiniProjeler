using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilp224_Hafta2_Lab01
{
    internal class Daire
    {
        private double yariCap;

        public Daire(double yariCap) 
        {
            this.yariCap = yariCap;
        }

        public double YariCap { get { return yariCap; } set { yariCap = value; } }

        public double daireCap() 
        {
            return yariCap*2;
        }

        public double daireCevre()
        {
            return 2*Math.PI*yariCap;
        }

        public double daireAlan() 
        {
            return Math.PI* (yariCap*yariCap);
        }
    }
}
