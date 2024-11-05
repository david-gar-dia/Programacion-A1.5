namespace ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            StreamReader file = new StreamReader("NUMEROS.TXT");
            string line;
            int number, biggestNumber, smallestNumber;

            //Initial Values
            line = file.ReadLine();
            biggestNumber = int.MinValue;
            smallestNumber = int.MaxValue;

            //Algorithms and Calculus
            while (line != null)
            {
                number = Convert.ToInt32(line);

                if (number > biggestNumber)
                    biggestNumber = number;
                else if (number < smallestNumber)
                    smallestNumber = number;

                line = file.ReadLine();
            }
            file.Close();

            //Output Values
            Console.WriteLine($"The smallest number in the list is {smallestNumber} and the biggest number in the list is {biggestNumber}");
        }
    }
}
