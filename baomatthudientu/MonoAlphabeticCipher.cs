using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baomatthudientu
{
    internal class MonoAlphabeticCipher
    {
        static string Encrypt(string plainText, string key)
        {

            char[] chars = new char[plainText.Length];
            for (int i = 0; i < plainText.Length; i++)
            {
                if (char.IsLetter(plainText[i]) == false)
                {
                    chars[i] = plainText[i];
                }
                else
                {
                    int j = plainText[i] - 97;
                    chars[i] = key[j];
                }
            }

            return new string(chars);
        }
        static string Decrypt(string cipherText, string key)
        {
            char[] chars = new char[cipherText.Length];
            if(cipherText != "")
            {
                for (int i = 0; i < cipherText.Length; i++)
                {
                    if (cipherText[i] == ' ')
                    {
                        chars[i] = ' ';
                    }
                    else
                    {
                        int j = key.IndexOf(cipherText[i]) + 97;
                        chars[i] = (char)j;
                    }
                }
            }
            return new string(chars);
        }
    }
}
