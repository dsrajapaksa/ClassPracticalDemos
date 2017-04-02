using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            ////--------IF CONDITIONS---------------------
            //Console.Write("What is the temparature out side ? ");
            //int temp = Convert.ToInt16(Console.ReadLine());

            //if(temp >= 55 &&  temp <=100 )
            //{
            //    Console.WriteLine("Its Boiling ! ");
            //}
            //else if (temp >=35 && temp <55)
            //{
            //    Console.WriteLine("It's Damn Hot !");
            //}
            //else if(temp >=25 && temp <35)
            //{
            //    Console.WriteLine("It Hot !");
            //}
            //else if(temp>=10 && temp <25)
            //{
            //    Console.WriteLine("Its Cool !");
            //}
            //else if(temp>=0 && temp <10)
            //{
            //    Console.WriteLine("Its Freezing ! ");
            //}
            //else
            //{
            //    Console.WriteLine("WTF !Value is not defined !");
            //}


            ////------SWITCH CONDITIONS--------------

            Console.Write("Please give a character: ");
            string character = Console.ReadLine();


            switch (character)
            {
                case "A":
                    Console.WriteLine("A is for Apple !");
                    break;
                case "B":
                    Console.WriteLine("B is for Ball !");
                    break;
                case "C":
                    Console.WriteLine("C is for Car !");
                    break;
                case "D":
                    Console.WriteLine("D is for Doll !");
                    break;
                default:
                    Console.WriteLine("No Letters found !");
                    break;
            }



            Console.ReadLine();
        }
    }
}
