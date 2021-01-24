using System;

namespace HomeWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.urunAdi = "Dizustu Bilgisayar";
            urun1.fiyati = 7700;
            urun1.saticiAdi = "Monster";

            Product urun2 = new Product();
            urun2.urunAdi = "Kareli Gomlek";
            urun2.fiyati = 59.99;
            urun2.saticiAdi = "Koton";
            urun2.beden = 'L';

            Product urun3 = new Product();
            urun3.urunAdi = "Monitor";
            urun3.fiyati = 1500;
            urun3.saticiAdi = "Casper";

            Product[] urunler = new Product[] { urun1, urun2, urun3 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.urunAdi + urun.fiyati);
            }

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].urunAdi);
            }

            int j = 0;
            while (j < urunler.Length)
            {
                Console.WriteLine(urunler[j].urunAdi);
                j++;
            }
        }
    }
    class Product
    {
        public string urunAdi { get; set; }

        public double fiyati { get; set; }

        public string saticiAdi { get; set; }

        public char beden { get; set;  } // eğer ürün kıyafetse

    }
}
