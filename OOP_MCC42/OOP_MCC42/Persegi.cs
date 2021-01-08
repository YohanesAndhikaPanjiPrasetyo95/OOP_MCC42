using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_MCC42
{
    class Persegi : PersegiPanjang
    {
       /* private double sisi;
        public double Sisi
        {
            get { return sisi; }
            set { sisi = value; }
        }*/

        public override double Luas()
        {
            double hitung;
            hitung = Nilai1 * Nilai1;
            return hitung;
        }

    }
}
