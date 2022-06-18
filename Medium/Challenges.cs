using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium
{
    internal static class Challenges
    {
        /*
        * Create a function that takes two numbers as arguments (num, length) 
        * and returns an array of multiples of num until the array length reaches length.
        * https://edabit.com/challenge/2QvnWexKoLfcJkSsc
        */
        public static int[] ArrayOfMultiples(int num, int lenght)
        {
            int[] array = new int[lenght];

            for (int i = 0; i < lenght; i++)
                array[i] = num * (i + 1);
            
            return array;
        }

        /*
        * Given a string, create a function to reverse the case. 
        * All lower-cased letters should be upper-cased, and vice versa.
        * https://edabit.com/challenge/99oN5igrbXddAjHEL
        */
        public static string ReverseTheCase(string word)
        {
            char[] chars = new char[word.Length];
           
            for (int i = 0; i < word.Length; i++)
                chars[i] = ( char.IsUpper(word[i]) ? char.ToLower(word[i]) : char.ToUpper(word[i]) );

            return new string(chars);
        }

        /*
        * Create a function that takes a single string as argument and 
        * returns an ordered array containing the indices of all capital letters in the string.
        * https://edabit.com/challenge/6qFnpAhd3kdmYcNG2
        */
        public static int[] ReturnTheIndexOfAllCapitalLetters(string word)
        {
            int index = 0;
            int[] capitalLetterIndex = new int[word.Length];

            for(int i = 0; i < word.Length; i++)
                if (char.IsUpper(word[i]))
                    capitalLetterIndex[index++] = i;

            return capitalLetterIndex;
        }
    }
}
