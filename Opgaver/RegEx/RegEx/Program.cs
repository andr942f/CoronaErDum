using System;
using System.Text.RegularExpressions;

namespace RegEx
{
    class Program
    {
        //https://www.youtube.com/watch?v=sa-TUpSx1JA

        static void Main(string[] args)
        {
            Regex regex1 = new Regex(@"[^aA]\w*");
            Regex regex2 = new Regex(@"M(r|s|rs)\.?\s[a-zA-Z]\w*");
            string vs1 = "Acorn Pcorn pcorn acorn ecor whoops";
            string vs2 = "Mr. Gman Mrs. Gman Mr Billy Mr bob asc";
            MatchCollection matches1 = regex1.Matches(vs1);
            MatchCollection matches2 = regex2.Matches(vs2);
            foreach (Match match in matches1)
                Console.Write(match);
            Console.WriteLine();
            foreach (Match match1 in matches2)
                Console.Write(match1 + ", ");

        }
    }
}
