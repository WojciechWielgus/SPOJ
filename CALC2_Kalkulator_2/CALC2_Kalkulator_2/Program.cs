using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALC2_Kalkulator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;
            int[] memory = new int[10];
            while ((data = Console.ReadLine()) != null)
            {
                
                string[] data_table = data.Split(' ');
                int a = int.Parse(data_table[1]);
                int b = int.Parse(data_table[2]);

                switch (data_table[0])
                {
                    case "z":
                        memory[a] = b;
                        break;
                    case "+":
                        Console.WriteLine(memory[a] + memory[b]);
                        break;
                    case "-":
                        Console.WriteLine(memory[a] - memory[b]);
                        break;
                    case "*":
                        Console.WriteLine(memory[a] * memory[b]);
                        break;
                    case "/":
                        Console.WriteLine(memory[a] / memory[b]);
                        break;
                    default:
                        Console.WriteLine(memory[a] % memory[b]);
                        break;
                }

            }
        }
    }
}
