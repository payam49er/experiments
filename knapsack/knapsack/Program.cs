///<summary>
/// Working on classic Knapsack problem in C#, we have five items of the weights 11,8,7,6,5 lb, in what combinatin we can have
/// 20 lb ?
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knapsack
{
    class Program
    {


        public static void GetWeight(List<int> weights,List<int> oneweight ,int upperbound, int sum, int goal)
        {
            //base cases
            if (sum == goal)
            {
                Display(oneweight, weights); //define the display funaction later 
               
            }
            if (sum > goal) // we have too much in our bag
            {
                return;
            }
            else
            {
                foreach (int weight in weights)
                {
                    if (weight >= upperbound)
                    {
                        List<int> copy = new List<int>(oneweight);
                        copy.Add(weight);
                        GetWeight(weights, copy, weight, sum + weight, goal);

                    }

                }

            }
        }

        public static void Display(List<int> items, List<int> weights)
        {
            foreach (int value in weights)
            {
                int count = items.Count(f => f == value);
                Console.WriteLine(" Use weight {0} for {1} times", value, count);
            }

        }



        static void Main(string[] args)
        {
            List<int> weights = new List<int>() { 11, 8, 7, 6, 5 };
            List<int> items = new List<int>();
            //compute for the values
            GetWeight(weights,items,0, 0, 20);

            Console.ReadLine();

        }
    }
}
