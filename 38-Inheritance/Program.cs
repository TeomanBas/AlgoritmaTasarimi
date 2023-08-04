internal class Program
{
    private static void Main(string[] args)
    {
        Person[] persons = new Person[3]
        {
            new Customer{Id=11}, new Student{Id=22}, new Person{Id=33}
        };

        foreach (Person person in persons)
        {
            Console.WriteLine(person.Id);
        }

        Console.ReadLine();
    }
}
internal class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
internal class Customer : Person
{

}
internal class Student : Person
{

}