using System;

namespace Liczby_Pierwsze_438
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            n = Console.ReadLine();
            for (int i = 0; i < int.Parse(n); i++)
            {
                string line;
                line = Console.ReadLine();

                int number = int.Parse(line);
                if(number == 0 || number == 1) Console.WriteLine("NIE");
                else if (IsPrime(number))
                {
                    Console.WriteLine("TAK");
                }
                else
                {
                    Console.WriteLine("NIE");
                }
            }
        }
        static bool IsPrime(int number)
        {
            for (int i = 2; i < number + 1 / 2; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

    }

    
}

