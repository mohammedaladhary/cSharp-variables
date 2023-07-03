using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers
{
    internal class rectangle
    {
            private double length { get; set; }
            private double width { get; set; }

        public rectangle(double length, double width)
            {
                this.length = length;
                this.width = width;
            }

            public double area()
            {
                return length * width;
            }

            public double perimeter()
            {
                return 2 * (length + width);
            }
    }
}
