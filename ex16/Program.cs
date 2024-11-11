using System.Globalization;

namespace ex16
{
    internal class Program
    {
        static double CalcModule(double x, double y)
        {
            double length;

            length = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            return length;
        }
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");

            //Variable Declaration
            StreamReader file = new StreamReader("coordenades.txt");
            double horizontalCoord, verticalCoord, radius;
            int count;
            string line;

            //Initial Values
            count = 0;
            horizontalCoord = 0;
            verticalCoord = 0;
            line = file.ReadLine();

            Console.Write("Introduce the radius of the circle for which you want to check if the points lie inside: ");
            radius = Convert.ToDouble(Console.ReadLine());

            //Algorithms and Calculus
            while (line != null)
            {
                if (count %2 == 0)
                    horizontalCoord = Convert.ToDouble(line);
                else
                {
                    line = file.ReadLine();
                    verticalCoord = Convert.ToDouble(line);

                    //Output Values
                    if (CalcModule(horizontalCoord, verticalCoord) < radius)
                        Console.WriteLine($"The point of the plane ({horizontalCoord},{verticalCoord}) lays inside the circle");
                    else if (CalcModule(horizontalCoord, verticalCoord) == radius)
                        Console.WriteLine($"The point of the plane ({horizontalCoord},{verticalCoord}) lays in the perimeter of the circle");
                    else
                        Console.WriteLine($"The point of the plane ({horizontalCoord},{verticalCoord}) lays outside the circle");
                }
                count++;
                line = file.ReadLine();
            }
            file.Close();
        }
    }
}
