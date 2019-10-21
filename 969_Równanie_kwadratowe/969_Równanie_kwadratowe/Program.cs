using System;
using System.Globalization;


namespace _969_Równanie_kwadratowe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string data;
            string[] tab;
            while((data = Console.ReadLine()) != null)
            {
                tab = data.Split(' ');
                double a = double.Parse(tab[0], CultureInfo.InvariantCulture);
                double b = double.Parse(tab[1], CultureInfo.InvariantCulture);
                double c = double.Parse(tab[2], CultureInfo.InvariantCulture);

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
