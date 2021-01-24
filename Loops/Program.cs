using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            //string kurs2 = "Programlamaya baslangic icin temel kurs";
            //string kurs3 = "Java";

            ////array - dizi

            //string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı" ,
            //"Programlamaya baslangic icin temel kurs","Java","Python","C++"};

            //for (int i = 0; i < kurslar.Length; i++)
            //{
            //    Console.WriteLine(kurslar[i]);
            //}

            //Console.WriteLine("For bitti");

            //foreach (string kurs in kurslar) // Dizi temelli yapilari tek tek donmeye yarar.
            //{
            //  Console.WriteLine(kurs); // her bir elemana takma isim verilir 
            //}

            //Console.WriteLine("sayfa sonu - footer");

            int a = 8;
            int b = 7;
            b++;
            if (a > b)
                b++;
            else
                a--;
            Console.Write(a + b);


        }
    }
}
