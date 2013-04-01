///<summary>
///This code implements Compare to max for finding the maximum value in an iteration.
///</summary>
///


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareToMax
{
    class Program
    {
        public class FindMax
        {
           

            public static int FindMaxLinear(int[] input)
            {
                int currentValue = input[0];

                for (int i = 1; i < input.Length; i++)
                {
                    if (currentValue <= input[i])
                        currentValue = input[i];

                }
                return currentValue;

            }

           
          

        }
  


            static void Main(string[] args)
            {
                int[] data = new int[1000];
                Random rnd = new Random();
                for (int i = 0; i < 1000; i++)
                {
                    data[i] = rnd.Next(i);
                    Console.WriteLine(data[i]);
                }
               
                int max = FindMax.FindMaxLinear(data);
            
                Console.WriteLine("The max value is {0}", max);
              
                Console.ReadLine();
            }
        }
    
}
