///<summary>
///the purpose of this code is to calculate Sin(x) and Cos(x) by Maclaurin series. 
///</summary>
///


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maclaurin
{
    class Program
    {

        public static int Factorial(int x)
        {
            if (x == 1)
                return 1;
            else
                return x * (x - 1);
        }


     

        public static double Sin(double x)
        {


            double sinusVal = x - (Math.Pow(x, 3) / Factorial(3)) + (Math.Pow(x, 5) / Factorial(5));
            return sinusVal;


        }




        static void Main(string[] args)
        {

            Console.WriteLine("Please insert a number to calculate its Sin value");
            var value = Convert.ToDouble(Console.ReadLine());
            var valueToRadian = value * (Math.PI / 180);
            var realSin = Math.Sin(value);
            var result = Sin(valueToRadian);
            Console.WriteLine("The Sin({0}) is :{1}", valueToRadian, result);
            Console.WriteLine("Real sin is {0}", realSin);
            Console.Read();

        }
    }
}
