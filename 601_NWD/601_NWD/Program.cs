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
            if(a >= b) for (int i = b; i > 0; i--) if (a % i == 0 && b % i == 0) return i;
            if (b >= a) for (int i = a; i > 0; i--) if (a % i == 0 && b % i == 0) return i;
            return 1;
        }
    }
}
