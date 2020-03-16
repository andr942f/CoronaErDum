using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edabit
{
    class Very_easy
    {
        /// <summary> Return the Sum of Two Numbers
        /// <para>Create a function that takes two numbers as arguments and 'return' their sum.</para>
        /// </summary>
        public int Sum(int a, int b) => a + b;
        /// <summary> Check if the Same Case
        /// <para>Create a function that returns 'true' if an input string contains only uppercase or only lowercase letters.</para>
        /// </summary>
        public bool SameCase(string str)
        {
            if (str == str.ToLower() || str == str.ToUpper())
                return true;
            else return false;
        }
        /// <summary> Find the Missing Number
        /// <para>Create a function that takes an array of numbers between 1 and 10 (excluding one number) and returns the missing number.</para>
        /// </summary>
        public static int MissingNum(int[] arr)
        {

        }
    }
}
