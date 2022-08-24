using System;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            // kodlama.io - 2.ders - 6.ödev

            Urun urun1 = new Urun();
            urun1.UrunAdi = "Elma";
            urun1.Fiyati = 10;
            urun1.Kategori = "Meyve";

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Armut";
            urun2.Fiyati = 12;
            urun2.Kategori = "Meyve";

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Patates";
            urun3.Fiyati = 14;
            urun3.Kategori = "Sebze";

            Urun urun4 = new Urun();
            urun4.UrunAdi = "Soğan";
            urun4.Fiyati = 11;
            urun4.Kategori = "Sebze";

            Urun[] urunler = new Urun[] {urun1 , urun2 , urun3 , urun4};

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi + " = " + urunler[i].Fiyati);
            }

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " -> " + urun.Kategori);
            }

            int a = 0;
            while (a<urunler.Length)
            {
                Console.WriteLine(urunler[a].UrunAdi);
                a++;
            }
        }

        class Urun
        {
            public string UrunAdi { get; set; }
            public int Fiyati { get; set; }
            public string Kategori { get; set; }
        }

        
    }
}
