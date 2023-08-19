using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager(10);
        customerManager.List();
        // Constructor injection kullanımı
        EmployeManager emp = new EmployeManager(new DatabaseLogger());
        emp.Add();
        Console.WriteLine("---------------------------------------");
        // Base class a parametre yollamak
        PersonManager personManager = new PersonManager("alex");
        personManager.Add();
        Console.WriteLine("---------------------------------------");

        /**************************************************************/
        // static Nesneler
        // heryerden bu değere erişim vardır.
        Teacher.Number = 10;
        // metodlar ve fonksiyonları kullanmak için bir o sınıftan bir nesne oluşturya gerek yoktur.
        Utilities.Validate();
        Manager manager = new Manager();
        manager.Dosomething2();
        Manager.Dosomething1();

    }

}
public class CustomerManager
{
    // genelde private fieldlar veya property ler isimlendirilirken "_" başlamalıdır.
    private int _count;
    public void Add()
    {
        Console.WriteLine("Added !");
    }
    public CustomerManager(int count)
    {

        _count = count;

    }
    public CustomerManager()
    {
        
    }
    public void List()
    {
        Console.WriteLine(" {0} tane müşteri vardır",_count);
    }
}
public class Product
{
    private int _id;
    private string _name;
    public int Id { get; set; }
    public string Name { get; set; }

    public Product(int id,string name)
    {
        _id= id;
        _name= name;
    }
}
interface ILogger
{
    public void log();
}

class DatabaseLogger : ILogger
{
    public void log()
    {
        Console.WriteLine("logged to database");
    }
}
class FileLogger : ILogger
{
    public void log()
    {
        Console.WriteLine("logged to file");
    }
}
class EmployeManager
{
    // Constructor Injection
    private ILogger _logger;
    public EmployeManager(ILogger logger)
    {
        _logger = logger;
    }
    public void Add()
    {
        _logger.log();
        Console.WriteLine("Added");
    }
}
class BaseClass
{
    private string _entity;

    public BaseClass(string entity)
    {
        _entity = entity;
    }
    public void Message()
    {
        Console.WriteLine("{0} kişisinin mesajı", _entity);
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
// static sınıf tanımı
static class Teacher
{// static sınıf içerisindeki metodlar ve fonksiyonlarda static olmalıdır.
    public static int Number { get; set; }
}
static class Utilities
{
    public static void Validate()
    {
        Console.WriteLine("validation is done");
    }

}
public class Manager
{
    public static void Dosomething1()
    {
        Console.WriteLine("something 1");
    }
    public void Dosomething2()
    {
        Console.WriteLine("something 2");
    }
}