using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Circle
    {
        private double radius;
        
        public Circle()
        {
            radius = 1.0;
        }
        public Circle(double r)
        {
            radius = r;
        }
        public double getRadius()
        {
            return radius;
        }
        public double getArea()
        {
            return radius * radius * Math.PI;
        }
        public void SetRadius(double newRadius)
        {
            this.radius = newRadius;
        }
        public override string ToString()
        {
            return String.Format("Circle[radius={0}]", radius);
        }
        public double getCircumference()
        {
            return 2 * radius * Math.PI;
        }
    }
}
