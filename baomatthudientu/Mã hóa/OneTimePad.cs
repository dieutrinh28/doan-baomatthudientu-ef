using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baomatthudientu
{
    internal class OneTimePad
    {
        public static string key(string key, int textLength)
        {
            key = key.Substring(0, textLength);
            return key;
        }
        public static string Encipher(string plainText, string key)
        {
            string result = "";
            int[] num = new int[plainText.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                num[i] = (plainText[i] - 'a') + (key[i] - 'a');

            }
            for (int i = 0; i < plainText.Length; i++)
            {
                if (num[i] > 25)
                {
                    num[i] = num[i] - 26;
                }
            }
            for (int i = 0; i < plainText.Length; i++)
            {
                int x = num[i] + 'a';
                result += (char)x;
            }

            return result;
        }

        public static string Decipher(string enText, string key)
        {
            string result = "";
            if (enText != "")
            {
                int[] num = new int[enText.Length];

                for (int i = 0; i < enText.Length; i++)
                {
                    num[i] = (enText[i] - 'a') - (key[i] - 'a');

                }
                for (int i = 0; i < enText.Length; i++)
                {
                    if (num[i] < 0)
                    {
                        num[i] = num[i] + 26;
                    }
                }
                for (int i = 0; i < enText.Length; i++)
                {
                    int x = num[i] + 'a';
                    result += (char)x;
                }
            }
            return result;
        }
    }
}
