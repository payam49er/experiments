using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveMultiplication
{
    class Program
    {

        public static int Multiply(int x, int y)
        {
            //add x to itself for y times
            //define the base case
            if (x == 0 || y == 0)
                return 0;
            if (x == 1)
                return y;
            if (y == 1)
                return x;
            else
            {
                return x + Multiply(x, y - 1);
            }

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Please insert two numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int result = Multiply(a, b);
            Console.WriteLine("The result of multiplication is {0}", result);

            Console.ReadLine();


        }
    }
}
