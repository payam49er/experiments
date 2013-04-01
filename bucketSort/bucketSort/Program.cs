///<summary>
///This is a code for Bucket Sort algorithm
///</summary>


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bucketSort
{
    class Program
    {
        public static void Sort(int[] inputarray, int m)
        {
            int[] buckets = new int[m];
            for (int j = 0; j < m; j++)
                buckets[j] = 0;
            for (int i = 0; i < inputarray.Length; ++i)
                ++buckets[inputarray[i]];
            for (int i = 0, j = 0; j < m; j++)
            {
                for(int k = buckets[j] ; k > 0 ; --k)
                    inputarray[i++] = j;
            }

            for (int a = 0; a < inputarray.Length; a++)
                Console.Write(inputarray[a]);
        }



        static void Main(string[] args)
        {
            int[] array = new int[10] { 2, 4, 8, 1, 0, 5, 9, 20, 45, 100 };
            Sort(array, 5);

            Console.Read();

        }
    }
}
