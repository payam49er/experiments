///<summary>
///This code accept any size string and place it in the dynamically managed array 
///</summary>


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    class Program
    {
        public static char[] AcceptString(string word)
        {
            char[] original = new char[10]; // intentionally setting the size of the array to 10. 
            if (word.Length > original.Length)
            {
                char[] newarray = new char[word.Length];
                for (int i = 0; i < word.Length; i++)
                {
                    newarray[i] = word[i];
                }

                return newarray;
            }
            else
            {
              
                for (int j = 0; j < 10; j++)
                {
                    original[j] = word[j];
                }
            }
            return original;

           
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Please write something:");
            string input = Console.ReadLine();

            char[] output = AcceptString(input);
            Console.WriteLine("Your output is:");
            foreach (char item in output)
            {
                Console.Write(item);
            }
            Console.ReadLine();


        }
    }
}
