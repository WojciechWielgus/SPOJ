using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _997_Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;
            while((data = Console.ReadLine()) != null)
            {
                string[] data_table = data.Split(' ');
                int a = int.Parse(data_table[1]);
                int b = int.Parse(data_table[2]);

                switch (data_table[0])
                {
                    case "+":
                        Console.WriteLine(a + b);
                        break;
                    case "-":
                        Console.WriteLine(a - b);
                        break;
                    case "*":
                        Console.WriteLine(a * b);
                        break;
                    case "/":
                        Console.WriteLine(a / b);
                        break;
                    default:
                        Console.WriteLine(a % b);
                        break;
                }
            }
        }
    }
}
