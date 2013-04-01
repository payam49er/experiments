///<summary>
///Another solution to heap sort by Recursive calling
///</summary>


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSortRecursive
{
    class Program
    {
        private static void BuildHeap(int[] input, int heapsize, int index)
        {
            int left = (index*2) + 1; //gives index value for the left child
            int right = (index * 2) + 2; // gives index value for the right child
            int largest = 0;

            if (left < heapsize && input[left] > input[index])
            {
                largest = left;
            }
            else
                largest = index;

            if (right < heapsize && input[right] > input[largest])
            {
                largest = right;
            }

            if (largest != index)
            {
                int temp = input[index];
                input[index] = input[largest];
                input[largest] = temp;
                BuildHeap(input, heapsize, largest);
            }
        }


        public static int[] Sort(int[] input)
        {
            //Build Max heap, the highest number is at root
            int heapsize = input.Length;

            for (int i = (heapsize - 1) / 2; i >= 0; i--)
            {
                BuildHeap(input, heapsize, i);
            }

            for (int j = heapsize - 1; j > 0; j--)
            {
                //swap 
                int temp = input[j];
                input[j] = input[0];
                input[0] = temp;
                heapsize--;
                BuildHeap(input, heapsize, 0);
            }

            return input;               

        }


        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbers = new int[7];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(10, 100);
            }

            int[] sortedval = Sort(numbers);

            foreach (int val in sortedval)
            {
                Console.WriteLine(val);
            }

            Console.Read();

        }
    }
}
