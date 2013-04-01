using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap
{
    class Program
    {
        public static void Main()
        {
            var a = "Payam";
            var b = "Shoghi";

            var temp = a;
            a = b;
            b = temp;

            Console.WriteLine(a + b);

            Console.Read();

        }

    }
}
