using System;

namespace _522_Przedszkolanka
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string data = Console.ReadLine();
                string[] data_table =  data.Split(' ');

                Console.WriteLine(NWW(int.Parse(data_table[0]), int.Parse(data_table[1])));
            }
        }

        static int NWW(int a, int b)
        {
            for (int i = 1; i > 0; i++)
            {
                if ((i * a) % b == 0) return (i * a); 
            }

            return a * b;
        }
    }
}
