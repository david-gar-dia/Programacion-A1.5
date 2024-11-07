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
            Console.Write("Introduce the radius of the circle for which you want to check if the points lie inside: ");
            radius = Convert.ToDouble(Console.ReadLine());

            count = 0;
            line = file.ReadLine();

            //Algorithms and Calculus
            while (line != null)
            {
                count++;

                horizontalCoord = Convert.ToDouble(line);

                line = file.ReadLine();
                verticalCoord = Convert.ToDouble(line);
                
                //Output Values
                if (CalcModule(horizontalCoord, verticalCoord) < radius)
                    Console.WriteLine($"The point of the plane ({horizontalCoord},{verticalCoord}) lays inside the circle");
                else if (CalcModule(horizontalCoord, verticalCoord) == radius)
                    Console.WriteLine($"The point of the plane ({horizontalCoord},{verticalCoord}) lays in the perimeter of the circle");
                else 
                    Console.WriteLine($"The point of the plane ({horizontalCoord},{verticalCoord}) lays outside the circle");

                line = file.ReadLine();
            }
            file.Close();
        }
    }
}
