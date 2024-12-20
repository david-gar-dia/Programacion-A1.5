﻿namespace ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            int goalsGirona, goalsOtherTeam, totalPoints, gamesWon, gamesLost, gamesTied, count;
            string line;

            //Initial Values
            StreamReader file = new StreamReader("Girona lliga23_24.txt");
            totalPoints = 0;
            goalsGirona = 0;
            goalsOtherTeam = 0;
            gamesWon = 0;
            gamesLost = 0;
            gamesTied = 0;
            count = 0;

            line = file.ReadLine();
            
            //Algorithms and Calculus
            while (Convert.ToInt32(line) != -1)
            {
                if (count % 2 == 0)
                {
                    goalsOtherTeam = Convert.ToInt32(line);
                }
                else
                {
                    goalsGirona = Convert.ToInt32(line);

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
