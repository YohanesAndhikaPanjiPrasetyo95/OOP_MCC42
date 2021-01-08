namespace OOP_MCC42
{
    internal class TrapesiumBase
    {
        private double jml_p_sisi;
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
        }

        public double hitungLuasTrapesium()
        {
            double hitung;
            hitung = 1 / 2 * jml_p_sisi + tinggi;
            return hitung;
        }
    }
}