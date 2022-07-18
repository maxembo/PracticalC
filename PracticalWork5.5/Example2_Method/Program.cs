using System;

namespace Example2_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            Split(Console.ReadLine());
        }
        /// <summary>
        /// Метод,выполняющий разделение строки на слова и перестановку слов в предложении
        /// </summary>
        /// <param name="senctence"></param>
        static void Split(string senctence)
        {
            string[] words = senctence.Split(' ', StringSplitOptions.RemoveEmptyEntries);//Параметр StringSplitOptions.RemoveEmptyEntries удаляет все пустые подстроки

            Console.WriteLine("Результат:");
            ReversWords(words);
        }
        /// <summary>
        /// Метод, выполняющий перестановку слов в предложении
        /// </summary>
        /// <param name="words"></param>
        static void ReversWords(string[] words)
        {
            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"{words[i]}");
            }
        }
    }
}
