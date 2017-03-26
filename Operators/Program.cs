using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            //-------Program 1---------------
            //Console.WriteLine("Please tell me your name ? ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hi, {0} how are you doing ? ", name);


            //Console.Write("{0}, how old are you ? ", name);
            //string age = Console.ReadLine();
            //Console.WriteLine("Ohh! Are you {0} years old ?", age);

            //-------Program 2---------------
            //double num1, num2, total;

            //Console.Write("Please enter number 1 value : ");
            //num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Please enter number 2 value : ");
            //num2 = Convert.ToDouble(Console.ReadLine());

            //total = num1 + num2;
            //Console.WriteLine("Addition of two numbers are : {0} ", total);

            //-------Program 3---------------
            //const double PI = 3.14;
            //double radius = 0, area = 0 ;

            //Console.Write("To find the Area of a circle please give radius : ");
            //radius = Convert.ToDouble(Console.ReadLine());

            ////Equation is here :D

            //area = Math.PI * Math.Pow(radius,2);

            //Console.WriteLine("Area of the Circle is : {0} ", area);



            //-------Program 4---------------

            //string num1 = "100", num2 = "400", total ;

            //total = num1 + num2;

            //Console.WriteLine(total);

            //-----Using Var Implicit type varibles-----

            /*    var number = 89;

                Console.WriteLine(number.GetType());

        */

            // Conversion between varibles 

            int number1= 10, number2= 10 ;
            int total;

           double number3 = (double) number2; //Convert.ToDouble(number2)

            total =number1 +number2;


            Console.ReadLine();

        }
    }
}
