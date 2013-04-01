///<summary>
///just a demonstration of priority queue
///</summary>
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQue
{
    class Program
    {

        class PriorityQ
        {
            private int maxsize;
            private int[] qarray;
            private int nItems;

            public PriorityQ(int size)
            {
                maxsize = size;
                qarray = new int[maxsize];
                nItems = 0; // no item in the queue yet
            }

            //method to insert in the Queue
            public void Insert(int number)
            {
                int j;
                if (nItems == 0)
                {
                    qarray[nItems++] = number;
                    
                }
                else
                {
                    for (j = nItems-1; j >= 0 ; j-- )
                    {
                        if (number < qarray[j])
              
                            qarray[j + 1] = qarray[j];
                
                        else
                            break;
                    }

                    qarray[j+1] = number;
                    nItems++;
                }

            }

            public int Remove()
            {
                return qarray[--nItems];
            }

        }




        static void Main(string[] args)
        {
            PriorityQ mypQ = new PriorityQ(4);

            mypQ.Insert(2);
            mypQ.Insert(6);
            mypQ.Insert(5);

            int rem1 = mypQ.Remove();
            int rem2 = mypQ.Remove();
            int rem3 = mypQ.Remove();

            Console.WriteLine("Values out from PQ are: {0},{1},{2}", rem1, rem2, rem3);

            Console.Read();


        }
    }
}
