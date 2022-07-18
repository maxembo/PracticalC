using System;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Popov Maxim Romanovich", email = "maxim.popov1234@mail.ru";
            double progrScores = 65.6, mathScores = 78.3, physicsScores = 59.1;
            int age = 20;

            Console.WriteLine($"ФИО: {fullName}\n" +
                              $"Возраст: {age}\n" +
                              $"Email: {email}\n" +
                              $"Баллы по программированию: {progrScores}\n" +
                              $"Баллы по математике: {mathScores}\n" +
                              $"Баллы по физике: {physicsScores}");

            Console.ReadKey();
        }
    }
}
