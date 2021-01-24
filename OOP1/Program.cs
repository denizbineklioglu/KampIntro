using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitysInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitysInStock = 5,
                ProductName = "Kalem",
                UnitPrice = 35
            };

            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName); //Kamera--> *Referans Numarası*

            //int sayi = 100;
            //productManager.BiseYap(sayi);
            //Console.WriteLine(sayi); //100

            productManager.Topla2(3,6); //void fonksiyon
            int toplamaSonucu = productManager.Topla(3,6); // void olmayan fonksiyon
            Console.WriteLine(toplamaSonucu*2);


        }
    }
}
