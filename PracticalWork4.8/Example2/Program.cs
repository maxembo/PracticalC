using System;

namespace Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 2. Наименьший элемент в последовательности

            int min = int.MaxValue;
            Console.Write("Введите длину последовательности: ");
            int lengthSequence = int.Parse(Console.ReadLine());
            
            
            int[] array = new int[lengthSequence];

            for (int i = 1; (i-1) < lengthSequence; i++)
            {
                Console.Write($"\nВведите {i} число: ");
                array[i-1] = int.Parse(Console.ReadLine());
                if( min > array[i-1]) min = array[i-1];
            }
          
            Console.WriteLine($"\nНаименьшее число в массиве: {min}");
        }
    }
}