namespace ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            StreamReader file = new StreamReader("NUMEROS.TXT");
            string line;
            int countPositives, countNegatives, number;

            //Initial Values
            line = file.ReadLine();
            countPositives = 0;
            countNegatives = 0;

            while (line != null)
            {
                number = Convert.ToInt32(line);

                if (number > 0)
                    countPositives++;
                else if (number < 0)
                    countNegatives++;

                line = file.ReadLine();
            }
            file.Close();

            //Output Values
            Console.WriteLine($"You have introduced {countPositives} positive numbers and {countNegatives} negative numbers");
        }
    }
}
