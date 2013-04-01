///This program calculates the Factorial of a number using recursion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        public static long CalculateFactorial(int number)
        {
            //factorial of the number N is N * (N-1) * (N-2)*...*1 
            //defining the base case
            if (number == 1)
                return 1;
            else
            {
                long factorial = number * (CalculateFactorial(number - 1));
                return factorial;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a number:");
            int userinput = Convert.ToInt32(Console.ReadLine());
            long factorial = CalculateFactorial(userinput);
            Console.Write("the factorial of {0} is {1}", userinput, factorial);



            Console.ReadLine();

        }
    }
}
