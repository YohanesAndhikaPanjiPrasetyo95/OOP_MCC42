using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_MCC42
{
    class Lingkaran : PersegiPanjang
    {
        /*private double jari2;
*/        private double phi = 3.14;

      /*  public double Jari2
        {
            get { return jari2; }
            set { jari2 = value; }
        }*/

        public override double Luas()
        {
            double hitung;
            hitung = phi*Nilai1*Nilai1;
            return hitung;
        }
    }
}
