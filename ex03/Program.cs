﻿namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            int countPositives, countNegatives, num;

            //Initial Values
            countPositives = 0;
            countNegatives = 0;

            Console.Write("Introduce a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Algorithms and Calculus
            while (num != 0)
            {   
                if (num > 0)
                    countPositives++;
                else if (num < 0)
                    countNegatives++;

                Console.Write("Introduce a number: ");
                num = Convert.ToInt32(Console.ReadLine());
            }

            //Output Values
            Console.WriteLine($"You have introduced {countPositives} positive numbers and {countNegatives} negative numbers");
        }
    }
}
