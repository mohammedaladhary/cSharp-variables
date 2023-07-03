using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers
{
    internal class employee
    {

            private String name;
            private String position;
            private double salary;

            public employee(String name, String position, double salary)
            {
                this.name = name;
                this.position = position;
                this.salary = salary;
            }

            public void setPosition(String newPosition)
            {
                this.position = newPosition;
            }
            public void setSalary(double newSalary)
            {
                this.salary = newSalary;
            }
            public String getName()
            {
                return name;
            }
            public String getPosition()
            {
                return position;
            }
            public double getSalary()
            {
                // Return the salary instance variable
                return salary;
            }
    }
}
