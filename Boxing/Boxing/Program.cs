using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 42;  //unboxing
            object o = i;  //boxing i
            Console.WriteLine(i + " ,  " +(Int32) o);

            Console.Read();



        }
    }
}
