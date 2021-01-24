using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // naming convention --> isim yazılış kuralları 
        public void Ekle(Urun urun) // imza
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urun.Fiyati);
        }
    }
}
