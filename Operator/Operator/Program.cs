using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class Program
    {

        static void Main()
        {
            int x = 10;
            int? nx = 20;
            Console.WriteLine(" nx has a value? {0}", nx.HasValue);
            Console.WriteLine("nx has a value? {0}", nx.Value);
            Console.WriteLine("x ==nx :{0}", x == nx);
            Console.WriteLine(" x!=nx :{0}", x != nx);
            Console.ReadLine();

        }
    }
}
