using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayStringAndColumn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { {5,6,7,13,9}, {7,8,27,30,4}, {42,71,6,11,2} };
            int summaString = 0;
            int multiplicationColumn = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i,j]} ");
                    if (i == 2)
                    {
                        summaString += array[i,j];
                    }
                    if (j == 1)
                    {
                        multiplicationColumn *= array[i,j];
                    }
                }
                Console.WriteLine();
            }
            Console.Write($"сумму второй строки {summaString}" +
                $" и произведение первого столбца {multiplicationColumn}");
            Console.ReadKey();
        }
    }
}
