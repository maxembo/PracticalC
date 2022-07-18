using System;

namespace Example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Проверка простого числа
            Console.Write("Введите любое число: ");
            int n = int.Parse(Console.ReadLine());
            bool result = false;
            int i = 2;
            while((n - 1) >= i)
            {
                if( n % i == 0)
                {
                    result = true;
                    break;
                }
                i++;
            }
            if (result)
                Console.WriteLine("непростое число");
            else
                Console.WriteLine("простое число");
            
            Console.ReadKey();
        }
    }
}