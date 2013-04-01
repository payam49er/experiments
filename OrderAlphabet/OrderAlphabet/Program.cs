///<summary>
///This code will get a word and place its characters in alphabetical orders
///</summary>
///
///


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAlphabet
{
    class Program
    {

        class Word
        {
            public static int[] OrderCharactersZtoA(string inputword)
            {
                char[] characters = new char[inputword.Length];
                characters = inputword.ToCharArray();
                int[] values = new int[inputword.Length];
                for (int i = 0; i < inputword.Length; i++)
                {
                    values[i] = Convert.ToInt32(characters[i]);
                }
                
                //ordering from Z to A 

                    for (int j = 0; j < values.Length -1 ; j++)
                    {
                        for (int k = 0; k < values.Length - 1; k++)
                        {
                            if (values[j + 1] > values[k])
                            {
                                var temp = values[k];
                                values[k] = values[j + 1];
                                values[j + 1] = temp;
                            }
                        }
                    }
                
                return values;
             
            }

            public static int[] OrderCharactersAtoZ(string inputword)
            {
                char[] characters = new char[inputword.Length];
                characters = inputword.ToCharArray();
                int[] values = new int[inputword.Length];
                for (int i = 0; i < inputword.Length; i++)
                {
                    values[i] = Convert.ToInt32(characters[i]);
                }

                //ordering from A to Z 

                for (int j = 0; j < values.Length - 1; j++)
                {
                    for (int k = 0; k < values.Length - 1; k++)
                    {
                        if (values[j + 1] < values[k])
                        {
                            var temp = values[k];
                            values[k] = values[j + 1];
                            values[j + 1] = temp;
                        }
                    }
                }

                return values;

            }


        }


        static void Main(string[] args)
        {
            Console.WriteLine("Please insert your word here:");
            string input = Console.ReadLine();
            var output = Word.OrderCharactersAtoZ(input);
            Console.WriteLine("Here is your ordered word:");
            for (int i = 0; i < output.Length; i++)
            {
                Console.Write(Convert.ToChar(output[i]));
            }
            Console.ReadKey();

        }
    }
}
