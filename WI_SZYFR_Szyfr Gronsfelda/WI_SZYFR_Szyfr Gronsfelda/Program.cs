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
            string input;
            while((input = Console.ReadLine()) != null)
            {
                string key = Console.ReadLine();
                string data = Console.ReadLine();
                switch (input)
                {
                    case "SZYFRUJ":
                        Console.WriteLine(Szyfruj(data, key));
                        break;
                    default:
                        break;
                }
            }
        }

        static string Szyfruj(string data, string key)
        {
            string new_word = "";
            int i = 0;
            int key_operator = 0;
            while (i < data.Length)
            {
                if (key_operator > key.Length) key_operator = 0;
                new_word += SwapChar(data[i].ToString(), Convert.ToInt32(key[key_operator]));
                i++;
                key_operator++;
            }
            return new_word;
        }

        static string SwapChar(string currentChar, int shift)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == currentChar)
                {
                    //if (i + shift <= alphabet.Length) return alphabet[i + shift];
                    return alphabet[(i + shift) % alphabet.Length];

                }
            }
            return null;
        }
    }
}
