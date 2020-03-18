using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpelt_spil
{
    class Line
    {
        /// <summary>
        /// Make a seperator line, so everything looks more smooth
        /// </summary>
        /// <param name="length">Length of the line being used</param>
        public static void Length(int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }
    }
}
