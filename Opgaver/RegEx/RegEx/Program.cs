using System;
using System.Text.RegularExpressions;

namespace RegEx
{
    public class Program
    {
        //https://www.youtube.com/watch?v=sa-TUpSx1JA
        //https://www.youtube.com/watch?v=9178EdR6Pyg
        //https://www.regextester.com/97589 Used to test RegEx
        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/xmldoc/summary Been working on this most of 4/17/2020, mostly to understand it, and use it in the future

        /// <summary>
        /// A string for all of the various RegEx's
        /// </summary>
        public static string[] str =
        { 
            /*reg1 */ "Acorn Pcorn pcorn acorn ecor whoops",
            /*reg2 */ "Mr. Gman Mrs. Gman Mr Billy Mr bob asc",
            /*reg3 */ "andreasvbeck420@hotmail.com ad@hot.dk realg@gmail.dk bruh@gmail.bruh a@e.co",
            /*reg4 */ "[stop] puting me in [brackets] please",
            /*reg5 */ "Password1234 password123 Password",
            /*reg6 */ "59001 853a7 732 32 393939",
            /*reg7 */ "1111"
        };

        /// <summary>
        /// Instead of writing the same thing a billion times
        /// </summary>
        /// <param name="matches"></param>
        public static void ForLoop(MatchCollection matches)
        {
            foreach (Match match in matches)
                Console.Write(match + ", ");
            Console.WriteLine();
        }

        public static void Main()
        {
            ForLoop(RegEx.reg1.Matches(str[0]));
            ForLoop(RegEx.reg2.Matches(str[1]));
            ForLoop(RegEx.reg3.Matches(str[2]));
            ForLoop(RegEx.reg4.Matches(str[3]));
            ForLoop(RegEx.reg5.Matches(str[4]));
            ForLoop(RegEx.reg6.Matches(str[5]));
            ForLoop(RegEx.reg7.Matches(str[6]));
        }
    }
}
