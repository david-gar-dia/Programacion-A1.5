namespace ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Variable Declaration
            StreamReader file = new StreamReader("bonus.txt");
            Random rng = new Random();
            string line;
            int count, bonusCount, bonusValue;

            //Initial Values
            count = 0;
            bonusCount = 0;
            line = file.ReadLine();

            while (line != null)
            {
                count++;

                if (line == "BONUS")
                {
                    bonusCount++;
                    bonusValue = rng.Next(1, 11);
                    Console.WriteLine($"The BONUS tcket {bonusCount} will receive a value of {bonusValue}€");
                }

                line = file.ReadLine();
            }
            file.Close();

            //Output Values
            Console.WriteLine($"In total, a percentage of {Math.Round((double)bonusCount / count * 100, 2)}% of a total of {count} tickets had a bonus");
        }
    }
}
