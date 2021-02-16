using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager = new CustomerManager(20);
            //customerManager.List();

            //Product product1 = new Product{Id=1,Name="Computer" };
            //Console.WriteLine(product1.Name);

            //Product product = new Product(2,"Bilgisayar");


            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();
            Console.ReadLine();
        }
    }
    //class'ın ihtiyac duydugu parametreler varsa bu parametreyi constructor sayesinde set ederiz
    // constroctur'lar overload edilebilir.
    class CustomerManager
    {
        int _count=15;  // mainde hiçbir parametre verilmezse 15, verilirse verilen değer. 
        public CustomerManager(int count) 
        {
            _count = count;
        }
        public CustomerManager()
        {
           
        }
        public void List()
        {
            Console.WriteLine("Listed {0} items",_count);
        }
        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }

    //Class özelliklerini constructor sayesinde hızlıca set edebiliriz.
    class Product
    {
        int _id;
        string _name;
        public Product(int id,string name)
        {
            _id = id;
            _name = name;
        }
        public Product()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }
    class EmployeeManager
    {
        ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }

    //Bir diğer constructor özelliği base sınıfa parametre göndermektir
    class BaseClass
    {
        string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }
    class PersonManager:BaseClass
    {
        public PersonManager(string entity):base(entity)
        {

        }
        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }
}
