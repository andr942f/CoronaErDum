using System;

namespace simpelt_spil
{
    class HighScore
    {
        /// <summary>
        /// When called, view the top 5 higscores
        /// </summary>
        public void ViewHighscore()
        {
            //clear main menu
            Console.Clear();
            //make a database connection here
            DatabaseAcess.DatabaseAcess db = new DatabaseAcess.DatabaseAcess();
            // count of ranks
            int hs = 1;
            // Layout used in the program to make it look more flawless
            string Layout = "{0,10} {1,15} {2,15}";

            //Go through top 5 people
            Console.WriteLine(Layout, "RANK", "SCORE", "NAME");
            Line.Length(50);
            foreach (var item in db.ViewAll())
            {
                switch (hs)
                {
                    case 1:
                        Console.WriteLine(Layout, $"{hs++}st", $"#{item.Score}", $"{item.Name}");
                        break;
                    case 2:
                        Console.WriteLine(Layout, $"{hs++}nd", $"#{item.Score}", $"{item.Name}");
                        break;
                    case 3:
                        Console.WriteLine(Layout, $"{hs++}rd", $"#{item.Score}", $"{item.Name}");
                        break;
                    case 4:
                        Console.WriteLine(Layout, $"{hs++}th", $"#{item.Score}", $"{item.Name}");
                        break;
                    case 5:
                        Console.WriteLine(Layout, $"{hs++}th", $"#{item.Score}", $"{item.Name}");
                        break;
                }
            }
            Console.WriteLine();
            Line.Length(50);
            // end

            //back to main menu
            MainMenuClasses.ToMainMenu.Back();
            //end
        }
    }
}
