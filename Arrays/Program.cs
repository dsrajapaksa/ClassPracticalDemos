using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Amal", "Kamal","Nimal"};

            //Console.WriteLine(name[0]);

            for(int i=0;i<name.Length;i++)
            {
                Console.WriteLine(name[i]);
            }


            foreach(string n in name )
            {
                Console.WriteLine(n);
            }


            Console.ReadLine();
        }
    }
}
