
using System.Drawing;

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
            Console.WriteLine("------------------------------------------------");

            BankAccount bank = new BankAccount();
            bank.accNo = bank.accNo;
            bank.accSalary = bank.accSalary;
            Console.WriteLine("Account number is : " + bank.accNo);
            Console.WriteLine("Amount to be credited/deposited : " + bank.accSalary + " OMR");
            Console.WriteLine("------------------------------------------------");

            rectangle rectangle = new rectangle(5, 10);
            double area = rectangle.area();
            double perimeter = rectangle.perimeter();
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);
            Console.WriteLine("------------------------------------------------");

            employee staff = new employee("mohammed" , "developer" , 700.000);
            string name = staff.getName();
            string position = staff.getPosition();
            double salary = staff.getSalary();
            Console.WriteLine("the name is "+name);
            Console.WriteLine("position is "+ position);
            Console.WriteLine("salary is " + salary);
            Console.WriteLine("------------------------------------------------");

            product item = new product("banana", 2.300 , 2);
            string name1 = item.getName();
            double price1 = item.getPrice();
            int quantity1 = item.getQuantity();
            Console.WriteLine("the name is " + name1);
            Console.WriteLine("the price is " + price1);
            Console.WriteLine("the quantity is " + quantity1);
            Console.WriteLine("------------------------------------------------");

        }
    }
}