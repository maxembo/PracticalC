using System;

namespace Example1_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            Split(Console.ReadLine());
        }
        /// <summary>
        /// Метод,выполняющий разделение строки на слова
        /// </summary>
        /// <param name="senctence"></param>
        static void Split(string senctence)
        {
            string[] words = senctence.Split(' ', StringSplitOptions.RemoveEmptyEntries);//Параметр StringSplitOptions.RemoveEmptyEntries удаляет все пустые подстроки

            Console.WriteLine("Результат:");
            foreach (string result in words)
            {
                Console.WriteLine($"{result}");
            }
        }
    }
}