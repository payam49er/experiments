///<summary>
///inout some numbers and get the biggest number possible
///</summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestNumber
{
    class Program
    {

        public class Numbers
        {
            public static int Getbiggest(int[] inputnumbers)
            {
                int high1 = inputnumbers[0];
               
                for (int j = 1; j < inputnumbers.Length; j++)
                {
                        if (inputnumbers[j] > high1)
                        {
                            high1 = inputnumbers[j];
                        }

                }

                return high1;
            }

            public static int Getsecondhigh(int[] inputnumbers)
            {
                int hight1 = inputnumbers[0];
                int high2 = inputnumbers[0];
                for (int i = 1; i < inputnumbers.Length; i++)
                {
                    if (inputnumbers[i] > hight1)
                    {

                        hight1 = inputnumbers[i];
                    }
                }
                for (int j = 1; j < inputnumbers.Length; j++)
                {
                    if (inputnumbers[j] > high2 && inputnumbers[j] < hight1)
                    {
                        high2 = inputnumbers[j];
                    }
                }

                return high2;
            }

        }


        static void Main(string[] args)
        {
            int[] mynumbers = new int[] {4, 65,5, 3,79, 6, 9, 78};
            int myvalue = Numbers.Getbiggest(mynumbers);
            int secondhigh = Numbers.Getsecondhigh(mynumbers);
           Console.WriteLine("The biggest number is {0} and the second biggest number is {1}",myvalue,secondhigh);

           Console.ReadLine();
        }
    }
}
