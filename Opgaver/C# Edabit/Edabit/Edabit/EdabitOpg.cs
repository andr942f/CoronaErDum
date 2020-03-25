using System;

namespace Opgaver
{
    class EdabitOpg
    {
        public void Edabit()
        {
            //Console.WriteLine($": {Desc.}");

            Very_easy Desc = new Very_easy();

            Console.WriteLine($"Sum: {Desc.Sum(5, 20)}");

            Console.WriteLine($"SameCase: {Desc.SameCase("Sup guyS?")}");

            Console.WriteLine($"Letters only: {Desc.LettersOnly("Y¤!#e4#!a¤!#h¤!#t¤#!ha¤4##t¤#4=()/9is¤#42m#¤342e")}");

            Console.WriteLine($"MissingNum: {Desc.MissingNum(new int[] { 1, 2, 3, 4, 6, 7, 8, 9, 10 })}");

            Console.WriteLine($"Match: {Desc.match("yo", "Yo")}");

            foreach (var item in Desc.IsFourLetters(new string[] { "Billy", "Illie", "Bill", "Billie" }))
            {
                Console.Write($"IsFourLetters: {item}");
                Console.WriteLine();
            }

            Console.WriteLine($"IsValid: {Desc.IsValid("50163")}");

            double[] arr = { 1, 2, 3 };
            foreach (var before in arr)
            {
                foreach (var after in Desc.CumulativeSum(new double[] { before }))
                    Console.Write($"CumulativeSum: {before} - {after}");
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
