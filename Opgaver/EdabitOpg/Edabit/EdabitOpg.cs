using System;
using System.Collections.Generic;
using System.Text;

namespace Opgaver
{
    class EdabitOpg
    {
        public static void Edabit()
        {
            Very_easy Desc = new Very_easy();
            Console.WriteLine(Desc.Sum(5, 20));
            Console.WriteLine(Desc.SameCase("Sup guyS?"));
            Console.WriteLine(Desc.LettersOnly("Y¤!#e4#!a¤!#h¤!#t¤#!ha¤4##t¤#4=()/9is¤#42m#¤342e"));
            Console.WriteLine(Desc.MissingNum(new int[] { 1, 2, 3, 4, 6, 7, 8, 9, 10 }));
            Console.WriteLine(Desc.match("yo", "Yo"));
            foreach (var item in Desc.IsFourLetters(new string[] { "Billy", "Illie", "Bill", "Billie" }))
            {
                Console.Write(item);
            }
        }
    }
}
