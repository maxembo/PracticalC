using System;

namespace Example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.Игра "Угадай число"
            Console.Write("Введите максимальное число последовательности: ");
            int range = int.Parse(Console.ReadLine());

            Random random = new Random();
            int hiddenNumber = random.Next(0,range+1);
            string user = "0";
            int count = 0;

            for(; ; )
            {
                Console.Write("\nВведите число: ");
                user = Console.ReadLine();
                count++;

                if (user == "") 
                {
                    break;
                }
                else
                {
                    if (int.Parse(user) == hiddenNumber)
                    {
                        Console.WriteLine($"\nВы угадали!!!\nЗагадочное число: {hiddenNumber}\nКоличество попыток: {count}");
                        break;
                    }
                    else
                    {
                        if (int.Parse(user) > hiddenNumber)
                        {
                            Console.WriteLine("Загаданное число меньше!");
                        }
                        else
                        {
                            if (int.Parse(user) < hiddenNumber)
                            {
                                Console.WriteLine("Загаданное число больше!");
                            }
                        }
                    }
                }
            }
        }
    }
}