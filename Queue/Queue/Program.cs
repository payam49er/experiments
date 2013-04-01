using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        class Queue
        {
            private int maxSize;
            private long[] queueArray;
            private int frontIndex;
            private int rearIndex;
            private int nItem;
        

        //constructor of the class
            public Queue(int max)
            {
                maxSize = max;
                queueArray = new long[maxSize];
                frontIndex = 0;
                rearIndex = -1;
                nItem = 0;
            }

            // method to insert a number in to the Queue 
            public void insert(long item)
            {
                if(rearIndex == maxSize-1)
                    rearIndex = -1;
                queueArray[++rearIndex] = item;
                nItem++;
            }








        static void Main(string[] args)
        {
        }
    }
}
