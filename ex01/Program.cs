namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            int cont, num;

            //Initial Values
            Console.Write("Introduce a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            cont = 1;

            //Algorithms and Calculus
            while (num != 0)
            {
                Console.Write("Introduce a number: ");
                num = Convert.ToInt32(Console.ReadLine());
                cont++;
            }

            //Output Values
            Console.WriteLine($"You have introduced {cont} numbers");
        }
    }
}
