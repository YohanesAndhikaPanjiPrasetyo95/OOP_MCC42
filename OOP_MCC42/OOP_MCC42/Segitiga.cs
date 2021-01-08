using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_MCC42
{
    class Segitiga : PersegiPanjang 
    {
/*        private double alas;
        private double tinggi;
        private double sisi;

        public double Alas
        {
            get { return alas; }
            set { alas = value; }
        }

        public double Tinggi
        {
            get { return tinggi; }
            set { tinggi = value; }
        }

        public double Sisi
        {
            get { return sisi; }
            set { sisi = value; }
        }*/

        public override double Luas()
        {
            double hitung;
            hitung = (Nilai1*Nilai2) /2 ;
            return hitung;
        }
    }
}
