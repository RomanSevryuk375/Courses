using System;

namespace H7_T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = { { 1, 19, 3 }, { 22, 5, 6 } , { 7, 52, 9} };
            int rows = numbers.GetUpperBound(0) + 1;
            int columns = numbers.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{numbers[i, j]} \t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 3; ++i)
            {
                int max = numbers[i, 0];
                for (int j = 1; j < 3; ++j)
                {
                    if (numbers[i, j] > max)
                    {
                        max = numbers[i, j];
                    }
                }
                Console.WriteLine($"Row {i + 1}: {max}");
            }
        }
    }
}
