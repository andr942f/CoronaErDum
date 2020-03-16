using System;

namespace Edabit
{
    class Program
    {
        static void Main(string[] args)
        {
            Very_easy Desc = new Very_easy();
            Console.WriteLine(Desc.Sum(5, 20));
            Console.WriteLine(Desc.SameCase("Sup guyS?"));
            Console.WriteLine(Desc.MissingNum( 1, 2, 3, 4 ));
        }
    }
}
