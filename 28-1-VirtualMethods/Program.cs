internal class Program
{
    private static void Main(string[] args)
    {
        Database[] db = new Database[2]
        {
            new SqlServer(), new MysqlServer(),
        };
        foreach (var item in db)
        {
            item.Delete();
        }
        
    }
}
public class Database
{
    public virtual void Add()
    {
        Console.WriteLine("add by default");
    }
    public virtual void Delete()
    {
        Console.WriteLine("add by default");
    }

}
public class SqlServer:Database
{
    override public void Delete()
    {
        Console.WriteLine("sql code added");
    }
}
public class MysqlServer:Database
{

}