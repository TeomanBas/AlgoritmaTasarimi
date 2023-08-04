// örnek loglama senaryosu
internal class Program
{
    private static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.logger = new DatabaseLogger();
        customerManager.Add();

        Console.ReadLine();
    }
}
class CustomerManager
{
    // normalde bu işlem constructor lar ile yapılır.
    // property injections 
    public ILogger logger { get; set; }
    public void Add()
    {
        logger.Log();
        /* YANLIŞ BİR KULLANIM ÖRNEĞİDİR.
        Logger logger = new Logger();
        logger.Log();
        */
        Console.WriteLine("Customer Added");
    }
}
/*
class Logger
{
    public void Log()
    {
        Console.WriteLine("Logged!");
    }
}
*/
class FileLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Log to file");

    }
}
class DatabaseLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Log to database");
    }
}
interface ILogger
{
    void Log();
}
