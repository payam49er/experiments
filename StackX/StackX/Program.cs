using System;

// this little app demonstrate how stacks work
namespace StackX
{
    class StacksX
    {
        private int maxSize;  // size of the array
        private long[] stackArray;
        private int indexOfItem; // the number of the index of the indexOfItem number

        public StacksX(int s) //constructor 
        {
            maxSize = s;
            stackArray = new long[maxSize];
            indexOfItem = -1;
        }

        //put item on indexOfItem of the stack
        public void push(long number)
        {
            stackArray[++indexOfItem] = number;  //increment the indexOfItem and insert number by assigning 
        }

        //method to pop a number from the stack
        public long pop()
        {
            return stackArray[indexOfItem--]; //pay attention to the decrement here, why I didn't use --indexOfItem ?
        }

        //what is the value at the indexOfItem of the stack

        public long peek()
        {
            return stackArray[indexOfItem];
        }

        //check to see if the stack is empty or not, return True if it is empty
        public bool isEmpty()
        {
            return indexOfItem == -1;
        }

        //check to see if the stack is full

        public bool isFull()
        {
            return indexOfItem == maxSize - 1;
        }

    }// end of class StackX

    class stackApp
    {
        public static void Main()
        {
            // initialized a stackX class with the initial size of 10, it can hold 10 items
            StacksX mystack = new StacksX(10); 

            mystack.push(100);
            mystack.push(105);
            mystack.push(110);
            mystack.push(115);
            while (!mystack.isEmpty())
            {
                long value = mystack.pop();
                Console.WriteLine("The value out is {0}", value);
            }
            Console.ReadLine();
        }

    }
}

    



