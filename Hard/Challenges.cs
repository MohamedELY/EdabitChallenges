using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hard
{
    internal class Challenges
    {
        /*
        * Write a function that takes an integer i and returns a string with the integer backwards
        * followed by the original integer.
        * We reverse "123" to get "321" and then add "123" to the end, resulting in "321123".
        * Bonus: By using System.Linq this should be completed in one line of code.
        * https://edabit.com/challenge/YGhgctqPsKQxQQCFS
        */
        public static string ReverseAndNot(int input) => String.Concat(input.ToString().Reverse()) + input.ToString();

        /*
        * Create a function that takes an array of numbers and return "Boom!" if the digit 7 appears in the array.
        * Otherwise, return "there is no 7 in the array".
        * https://edabit.com/challenge/6R6gReGTGwzpwuffD
        */
        public static string sevenBoom(int[] input)
        {
            foreach (int num in input)
                if (num == 7)
                    return "Boom!";
            return "there is no 7 in the array";
        }

        /*
        * Create a function that determines whether a number is Oddish or Evenish. 
        * A number is Oddish if the sum of all of its digits is odd, and a number is Evenish if the sum of all of its digits is even. 
        * If a number is Oddish, return "Oddish". Otherwise, return "Evenish".
        * https://edabit.com/challenge/6R6gReGTGwzpwuffD
        */
        public static string oddishOrEvenish(int numbers)
        {
            string numbersString = numbers.ToString();
            int total = 0;

            foreach (char num in numbersString)
            {
                total += Convert.ToInt32(num);
            }

            if (total % 2 == 0)
            {
                return "Evenish";
            }
            else
            {
                return "Oddish";
            }
                
        }
    }
}
