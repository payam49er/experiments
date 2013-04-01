///The program accepts an specific amount of dollar and tells you all the combinations possible of this dollar amount 
///in dollar, quarters, dimes, nikeles and pennies using recursion. This is a classic CS problem and solution. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarChange
{
    class Program
    {
        public class Dollar
        {
          
            // the method change accepts the mount of money that you have in cents, the type of coins sizes, 
          public static void Change(List<int> Coins, List<int> Coinsizes, int highest, int sum, int dollaramount)
            {
               
               
                //defining the basic case 
                if(sum == dollaramount)
                {
                    
                    Display(Coins, Coinsizes);
                          return;
                }

                else if (sum > dollaramount)
                    return;

                else
                {  
                    
                    //we have to call Change() recursively here, looping through Coinsizes
                    foreach (int coinvalue in Coinsizes)
                    { 
                       
                        if (coinvalue >= highest)
                        {
                            List<int> copy = new List<int>(Coins);
                            copy.Add(coinvalue);
                            Change(copy, Coinsizes, coinvalue, sum + coinvalue, dollaramount);

                        }
                    }
                }

            }

            //Display method to show our output 
            public static void Display(List<int>Coins, List<int> Coinsizes)
            {
                foreach (int coin in Coinsizes)
                {
                    int count = Coins.Count(value => value == coin);
                    Console.WriteLine(" Combinations are {0} : {1}",coin,count);

                }
            }



        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the amount of your dollar bill:");
            int dollaramount = Convert.ToInt32(Console.ReadLine());
            int numberofpennies = dollaramount*100; // we convert our money to pennies and pass it to the method
            List<int> Coinsizes = new List<int>() { 1, 5, 10, 25 };
            List<int> inputcoins = new List<int>();
            Dollar.Change(inputcoins, Coinsizes, 0, 0, numberofpennies);

            Console.ReadLine();
        }



    }
}
