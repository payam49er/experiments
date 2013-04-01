///<summary>
///This is a demo for how Queue data structure works
///</summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDemo
{
    class Program
    {
        class QueueDemo
        {
            private int maxsize;
            private int[] quearray;
            private int front;
            private int rear;
            private int nItem;

            //constructor
            public QueueDemo(int size)
            {
                maxsize = size;
                quearray = new int[maxsize];
                front = 0;
                rear = 0;
                nItem = 0; //nothing in the queue yet
            }
            
            //methods for the Queue
            public void Insert(int number)
            {
                //deal with wrap around
                if (rear == maxsize)
                    rear = 0;
                quearray[rear++] = number;
                nItem++; //one more item in the queue
            }

            public int Remove()
            {
                int temp = quearray[front++];
                if (front == maxsize)
                    front = 0;
                nItem--; // one less item
                return temp;

            }

        }



        static void Main(string[] args)
        {
            QueueDemo myque = new QueueDemo(5);
            myque.Insert(3);
            myque.Insert(4);
            myque.Insert(5);
            myque.Insert(6);
            int rem1 = myque.Remove(); // we should expect 3 to come out. 
            int rem2 = myque.Remove();
            int rem3 = myque.Remove();

            myque.Insert(7);
            myque.Insert(8);
            myque.Insert(9);
            myque.Insert(10);

            int rem4 = myque.Remove();
            int rem5 = myque.Remove();
            int rem6 = myque.Remove();
            int rem7 = myque.Remove();
            int rem8 = myque.Remove();

            Console.WriteLine("The out value is {0} and then {1} and finally {2}", rem1,rem2,rem3);
            Console.WriteLine("The out values after wrap around are : {0},{1},{2},{3},{4}", rem4,rem5, rem6, rem7,rem8);

            Console.Read();

        }
    }
}
