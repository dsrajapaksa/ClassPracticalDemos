using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Person
    {
        public string id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public int age { get; set; }

        public void PrintAllDetails()
        {
            Console.WriteLine("Id of the Person is : {0}", id);
            Console.WriteLine("Name of the Person is : {0}", name);
            Console.WriteLine("City of the Person Living: {0}", city);
            Console.WriteLine("Peron's age is : {0}", age);
        }

        public string GetLocation()
        {
            return city + ", Sri Lanka";
        }

    }
}
