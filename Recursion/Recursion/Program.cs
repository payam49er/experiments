using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Recursion
    {
        public static int GetTriangle(int n)
        {
            int result = 0;
            for (int j = n; j >= 0; j--)
            {
                result = result + n;
                --n;
            }
            return result;
          
        }


        public static int GetRecursion(int n)
        {
            int total = 0;
            if (n == 1)
                return 1;
            else
            {
                total = n + (GetRecursion(n - 1));
                return total;
            }
        }

        public static int CalculateFibo(int index)
        {
            int total = 0;
            if (index == 1 || index == 2)
                return 1;
            else
            {
                total = CalculateFibo(index - 1) + CalculateFibo(index - 2);
                return total;
            }

        }


        static void Main(string[] args)
        {
            int myvalue = GetTriangle(8);
            Console.WriteLine("The result of triangle is:{0}", myvalue);
            int mySecondvalue = GetRecursion(8);
            Console.WriteLine("The value from recursion is:{0}", mySecondvalue);

            int fibovalue = CalculateFibo(8);
            Console.WriteLine("The Fibonacci value at your index is:");
            Console.Write(fibovalue);


            Console.ReadLine();
        }
    }
}
