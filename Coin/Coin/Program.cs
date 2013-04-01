using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Coin
{

    class Program
    {
        static void Main()
        {
            List<int> coins = new List<int>();
            List<int> Coinsizes = new List<int>() { 1, 5, 10, 25};
            //
            // Compute change for 51 cents.
            //
            Change(coins, Coinsizes, 0, 0, 200);
            Console.ReadLine();
        }

        static void Change(List<int> coins, List<int> Coinsizes, int highest, int sum, int goal)
        {
            //
            // See if we are done.
            //
            if (sum == goal)
            {
                Display(coins, Coinsizes);
                return;
            }
            //
            // See if we have too much.
            //
            if (sum > goal)
            {
                return;
            }
            //
            // Loop through amounts.
            //
            foreach (int value in Coinsizes)
            {
                //
                // Only add higher or equal amounts.
                //
                if (value >= highest)
                {
                    List<int> copy = new List<int>(coins);
                    copy.Add(value);
                    Change(copy, Coinsizes, value, sum + value, goal); 
                }
            }
        }

        static void Display(List<int> coins, List<int> Coinsizes)
        {
            foreach (int amount in Coinsizes)
            {
                int count = coins.Count(value => value == amount);
                Console.WriteLine("{0} : {1}",
                amount,
                count);
            }
            
        }
    }
}
