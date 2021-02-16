using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product harddisk = new Product(50);
            harddisk.ProductName = "Hard Disk";

            Product telefon = new Product(50);
            telefon.ProductName = "Iphone";
            telefon.StockControlEvent += Telefon_StockControlEvent;

            for (int i = 0; i < 10; i++)
            {
                harddisk.Sell(10);
                telefon.Sell(10);
                Console.ReadLine();
            }
            Console.ReadLine();
        }
        private static void Telefon_StockControlEvent()
        {
           Console.WriteLine("Telefon about to finish!!!");
        }
    }
}
