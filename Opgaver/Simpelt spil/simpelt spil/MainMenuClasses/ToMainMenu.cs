using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpelt_spil.MainMenuClasses
{
    class ToMainMenu
    {
        public static void Back()
        {
            Console.WriteLine();
            Console.WriteLine("Press any button to exit");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
