using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeryEasy
{
    internal static class Challenges
    {
        /*
        * Create a function that takes two numbers as arguments and returns their sum.
        * https://edabit.com/challenge/xfRucdwGksiyjZq4K
        */
        public static int ReturntheSumofTwoNumbers(int num1, int num2) => num1 + num2;

        /*
        * Write a function that takes an integer minutes and converts it to seconds.
        * https://edabit.com/challenge/bizjGL4wyd8PwR4Ke
        */
        public static int ConvertMinutesintoSeconds(int min) => min * 60;

        /*
        * Create a function that takes a number as an argument, increments the number by +1 and returns the result.
        * https://edabit.com/challenge/RzkLShpDgDqG3c45H
        */
        public static int ReturntheNextNumberfromtheIntegerPassed(int num) => num + 1;

        /*
        * Create a function that takes voltage and current and returns the calculated power.
        * https://edabit.com/challenge/L2fwjYi9YixY8kJfK
        */
        public static int PowerCalculator(int voltage, int current) => voltage * current;

        /*
        * Create a function that takes the age in years and returns the age in days.
        * https://edabit.com/challenge/nkkKguC5TgWnBiMLA
        */
        public static int ConvertAgeToDays(int age) => age * 360;



    }
}
