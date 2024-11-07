namespace ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            int goalsGirona, goalsOtherTeam, totalPoints;
            string line;

            //Initial Values
            StreamReader file = new StreamReader("Girona lliga23_24.txt");
            totalPoints = 0;

            line = file.ReadLine();
            
            //Algorithms and Calculus
            while (Convert.ToInt32(line) != -1)
            {
                goalsGirona = Convert.ToInt32(line);

                line = file.ReadLine();
                goalsOtherTeam = Convert.ToInt32(line);

                if (goalsGirona > goalsOtherTeam)
                    totalPoints += 3;
                else if (goalsGirona == goalsOtherTeam)
                    totalPoints += 1;

                line = file.ReadLine();
            }
            file.Close();

            //Output Values
            Console.WriteLine($"The Girona got a total of {totalPoints} this season");
        }
    }
}
