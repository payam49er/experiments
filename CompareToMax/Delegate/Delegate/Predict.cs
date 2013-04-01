using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
   public class Predict
    {
        //delegate for a method that recieves a number and returns a bool
        public delegate bool NumberPredicate(int number);

        public static List<int> FilterArray(int[] intArray, NumberPredicate predicate)
        {
            //hold selected elements
            List<int> result = new List<int>();

            //iterate over each element in the array
            foreach (int item in intArray)
            {
                if (predicate(item))
                    result.Add(item);
            }

            return result;
        }


        //determine if an integer is even
        public static bool IsEven(int number)
        {
            return(number % 2 == 0);
                
        }

        //determine if the number is odd
        public static bool IsOdd(int number)
        {
            return (number % 2 != 0);
        }

        public static bool IsOver5(int number)
        {
            return (number >= 5);
        }

        //display elements of a list
        public static void DisplayList(string description, List<int> list)
        {
            Console.Write(description);
            //iterate over each element in the list
            foreach (int item in list)
                Console.WriteLine("{0}", item);

        }
        
    }
}
