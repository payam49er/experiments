///<summary>
///use recursion to print characters of a word in reverse order
///</summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWord
{
    class Program
    {
        public static string Reverse(string word)
        {
            if (word.Length == 1)
                return word;
            if (word == null)
                return null;
            else
            {
                return Reverse(word.Substring(1, word.Length - 1))+word.Substring(0,1);

            }
        }


        public static char[] Reversebystack(string word)
        {
            char[] wordarray = word.ToArray();
            char[] finalarray = new char[wordarray.Length];
            int top = wordarray.Length;
            for (int i = 0; i < wordarray.Length; i++)
            {
                finalarray[i] = wordarray[--top];
            }
           
            return finalarray;
        }


        public static void SimpleReverse(string word)
        {
            char[] wordarray = word.ToArray();
            int top = wordarray.Length;
            foreach (char item in wordarray)
            {
                Console.Write(wordarray[--top]);
            }
            
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a word:");
            string word = Console.ReadLine();
            string output = Reverse(word);
            Console.WriteLine(output);

            char[] output2 = Reversebystack(word);
            foreach (char item in output2)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Console.WriteLine("The simple method:");
            SimpleReverse(word);


            Console.ReadLine();
        }
    }
}
