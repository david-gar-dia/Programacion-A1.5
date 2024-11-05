namespace ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            StreamReader file = new StreamReader("NUMEROS2.TXT");
            string line;
            int number, count, sum;
            double average;

            //Initial Values
            line = file.ReadLine();
            count = 0;
            sum = 0;

            //Algorithms and Calculus
            while (line != null)
            {
                number = Convert.ToInt32(line);
                sum += number;
                count++;

                line = file.ReadLine();
            }
            file.Close();

            average = (double) sum / count;

            //Ouput Values
            Console.WriteLine($"The average of every value is {average}");
        }
    }
}
