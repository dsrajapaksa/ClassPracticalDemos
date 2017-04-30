using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Calculator
    {

        public double getMultiplication(double number1, double number2)
        {
            return number1 * number2;
        }

        public double getDivision(string number1, string number2)
        {
            try
            {
                double result = Convert.ToInt16(number1) / Convert.ToInt16(number2);
                return result;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Dont Divide By Zero !");
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        


    }
}
