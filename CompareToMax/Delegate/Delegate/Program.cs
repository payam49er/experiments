using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegate;

namespace Delegate
{
    class Program
    {
        public delegate void Delgate_Prod(int a, int b);
        class Multiply
        {
           
            static void Method1(int val1, int val2)
            {

                Console.WriteLine("The result of multiplication is:{0}", val1 * val2);
            }

            static void Method2(int val1, int val2)
            {
                double result = val1 / val2;
                Console.WriteLine("The result of division is:{0}", result);
            }


            static void Main(string[] args)
            {
                ////Creating the delgate instance
                //Delgate_Prod func = new Delgate_Prod(Method1);
                //func += new Delgate_Prod(Method2);
                //func(10, 2);
                //func -= new Delgate_Prod(Method1);
                //func(20, 3);

                //Math math = new Math();
                //// creating a new instance of the calculationhandler 
                //Math.CalculationHandler calcualte = new Math.CalculationHandler(math.Sum);
                //int result = calcualte(8, 9);
                //Console.WriteLine("the result of the addition is {0}", result);

                //Math.DivisionHandler calculateDivision = new Math.DivisionHandler(math.Devide);
                //double divisionresult = calculateDivision(10, 5);
                //Console.WriteLine("Result of division is {0}", divisionresult);

                //Math.WriteSomething writer = new Math.WriteSomething(math.Message);
                //writer("Payam");

                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                Predict.NumberPredicate evenPredicate = Predict.IsEven;
                Console.WriteLine("Call IsEven using a delegate variable:{0}", evenPredicate(4)); 

                <List><int> evenNumbers = Predict.FilterArray(numbers,evenPredicate);

                Console.ReadLine();

            }
        }
    }
}
