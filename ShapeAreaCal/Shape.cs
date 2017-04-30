using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCal
{
    class Shape
    {
        public double getAreaCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
        public double getAreaTriangle(double height, double baseWidth)
        {
            double area = (height * baseWidth) / 2;
            return area;
        }
    }
}
