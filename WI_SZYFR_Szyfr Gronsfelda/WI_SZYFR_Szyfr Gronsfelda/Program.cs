using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WI_SZYFR_Szyfr_Gronsfelda
{
    class Program
    {
        public static string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        static void Main(string[] args)
        {
            //string input;
            //while((input = Console.ReadLine()) != null)
            //{
            //    string key = Console.ReadLine();
            //    string data = Console.ReadLine();
            //    switch (input)
            //    {
            //        case "SZYFRUJ":
            //            Console.WriteLine(Szyfruj(data, key));
            //            break;
            //        default:
            //            break;
            //    }
            //}

            //while(true)
            //{
            //    Console.Write("Podaj klucz: ");
            //    string key = Console.ReadLine();

            //    Console.Write("Podaj znak: ");
            //    string data = Console.ReadLine();

            //    Console.WriteLine("After shift: " + SwapChar(data, Convert.ToInt32(key)));
            //}

            Console.WriteLine(Szyfruj("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "34"));
            Console.ReadLine();
        }

        static string Szyfruj(string data, string key)
        {
            string new_word = "";
            char[] key_table = key.ToCharArray();
            Console.WriteLine("key_table[0]: " + key_table[0]);
            int key_operator = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (key_operator >= key_table.Length) key_operator = 0;
                int key_temp =Convert.ToInt32(key_table[key_operator].ToString());              
                new_word += SwapChar(data[i].ToString(), key_temp);
                key_operator++;
            }
            return new_word;
        }

        static string SwapChar(string currentChar, int shift)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == currentChar) return alphabet[(i + shift) % alphabet.Length];               
            }
            return null;
        }
    }
}
