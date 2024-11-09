namespace ex15b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            StreamReader file = new StreamReader("Girona lliga23_24.txt");
            int goalsGirona, goalsOtherTeam, totalPoints, gamesWon, gamesLost, gamesTied, count, countGames;
            string line;

            //Initial Values
            totalPoints = 0;
            goalsGirona = 0;
            goalsOtherTeam = 0;
            gamesWon = 0;
            gamesLost = 0;
            gamesTied = 0;
            count = 0;
            countGames = 0;

            line = file.ReadLine();

            //Algorithms and Calculus
            while (Convert.ToInt32(line) != -1)
            {
                if (count % 2 == 0)
                {
                    if (countGames % 2 == 0)
                        goalsOtherTeam = Convert.ToInt32(line);
                    else
                        goalsGirona = Convert.ToInt32(line);
                }
                else
                {
                    if (countGames % 2 == 0)
                        goalsGirona = Convert.ToInt32(line);
                    else
                        goalsOtherTeam = Convert.ToInt32(line);

                    if (goalsGirona > goalsOtherTeam)
                    {
                        totalPoints += 3;
                        gamesWon++;
                    }
                    else if (goalsGirona == goalsOtherTeam)
                    {
                        totalPoints += 1;
                        gamesTied++;
                    }
                    else
                        gamesLost++;

                    countGames++;
                }
                count++;
                line = file.ReadLine();
            }
            file.Close();

            //Output Values
            Console.WriteLine("The Girona team:");
            Console.WriteLine($"Has won: {gamesWon} matches");
            Console.WriteLine($"Has tied: {gamesTied} matches");
            Console.WriteLine($"Has lost: {gamesLost} matches");
            Console.WriteLine($"In total it scored {totalPoints} this season");
        }
    }
}