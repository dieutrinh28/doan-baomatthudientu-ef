using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baomatthudientu
{
    internal class RailFence
    {
        public static string Encipher(string plainText, int key)
        {
            string result = "";

            char[,] matrix = GenerateMatrix(plainText, key);



            for (int col = 0; col < matrix.GetLength(1); col++) //Creating the encrypted string
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    result += matrix[row, col];
                }
            }

            return result;
        }
        public static string Decipher(string EnText, int key)
        {
            string result = "";
            if (EnText != "")
            {
                char[,] matrix = GenerateMatrixForDecrypt(EnText, key);

                for (int row = 0; row < matrix.GetLength(0); row++) //Creating the encrypted string
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        result += matrix[row, col];
                    }
                }
                for (int i = result.Length - 1; i > 0; i--)
                {
                    if (result[i] == 'x')
                    {
                        result = result.Remove(i, 1);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return result;
        }
        private static char[,] GenerateMatrixForDecrypt(string EnText, int key)
        {
            char[,] matrix = new char[EnText.Length / key, key];
            int index = 0;

            for (int col = 0; col < matrix.GetLength(1); col++) //Putting chars into the matrix
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = EnText[index];
                    index++;

                }
            }
            return matrix;
        }
        private static char[,] GenerateMatrix(string plainText, int key)
        {
            if (plainText.Length % key == 0)
            {
                char[,] matrix = new char[plainText.Length / key, key];
                int index = 0;

                for (int row = 0; row < matrix.GetLength(0); row++) //Putting chars into the matrix
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (index >= plainText.Length && index <= matrix.GetLength(0) * matrix.GetLength(1))
                        {
                            matrix[row, col] = 'x';
                            index++;
                        }
                        else
                        {
                            matrix[row, col] = plainText[index];
                            index++;
                        }

                    }
                }
                return matrix;
            }
            else
            {
                char[,] matrix = new char[(plainText.Length / key) + 1, key];
                int index = 0;

                for (int row = 0; row < matrix.GetLength(0); row++) //Putting chars into the matrix
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (index >= plainText.Length && index <= matrix.GetLength(0) * matrix.GetLength(1))
                        {
                            matrix[row, col] = 'x';
                            index++;
                        }
                        else
                        {
                            matrix[row, col] = plainText[index];
                            index++;
                        }

                    }
                }
                return matrix;
            }
        }
    }
}
