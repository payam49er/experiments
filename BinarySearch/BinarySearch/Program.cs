///<summary>
///just an experiment and work with binary search
///</summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        public class OrderedArray
        {
            private int[] array;
            private int nElements;

            //constructor
            public OrderedArray(int Max)
            {
                array = new int[Max];
                nElements = 0;
            }

            //method size
            public int Size()
            {
                return nElements;
            }

            //method find
            public int Find(int key)
            {
                return Find(key, 0, nElements - 1);
            }

            //inserting integer values in to the array
            public void insert(int number)
            {
                nElements++;
                array[nElements - 1] = number;
                for(int outer = nElements-1 ; outer > 1 ; outer--)
                {
                    for (int inner = 0; inner < outer; inner++)
                    {
                        if (array[inner] > array[inner + 1])
                        {
                            int temp = array[inner];
                            array[inner] = array[inner + 1];
                            array[inner + 1] = temp;
                        }
                    }
                }
        
            }


            private int Find(int searchkey, int lowerbound, int higherbound)
            {
                
                int CurIndex = (lowerbound + higherbound) / 2;

                if (array[CurIndex] == searchkey)   //we are lucky and the element is in the middle of the array
                    return CurIndex;
                else if (lowerbound > higherbound) // it can not find the element
                    return -1;
                else
                {
                    if (array[CurIndex] < searchkey)
                        return Find(searchkey, CurIndex + 1, higherbound);
                    else
                        return Find(searchkey, lowerbound, CurIndex - 1);
                }
               
            }//end of Find

            public void Display()
            {
                for (int i = 0; i < nElements ; i++)
                {
                    Console.Write(array[i]);
                    Console.Write(" ");
                }
            }

        }
        static void Main(string[] args)
        {

            OrderedArray testArray = new OrderedArray(10);

            testArray.insert(1);
            testArray.insert(3);
            testArray.insert(2);
            testArray.insert(30);
            testArray.insert(15);
            testArray.insert(12);
            testArray.insert(-4);
            testArray.insert(-5);
            Console.WriteLine("Please insert a value that you are looking for to get its index back:");
            int userindex = Convert.ToInt32(Console.ReadLine());
            int value = testArray.Find(userindex);
            if (value == -1)
                Console.WriteLine("Your value does not exist in the array");
            else
                Console.WriteLine("This is the index for {0}: {1}", userindex ,value);

            testArray.Display();
           
            Console.Read();


        }
    }
}
