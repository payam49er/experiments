///<summary>
///creating Magic Square using recursion
///</summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicSquare
{
    class Program
    {
        public static List<int> MakeMagic(List<int> numbers)
        {
            List<int> permuted = new List<int>();
            //base case
            if (numbers.Count() == 1)
                return numbers;
            else
                foreach (int item in numbers)
                {
                    permuted.Add(item);
                    permuted = MakeMagic(permuted);
                }

            return permuted;
        }
              
            
        


        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 0; i < number; i++)
            {
                numbers.Add(i);
            }
            List<int> myvalues = MakeMagic(numbers);

            foreach (int item in myvalues)
            {
                Console.WriteLine(item);
            }


            Console.Read();
        }
    }
}
