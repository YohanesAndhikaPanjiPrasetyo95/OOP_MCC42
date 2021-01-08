using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_MCC42
{
    class Program
    {
        static void Main(string[] args)
        {
            Persegi prsg = new Persegi();
            prsg.Nilai1 = 5;

            System.Console.WriteLine("\t\t\t\t===== Hitung Luas Bangun Datar =====");
            System.Console.WriteLine("\n\t\t\t\tPersegi");
            System.Console.WriteLine("\n\t\t\t\tNilai Sisi :" + prsg.Nilai1);
            System.Console.WriteLine("\n\t\t\t\tLuas Persegi :" + prsg.Luas());
            System.Console.WriteLine("\t\t\t\t====================================");

            PersegiPanjang prsgPjg = new PersegiPanjang();
            prsgPjg.Nilai1 = 8;
            prsgPjg.Nilai2 = 4;
            System.Console.WriteLine("\n\n\t\t\t\tPersegi Panjang");
            System.Console.WriteLine("\n\t\t\t\tNilai Panjang :" + prsgPjg.Nilai1);
            System.Console.WriteLine("\n\t\t\t\tNilai Lebar :" + prsgPjg.Nilai2);
            System.Console.WriteLine("\n\t\t\t\tLuas Persegi Panjang :" + prsgPjg.Luas());
            System.Console.WriteLine("\t\t\t\t====================================");

            Segitiga s = new Segitiga();
            s.Nilai1 = 5;
            s.Nilai2 = 10;
            System.Console.WriteLine("\n\n\t\t\t\tSegitiga");
            System.Console.WriteLine("\n\t\t\t\tNilai Alas :" + s.Nilai1);
            System.Console.WriteLine("\n\t\t\t\tNilai Tinggi :" + s.Nilai2);
            System.Console.WriteLine("\n\t\t\t\tNilai Sisi :" + s.Nilai1); 
            System.Console.WriteLine("\n\t\t\t\tLuas Segitiga :" + s.Luas());
            System.Console.WriteLine("\t\t\t\t====================================");

            Lingkaran l = new Lingkaran();
            l.Nilai1 = 5;
            System.Console.WriteLine("\n\n\t\t\t\tLingkaran");
            System.Console.WriteLine("\n\t\t\t\tNilai Jari-jari :" + l.Nilai1);
            System.Console.WriteLine("\n\t\t\t\tLuas Lingkaran :" + l.Luas());
            System.Console.WriteLine("\t\t\t\t====================================");

            Trapesium t = new Trapesium();
            t.Nilai1 = 12;
            t.Nilai2 = 10;
            System.Console.WriteLine("\n\n\t\t\t\tTrapesium");
            System.Console.WriteLine("\n\t\t\t\tNilai Jumlah Panjang Sisi :" + t.Nilai1);
            System.Console.WriteLine("\n\t\t\t\tNilai Tinggi :" + t.Nilai2);
            System.Console.WriteLine("\n\t\t\t\tLuas Trapesium :" + t.Luas());
            System.Console.WriteLine("\t\t\t\t====================================");
            System.Console.ReadKey();
        }
    }
}
