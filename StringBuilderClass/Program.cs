using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderClass
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder strb = new StringBuilder();
            StringBuilder strb1 = new StringBuilder();

            strb.Append("No 22/2");
            strb.Append(" Cross Street");
            strb.Append(" Colombo -2 ");
            strb.Append(" Sri Lanka");

            strb.Replace("Colombo -2", "Colombo 07");
            strb.Remove(21, 11);

            Console.WriteLine(strb);

            Console.ReadLine();
        }
    }
}
