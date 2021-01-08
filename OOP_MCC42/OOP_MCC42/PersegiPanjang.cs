using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_MCC42
{
    class PersegiPanjang 
    {
        private double nilai_1;
        private double nilai_2;

        public double Nilai1
        {
            get { return nilai_1; }
            set { nilai_1 = value; }
        }

        public double Nilai2
        {
            get { return nilai_2; }
            set { nilai_2 = value; }
        }

        public virtual double Luas()
        {
            double hitung;
            hitung = nilai_1 + nilai_2;
            return hitung;
        }
    }
}
