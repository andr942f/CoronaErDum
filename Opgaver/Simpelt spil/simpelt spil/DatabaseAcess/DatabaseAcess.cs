using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace simpelt_spil.DatabaseAcess
{
    //stored procedure is a way to store queries, very easy, very handy

    class DatabaseAcess
    {
        /// <summary>
        /// Insert a highscore when game is completed
        /// </summary>
        /// <param name="Name">Name of player</param>
        /// <param name="Score">Score of player</param>
        public void InsertHighscore(string Name, int Score)
        {
            //make an sql connection from the "DB" name in app config
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("DB")))
            {
                //make a new entry through the name and score in newentry and in this class (connect the two)
                NewEntry newHighscore = new NewEntry { Name = Name, Score = Score };
                List<NewEntry> Highscore = new List<NewEntry>();

                //Add the connection to a new list
                Highscore.Add(newHighscore);

                //execute the stored procedure: INSERT INTO Highscore VALUES(Name, Score); from the newHighscore info (List will be used to view the info int the program)
                connection.Execute("dbo.NewScore @Name, @Score", newHighscore);
            }
        }
        /// <summary>
        /// View top five people in the highscore
        /// </summary>
        /// <returns></returns>
        public List<NewEntry> ViewAll()
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("DB")))
            {
                //return the stored procedure: SELECT * FROM Highscore ORDER BY Score DESC
                return connection.Query<NewEntry>("dbo.ViewAll").ToList();
            }
        }
    }
}
