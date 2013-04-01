using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCast
{
    class Program
    {
        delegate int multiply(int a, int b);
     
            static int multiplyNumbers(int a, int b)
            {
                return a * b;
            }

            static int devideNumbers(int a, int b)
            {
                return a / b;
            }
     

        static void Main(string[] args)
        {
            multiply multiDelegate = new multiply(multiplyNumbers);
            multiDelegate += new multiply(multiplyNumbers);
            var multiplicationResult = multiDelegate(3, 2);
            Console.WriteLine(multiplicationResult);

            multiDelegate += new multiply(devideNumbers);
            var devisionResult = multiDelegate(10, 2);
            Console.WriteLine(devisionResult);
            Console.Read();
        }
    }
}
