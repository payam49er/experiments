///<summary>
///raisign a number to a power recursively
///</summary>
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaiseNumber
{
    class Program
    {
        public class Power
        {
            public static int RaiseToPower(int number, int n)
            {
                if (n == 0)
                    return 1;
                else
                    return RaiseToPower(number, n-1)*number;

            }

        }




        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a number and a value to be raise to:");
            int number = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int result = Power.RaiseToPower(number, n);

            Console.WriteLine("Your answer is: {0}", result);

            Console.ReadLine();


        }
    }
}
