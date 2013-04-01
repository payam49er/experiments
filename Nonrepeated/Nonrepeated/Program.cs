///<summary>
///Find the first non repeating character in a string
///</summary>
///

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonrepeated
{
    class Program
    {
        public class Word
        {
            char c {get; set;}
            public  char FindNonRepeated(string word)
            {
                Hashtable chartable = new Hashtable();
                
                char c;
                //building the hashtable
                for (int i = 0; i < word.Length; i++)
                {
                    c = word[i];
                    if (chartable.ContainsKey(c))
                    {
                        //increment count corresponding to the c
                        chartable.Add(c,(int)chartable[c] + 1);
                    }
                        else
                        {
                            chartable.Add(c,1);
                        }
                }
                //search hash table
                for(int i = 0; i < word.Length ; i++)
                {
                    char item ;
                    item = word[i];
                    if((int)chartable[item] == 1)
                    {
                        this.c= item;
                    }
                }

               return this.c;
              
            }

            

        }
    



        static void Main(string[] args)
        {
            Console.WriteLine("Please insert your word");
            string input = Console.ReadLine();
            Word testword = new Word();
            char output = testword.FindNonRepeated(input);

            Console.WriteLine("This is your first unrepeated character:{0}", output);

            Console.Read();
        }
    }
}
