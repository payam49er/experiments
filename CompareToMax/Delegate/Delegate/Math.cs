using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Math
    {
        delegate int MyDelegate(int p, int q);

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static void Main()
        {
            MyDelegate arithMathic = new MyDelegate(Add);
            int r = arithMathic(10, 5);
            Console.Write("The value of addition is {0}", r);
        }
        
  
    }
}
