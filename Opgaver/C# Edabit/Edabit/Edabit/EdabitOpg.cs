using System;

namespace Opgaver
{
    class EdabitOpg
    {
        public Action<string> cw = Console.WriteLine;
        public void Edabit()
        {

            //opg connecter
            Opgaver Desc = new Opgaver();

            //Sum
            int vs1 = 5;
            int vs2 = 20;
            cw($"Sum: {vs1} {vs2} - {Desc.Sum(vs1, vs2)}");

            //SameCase
            string vs3 = "Sup guyS";
            cw($"SameCase: {vs3} - {Desc.SameCase(vs3)}");

            //Letters Only
            string vs4 = "Y¤!#e4#!a¤!#h¤!#t¤#!ha¤4##t¤#4=()/9is¤#42m#¤342e";
            cw($"LettersOnly: {vs4} - {Desc.LettersOnly(vs4)}");
            
            //missing num
            int[] vs5 = { 1, 2, 3, 4, 6, 7, 8, 9, 10 };
            cw($"MissingNum: {vs5} - {Desc.MissingNum(vs5)}");

            //match
            string vs6 = "yo";
            cw($"match: {vs6} - {Desc.match(vs6, vs6.ToUpper())}");

            //isfourletters
            foreach (var item in Desc.IsFourLetters(new string[] { "Billy", "Illie", "Bill", "Billie" }))
            {
                Console.Write($"IsFourLetters: {item}");
                cw("");
            }

            //isvalid
            string vs7 = "50163";
            cw($"IsValid: {vs7} - {Desc.IsValid(vs7)}");

            //cumulativesum
            double[] vs8 = { 1, 2, 3 };
            foreach (var before in vs8)
            {
                foreach (var after in Desc.CumulativeSum(new double[] { before }))
                    Console.Write($"CumulativeSum: {before} - {after}");
            }
            cw("");

            //largest swap
            int vs9 = 25;
            cw($"LargestSwap: {vs9} - {Desc.LargestSwap(vs9)}");

            //repeat
            string vs10 = "Hi i'm a string";
            cw($"Repeat: {vs10} - {Desc.Repeat(vs10, 5)}");

            //equal
            int vs11 = 5;
            cw($"Equal: {vs11} - {Desc.Equal(vs11, vs11, vs11)}");

            //remove vowels
            string vs12 = "Hi i'm a string";
            cw($"RemoveVowels: {vs12} - {Desc.RemoveVowels(vs12)}");
           
            //findlargest
            Console.Write("FindLargest: ");
            foreach (var item in Desc.FindLargest(new double[][] { new double[] { 5.23, 5, 2 }, new double[] { 5, 21, 6, 99 }, new double[] { 6, 7, 9, 10 } }))
                Console.Write($"{item}, ");
            cw("");

            //subreddit
            string vs13 = "https://www.reddit.com/r/mildlyinteresting/";
            cw($"SubReddit: {vs13} - {Desc.SubReddit(vs13)}");

            //index of capitals
            string vs14 = "YoU dOnT kNoW mE";
            Console.Write($"Index Of Capitals: {vs14} - ");
            foreach (int item in Desc.IndexOfCapitals(vs14))
                Console.Write($"{item}, ");
            cw("");

            string vs15 = "What";
            cw($"ReverseCase: {vs15} - {Desc.ReverseCase(vs15)}");

            string vs16 = "Yeters";
            cw($"IsIsogram: {vs16} - {Desc.IsIsogram(vs16)}");

            string vs17 = "Hi i'm a string";
            cw($"isIdentical: {vs17} - {Desc.isIdentical(vs17)}");

            string vs18 = "Concat is very helpful, i will remember it big time";
            cw($"Reverse: {vs18} - {Desc.Reverse(vs18)}");

            int vs19 = 434;
            cw($"NumPalindrome: {vs19} - {Desc.IsPalindrome(vs19)}");

            string vs20 = "mwowowm";
            cw($"StrPalindrome: {vs20} - {Desc.CheckPalindrome(vs20)}");

            string vs21 = "Hi i'm a string";
            cw($"ReplaceVowels: {vs21} - {Desc.ReplaceVowels(vs21, "*")}");

            Console.Write("UniqueSort: ");
            foreach (var item in Desc.UniqueSort(new double[] { 7, 2, 2, 2, 4, 5, 1, 7, 6, 3, 5 }))
                Console.Write($"{item}, ");
            cw("");

            Console.Write("ArrayOfMultiples: ");
            foreach (var item in Desc.ArrayOfMultiples(5, 10))
                Console.Write($"{item}, ");
            cw("");

            string vs22 = "Pizzeria";
            cw($"GetMiddle: {vs22} - {Desc.GetMiddle(vs22)}");

            string vs23 = "12345678910";
            cw($"maskify: {vs23} - {Desc.Maskify(vs23)}");

            int vs24 = 5;
            cw($"CountOnes: {vs24} - {Desc.CountOnes(vs24)}");

            string bs25 = "1 2 3 4 5 6 7";
            cw($"HighLow: {bs25} - {Desc.HighLow(bs25)}");

            int vs26 = 121532153;
            cw($"SortDescending: {vs26} - {Desc.SortDescending(vs26)}");

            object[] vs27 = {1, "a", 3, "t", "ea", 'e', 5};
            cw($"FilterArray: {vs27} - {Desc.FilterArray(vs27)}");

            string vs28 = "Hi i'm a string";
            cw($"XO: {vs28} - {Desc.XO(vs28)}");

            int vs29 = 4;
            cw($"MyPi: {vs29} - {Desc.MyPi(vs29)}");

            int vs30 = 3423;
            cw($"IsSymmetrical: {vs30} - {Desc.IsSymmetrical(vs30)}");

            string vs31 = "Radio";
            cw($"IsStrangePair: {vs31} - groups - {Desc.IsStrangePair(vs31, "groups")}");

            int vs32 = 18000000;
            cw($"FormatNum: {vs32} - {Desc.FormatNum(vs32)}");

            int[] vs33 = {1, 6, 10, 555 };
            cw($"Magnitude: {vs33} - {Desc.Magnitude(vs33)}");

            int vs34 = 1500;
            cw($"Century: {vs34} - {Desc.Century(vs34)}");

            int[] vs35 = {1, 2, 5, 10, 55 };
            cw($"SumSmallest: {vs35} - {Desc.SumSmallest(vs35)}");

            string vs36 = "Hi##@$i'm**a(str!ing)";
            cw($"RemoveSpecialCharacters: {vs36} - {Desc.RemoveSpecialCharacters(vs36)}");

            string vs37 = "andreasvbeck@hotmail.com";
            cw($"ValidateEmail: {vs37} - {Desc.ValidateEmail(vs37)}");

            int vs38 = 152;
            cw($"MysteryFunc: {vs38} - {Desc.MysteryFunc(vs38)}");

            string vs39 = "abcd";
            cw($"Accum: {vs39} - {Desc.Accum(vs39)}");

            int vs40 = 2;
            cw($"isPrime: {vs40} - {Desc.isPrime(vs40)}");

            string vs41 = "1254";
            cw($"ValidatePIN: {vs41} - {Desc.ValidatePIN(vs41)}");

            string vs42 = "What???? SYNONYM!!!";
            cw($"NoYelling: {vs42} - {Desc.NoYelling(vs42)}");

            string vs43 = "#5423a";
            cw($"IsValidHexCode: {vs43} - {Desc.IsValidHexCode(vs43)}");

            cw($"UTFcode: - {Desc.UTFcode()}");

            string vs44 = "Billy";
            string vs45 = "Blily";
            cw($"IsAnagram: {vs44}/{vs45} - {Desc.IsAnagram(vs44, vs45)}");

            string vs46 = "epic movie title";
            cw($"MakeTitle: {vs46} - {Desc.MakeTitle(vs46)}");

            string vs47 = "(123)-312-EYES";
            cw($" TextToNum: {vs47} - {Desc. TextToNum(vs47)}");

            string vs48 = "(123) 456-7890";
            cw($"IsValidPhoneNumber: {vs48} - {Desc.IsValidPhoneNumber(vs48)}");

            string vs49 = "Hi i'm a string";
            cw($"IsPalindrome: {vs49} - {Desc.IsPalindrome(vs49)}");

            int vs50 = 100;
            cw($"lessThan100: {vs50} + {vs50} - {Desc.lessThan100(vs50, vs50)}");

            string vs51 = "Kielbasa is better than Wurst";
            cw($"WurstIsBetter: {vs51} - {Desc.WurstIsBetter(vs51)}");

            string[] vs52 = {"post", "MALONE", "Rapper" };
            Console.Write("CapMe: ");
            foreach (var item in Desc.CapMe(vs52))
                Console.Write($"{item}, ");
            cw("");

            int vs53 = 5;
            cw($"dividesEvenly: {vs53} / {vs53} = {vs53 / vs53} - {Desc.dividesEvenly(vs53, vs53)}");

            int vs54 = 55;
            cw($"Fact: {vs54} - {Desc.Fact(vs54)}");

            string vs55 = "59005";
            cw($"IsValid2: {vs55} - {Desc.IsValid2(vs55)}");

            int vs56 = 10;
            cw($"reversedBinaryInteger: {vs56} - {Desc.reversedBinaryInteger(vs56)}");

            int vs57 = 123;
            foreach (var item in Desc.ReverseAndNot(vs57))
                Console.Write(item);
            cw("");

            string vs58 = "people who call RegEx useless are smartn't";
            cw($"TranslateSentence: {vs58} - {Desc.TranslateSentence(vs58)}");

            string vs59 = "Fhg93@";
            cw($"ValidatePassword: {vs59} - {Desc.ValidatePassword(vs59)}");


            string vs60 = "Hello fellow kidss";
            cw($"IsParselTongue: {vs60} - {Desc.IsParselTongue(vs60)}");
            //end
            cw("");

        }
    }
}
