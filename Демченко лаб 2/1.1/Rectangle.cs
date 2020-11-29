using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    class Rectangle
    {
        double side1;
        double side2;
        public double Area { get; private set; }
        public double Perimeter { get; private set; }
        public Rectangle(double a, double b) => (side1, side2) = (a, b);

        public void AreaCalulator(double a, double b) {
            Area = a * b;
            Console.WriteLine(Area);
        }
        public void PerimeterCalulator(double a, double b)
        {
            Perimeter = 2 * a + 2 * b;
            Console.WriteLine(Perimeter);
        }


    }
}
