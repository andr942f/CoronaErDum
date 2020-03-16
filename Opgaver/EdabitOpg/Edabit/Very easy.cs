using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
        /// <summary> Letters Only
        /// <para>Write a function that removes any non-letters from a string, returning a well-known film title.</para>
        /// </summary>
        public string LettersOnly(string str) => Regex.Replace(str, "[^a-zA-Z]", string.Empty);
        /// <summary> Find the Missing Number
        /// <para>Create a function that takes an array of numbers between 1 and 10 (excluding one number) and returns the missing number.</para>
        /// </summary>
        public int MissingNum(int[] arr) => Enumerable.Range(1, 10).Except(arr).First();
        /// <summary> Case Insensitive Comparison
        /// <para>Write a function that validates whether two strings are identical. Make it case insensitive.</para>
        /// </summary>
        public bool match(string s1, string s2) => (s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
        /// <summary> Return the Four Letter Strings
        /// <para>Create a function that takes an array of strings and returns the words that are exactly four letters.</para>
        /// </summary>
        public string[] IsFourLetters(string[] arr) => arr.Where(length => length.Length == 4).ToArray();
    }
}


