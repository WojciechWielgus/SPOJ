using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP0604A_Średnia_arytmetyczna
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string[] data_table = Console.ReadLine().Split(' ');
                double[] numbers = new double[data_table.Length];
                //numbers[0] = 0;
                double sum = 0;
                for (int j = 0; j < data_table.Length; j++)
                {
                    numbers[j] = int.Parse(data_table[j]);
                    sum += numbers[j];
                    Console.WriteLine("Sum: {0}", sum);
                }
                double average = sum / numbers.Length;
                double closest_average = double.MaxValue;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (Math.Abs((average - numbers[j])) < closest_average) closest_average = numbers[j];
                }
                Console.WriteLine(closest_average);
                Console.WriteLine("average = " + average);
                
            }         
        }
    }
}
