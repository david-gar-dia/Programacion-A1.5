namespace ex15b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            StreamReader file = new StreamReader("Girona lliga23_24(visitant-local).txt");
            int goalsGirona, goalsOtherTeam, totalPoints, gamesWon, gamesLost, gamesTied, count;
            string line;
            bool local;

            //Initial Values
            totalPoints = 0;
            goalsGirona = 0;
            goalsOtherTeam = 0;
            gamesWon = 0;
            gamesLost = 0;
            gamesTied = 0;
            count = 0;
            local = false;

            line = file.ReadLine();

            //Algorithms and Calculus
            while (line != null)
            {
                if (count % 2 == 0)
                {
                    if (local)
                        goalsGirona = Convert.ToInt32(line);
                    else
                        goalsOtherTeam = Convert.ToInt32(line);
                }
                else
                {
                    if (!local)
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

                    local = !local;
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