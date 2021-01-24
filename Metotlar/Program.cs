using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun elma = new Urun();
            elma.Adi = "Elma";
            elma.Fiyati = 15;
            elma.Aciklama = "Amasya Elmasi";

            Urun karpuz = new Urun();
            karpuz.Adi = "Karpuz";
            karpuz.Fiyati = 80;
            karpuz.Aciklama = "Diyarbakir Karpuzu";

            Urun[] urunler = new Urun[] {elma,karpuz};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("..................\n");
            }

            Console.WriteLine("------------METOTLAR--------------\n");

            // instance --> class örneği oluşturmak
            // encapsulation
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(karpuz);
            sepetmanager.Ekle(elma);

            
        }
    }
}

// Do not repeat YOURSELF! - DRY - Clean Code - Best Practice 
