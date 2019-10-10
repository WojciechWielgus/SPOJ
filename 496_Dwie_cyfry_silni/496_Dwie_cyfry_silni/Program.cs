using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _496_Dwie_cyfry_silni
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x < 10)
                {
                    int sum = 1;
                    for (int j = 2; j <= x; j++)
                    {
                        sum *= j;
                    }
                    int unit_digit = sum % 10;
                    int decimal_digit = (sum / 10) % 10;

                    Console.WriteLine("{0} {1}", decimal_digit, unit_digit);
                }
                else Console.WriteLine("0 0");
                
            }
        }
    }
}
