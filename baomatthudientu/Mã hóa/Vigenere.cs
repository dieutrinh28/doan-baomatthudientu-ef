using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baomatthudientu
{
    class Vigenere
    {
        public static string Encipher(string plainText, string key)
        {
            string result = "";
            string inputText = plainText.ToLower();
            StringBuilder input = new StringBuilder(inputText);

            int idex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    input[i] = (char)(input[i] + key[idex] - 'a');
                    if (input[i] > 'z')
                    {
                        input[i] = (char)(input[i] - 'z' + 'a' - 1);
                    }
                }
                idex = idex + 1 == key.Length ? 0 : idex + 1;
            }
            result = input.ToString();
            return result;
        }

        public static string Decipher(string enText, string key)
        {
            string result = "";
            if(enText != "")
            {
                string inputText = enText.ToLower();
                StringBuilder input = new StringBuilder(inputText);

                int idex = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsLetter(input[i]))
                    {
                        input[i] = input[i] >= key[idex] ?
                            (char)(input[i] - key[idex] + 'a') :
                            (char)('a' + ('z' - key[idex] + input[i] - 'a') + 1);
                    }
                    idex = idex + 1 == key.Length ? 0 : idex + 1;
                }
                result = input.ToString();
            }
            
            return result;
        }
    }
}
