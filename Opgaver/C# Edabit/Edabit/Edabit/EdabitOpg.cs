using System;

namespace Opgaver
{
    class EdabitOpg
    {
        public void Edabit()
        {
            //Console.WriteLine($": {Desc.}");

            //opg connecter
            Very_easy Desc = new Very_easy();

            //Sum
            Console.WriteLine($"Sum: {Desc.Sum(5, 20)}");
            
            //SameCase
            Console.WriteLine($"SameCase: {Desc.SameCase("Sup guyS?")}");

            //Letters Only
            Console.WriteLine($"Letters only: {Desc.LettersOnly("Y¤!#e4#!a¤!#h¤!#t¤#!ha¤4##t¤#4=()/9is¤#42m#¤342e")}");

            //missing num
            Console.WriteLine($"MissingNum: {Desc.MissingNum(new int[] { 1, 2, 3, 4, 6, 7, 8, 9, 10 })}");

            //match
            Console.WriteLine($"Match: {Desc.match("yo", "Yo")}");

            //isfourletters
            foreach (var item in Desc.IsFourLetters(new string[] { "Billy", "Illie", "Bill", "Billie" }))
            {
                Console.Write($"IsFourLetters: {item}");
                Console.WriteLine();
            }

            //isvalid
            Console.WriteLine($"IsValid: {Desc.IsValid("50163")}");

            //cumulativesum
            double[] arr = { 1, 2, 3 };
            foreach (var before in arr)
            {
                foreach (var after in Desc.CumulativeSum(new double[] { before }))
                    Console.Write($"CumulativeSum: {before} - {after}");
                Console.WriteLine();
            }

            //largest swap
            Console.WriteLine($"Largest Swap: {Desc.LargestSwap(25)}");

            //repeat
            Console.WriteLine($"Repeat: {Desc.Repeat("What?", 5)}");

            //equal
            Console.WriteLine($"Equal: {Desc.Equal(5, 5, 5)}");

            //remove vowels
            Console.WriteLine($"Remove Vowels: {Desc.RemoveVowels("prepareth to square! i shall heave the gorge on thy livings, naughty mushrump!")}");

            //findlargest
            Console.Write("FindLargest: ");
            foreach (var item in Desc.FindLargest(new double[][] { new double[] { 5.23, 5, 2 }, new double[] { 5, 21, 6, 99 }, new double[] { 6, 7, 9, 10 } }))
                Console.Write($"{item}, ");
            Console.WriteLine();

            //subreddit
            Console.WriteLine($"Subreddit: {Desc.SubReddit("https://www.reddit.com/r/mildlyinteresting/")}");

            //index of capitals
            string input = "YoU dOnT kNoW mE";
            Console.Write($"Index Of Capitals: {input} - ");
            foreach (int item in Desc.IndexOfCapitals(input))
                Console.Write($"{item}, ");
            Console.WriteLine();

            Console.WriteLine($"reverse case: {Desc.ReverseCase("What")}");

            Console.WriteLine($"is isogram: {Desc.IsIsogram("Yeeters")}");

            //end
            Console.WriteLine();
        }
    }
}
