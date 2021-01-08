using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_MCC42
{
    class Trapesium : PersegiPanjang
    {
      /*  private double jml_p_sisi;
        private double tinggi;

        public double Jumlah_P_Sisi
        {
            get { return jml_p_sisi; }
            set { jml_p_sisi = value; }
        }

        public double Tinggi
        {
            get { return tinggi; }
            set { tinggi = value; }
        }*/

        public override double Luas()
        {
            double hitung;
            hitung = (1/2*Nilai1) + Nilai2;
            return hitung;
        }
    }
}
