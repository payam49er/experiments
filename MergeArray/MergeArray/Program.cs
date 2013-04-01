///<summary>
///this code is to demonstrate how to merge to sorted arrays to a new empty array
///</summary>
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeArray
{
    class Program
    {
        public static int[] Merge(int[] arrayA, int[] arrayB, int[] arrayC)
        {
            int countA = 0;
            int countB = 0;
            int countC = 0;

            while ( countA < arrayA.Length && countB < arrayB.Length) // neither array is empty
            {
                if (arrayA[countA] < arrayB[countB])
                {
                    arrayC[countC++] = arrayA[countA++];
                }
                else
                {
                    arrayC[countC++] = arrayB[countB++];
                }

            }

            while (countA < arrayA.Length)
            {
                arrayC[countC++] = arrayA[countA++];
            }

            while (countB < arrayB.Length)
            {
                arrayC[countC++] = arrayB[countB++];
            }

            return arrayC;
        }

        static void Main(string[] args)
        {

            int[] arrayA = new int[4] { 23, 47, 81, 95 };
            int[] arrayB = new int[6] { 7, 14, 39, 55, 62, 74 };
            int[] arrayC = new int[10];
            int[] mergedArray = Merge(arrayA, arrayB, arrayC);
            foreach (int item in mergedArray)
            {
                Console.Write(" " + item);
            }

            Console.Read();
        }
    }
}
