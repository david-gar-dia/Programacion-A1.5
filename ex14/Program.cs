namespace ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Variable Declaration
            StreamReader file = new StreamReader("BONUS2.TXT");
            string line;
            int totalEarning, bonusCount, bonusValue;

            //Initial Values
            totalEarning = 0;
            bonusCount = 0;
            line = file.ReadLine();

            while (line != null)
            {
                if (line == "BONUS")
                {
                    bonusCount++;
                    line = file.ReadLine();
                    bonusValue = Convert.ToInt32(line);
                    totalEarning += bonusValue;
                    Console.WriteLine($"The BONUS ticket {bonusCount} will receive a value of {bonusValue}€");
                }

                line = file.ReadLine();
            }
            file.Close();

            //Output Values
            Console.WriteLine($"In total, there were {bonusCount} winning tickets which amounted a total of {totalEarning}€");
        }
    }
}
