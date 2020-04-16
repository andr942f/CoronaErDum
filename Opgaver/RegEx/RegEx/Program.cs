using System;
using System.Text.RegularExpressions;

namespace RegEx
{
    public class Program
    {
        //https://www.youtube.com/watch?v=sa-TUpSx1JA
        //https://www.youtube.com/watch?v=9178EdR6Pyg
        //https://www.regextester.com/97589 Used to test RegEx

        public static string str =
        /*reg1 */ "Acorn Pcorn pcorn acorn ecor whoops " +
        /*reg2 */ "Mr. Gman Mrs. Gman Mr Billy Mr bob asc " +
        /*reg3 */ "andreasvbeck420@hotmail.com ad@hot.dk realg@gmail.dk bruh@gmail.bruh a@e.co" +
        /*reg4 */ "[stop] puting me in [brackets] please";

        public static void ForLoop(MatchCollection matches)
        {
            foreach (Match match in matches)
                Console.Write(match + ", ");
            Console.WriteLine();
        }
        public static void Main()
        {
            ForLoop(RegEx.reg1.Matches(str));
            ForLoop(RegEx.reg2.Matches(str));
            ForLoop(RegEx.reg3.Matches(str));
            ForLoop(RegEx.reg4.Matches(str));
        }
    }
}
