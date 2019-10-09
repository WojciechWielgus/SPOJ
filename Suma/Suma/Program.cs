using System;


namespace Suma
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                sum += int.Parse(line);
                Console.WriteLine(sum);
            }
        }
    }
}
