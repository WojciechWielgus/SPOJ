using System;

namespace _499_Czy_umiesz_potęgować
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(' ');
                int baseOfPower = int.Parse(data[0]);
                int index = int.Parse(data[1]);
                if(index%4 != 0)Console.WriteLine((int)(Math.Pow((baseOfPower % 10), (index)%4) % 10));
                else Console.WriteLine((int)(Math.Pow((baseOfPower % 10), 4) % 10));
              
            }
        }
    }
}
