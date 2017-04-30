using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCal
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shp = new Shape();

            Console.WriteLine("------AREA CALCULATOR-----");
            string shape;
            double radius, height, baseWidth;
            Console.WriteLine("Please choose shape :\n(C - Circle,T - Triangle)");

            shape = Console.ReadLine().ToUpper();

            try
            {
                switch (shape)
                {
                    case "C":
                        Console.Write("Radius of circle ? ");
                        radius = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Area : {0} ", shp.getAreaCircle(radius));

                        break;
                    case "T":
                        Console.Write("Hight of the Triangle ? ");
                        height = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Base Width of the Triangle ? ");
                        baseWidth = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Area : {0} ", shp.getAreaTriangle(height, baseWidth));
                        break;
                    default:
                        Console.WriteLine("No Match Found !");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            Console.ReadLine();
        }
    }
}
