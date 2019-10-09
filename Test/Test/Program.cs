using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {     
        static void Main(string[] args)
        {
            int test_count = 0;
            for (int i = 0; i < test_count; i++)
            {
                int value = Console.Read();
                string result;
                if (IsPrimaryNumber(value)) Console.WriteLine("TAK"); else Console.WriteLine("NIE");


            }

            System.Console.ReadLine(); 
            
        }

        public static bool IsPrimaryNumber(int value)
        {
            for (int i = 2; i < value/2; i++)
            {
                if (value % i == 0) return false;
            }  
            return true;
        }
    }


}
