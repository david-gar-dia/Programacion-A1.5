﻿namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            StreamReader file = new StreamReader("NUMEROS.TXT");
            string line;
            int count;

            //Initial Values
            line = file.ReadLine();
            count = 0;

            //Algorithms and Calculus
            while (line != null)
            {
                count++;
                line = file.ReadLine();
            }
            file.Close();
            
            //Output Values
            Console.WriteLine($"We have found {count} numbers");
        }
    }
}
