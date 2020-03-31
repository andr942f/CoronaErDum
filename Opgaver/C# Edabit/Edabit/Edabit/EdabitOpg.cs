using System;

namespace Opgaver
{
    class EdabitOpg
    {
        public void Edabit()
        {
            Action<string> cw = Console.WriteLine;

            //opg connecter
            Very_easy Desc = new Very_easy();

            //Sum
            int five = 5;
            int twenty = 20;
            cw($"Sum: {five} - {Desc.Sum(five, twenty)}");

            //SameCase
            string guy = "Sup guyS";
            cw($"SameCase: {guy} - {Desc.SameCase(guy)}");

            //Letters Only
            string only = "Y¤!#e4#!a¤!#h¤!#t¤#!ha¤4##t¤#4=()/9is¤#42m#¤342e";
            cw($"LettersOnly: {only} - {Desc.LettersOnly(only)}");
            
            //missing num
            int[] missing = { 1, 2, 3, 4, 6, 7, 8, 9, 10 };
            cw($"MissingNum: {missing} - {Desc.MissingNum(missing)}");

            //match
            string yo = "yo";
            cw($"match: {yo} - {Desc.match(yo, yo.ToUpper())}");

            //isfourletters
            foreach (var item in Desc.IsFourLetters(new string[] { "Billy", "Illie", "Bill", "Billie" }))
            {
                Console.Write($"IsFourLetters: {item}");
                cw("");
            }

            //isvalid
            string valid = "50163";
            cw($"IsValid: {valid} - {Desc.IsValid(valid)}");

            //cumulativesum
            double[] arr = { 1, 2, 3 };
            foreach (var before in arr)
            {
                foreach (var after in Desc.CumulativeSum(new double[] { before }))
                    Console.Write($"CumulativeSum: {before} - {after}");
                cw("");
            }

            //largest swap
            int LS = 25;
            cw($"LargestSwap: {LS} - {Desc.LargestSwap(LS)}");

            //repeat
            string re = "Hi i'm a string";
            cw($"Repeat: {re} - {Desc.Repeat(re, 5)}");

            //equal
            int eq = 5;
            cw($"Equal: {eq} - {Desc.Equal(eq, eq, eq)}");

            //remove vowels
            string v = "Hi i'm a string";
            cw($"RemoveVowels: {v} - {Desc.RemoveVowels(v)}");
           
            //findlargest
            Console.Write("FindLargest: ");
            foreach (var item in Desc.FindLargest(new double[][] { new double[] { 5.23, 5, 2 }, new double[] { 5, 21, 6, 99 }, new double[] { 6, 7, 9, 10 } }))
                Console.Write($"{item}, ");
            cw("");

            //subreddit
            string reddit = "https://www.reddit.com/r/mildlyinteresting/";
            cw($"SubReddit: {reddit} - {Desc.SubReddit(reddit)}");

            //index of capitals
            string input = "YoU dOnT kNoW mE";
            Console.Write($"Index Of Capitals: {input} - ");
            foreach (int item in Desc.IndexOfCapitals(input))
                Console.Write($"{item}, ");
            cw("");

            string what = "What";
            cw($"ReverseCase: {what} - {Desc.ReverseCase(what)}");

            string dio = "Yeeters";
            cw($"IsDiogram: {dio} - {Desc.IsIsogram(dio)}");

            string name = "Hi i'm a string";
            cw($"isIdentical: {name} - {Desc.isIdentical(name)}");

            string reverse = "Concat is very helpful, i will remember it big time";
            cw($"Reverse: {reverse} - {Desc.Reverse(reverse)}");

            int num = 434;
            cw($"NumPalindrome: {num} - {Desc.IsPalindrome(num)}");

            string str = "mwowowm";
            cw($"StrPalindrome: {str} - {Desc.CheckPalindrome(str)}");

            string str2 = "Hi i'm a string";
            cw($"ReplaceVowels: {str2} - {Desc.ReplaceVowels(str2, "*")}");

            Console.Write("UniqueSort: ");
            foreach (var item in Desc.UniqueSort(new double[] { 7, 2, 2, 2, 4, 5, 1, 7, 6, 3, 5 }))
                Console.Write($"{item}, ");
            cw("");

            Console.Write("ArrayOfMultiples: ");
            foreach (var item in Desc.ArrayOfMultiples(5, 10))
                Console.Write($"{item}, ");
            cw("");

            string pizzeria = "Pizzeria";
            cw($"GetMiddle: {pizzeria} - {Desc.GetMiddle(pizzeria)}");

            string mask = "12345678910";
            cw($"maskify: {mask} - {Desc.Maskify(mask)}");


            int i = 5;
            cw($"CountOnes: {i} - {Desc.CountOnes(i)}");

            string high = "1 2 3 4 5 6 7";
            cw($"HighLow: {high} - {Desc.HighLow(high)}");

            //end
            cw("");

        }
    }
}
