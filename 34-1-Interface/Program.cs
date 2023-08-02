using _34_1_Interface;


internal class Program
{
    private static void Main(string[] args)
    {
        // örnek bir interface kullanımı 
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(new SqlServerCustomerDal());
        customerManager.Add(new OracleCustomerDal());
        Console.WriteLine("-------------------------------------");
        // eğer birden çok  veri tabanı için kayıt yapılacaksa
        ICustomerDataAccessLayer[] customerManager2 = new ICustomerDataAccessLayer[2]
        {
            new SqlServerCustomerDal(),
            new OracleCustomerDal()
        };
        foreach (var customer in customerManager2)
        {
            customer.Add();
        }

        Console.WriteLine("---------------------------------");
        // Interface Segregation

        IWorker[] workers = new IWorker[2] { new Personal(),new Robot()};
        foreach (var worker in workers)
        {
            worker.work();
        }


        Console.ReadLine();
    }
}