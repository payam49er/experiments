using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateRD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert your month :");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert your day :");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert your year :");
            int year = Convert.ToInt32(Console.ReadLine());

            DateTime userInput = new DateTime(year, month, day);
            var subtractedDay = userInput.Subtract(DateTime.Now);
            Console.WriteLine("Your date is {0} days ago from today", subtractedDay); // just experiments, read the code
            
            Console.WriteLine(myguid);
            Console.ReadLine();
        }


        
    }
}
