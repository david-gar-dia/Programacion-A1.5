namespace ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            int count, num, totalSum;
            double average;

            //Initial Values
            count = 0;
            totalSum = 0;

            Console.Write("Introduce a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Algorithms and Calculus
            while (num != 0)
            {
                count++;
                totalSum += num;

                Console.Write("Introduce a number: ");
                num = Convert.ToInt32(Console.ReadLine());
            }

            average = (double) totalSum / count;

            //Output Values
            Console.WriteLine($"The average of all the introduced numbers is {average}");
        }
    }
}
