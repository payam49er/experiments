using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        public class Number
        {
            public bool IsPrime(int number)
            {
                 bool result = true;
                //prime number is only divisible by itself and 1
                int upperlimit = (int)Math.Sqrt(number);
                for (int i = 2; i <= upperlimit; i++)
                {
                    if (number % i == 0)
                        return result = false;
                                           
                }
                return result;
                  
            }
        }

        static void Main(string[] args)
        {
            Number mynumber = new Number();
            Console.WriteLine("Please insert your number:");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input <= 1)
                Console.WriteLine("Your number is not acceptable, it has to be bigger than 1");

            else
            {
                bool isprime = mynumber.IsPrime(input);
                if (isprime == true)
                    Console.WriteLine("{0} is a prime number", input);
                else
                    Console.WriteLine("{0} is NOT a prime number", input);
            }
            Console.ReadLine();
        }
    }
}
