using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _601_NWD
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string data = Console.ReadLine();
                string[] data_table = data.Split(' ');

                Console.WriteLine(NWD(int.Parse(data_table[0]), int.Parse(data_table[1])));
            }
        }

        static int NWD(int a, int b)
        {
            if (b != 0)
                return NWD(b, a % b);
            return a;
        }
    }
}
