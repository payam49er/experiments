using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSolution
{
    class Program
    {
      
        static void Main(string[] args)
        {
            string str = "Hello";
            str.ToUpper();
            str.Insert(0, "World");
            Console.WriteLine(str);

            StringBuilder test = new StringBuilder("Payam",10);
            test.AppendLine("Shoghi");
            Console.WriteLine(test);

            Console.ReadLine();

        }
    }
}
