using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person ps1 = new Person();
            //Person person2 = new Person();

            //ps1.name = "Saman";
            //ps1.id = "11212121";
            //ps1.age = 34;
            //ps1.city = "Colombo";

            //person2.id = "9999";
            //person2.name = "Kamal";
            //person2.age = 67;
            //person2.city = "Gampaha";


            //ps1.PrintAllDetails();

            //Console.WriteLine("-----------");

            //person2.PrintAllDetails();

            //string returnvalue = ps1.GetLocation();
            //Console.WriteLine(returnvalue);

            Calculator cal = new Calculator();

            Console.WriteLine("Get multiplication : {0}", cal.getDivision("23","c"));

            Console.ReadLine();
        }
    }

 
}
