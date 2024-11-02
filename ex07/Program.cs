namespace ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            int num, smallestNum, biggestNum;

            //Initial Values
            Console.Write("Introduce a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            smallestNum = num;
            biggestNum = num;

            //Algorithms and Calculus
            while (num != 0)
            {
                if (num > biggestNum)
                    biggestNum = num;
                else if (num < smallestNum)
                    smallestNum = num;

                Console.Write("Introduce a number: ");
                num = Convert.ToInt32(Console.ReadLine());
            }

            //Output Values
            Console.WriteLine($"The smalles number in the list is {smallestNum} and the biggest number in the list is {biggestNum}");
        }
    }
}
