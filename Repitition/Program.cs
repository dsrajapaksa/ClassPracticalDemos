
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire;
using Spire.Barcode;
using System;

namespace Repitition
{
    class Program
    {
        static void Main(string[] args)
        {
            //For Loops 
            //for(int i=1;i<=12;i++)
            //{
            //   Console.WriteLine("{0} x 5 = {1} {2}", i, (i*5));
            //}


            //While Loop
            //int i = 1;

            //while(i<=12)
            //{
            //    Console.WriteLine("{0} x 5 = {1}", i, (i * 5));
            //    i++;
            //}

            //// WHILE LOOP EXAPLE UAGE 

            //bool stat = true;
            //double total = 0;
            //int tempNumber = 0;
            //int counter = 0;

            //while (stat)
            //{
            //    Console.Write("Please enter some value to calcuate : ");
            //    tempNumber = Convert.ToInt16(Console.ReadLine());

            //    total = total+ tempNumber;

            //    Console.Write("Do you have more values to add ? (Y/N)");

            //    if (Console.ReadLine().ToUpper() !="Y" )
            //    {
            //        stat = false;
            //    }

            //    counter++;
            //}
            //Console.WriteLine("Grand total is : {0}", total);
            //Console.WriteLine("Average is : {0} ", Convert.ToDouble(total / counter));


            //FOREACH LOOP
          //  string[] names = { "Amal", "Kamal", "Nimal", "Saman" };
            int[] ages = { 23, 45, 89 };

            string[] names = new string[4]
            {
                "Amal", "Kamal", "Nimal", "Saman"
            };

            Console.Write(names[3]);

       
       
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            //foreach(string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //foreach (int age in ages)
            //{
            //    Console.WriteLine(age);
            //}

                         

            Console.ReadLine();
        }
    }
}
