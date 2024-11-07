using System.Globalization;

namespace ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            int number, count, checkOperation;

            //Initial Values
            Console.Write("Introduce a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            count = 0;
            checkOperation = number;

            //Algorithms and Calculus
            while (checkOperation != 0)
            {
                count++;
                checkOperation = (int)(number / Math.Pow(10, count));
            }

            //Output Values
            Console.WriteLine($"The number {number} has {count} digits");
        }
    }
}
