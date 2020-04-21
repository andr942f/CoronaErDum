using System;
using System.Text.RegularExpressions;

namespace RegEx
{
    public class Program
    {
        //A bit of help: https://www.youtube.com/watch?v=sa-TUpSx1JA
        //A bit of help: https://www.youtube.com/watch?v=9178EdR6Pyg
        //A bit of help: https://users.pja.edu.pl/~jms/qnx/help/watcom/wd/regexp.html
        //Used to test RegEx: https://www.regextester.com/97589
        //Been working on this most of 4/17/2020, mostly to understand it (will look more at this): https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/xmldoc/summary
        //Exersises: https://regexone.com/
        //My score on intermediate difficulty: http://play.inginf.units.it/#/end/1587380068871

        public static Action<string> cwl = Console.WriteLine;
        public static Action<string> cw = Console.Write;

        /// <summary>
        /// A string for all of the various RegEx's
        /// </summary>
        public static string[] str =
        { 
            /*reg0 */ "Acorn Pcorn pcorn acorn ecor whoops",
            /*reg1 */ "Mr. Gman Mrs. Gman Mr Billy Mr bob asc",
            /*reg2 */ "andreasvbeck420@hotmail.com ad@hot.dk realg@gmail.dk bruh@gmail.bruh a@e.co",
            /*reg3 */ "[stop] puting me in [brackets] please",
            /*reg4 */ "Password1234 password123 Password",
            /*reg5 */ "59001 853a7 732 32 393939",
            /*reg6 */ "1111",

            // RegexOne opgaver
                /*reg7 */ "whssup",
                /*reg8 */ "1111asvssa",
                /*reg9 */ "1111.sas.",
                /*reg10 */ "nan",
                /*reg11 */ "pog",
                /*reg12 */ "AASDsaasDaasdASD",
                /*reg13 */ "Wazzzzzzup",
                /*reg14 */ "aaaaaacc",
                /*reg15 */ "cc",
                /*reg16 */ "Wha    t",
                /*reg17 */ "Mission: successful",
                /*reg18 */ "file_07241999.pdf",
                /*reg19 */ "Jan 1987",
                /*reg20 */ "1920x1600",
                /*reg21 */ "I love cats",
                /*reg22 */ "Andreas is cool",
                /*reg23 */ "123,340.00",
                /*reg24 */ "(416)555-3456",
                /*reg25 */ "Andreas.vbeck@hotmail.com",
                /*reg26 */ "<a>This is a link</a>",
                /*reg27 */ "updated_img0912.png",
                /*reg28 */ "				The quick brown fox...",
                /*reg29 */ "E/( 1553):   at widget.List.fillFrom(ListView.java:709)",
                /*reg30 */ "ftp://file_server.com:21/top_secret/life_changing_plans.pdf",
                /*reg31 */ "https://www.youtube.com/watch?v=62Z0mU9yUFY&list=PLB71qIrDRO8ifVSUz537dZFjYQ-jyIs5w&index=2",
                /*reg32 */ "https://www.youtube.com/watch?v=62Z0mU9yUFY&list=PLB71qIrDRO8ifVSUz537dZFjYQ-jyIs5w&index=2",
                /*reg33 */ "good word"
            // end
        };

        /// <summary>
        /// Instead of writing the same thing a billion times
        /// </summary>
        /// <param name="matches"></param>
        public static void ForLoop(MatchCollection matches, bool length)
        {
            switch (length)
            {
                case true:
                    foreach (Match match in matches)
                        cw(match.Length.ToString() + ", ");
                    cwl("");
                    break;
                default:
                    foreach (Match match in matches)
                        cw(match + ", ");
                    cwl("");
                    break;
            }
        }

        public static void Main()
        {
            ForLoop(RegEx.reg0.Matches(str[0]), false);
            ForLoop(RegEx.reg1.Matches(str[1]), false);
            ForLoop(RegEx.reg2.Matches(str[2]), false);
            ForLoop(RegEx.reg3.Matches(str[3]), false);
            ForLoop(RegEx.reg4.Matches(str[4]), false);
            ForLoop(RegEx.reg5.Matches(str[5]), false);
            ForLoop(RegEx.reg6.Matches(str[6]), true);

            //RegexOne opgaver
                ForLoop(RegEx.reg7.Matches(str[7]), false);
                ForLoop(RegEx.reg8.Matches(str[8]), false);
                ForLoop(RegEx.reg9.Matches(str[9]), false);
                ForLoop(RegEx.reg10.Matches(str[10]), false);
                ForLoop(RegEx.reg11.Matches(str[11]), false);
                ForLoop(RegEx.reg12.Matches(str[12]), false);
                ForLoop(RegEx.reg13.Matches(str[13]), false);
                ForLoop(RegEx.reg14.Matches(str[14]), false);
                ForLoop(RegEx.reg15.Matches(str[15]), false);
                ForLoop(RegEx.reg16.Matches(str[16]), false);
                ForLoop(RegEx.reg17.Matches(str[17]), false);
                ForLoop(RegEx.reg18.Matches(str[18]), false);
                ForLoop(RegEx.reg19.Matches(str[19]), false);
                ForLoop(RegEx.reg20.Matches(str[20]), false);
                ForLoop(RegEx.reg21.Matches(str[21]), false);
                ForLoop(RegEx.reg22.Matches(str[22]), false);
                ForLoop(RegEx.reg23.Matches(str[23]), false);
                ForLoop(RegEx.reg24.Matches(str[24]), false);
                ForLoop(RegEx.reg26.Matches(str[26]), false);
                ForLoop(RegEx.reg27.Matches(str[27]), false);
                ForLoop(RegEx.reg28.Matches(str[28]), false);
                ForLoop(RegEx.reg29.Matches(str[29]), false);
                ForLoop(RegEx.reg30.Matches(str[30]), false);
                ForLoop(RegEx.reg31.Matches(str[31]), false);
                ForLoop(RegEx.reg32.Matches(str[32]), false);
                ForLoop(RegEx.reg33.Matches(str[33]), false);
            //end
        }
    }
}
