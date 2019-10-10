using System;
namespace Samolot_1502
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] string_numbers = line.Split(' ');

            int r1 = int.Parse(string_numbers[0]);
            int s1 = int.Parse(string_numbers[1]);
            int r2 = int.Parse(string_numbers[2]);
            int s2 = int.Parse(string_numbers[3]);

            Console.WriteLine("{0}", (r1 * s1) + (r2 * s2));
            //Console.ReadLine();
        }
    }
}
