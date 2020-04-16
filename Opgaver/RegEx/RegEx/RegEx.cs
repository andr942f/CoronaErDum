using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegEx
{
    public class RegEx
    {
        public static Regex reg1 = new Regex(@"[^Aa]corn");
        public static Regex reg2 = new Regex(@"M(r|s|rs)\.?\s[a-zA-Z]\w*");
        public static Regex reg3 = new Regex(@"\w*@\b(hotmail|gmail)\.\b(com|dk)");
        public static Regex reg4 = new Regex(@"\[\w*\]");
    }
}
