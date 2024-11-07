namespace ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            Random rng = new Random();
            int number1, number2, sumAns, diffAns, multAns, divAns, count;

            //Initial Values
            number1 = rng.Next(1, 101);
            number2 = rng.Next(1, 101);
            sumAns = number1;
            diffAns = number2;
            multAns = number1 - number2;
            divAns = number1 + number2;
            count = 1;

            //Algorithms and Calculus
            Console.Write($"What is the sum of {number1} and {number2}?: ");
            sumAns = Convert.ToInt32(Console.ReadLine());
            Console.Write($"What is the difference of {number1} and {number2}?: ");
            diffAns = Convert.ToInt32(Console.ReadLine());
            Console.Write($"What is the product of {number1} and {number2}?: ");
            multAns = Convert.ToInt32(Console.ReadLine());
            Console.Write($"What is the result of the entire division of {number1} and {number2}?: ");
            divAns = Convert.ToInt32(Console.ReadLine());

            while (sumAns != number1 + number2 || diffAns != number1 - number2 || multAns != number1 * number2 || divAns != number1 / number2)
            {
                Console.WriteLine("Your results were wrong, let's try again:");
                Console.WriteLine("");
                number1 = rng.Next(1, 101);
                number2 = rng.Next(1, 101);
                count++;

                Console.Write($"What is the sum of {number1} and {number2}?: ");
                sumAns = Convert.ToInt32(Console.ReadLine());
                Console.Write($"What is the difference of {number1} and {number2}?: ");
                diffAns = Convert.ToInt32(Console.ReadLine());
                Console.Write($"What is the product of {number1} and {number2}?: ");
                multAns = Convert.ToInt32(Console.ReadLine());
                Console.Write($"What is the result of the entire division of {number1} and {number2}?: ");
                divAns = Convert.ToInt32(Console.ReadLine());
            }

            //Output Values
            if (count == 1)
                Console.WriteLine($"Well done, it took you {count} try to get it right");
            else
                Console.WriteLine($"Well done, it took you {count} tries to get it right");

        }
    }
}
