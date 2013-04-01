///<summary>
///A demo of heap sort
///</summary>


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class Program
    {
        public static int[] Sortbyheap(int[] valArray)
        {
            int arraysize = valArray.Length;
       
            for (int i = (arraysize / 2) - 1; i >= 0; i--)
            {
                ShiftDown(valArray, i, arraysize); 
            }
            for (int j = arraysize - 1; j >= 1; j--)
            {   
                //switching values
                int temp = valArray[0];
                valArray[0] = valArray[j];
                valArray[j] = temp;
                ShiftDown(valArray, 0, j - 1);
            }

            return valArray;

        }

        //the ShiftDown method is the heart of the algorithm as it makes sure 
        //the biggest number is in the root and creates the Heap structure, making sorting easy
        private static void ShiftDown(int[] numbers, int root, int bottom)
        {
            int done = 0;
            int maxchild;
            while ((root * 2) <= bottom && done == 0)
            {
                if (root * 2 == bottom)
                    maxchild = root * 2;
                else if (numbers[root * 2] > numbers[(root * 2) + 1])
                    maxchild = root * 2;
                else
                    maxchild = root * 2 + 1;
                if (numbers[root] < numbers[maxchild])
                {
                    int temp = numbers[root];
                    numbers[root] = numbers[maxchild];
                    numbers[maxchild] = temp;
                    root = maxchild;

                }
                else
                    done = 1;
            }

        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(10,100);
            }

            int[] sortedval = Sortbyheap(numbers);

            foreach (int val in sortedval)
            {
                Console.WriteLine(val);
            }

            Console.Read();
        }
    }
}
