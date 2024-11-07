namespace ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            StreamReader file = new StreamReader("alumnesDAMDAW.txt");
            string line;
            int countAlex, countIker;

            //Initial Values
            countAlex = 0;
            countIker = 0;
            line = file.ReadLine();

            //Algorithms and Calculus
            while (line != null)
            {
                if (line == "Alex")
                    countAlex++;
                else if (line == "Iker")
                    countIker++;

                line = file.ReadLine();
            }
            file.Close();

            //Output Values
            if (countAlex > countIker)
                Console.WriteLine("There are more students named Alex than Iker");
            else if (countAlex < countIker)
                Console.WriteLine("There are more students named Iker than Alex");
            else
                Console.WriteLine("There is the same amount of students named Iker as there are named Alex");
        }
    }
}
