using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAdd
{
    class Program
    {

        delegate int MyDelegate(int p, int q);

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtrac(int a, int b)
        {
            return a - b;
        }

        public static int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            MyDelegate arithmethod = null;
            Console.WriteLine("Please insert two integer numbers");

                int input1 = Convert.ToInt32(Console.ReadLine());
                int input2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please choose your operation as + , - , * , M");
                char operationinput = Convert.ToChar(Console.ReadLine());
                switch (operationinput)
                {
                    case '+':
                        arithmethod = new MyDelegate(Add);
                        break;
                    case '-':
                        arithmethod = new MyDelegate(Subtrac);
                        break;
                    case '*':
                        arithmethod = new MyDelegate(Multiply);
                        break;
                    case 'M':
                        arithmethod = new MyDelegate(Max);
                        break;

                }

                int r = arithmethod(input1, input2);
                Console.WriteLine("The result of your {0} operation is {1}", operationinput, r);

            Console.ReadLine();
        }
    }
}
