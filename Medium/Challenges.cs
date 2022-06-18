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

        /*
        * Create a function which returns the number of true values there are in an array.
        * Return 0 if given an empty array.
        * All array items are of the type bool (true or false).
        * https://edabit.com/challenge/GLbuMfTtDWwDv2F73
        */
        public static int CountTrue(params bool[] input)
        {
            int trueCounter = 0;
            foreach (bool value in input)
                if (value == true)
                    trueCounter++;
            
            return trueCounter;
        }

        /*
        * Create a function that finds the word "bomb" in the given string (not case sensitive). If
        * found, return "Duck!!!", otherwise, return "There is no bomb, relax."
        * https://edabit.com/challenge/JYEufqRvkusjr5R58
        */
        public static string Bomb(string input) => input.ToLower().Contains("bomb") ? "Duck!!!" : "There is no bomb, relax.";

    }
}
