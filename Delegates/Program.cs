using System;

namespace Delegates
{  
    class Program
    {
        public delegate void MyDelegate(); // void döndürüyor ve parametresiz 
        public delegate void MyDelegate2(string text); // void döndürüyor ama string parametre döndürüyor.
        public delegate int MyDelegate3(int number1,int number2); // 2 int parametre isteyen ve int döndüren
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert; // önce yapılacak işler toplanıyor.
            myDelegate -= customerManager.SendMessage; //yapılacak bir işi geride alabiliriz
            myDelegate(); // delegate çağırıldı.


            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 +=customerManager.ShowAlert2;
            myDelegate2("Hello"); // 2 Hello ekrana yazılır. 


            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Carp;
            var sonuc = myDelegate3(2,3);
            Console.WriteLine(sonuc);
            // integer türünde bir değer return edilecekse genellikle değişkene son atanan değer verilir.
            // yani çıktısı 3*2'den 6'dır.

            Console.ReadLine();
        }
    }
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }
        public void ShowAlert() 
        {
            Console.WriteLine("Be careful!");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }

   public class Matematik
    {
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
