///<summary>
///using recursion to count numbers up from 1 to a certain number
///</summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountUp
{
    class Program
    {
        public static void CountUp(int start, int stop)
        {
            //base
            if (start == 0)
                return;
            if (start > stop)
                return;
            else
            {
                CountUp(start + 1, stop);
                Console.Write("{0}"+" ",start);
            }
        }

        
        //method to count down
        public static void CountDown(int start, int stop)
        {
            if (start == stop)
                return;
            if (start == 0)
                return;
            else
            {
                CountDown(start - 1, stop);
                Console.WriteLine("{0}" + " ", start);
            }


        }
             

   



        static void Main(string[] args)
        {
            Console.WriteLine("Pelase insert a number to be counted up to:");
            int number = Convert.ToInt32(Console.ReadLine());
           // CountUp(1,number);
           // Console.WriteLine();
            CountDown(20,number);
            Console.ReadLine();
        }
    }
}
