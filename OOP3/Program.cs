using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediBaseManager ihtiyackredi = new IhtıyacKrediManager();
            IKrediBaseManager tasitKredi = new TasitKrediManager();
            IKrediBaseManager konutKredi = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyackredi,new DataBaseLoggerService());

            List<IKrediBaseManager> krediler = new List<IKrediBaseManager>() {ihtiyackredi,konutKredi,tasitKredi};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
