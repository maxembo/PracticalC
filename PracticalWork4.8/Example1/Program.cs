using System;

namespace Example1
{
    internal class Program
    {
        static void Main()
        {
            //Задание 1. Случайная матрица
            Random rand = new Random();

            int sum = 0;

            Console.Write("\nВведите количество строк: ");
            int n = int.Parse(s: Console.ReadLine());

            Console.Write("\nВведите количество столбцов: ");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];

            Console.WriteLine("\nВыходная матрица:\n");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(0, 10);
                    Console.Write(matrix[i, j] + " ");
                     sum += matrix[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\nСумма всех элементов: {sum}");

        }
    }
}