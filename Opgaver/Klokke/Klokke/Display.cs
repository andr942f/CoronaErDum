using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klokke
{
    public class Display : ClockInfo
    {
        public static string TimeNow() => DateTime.Now.ToString(Format);

        public static string ToRoman(int time)
        {
            StringBuilder Builder = new StringBuilder();
            SortedDictionary<int, string> Numerals = new SortedDictionary<int, string>
            { { 1, "I" }, { 4, "IV" }, { 5, "V" }, { 9, "IX" }, { 10, "X" }, { 40, "XL" }, { 50, "L" } };

            foreach (var Number in Numerals.Reverse())
                while (time >= Number.Key)
                { time -= Number.Key; Builder.Append(Number.Value); }
            return Builder.ToString();
        }
    }
}