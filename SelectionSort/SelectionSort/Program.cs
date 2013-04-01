///<summary>
///The goal of this code is to demonstrate different sorting Algorithms in C#, the efficency is of O(n^2), and n(log n)
///</summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {

        public class SelectionSort
        {
            //a method to generate random numbers in an array to be used for sorting
            public static int[] GenerateRandom(int initial, int end, int size)
            {
                int[] array = new int[size];
                Random rnd = new Random();
                for (int i = 0; i < size; i++)
                {
                    array[i] = rnd.Next(initial, end);
                }

                return array;
                
            }

            //sorting elements by bubble method with efficiency of O^2
            public static int[] SortByBubble(int[] inputarray)
            {
                bool swap = true;
                int j = 0;
                while (swap)
                {
                    swap = false;
                    j++;
                    for (int i = 0; i < inputarray.Length-j; i++)
                    {
                        if (inputarray[i] > inputarray[i+1])
                        {
                            int temp = inputarray[i];
                            inputarray[i] = inputarray[i+1];
                            inputarray[i+1] = temp;
                            swap = true;
                        }
                    }
                }

                return inputarray;
                
            }

            //sorting elements by selection method
            public static int[] SortBySelection(int[] inputarray)
            {
           
                    
                //find the smallest values in the array after marker
                    for (int i = 0 ; i < inputarray.Length; i++)
                    {
                       
                        for (int j = 0; j < inputarray.Length; j++)
                        {

                            if (inputarray[i] < inputarray[j])// swap the smallest number in the array to the front
                            {
                                int temp = inputarray[j];
                                inputarray[j] = inputarray[i];
                                inputarray[i] = temp;

                            }
                           
                        }
                     
                }
                return inputarray;
            }


        }


        static void Main(string[] args)
        {
            int[] testarray = new int[10];
            testarray = SelectionSort.GenerateRandom(1, 100, 10);

           

            Console.WriteLine("This is the generated unsorted array:");
            foreach (int item in testarray)
            {
                Console.Write(" " + item);
            }

            Console.WriteLine("");
            int[] sortedarray = SelectionSort.SortByBubble(testarray);



            Console.WriteLine("This is the sorted array by bubble method:");

            foreach (int number in sortedarray)
            {
                Console.Write(" " + number);
            }

            Console.WriteLine(" ");

            int[] selectarray = SelectionSort.SortBySelection(testarray);
            Console.WriteLine("Sorted array by Selection method:");
            foreach (int number in selectarray)
            {
                Console.Write(" " + number);
            }

         
            Console.ReadLine();

        }
    }
}
