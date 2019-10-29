using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Console.WriteLine("The circle has radius of {0} and area of {1}", c1.getRadius(), c1.getArea());
            Circle c2 = new Circle(2.0);
            Console.WriteLine("The circle has radius of {0} and area of {1}", c2.getRadius(), c2.getCircumference());
            Circle c3 = new Circle();
            Console.WriteLine(c3.ToString());
        }
    }
}
