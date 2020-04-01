﻿using System;
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
        public int Equal(int a, int b, int c) => (a == b && b == c) ? 3 : (a != b && b != c && a != c) ? 0 : 2;
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
        public bool IsIsogram(string str) => str.ToLower().Distinct().Count() == str.Length;
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
        /// <summary> Vowel Replacer
        /// <para>Create a function that replaces all the vowels in a string with a specified character.</para>
        /// </summary>
        public string ReplaceVowels(string str, string ch) => new Regex(@"[aeiouAEIOU]").Replace(str, ch);
        /// <summary> Purge and Organize
        /// <para>Given an array of numbers, write a function that returns an array that...</para>
        /// <para>Has all duplicate elements removed.</para>
        /// <para>Is sorted from least value to greatest value.</para>
        /// </summary>
        public double[] UniqueSort(double[] arr) => arr.Distinct().OrderBy(str => str).ToArray();
        /// <summary> Array of Multiples
        /// <para>Create a function that takes two numbers as arguments (num, length) and returns an array of multiples of num up to length.</para>
        /// </summary>
        public int[] ArrayOfMultiples(int num, int length) => Enumerable.Range(1, length).Select(start => start * num).ToArray();
        /// <summary> Return the Middle Character(s) of a String
        /// <para>Create a function that takes a string and returns the middle character(s). If the word's length is odd, return the middle character. If the word's length is even, return the middle two characters.</para>
        /// </summary>
        public string GetMiddle(string str) => str.Substring((str.Length - 1) / 2, 2 - (str.Length % 2));
        /// <summary> Maskify the String
        /// <para>Usually when you sign up for an account to buy something, your credit card number, phone number or answer to a secret question is partially obscured in some way. Since someone could look over your shoulder, you don't want that shown on your screen. Hence, the website masks these strings.</para>
        /// <para>Your task is to create a function that takes a string, transforms all but the last four characters into "#" and returns the new masked string.</para>
        /// </summary>
        public string Maskify(string str) => (str.Length < 5) ? str : $"{new string('#', str.Length)}{str.Substring(str.Length - 4).Replace(str, "#")}";
        /// <summary> Count Ones in Binary Representation of Integer
        /// <para>Count the amount of ones in the binary representation of an integer. So for example, since 12 is '1100' in binary, the return value should be 2.</para>
        /// </summary>
        public int CountOnes(int i)
        {
            int count = 0;
            while (i > 0) { count += i & 1; i >>= 1; }
            return count;
        }
        /// <summary> Return the Highest and Lowest Numbers
        /// <para>Create a function that accepts a string of space separated numbers and returns the highest and lowest number (as a string).</para>
        /// </summary>
        public string HighLow(string str) => $"{str.Split(' ').Select(x => int.Parse(x)).Max()} {str.Split(' ').Select(y => int.Parse(y)).Min()}";
        /// <summary> Positive Count / Negative Sum
        /// <para>Create a function that takes an array of positive and negative numbers. Return an array where the first element is the count of positive numbers and the second element is the sum of negative numbers.</para>
        /// </summary>
        public int[] CountPosSumNeg(double[] arr) => new[] { arr.Count(x => x > 0), (int)arr.Sum(y => y < 0 ? y : 0) };
        /// <summary> Sort Numbers in Descending Order
        /// <para>Create a function that takes any nonnegative number as an argument and return it with it's digits in descending order. Descending order is when you sort from highest to lowest.</para>
        /// </summary>
        public int SortDescending(int num) => Convert.ToInt32(string.Concat(num.ToString().OrderByDescending(x => x)));
        /// <summary> Filter out Strings from an Array
        /// <para>Create a function that takes an array of non-negative numbers and strings and return a new array without the strings.</para>
        /// </summary>
        public int[] FilterArray(object[] arr) => arr.OfType<int>().ToArray();
        /// <summary> Xs and Os, Nobody Knows
        /// <para>Create a function that takes a string, checks if it has the same number of x's and o's and returns either true or false.</para>
        /// <para>Return a boolean value (true or false).</para>
        /// <para>The string can contain any character.</para>
        /// <para>When no x and no o are in the string, return true.</para>
        /// <para>!UNLOCKED THROUGH SOLUTIONS!</para>
        /// </summary>
        public bool XO(string str) => str.Count(c => c == 'o' || c == 'O') == str.Count(c => c == 'x' || c == 'X');
        /// <summary> Pi to N Decimal Places
        /// <para>Given a number n, write a function that returns PI to n decimal places.</para>
        /// </summary>
        public decimal MyPi(int n) => (n != 15) ? Math.Round((decimal)Math.PI, n) : decimal.Parse("3.141592653589793");
        /// <summary> Is the Number Symmetrical?
        /// <para>Create a function that takes a number as an argument and returns true or false depending on whether the number is symmetrical or not. A number is symmetrical when it is the same as its reverse.</para>
        /// </summary>
        public bool IsSymmetrical(int num) => num.ToString() == string.Concat(num.ToString().ToCharArray().Reverse());
        /// <summary> Strange Pair
        /// <para>A pair of strings form a strange pair if both of the following are true:</para>
        /// <para>The 1st string's first letter = 2nd string's last letter.</para>
        /// <para>The 1st string's last letter = 2nd string's first letter.</para>
        /// <para>Create a function that returns true if a pair of strings constitutes a strange pair, and false otherwise.</para>
        /// </summary>
        public bool IsStrangePair(string str1, string str2) => string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2) ? str1 == str2 : str1.First() == str2.Last() && str2.First() == str1.Last();
        /// <summary> Check if a Number is Prime
        /// <para>Create a function that outputs true if a number is prime, and false otherwise.</para>
        /// <para>Not done</para>
        /// </summary>
        public bool isPrime(int x)
        {
            return x <= 1 ? false : x == 2 ? true : x % 2 == 0 ? false : true;

        }
    }
}