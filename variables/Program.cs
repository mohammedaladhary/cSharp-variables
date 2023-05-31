
internal class Program
{
    private static void Main(string[] args)
    {
        //double i = 6.5;
        //char a = 'b';
        //Console.WriteLine(i + "" +a);


        //Console.WriteLine("Enter the first number:");
        //int a = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Enter the second number:");
        //int b = Convert.ToInt32(Console.ReadLine());


        //Console.WriteLine("a+b=" + (a + b));
        //Console.WriteLine("a-b=" + (a - b));
        //Console.WriteLine("b-a=" + (b - a));
        //Console.WriteLine("a/b=" + (a / b));
        //Console.WriteLine("b/a=" + (b / a));
        //Console.WriteLine("a*b=" + (a * b));
        //Console.WriteLine("a%b=" + (a % b));
        //Console.WriteLine("b%a=" + (b % a));

        Console.WriteLine("Enter the first string:");
        string a = Console.ReadLine();

        Console.WriteLine("Enter the second string:");
        string b = Console.ReadLine();

        Console.WriteLine("<==Swap==>");
        //(a, b) = (b, a);
        string c;
        //c=b
        //b=a

        c = a;
        a = b;
        b = c;
        Console.WriteLine(a);
        Console.WriteLine(b);










    }
}