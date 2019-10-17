using System;
using System.Globalization;


namespace _969_Równanie_kwadratowe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string[] data;
            while((data = Console.ReadLine().Split(' ')) != null)
            {
                double a = double.Parse(data[0], CultureInfo.InvariantCulture);
                double b = double.Parse(data[1], CultureInfo.InvariantCulture);
                double c = double.Parse(data[2], CultureInfo.InvariantCulture);

                Console.WriteLine(NumbersOfRoots(a, b, c));                
            }
        }

        static int NumbersOfRoots(double a, double b, double c)
        {
            double delta = b*b - 4 * a * c;
            if (delta > 0) return 2;
            if (delta < 0) return 0;
            else return 1;      
        }
    }
}
