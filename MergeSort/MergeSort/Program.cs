///<summary>
///this is a code to read an input file, and place the data in an array that we do not know of its size yet
///then the code has to sort the data (all numbers) by merging sort algorithm and counting the number of inversions
///</summary>
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace MergeSort
{
    class Program
    {
        public class Mergebysort
        {
            public int counter { get; set; }
            private int[] theArray { get; set; }

            //let's read the lines of a text file and place the numbers in to an array
            public int[] ReadFile(string path)
            {
                int counter = 0;
                int[] numberarray = new int[100000]; // we knew that there are 100,000 numbers 
                var lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    numberarray[counter++] = Convert.ToInt32(line);
                }

                return numberarray;
            }

            //method to be called by main method
            public int[] Sortingbymerge(int[] unsortedarray)
            {
                int[] workspace = new int[unsortedarray.Length];
                theArray = unsortedarray;
                recMergesort(workspace, 0, unsortedarray.Length-1);
                return theArray;
            }

            private void recMergesort(int[] workspace, int lowerbound, int upperbound)
            {
                //define the basic case
                if (lowerbound == upperbound) // there is only one element and you don't sort it
                    return;
                else
                {
                    int mid = (upperbound + lowerbound) / 2;
                    recMergesort(workspace, lowerbound, mid);//sort lower half
                    recMergesort(workspace, mid + 1, upperbound);  // sort upperhalf
                         
                    Merge(workspace, lowerbound, mid + 1, upperbound); //merge them
                }
            }

            //method to merge the sorted arrays
            private void Merge(int[] workspace, int lowpoint, int highpoint, int upperbound)
            {
                this.counter = 0;
                int j = 0;
                int lowerBound = lowpoint;
                int mid = highpoint - 1;
                int n = (upperbound - lowpoint)+1; // number of elements

                while (lowpoint <= mid && highpoint <= upperbound)
                {
                    if (theArray[lowpoint] < theArray[highpoint])
                    {
                        workspace[j++] = theArray[lowpoint++];
                        this.counter++;
                    }
                    else
                    {
                        workspace[j++] = theArray[highpoint++];
                        this.counter++;
                    }
                }

                while (lowpoint <= mid)
                {
                    workspace[j++] = theArray[lowpoint++];
                }
                while (highpoint <= upperbound)
                {
                    workspace[j++] = theArray[highpoint++];
                }

                for (j = 0; j < n; j++)
                {
                    theArray[lowerBound + j] = workspace[j];
                }
            }




        }


        static void Main(string[] args)
        {
            string filepath = @"E:\Csharp\MergeSort\input.txt";
            Mergebysort sorting = new Mergebysort();
            int[] unsortednumbers = sorting.ReadFile(filepath);
             var f= Stopwatch.StartNew();
            int[] sortednumbers = sorting.Sortingbymerge(unsortednumbers);
            string path = @"E:\Csharp\MergeSort\output.txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                for (int i = 0; i < sortednumbers.Length; i++)
                {
                    sw.WriteLine(sortednumbers[i]);
                }
             sw.Close();
            }
            Console.WriteLine("the operation is finished in {0} milisecond", f.ElapsedMilliseconds);
            Console.WriteLine("The operation needed {0} swaps", sorting.counter);
            Console.Read();

        }
    }
}
