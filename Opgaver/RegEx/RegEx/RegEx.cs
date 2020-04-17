using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegEx
{
    public class RegEx
    {
        /// <summary>
        /// Any corn but acorns!
        /// </summary>
        public static Regex reg1 = new Regex(@"[^Aa]corn");
        /// <summary>
        /// mr or mrs. x 
        /// </summary>
        public static Regex reg2 = new Regex(@"M(r|s|rs)\.?\s[a-zA-Z]\w*");
        /// <summary>
        /// Is it a valid email?
        /// </summary>
        public static Regex reg3 = new Regex(@"\w*@\b(hotmail|gmail)\.\b(com|dk)");
        /// <summary>
        /// is it in [brackets]?
        /// </summary>
        public static Regex reg4 = new Regex(@"\[\w*\]");
        /// <summary>
        /// Is it a valid password?
        /// </summary>
        public static Regex reg5 = new Regex(@"[A-Z]\w*[0-9]");
        /// <summary>
        /// Edabit opg: Valid Zip Code (regex edition)
        /// </summary>
        public static Regex reg6 = new Regex(@"\b\d{5}\b");
        /// <summary>
        /// Find NON prime numbers
        /// <para>Input is in unary form. 1 is 1, 2 is 11, 3 is 111, etc. Zero is an empty string.</para>
        /// <para>The first part of the regex matches 0 and 1 as non-prime.The second is where the magic kicks in.</para>
        /// <para>(11+?) starts by finding divisors.It starts by being defined as 11, or 2. \1 is a variable referring to that previously captured match, so \1+ determines if the number is divisible by that divisor. (111111 starts by assigning the variable to 11, and then determines that the remaining 1111 is 11 repeated, so 6 is divisible by 2.)</para>
        /// <para>If the number is not divisible by two, the regex engine increments the divisor. (11+?) becomes 111, and we try again.If at any point the regex matches, the number has a divisor that yields no remainder, and so the number cannot be prime.</para>
        /// </summary>
        public static Regex reg7 = new Regex(@"^1?$|^(11+?)\1+$");
        
        
    }
}
