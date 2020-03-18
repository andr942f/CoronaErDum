using System;

namespace simpelt_spil
{
    class MainMenu
    {
        static void Main(string[] args)
        {
            //Play game music
            Random random = new Random();
            switch (random.Next(1,3))
            {
                case 1:
                    Music.Music.Player("Best Friend");
                    break;
                case 2:
                    Music.Music.Player("Journey");
                    break;
            }
            //end

            MainGame mainGame = new MainGame();
            MainHelp mainHelp = new MainHelp();
            HighScore highScore = new HighScore();
            while (true)
            {
                //when game is done, reset points and tries
                int points = 0;
                int tries = 0;

                //menu options
                Console.WriteLine("=====WELCOME=====");
                Console.WriteLine("To a Simple Game");
                Line.Length(17);
                Console.WriteLine();
                Console.WriteLine("1) Start game");
                Console.WriteLine("2) Highscore");
                Console.WriteLine("3) Help");
                Console.WriteLine("4) Quit");
                Console.WriteLine();
                Line.Length(17);

                //pick between options
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        mainGame.Game(tries, points);
                        break;
                    case ConsoleKey.D2:
                        highScore.ViewHighscore();
                        break;
                    case ConsoleKey.D3:
                        mainHelp.Help();
                        break;
                    case ConsoleKey.D4:
                        Environment.Exit(0);
                        break;
                }
                Console.Clear();
            }
        }
    }
}
