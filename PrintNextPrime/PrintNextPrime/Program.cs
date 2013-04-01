/// <summary>
/// This code will prinet the next prime number after any number that you insert. 
///</summary>
///


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNextPrime
{
    class Program
    {
        class PrimeNumber
        {
            public static bool IsitPrime(int number)
            {
                bool prime = true;
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                        prime = false;
                }
                return prime;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a number bigger than 1 here:");
            int number = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i < i + 1; i++)
            {
                bool result = PrimeNumber.IsitPrime(number + i);
                if (result == true)
                {
                    Console.WriteLine(number + i);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
