using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            ////In this example we gonna look at how to work with Access Modifiers

            Dog dg = new Dog();
            dg.Name = "Tomy";
       //     dg.Id = 10; // This Cannot be access due to protection level

            Console.ReadLine();
        }
    }
}
