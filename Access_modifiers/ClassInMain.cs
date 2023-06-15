using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers
{
    internal class Person
    {
        // Declare private fields
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        private bool isHeHasFamily;

        // Define public methods to set and get the values of the fields
        public Person(string name, string address, int age)
        {
            this.name = name;
            this.address = address;
            this.age = age;
        }

        public void family()
        {
            isHeHasFamily = true;
            Console.WriteLine("he has a family");
        }

      
        string personName()
            {
                this.name = "Ahmed";
                return this.name;
            }
      
        int personAge()
        {
            this.age = 24;
            return this.age;
        }

        string setAddress()
        {
            this.address = "Muscat";
            return this.address;
        }
    }
}
