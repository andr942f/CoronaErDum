using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Opgaver
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
        public bool SameCase(string str) => str == str.ToUpper() || str == str.ToLower() ? true : false;
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
        /// <summary> Valid Zip Code
        /// <para>Zip codes consist of 5 consecutive digits. Given a string, write a function to determine whether the input is a valid zip code. A valid zip code is as follows:</para>
        /// <para>* Must only contain numbers (no non-digits allowed).</para>
        /// <para>* Must not contain any spaces.</para>
        /// <para>* Must not be greater than 5 digits in length.</para>
        /// </summary>
        public bool IsValid(string zip) => (Int32.TryParse(zip, out int result) && zip.Length == 5);
        /// <summary> Cumulative Array Sum
        /// <para>Create a function that takes an array of numbers and returns an array where each number is the sum of itself + all previous numbers in the array.</para>
        /// </summary>
        public double sum = 0;
        public double[] CumulativeSum(double[] arr) => arr.Select(i => { sum += i; return sum; }).ToArray();
        /// <summary> Largest Swap
        /// <para>Create a function that takes a two-digit number and determines if it's the largest of two possible digit swaps.</para>
        /// </summary>
        public bool LargestSwap(int num) => (num / 10) >= num % 10;
        /// <summary> Repeating Letters N Times
        /// <para>Create a function that repeats each character in a string n times.</para>
        /// </summary>
        public string Repeat(string str, int num)
        {
            string empty = string.Empty;
            for (int x = 0; x < num; x++)
                 empty += new string(str[x], num);
            return empty;
        }
        /// <summary> Equality of 3 Values
        /// <para>Create a function that takes three integer arguments (a, b, c) and returns the number of equal values.</para>
        /// </summary>
        public int Equal(int a, int b, int c) => (a==b && b==c) ? 3 : (a!=b && b!=c && a!=c) ? 0 : 2;
        /// <summary> Remove Every Vowel from a String
        /// <para>Create a function that takes a string and returns a new string with all vowels removed.</para>
        /// <para>!Unlocked through solutions!</para>
        /// </summary>
        public string RemoveVowels(string str) => new Regex(@"[aeiouAEIOU]").Replace(str, "");
        /// <summary> Find the Largest Numbers in a Group of Arrays
        /// <para>Create a function that takes an array of arrays with numbers. Return a new (single) array with the largest numbers of each.</para>
        /// </summary>
        public double[] FindLargest(double[][] values) => values.Select(num => num.Max()).ToArray();
        /// <summary> Retrieve the Subreddit
        /// <para>Create a function to extract the name of the subreddit from its URL.</para>
        /// </summary>
        public string SubReddit(string link) => link.Replace("https://www.reddit.com/r/", "").Trim('/');
        /// <summary> Return the Index of All Capital Letters
        /// <para>Create a function that takes a single string as argument and returns an ordered array containing the indices of all capital letters in the string.</para>
        /// </summary>
        public int[] IndexOfCapitals(string str) => str.Select((x, y) => y).Where(z => char.IsUpper(str[z])).ToArray();
        /// <summary> Reverse the Case
        /// <para>Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.</para>
        /// </summary>
        public string ReverseCase(string str) => new string(str.Select(@char => char.IsLetter(@char) ? (char.IsUpper(@char) ? char.ToLower(@char) : char.ToUpper(@char)) : @char).ToArray());
        /// <summary> Is the Word an Isogram?
        /// <para>An isogram is a word that has no repeating letters, consecutive or nonconsecutive. Create a function that takes a string and returns either true or false depending on whether or not it's an "isogram".</para>
        /// </summary>
        public bool IsIsogram(string str)
        {
            Array.Sort(str.ToLower().ToCharArray());
            for (int i = 0; i < str.Length - 1; i++)
                return (str.ToLower().ToCharArray()[i] == str.ToLower().ToCharArray()[i + 1]) ? false : true;
            return true;
        }
        /// <summary> Check if a String Contains only Identical Characters
        /// <para>Write a function that returns true if all characters in a string are identical and false otherwise.</para>
        /// </summary>
        public bool isIdentical(string str) => str.ToCharArray().Distinct().Count() == 1 ? true : false;
        /// <summary> Reverse the string
        /// <para></para>
        /// </summary>
        public string Reverse(string str) => string.Concat(str.Reverse());
        /// <summary> Palindrome num
        /// <para>return true if the num is the same when reversed</para>
        /// </summary>
        public bool IsPalindrome(int num) => num.ToString() == string.Concat(num.ToString().Reverse()) ? true : false;
        /// <summary> Palindrome str
        /// <para>return true if the string is the same when reversed</para>
        /// </summary>
        public bool CheckPalindrome(string str) => str == string.Concat(str.Reverse()) ? true : false;
    }
}


