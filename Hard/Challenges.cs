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
    }
}
