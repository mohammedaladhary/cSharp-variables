
namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------shape----------------------");
            Shape[] design = new Shape[4];
                design[0] = new Circle(2);
                design[1] = new Rectangle(3, 5);
                design[2] = new Triangle(4, 7);
                design[3] = new Circle(5);


            for (int i = 0; i < design.Length; i++)
                {
                Shape shape = design[i];
                Console.WriteLine("Area of " + shape.GetType().Name + " is " + shape.CalculateArea());
                }
            Console.WriteLine("-------------------------------------------");

        }
    }
}