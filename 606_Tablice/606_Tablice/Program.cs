using System;

namespace _606_Tablice
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
                string[] reverse_data_table = new string[data_table.Length - 1];
                for (int j = 0; j < int.Parse(data_table[0]); j++)
                {
                    reverse_data_table[j] = data_table[data_table.Length - j - 1];
                }
                string output = "";
                for (int j = 0; j < reverse_data_table.Length; j++)
                {
                    if (j != 0) output += " "; 
                    output += reverse_data_table[j];                   
                }
                Console.WriteLine(output);               
            }
        }
    }
}
