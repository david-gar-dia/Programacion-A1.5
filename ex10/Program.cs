namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            int count, num, timesOne, timesSix;
            Random rnd = new Random();

            //Initial Values
            timesOne = 0;
            timesSix = 0;

            num = rnd.Next(1, 7);

            count = 1;

            if (num == 1)
                timesOne++;
            else if (num == 6)
                timesSix++;

            //Algorithms and Calculus
            while (timesOne != timesSix || timesSix == 0)
            {
                num = rnd.Next(1, 7);
                count++;

                if (num == 1)
                    timesOne++;
                else if (num == 6)
                    timesSix++;
            }

            //Output Values
            Console.WriteLine($"We have thrown the dice {count} times and {timesSix} times it has landed on six");
        }
    }
}
