using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {

        public class Anagram
        {
            
          
            
            
            public static void DoAnagram(int size)
            {
                
                //define my recursion for the angram of the word
                if (size == 1)
                {
                    return;
                }
                for (int i = 0; i < size; i++)
                {
                    DoAnagram(size - 1);
                    if (size == 2)
                        DisplayWord();
                    Rotate(size);
                }

                
            }

            public static void Rotate(int size)
            {
                //Rotate method goes here

            }

            public static void DisplayWord()
            {
                //DisplayWord method goes here
            }
                  
        }


        static void Main(string[] args)
        {
             Console.WriteLine("Please insert a word:");
             string userInput = Console.ReadLine();
             char[] userWord = new char[userInput.Length];
             userWord = userInput.ToArray();
              
             Anagram.DoAnagram(userWord.Length);
           


            Console.ReadLine();

        }
    }
}
