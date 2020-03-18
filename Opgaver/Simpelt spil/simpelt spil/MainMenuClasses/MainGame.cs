using System;

namespace simpelt_spil
{
    class MainGame
    {
        /// <summary>
        /// when you're done and you need to look at points and insert highscore aso.
        /// </summary>
        /// <param name="points">Total poits aquired</param>
        /// <returns></returns>
        public static void EndMenu(int points)
        {
            //clear game window
            Console.Clear();
            //total points
            Console.WriteLine("Your total points stand at:");
            Line.Length(20);
            Console.WriteLine(points);
            Console.WriteLine();
            //end

            //Insert name for your highscore to show up
            Console.WriteLine("Show off your highscore!");
            Line.Length(20);
            Console.Write("Name: ");
            DatabaseAcess.DatabaseAcess db = new DatabaseAcess.DatabaseAcess();
            db.InsertHighscore(Console.ReadLine(), points);
            MainMenuClasses.ToMainMenu.Back();
            //end

            //clear and go back to main menu
            Console.Clear();
        }
        /// <summary>
        /// The main game
        /// </summary>
        /// <param name="tries"></param>
        /// <param name="points"></param>
        /// <returns></returns>
        public void Game(int tries, int points)
        {
            //clear main menu window
            Console.Clear();
            //ready, set, start! Find a random number to start out with
            Console.WriteLine("Enter any number to start guessing, this will count as a guess. Oh, and one last thing, good luck");
            Random random = new Random();
            int Answer = random.Next(0, 11);
            //end
            //if you surpass 20 tries, you lose
            while (tries <= 20)
            {
                // if input not an int, go catch
                try
                {
                    // guess
                    int Guess = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    
                    // if guess is correct, gain 10 points!
                    if (Guess == Answer)
                    {
                        Console.WriteLine("Correct! 10 points!");
                        Answer = random.Next(1, 11);
                        tries -= 2;
                        points += 10;
                    }
                    // else tell player if tehy were higher or lower than the answer
                    else if (Guess > Answer)
                        Console.WriteLine("Your guess was HIGHER than the answer, try again :(");
                    else if (Guess < Answer)
                        Console.WriteLine("Your guess was LOWER than the answer, try again :(");

                    // when answer given, count tries
                    Console.WriteLine($"Tries: {tries++}/20");
                    Line.Length(20);
                }
                catch
                {
                    Console.WriteLine("syntax error, must input a number");
                }
            }
            // when all said and done, view the end menu
            EndMenu(points);
        }
    }
}
