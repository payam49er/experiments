///<summary>
///just an experiment and work with binary search
///</summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        public static int[] GenerateRND(int startbound, int stopbound)
        {
            Random rnd = new Random();
            int[] numbers = new int[stopbound - startbound];
            for (int i = 0; i < (stopbound - startbound); i++)
            {
                numbers[i] = rnd.Next(startbound, stopbound);
            }

            return numbers;

        }




        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number for lower boundry:");
            int lowerbound = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert a number for upperbound:");
            int upperbound = Convert.ToInt32(Console.ReadLine());
            int[] values = GenerateRND(lowerbound, upperbound);
            Console.WriteLine("sum of your values is : {0}", values.Sum());
            foreach (int item in values)
            {
                Console.WriteLine(item);
            }

            Console.Read();


        }
    }
}
