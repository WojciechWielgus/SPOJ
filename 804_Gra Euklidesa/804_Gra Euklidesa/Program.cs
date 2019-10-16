using System;

namespace _804_Gra_Euklidesa
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] players = Console.ReadLine().Split(' ');
                int a = int.Parse(players[0]);
                int b = int.Parse(players[1]);
                Console.WriteLine(Game(a, b));
            }
        }

        static int Game(int a, int b)
        {
            if (a > b)
            {
                if (a - b > 0) return Game(a - b, b);
            }
            if (b > a)
            {
                if (b - a > 0) return Game(a, b - a);
            }
            return a + b;
        }

    }
}
