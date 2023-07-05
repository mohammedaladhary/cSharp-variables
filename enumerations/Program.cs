using System.ComponentModel;
using System.Runtime.InteropServices.ComTypes;

namespace enumerations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            User user1 = new User("Aladhary", 1, Gender.MALE, CarType.PREMIUM);
            User user2 = new User("Osama", 1, Gender.MALE, CarType.PREMIUM);
            User user3 = new User("Salim", 1, Gender.MALE, CarType.PREMIUM);

            foreach (Gender gender in Enum.GetValues(typeof(Gender)))
            {
                Console.WriteLine(gender.ToString());
            }

            Console.WriteLine((int)Gender.FEMALE);
            Console.WriteLine((int)CarType.VAN);
            string description = getEnumDescription(CarType.BASIC);
            Console.WriteLine(description);


        }

        private static string getEnumDescription(Enum enums)
        {
            var field = enums.GetType().GetField(enums.ToString());
            var attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
            return attribute != null ? attribute.Description : enums.ToString();
        }
    }
}