using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _34_1_Interface
{
    internal interface ICustomerDataAccessLayer
    {
        void Add();
        void Update();
        void Delete();

    }
    class SqlServerCustomerDal : ICustomerDataAccessLayer
    {
        public void Add()
        {
            Console.WriteLine(" sql server :eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("sql server : silindi");
        }

        public void Update()
        {
            Console.WriteLine("sql server : güncellendi");
        }
    }
    class OracleCustomerDal : ICustomerDataAccessLayer
    {
        public void Add()
        {
            Console.WriteLine("oracle server :eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("oracle server :silindi");
        }

        public void Update()
        {
            Console.WriteLine("oracle server :güncellendi");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDataAccessLayer CDAL)
        {
            CDAL.Add();
        }
    }
    // SOLID - interface Segregation
    interface IWorker
    {
        void work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void Salary();
    }

    public class Personal : IWorker, ISalary, IEat
    {
        public Personal()
        {
            Console.WriteLine("Personel özellikleri: ");
        }
        public void Eat()
        {
            Console.Write("yemek yer ");
        }

        public void Salary()
        {
            Console.Write("maaş alır ");

        }

        public void work()
        {
            Console.Write(" çalışır");

        }
    }
    public class Robot : IWorker
    {
        public Robot()
        {
            Console.WriteLine("Robot özellikleri: ");
        }
        public void work()
        {
            Console.Write(" çalışır");

        }
    }

    public class Departmant
    {
        void work()
        {

        }
    }
}
