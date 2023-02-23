using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilp224_Hafta2_Lab02
{
    internal class Dikdörtgen
    {
        private double uzunKenar;
        private double kisaKenar;

        public double UzunKenar
        {
            get { return uzunKenar; }
            set { uzunKenar = value; }
        }
        public double KisaKenar
        {
            get { return kisaKenar; }
            set { kisaKenar = value; }
        }

        public double kosegen()
        {
            return Math.Sqrt((kisaKenar * kisaKenar)+(uzunKenar*uzunKenar));
        }

        public double cevre()
        {
            return kisaKenar * 2 + uzunKenar * 2;
        }

        public double alan()
        {
            return kisaKenar*uzunKenar;
        }

    }
}
