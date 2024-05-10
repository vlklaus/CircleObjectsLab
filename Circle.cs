using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _051024_Circle_Objects_Lab
{
    public class Circle
    {
        // properties
        private double Radius { get; set; }


        // constructor
        public Circle(double _radius)
        {
            Radius = _radius;
        }


        // method
        public double CalculateDiameter()
        {
           double diameter = Radius * 2;
           return diameter;
        }

        public double CalculateCircumference()
        {
            double circumference = 2 * System.Math.PI * Radius;
            return circumference;
        }

        public double CalculateArea()
        {
            double area = System.Math.PI * Math.Pow(Radius, 2);
            return area;
        }

        public void Grow()
        {
            Radius *= 2;
        }

        public double GetRadius()
        {
            double radius = (2 * System.Math.PI * Radius) / (2 * System.Math.PI);
            return radius;
        }

    }
}