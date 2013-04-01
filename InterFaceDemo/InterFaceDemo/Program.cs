using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceDemo
{
    class Program
    {
        class Demo : abc,def
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello interfaces");
                Demo refdemo = new Demo();
                def refdef = refdemo;
                refdef.pqr();
                refdef.xyz();


                Console.ReadLine();
            }

             void abc.xyz()
            {
                Console.WriteLine("In Demo  xyz");
            }

              void def.pqr()
            {
                Console.WriteLine("In Demo pqr from def");
            }

        }


        class Sample : abc,def
        {
            public void xyz()
            {
                Console.WriteLine("In Sample :: xyz");
            }

            public  void pqr()
            {
                Console.WriteLine("def implemented from Sample");
            }
        }

        interface abc
        {
            void xyz();
        }

        interface def:abc
        {
            void pqr();
        }

    }
}
