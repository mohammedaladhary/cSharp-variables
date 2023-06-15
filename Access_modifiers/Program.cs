
namespace Access_modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ahmed", "Muscat", 24);
            Console.WriteLine(person.name);
            Console.WriteLine(person.address);
            Console.WriteLine(person.age);
        }
    }
}