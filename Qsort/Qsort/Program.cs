///<summary>
///This is an implementation of Quick Sort
///</summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qsort
{
    class Program
    {
        class StackDemo
        {

            private int maxsize;
            private int[] stackarray;
            private int top;

            public StackDemo(int size) //constructor
            {
                maxsize = size;
                stackarray = new int[maxsize];
                top = 0; //no item in there yet
            }


            //methods of this class
            public void Push(int number)
            {
                stackarray[top++] = number;
            }

            public void Pop()
            {
                Console.WriteLine(stackarray[--top]);
            }

        }



        static void Main(string[] args)
        {

            StackDemo sDemo = new StackDemo(3);
            sDemo.Push(5);
            sDemo.Push(7);
            sDemo.Pop();
            sDemo.Pop();

            Console.Read();

        }
    }
}
