///<summary>
///working with binary tree
///</summary>
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        //creating the node class, where we store the keys

        public class Node
        {
            public int iData;  // data used as a key
            public double fData; //other data
            public Node leftChild;
            public Node rightChild; 
        }//end of class Node

        public class Tree
        {
            private Node root;   // the only data member for a Tree class

            // method to find a key in the tree
            public Node find(int key)
            {
                Node current = root; //start at root
                while (current.iData !=key)  //while no match
                {
                    if (key < current.iData)
                        current = current.leftChild;
                    else if (key > current.iData)
                        current = current.rightChild;
                    else if (key == null)
                         return null;    // did not find it 
                }

                return current;   //found it
            }

            public void insert(int id, double data)
            {
                Node newnode = new Node(); // creating a new node
                newnode.iData = id;
                newnode.fData = data;

                if (root == null)
                    root = newnode;
                else
                {
                    Node current = root;
                    Node parent;
                    while (true)
                    {
                        parent = current;

                        if (id < current.iData)  // go left
                        {
                            current = current.leftChild;
                            if (current == null)
                            {
                                parent.leftChild = newnode;
                                return;
                            }
                        } // end of the the left hand
                        else
                        {
                            current = current.rightChild;
                            if (current == null)
                            {
                                parent.rightChild = newnode;
                                return;
                            } // end of right hand
                        }
                    } // end of while

                }
            }    
               

            public void delete(int id)
            {
            }


        }// end of class tree


        static void Main(string[] args)
        {
        }
    }
}
