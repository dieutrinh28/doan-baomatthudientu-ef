using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baomatthudientu
{
    class PlayFair
    {
        public static string Encipher(string PlainText, string key)
        {
            string result = "";
            if(PlainText != "")
            {
                List<string> splittedText = Split(PlainText);
                char[,] matrix = GenerateMatrix(key);
                foreach (string pair in splittedText)
                {
                    int row1 = 0;
                    int col1 = 0;
                    int row2 = 0;
                    int col2 = 0;

                    char l1 = char.ToLower(pair[0]);
                    char l2 = char.ToLower(pair[1]);

                    GetPosition(matrix, l1, ref row1, ref col1);
                    GetPosition(matrix, l2, ref row2, ref col2);

                    if (row1 == row2)
                    {
                        if (col1 == 4)
                        {
                            result += matrix[row1, 0];
                            result += matrix[row1, col2 + 1];
                        }
                        else if (col2 == 4)
                        {
                            result += matrix[row1, col1 + 1];
                            result += matrix[row1, 0];
                        }
                        else
                        {
                            result += matrix[row1, col1 + 1];
                            result += matrix[row1, col2 + 1];
                        }
                    }
                    else if (col1 == col2)
                    {
                        if (row1 == 4)
                        {
                            result += matrix[0, col1];
                            result += matrix[row2 + 1, col1];
                        }
                        else if (row2 == 4)
                        {
                            result += matrix[row1 + 1, col1];
                            result += matrix[0, col1];
                        }
                        else
                        {
                            result += matrix[row1 + 1, col1];
                            result += matrix[row2 + 1, col1];
                        }
                    }
                    else
                    {
                        result += matrix[row1, col2];
                        result += matrix[row2, col1];
                    }
                }
            }
            

            return result;
        }
        public static string Decipher(string EnText, string key)
        {
            string result = "";
            string result2 = "";
            if (EnText != "")
            {
                List<string> splittedText = Split(EnText);
                char[,] matrix = GenerateMatrix(key);
                foreach (string pair in splittedText)
                {
                    int row1 = 0;
                    int col1 = 0;
                    int row2 = 0;
                    int col2 = 0;

                    char l1 = char.ToLower(pair[0]);
                    char l2 = char.ToLower(pair[1]);

                    GetPosition(matrix, l1, ref row1, ref col1);
                    GetPosition(matrix, l2, ref row2, ref col2);

                    if (row1 == row2)
                    {
                        if (col1 == 0)
                        {
                            result += matrix[row1, 4];
                            result += matrix[row1, col2 - 1];
                        }
                        else if (col2 == 0)
                        {
                            result += matrix[row1, col1 - 1];
                            result += matrix[row1, 4];
                        }
                        else
                        {
                            result += matrix[row1, col1 - 1];
                            result += matrix[row1, col2 - 1];
                        }
                    }
                    else if (col1 == col2)
                    {
                        if (row1 == 0)
                        {
                            result += matrix[4, col1];
                            result += matrix[row2 - 1, col1];
                        }
                        else if (row2 == 0)
                        {
                            result += matrix[row1 - 1, col1];
                            result += matrix[4, col1];
                        }
                        else
                        {
                            result += matrix[row1 - 1, col1];
                            result += matrix[row2 - 1, col1];
                        }
                    }
                    else
                    {
                        result += matrix[row1, col2];
                        result += matrix[row2, col1];
                    }
                }
                List<string> splitresult = new List<string>();

                int index = 0;
                while (index < result.Length)
                {
                    splitresult.Add(result.Substring(index, 2));
                    index += 2;
                }
                for (int i = 0; i < splitresult.Count; i++)
                {
                    if (i == splitresult.Count - 1)
                    {
                        if (splitresult[i][1] == 'x')
                        {

                            splitresult[i] = splitresult[i].Remove(1);

                        }
                    }
                    else if (splitresult[i].IndexOf('x') != -1)
                    {
                        if (splitresult[i][0] == splitresult[i + 1][0])
                        {
                            splitresult[i] = splitresult[i].Remove(1);
                        }
                    }
                }

                foreach (string s in splitresult)
                {
                    result2 += s;
                }
            }

            return result2;
        }
        private static char[,] GenerateMatrix(string key)
        {
            string finalkey = key.ToLower();
            char[,] matrix = new char[5, 5];

            string duplicates = "";
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            int row = 0;
            int col = 0;

            foreach (char ch in finalkey)
            {
                if (col < 5)
                {
                    if (duplicates.IndexOf(ch) == -1)
                    {
                        if (ch == 'i')
                        {
                            matrix[row, col] = ch;
                            duplicates += ch;
                            duplicates += 'j';
                            col++;
                        }
                        else if (ch == 'j')
                        {
                            matrix[row, col] = ch;
                            duplicates += ch;
                            duplicates += 'i';
                            col++;
                        }
                        else
                        {
                            matrix[row, col] = ch;
                            duplicates += ch;
                            col++;
                        }
                    }
                }
                else
                {
                    row++;
                    col = 0;
                    if (duplicates.IndexOf(ch) == -1)
                    {
                        if (ch == 'i')
                        {
                            matrix[row, col] = ch;
                            duplicates += ch;
                            duplicates += 'j';
                            col++;
                        }
                        else if (ch == 'j')
                        {
                            matrix[row, col] = ch;
                            duplicates += ch;
                            duplicates += 'i';
                            col++;
                        }
                        else
                        {
                            matrix[row, col] = ch;
                            duplicates += ch;
                            col++;
                        }
                    }
                }
            }

            foreach (char ch in alphabet)
            {
                if (col < 5)
                {
                    if (duplicates.IndexOf(ch) == -1)
                    {
                        if (ch == 'i')
                        {
                            matrix[row, col] = ch;
                            duplicates += ch;
                            duplicates += 'j';
                            col++;
                        }
                        else if (ch == 'j')
                        {
                            matrix[row, col] = ch;
                            duplicates += ch;
                            duplicates += 'i';
                            col++;
                        }
                        else
                        {
                            matrix[row, col] = ch;
                            duplicates += ch;
                            col++;
                        }
                    }
                }
                else
                {
                    row++;
                    col = 0;
                    if (duplicates.IndexOf(ch) == -1)
                    {
                        if (ch == 'i')
                        {
                            matrix[row, col] = ch;
                            duplicates += ch;
                            duplicates += 'j';
                            col++;
                        }
                        else if (ch == 'j')
                        {
                            matrix[row, col] = ch;
                            duplicates += ch;
                            duplicates += 'i';
                            col++;
                        }
                        else
                        {
                            matrix[row, col] = ch;
                            duplicates += ch;
                            col++;
                        }
                    }
                }
            }

            return matrix;
        }

        private static List<string> Split(string plainText)
        {
            List<string> result = new List<string>();
            if (plainText != "")
            {
                int index = 0;
                while (index < plainText.Length)
                {
                    if (index == plainText.Length - 1 || plainText[index] == plainText[index + 1])
                    {
                        result.Add(plainText[index] + "x");
                        index++;
                    }
                    else
                    {
                        result.Add(plainText.Substring(index, 2));
                        index += 2;
                    }
                }
            }
            else
            {
                result.Add("");
            }
            return result;
        }

        private static void GetPosition(char[,] matrix, char ch, ref int row, ref int col)
        {
            if (ch == 'j' || ch == 'i')
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (matrix[i, j] == 'j' || matrix[i, j] == 'i')
                        {
                            row = i;
                            col = j;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (matrix[i, j] == ch)
                        {
                            row = i;
                            col = j;
                        }
                    }
                }
            }
        }
    }
}
