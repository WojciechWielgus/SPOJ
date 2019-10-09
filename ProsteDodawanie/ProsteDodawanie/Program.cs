using System;


namespace ProsteDodawanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int numbers_count = int.Parse(Console.ReadLine());
                string text = Console.ReadLine();
                string[] text_tab = text.Split(' ');
                int sum = 0;
                for (int j = 0; j < text_tab.Length; j++)
                {
                    sum += int.Parse(text_tab[j]);
                }
                Console.WriteLine(sum);
            }
        }
    }
}
