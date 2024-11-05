using System.Globalization;

namespace ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            int number, count, numDigits;
            double checkOperation;

            //Initial Values
            Console.Write("Introduce a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            numDigits = 0;
            count = 0;
            checkOperation = 1;

            //Algorithms and Calculus
            while (checkOperation >= 1)
            {
                numDigits++;
                count++;

                checkOperation = number / Math.Pow(10, count);
            }

            //Output Values
            Console.WriteLine($"The number {number} has {numDigits} digits");
        }
    }
}
