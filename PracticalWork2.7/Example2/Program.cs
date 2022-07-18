using System;


namespace Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  ЕГЭ  ");
            Console.Write("Введите сумму баллов: ");
            double sumScores = double.Parse(Console.ReadLine());
            Console.Write("Введите количество сданных предметов: ");
            int subjects = int.Parse(Console.ReadLine());
            double averageScore = (double)(sumScores / subjects);

            Console.WriteLine($"Средний балл:{Math.Round(averageScore,1)}");

            Console.ReadKey();
        }
    }
}