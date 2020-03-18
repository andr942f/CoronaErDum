using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpelt_spil
{
    class MainHelp
    {
        /// <summary>
        /// a help on how to play the game
        /// </summary>
        public void Help()
        {
            Console.Clear();
            Console.WriteLine("This is a guessing game, to win you must guess the correct number from 0-10");
            Console.WriteLine("You have 20 tries to guess correct");
            Console.WriteLine("If you guess correct, you gain 2 more tries");
            Console.WriteLine("At the end of the game, you will get feedback on your score");
            MainMenuClasses.ToMainMenu.Back();
        }
    }
}
