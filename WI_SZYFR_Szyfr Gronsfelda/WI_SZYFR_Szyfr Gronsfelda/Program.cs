using System;

namespace WI_SZYFR_Szyfr_Gronsfelda
{
    class Program
    {
        public static string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "")
            {
                string key = Console.ReadLine();
                string data = Console.ReadLine();
                if(input == "SZYFRUJ") Console.WriteLine(Szyfruj(data, key));
                else Console.WriteLine(Deszyfruj(data, key));
            }
        }

        static string Szyfruj(string data, string key)
        {
            string new_word = "";
            char[] key_table = key.ToCharArray();
            int key_operator = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (key_operator >= key_table.Length) key_operator = 0;
                int key_temp = Convert.ToInt32(key_table[key_operator].ToString());
                new_word += SwapChar(data[i].ToString(), key_temp);
                key_operator++;
            }
            return new_word;
        }

        static string Deszyfruj(string data, string key)
        {
            string new_word = "";
            char[] key_table = key.ToCharArray();
            int key_operator = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (key_operator >= key_table.Length) key_operator = 0;
                int key_temp = -Convert.ToInt32(key_table[key_operator].ToString());
                new_word += SwapChar(data[i].ToString(), key_temp);
                key_operator++;
            }
            return new_word;
        }

        static string SwapChar(string currentChar, int shift)
        {
            for (int i = 0; i < alphabet.Length; i++)
                if (alphabet[i] == currentChar)
                {
                    if (shift > 0) return alphabet[(i + shift) % alphabet.Length];
                    else
                    {
                        if (i + shift < 0) return alphabet[alphabet.Length + shift];
                        else return alphabet[i + shift];
                    }
                }
            return null;
        }
    }
}
