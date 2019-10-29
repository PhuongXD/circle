using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class Circle
    {
        private string color;
        private double radius;

        public Circle()
        {
            radius = 1.0;
            color = "red";
        }
        public Circle(double r)
        {
            radius = r;
            color = "red";
        }
       public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public double getRadius()
        {
            return radius;
        }
        public double getArea()
        {
            return radius * radius * Math.PI;
        }
       public string getColor()
        {
            return color;
        }
       public void SetRadius(double newRadius)
       {
           this.radius = newRadius;
       }

       public void SetColor(string newColor)
       {
           this.color = newColor;
       }
       public override string ToString()
       {
           return String.Format("Circle[radius={0},color={1}]", radius, color);
       }
    }
}
