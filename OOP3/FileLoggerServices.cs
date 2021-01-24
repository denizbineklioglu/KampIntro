using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class FileLoggerServices : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosya loglandi");        
        }
    }
}
