using System.Text.RegularExpressions;

namespace RegEx
{
    public class RegEx
    {
        /// <summary>
        /// Any corn but acorns!
        /// </summary>
        public static Regex reg0 = new Regex(@"[^Aa]corn");
        /// <summary>
        /// mr or mrs. x 
        /// </summary>
        public static Regex reg1 = new Regex(@"M(r|s|rs)\.?\s[a-zA-Z]\w*");
        /// <summary>
        /// Is it a valid email?
        /// </summary>
        public static Regex reg2 = new Regex(@"\w*@\b(hotmail|gmail)\.\b(com|dk)");
        /// <summary>
        /// is it in [brackets]?
        /// </summary>
        public static Regex reg3 = new Regex(@"\[\w*\]");
        /// <summary>
        /// Is it a valid password?
        /// </summary>
        public static Regex reg4 = new Regex(@"[A-Z]\w*[0-9]");
        /// <summary>
        /// Edabit opg: Valid Zip Code (regex edition)
        /// </summary>
        public static Regex reg5 = new Regex(@"\b\d{5}\b");
        /// <summary>
        /// Find NON prime numbers
        /// <para>Input is in unary form. 1 is 1, 2 is 11, 3 is 111, etc. Zero is an empty string.</para>
        /// <para>The first part of the regex matches 0 and 1 as non-prime.The second is where the magic kicks in.</para>
        /// <para>(11+?) starts by finding divisors.It starts by being defined as 11, or 2. \1 is a variable referring to that previously captured match, so \1+ determines if the number is divisible by that divisor. (111111 starts by assigning the variable to 11, and then determines that the remaining 1111 is 11 repeated, so 6 is divisible by 2.)</para>
        /// <para>If the number is not divisible by two, the regex engine increments the divisor. (11+?) becomes 111, and we try again.If at any point the regex matches, the number has a divisor that yields no remainder, and so the number cannot be prime.</para>
        /// </summary>
        public static Regex reg6 = new Regex(@"^1?$|^(11+?)\1+$");

        //RegexOne opgaver
            /// <summary>
            /// Lesson 1: An Introduction, and the ABCs
            /// </summary>
            public static Regex reg7 = new Regex(@"[a-z]");
            /// <summary>
            /// Lesson 1½: The 123s
            /// </summary>
            public static Regex reg8 = new Regex(@"\d");
            /// <summary>
            /// Lesson 2: The Dot
            /// </summary>
            public static Regex reg9 = new Regex(@"\.");
            /// <summary>
            /// Lesson 3: Matching specific characters
            /// </summary>
            public static Regex reg10 = new Regex(@"[^drp]an");
            /// <summary>
            /// Lesson 4: Excluding specific characters
            /// </summary>
            public static Regex reg11 = new Regex(@"[^b]og");
            /// <summary>
            /// Lesson 5: Character ranges
            /// </summary>
            public static Regex reg12 = new Regex(@"[A-Z]");
            /// <summary>
            /// Lesson 6: Catching some zzz's
            /// </summary>
            public static Regex reg13 = new Regex(@"wa{3,11}up");
            /// <summary>
            /// Lesson 7: Mr. Kleene, Mr. Kleene
            /// </summary>
            public static Regex reg14 = new Regex(@"a+b*c+");
            /// <summary>
            /// Lesson 8: Characters optional
            /// </summary>
            public static Regex reg15 = new Regex(@"\?");
            /// <summary>
            /// Lesson 9: All this whitespace
            /// </summary>
            public static Regex reg16 = new Regex(@"\s");
            /// <summary>
            /// Lesson 10: Starting and ending
            /// </summary>
            public static Regex reg17 = new Regex(@"[^un]successful$");
            /// <summary>
            /// Lesson 11: Match groups
            /// </summary>
            public static Regex reg18 = new Regex(@"(file_(\w*))\.pdf$");
            /// <summary>
            /// Lesson 12: Nested groups
            /// </summary>
            public static Regex reg19 = new Regex(@"(\w* (\d*))");
            /// <summary>
            /// Lesson 13: More group work
            /// </summary>
            public static Regex reg20 = new Regex(@"(\d*)x(\d*)");
            /// <summary>
            /// Lesson 14: It's all conditional
            /// </summary>
            public static Regex reg21 = new Regex(@"(cats|dogs)");
            /// <summary>
            /// Lesson 15: Other special characters
            /// </summary>
            public static Regex reg22 = new Regex(@"\w\s");
            /// <summary>
            /// Problem 1: Matching a decimal numbers
            /// </summary>
            public static Regex reg23 = new Regex(@"\d$");
            /// <summary>
            /// Problem 2: Matching phone numbers
            /// </summary>
            public static Regex reg24 = new Regex(@"(\d{3})");
            /// <summary>
            /// Problem 3: Matching emails
            /// </summary>
            public static Regex reg25 = new Regex(@"^([\w\.]*)");
            /// <summary>
            /// Problem 4: Matching HTML
            /// </summary>
            public static Regex reg26 = new Regex(@"<(\w{0,3})");
            /// <summary>
            /// Problem 5: Matching specific filenames
            /// </summary>
            public static Regex reg27 = new Regex(@"(\w*)\.(jpg|png|gif)$");
            /// <summary>
            /// Problem 6: Trimming whitespace from start and end of line
            /// </summary>
            public static Regex reg28 = new Regex(@"\s*(.*)\s*");
            /// <summary>
            /// Problem 7: Extracting information from a log file
            /// </summary>
            public static Regex reg29 = new Regex(@"(\w*)\(([\w\.]*):(\d*)\)");
            /// <summary>
            /// Problem 8: Parsing and extracting data from a URL
            /// </summary>
            public static Regex reg30 = new Regex( @"(\w*)://([\w\-\.]*)(:([\d]*))*");
        //end
        
           
        /// <summary>
        /// youtube watch link search
        /// </summary>
        public static Regex reg31 = new Regex(@"watch\?v=\w*\S+");
        /// <summary>
        /// youtube full link search
        /// </summary>
        public static Regex reg32 = new Regex(@"htt(ps||s):\/\/w{3}.youtube.com\/watch\?v=\w*\S+");
        /// <summary>
        /// if Contains x, don't write
        /// </summary>
        public static Regex reg33 = new Regex(@"^((?!bword|fword).)*$]*");


    }
}
