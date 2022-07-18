using System;

namespace Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите любое число: ");
            int value = int.Parse(Console.ReadLine());
            
            if (value % 2 == 0)
                Console.WriteLine($"Это четное число: {value}");
            else 
                Console.WriteLine($"Это нечетное число: {value}");
           
            Console.ReadKey();
        }
    }
   
}