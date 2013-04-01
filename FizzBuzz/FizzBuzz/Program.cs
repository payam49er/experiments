using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        public static void PrintNumbers(int n)
        {
            if (n % 5 == 0 & n % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (n % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (n % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
          
            else
                Console.WriteLine(n);

        }

        static void Main(string[] args)
        {

            for (int i = 1; i <= 100; i++)
            {
                PrintNumbers(i);
            }
            Console.ReadLine();
        }
    }
}
