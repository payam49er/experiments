///<summary>
///the purpose of this code is to run experiments with Linked List, doubly Linked List, and circular Linked List
///</summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    class Program
    {
        public class Node
        {
            public object data { get; private set; }
            public Node next { get; set; }

            //consructor of the class
            public Node(object data)
            {
                this.data = data;
            }
        
        }

        public class LinkedList
        {
            Node head;
            Node current;
           //method to add objects to the linkedlist
            public void Add(Node n)
            {

                if (head == null)
                {
                    head = n;
                    current = head;
                }
                else
                {
                    current.next = n;
                    current = current.next;
                }

            }


            public void Display()
            {

                while (head != null)
                {
                    Console.WriteLine(head.data);
                    head = head.next;


                }
            }

        }





        static void Main(string[] args)
        {

            LinkedList List = new LinkedList();
            List.Add(new Node("Payam"));
            List.Add(new Node("Pouria"));
            List.Add(new Node(30));

            List.Display();

            Console.ReadLine();

        }
    }
}
