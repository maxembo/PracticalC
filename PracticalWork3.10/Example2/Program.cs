using System;

namespace Example1
{
     internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в карточную игру Blacjack");
            Console.Write("Введите количество карт: ");

            int totalCards = int.Parse(Console.ReadLine());
            int sumTotalCards = 0;
            
            Console.WriteLine("Введите номинал каждой карты");
            for(int i = 0; i < totalCards;i++)
            {
                string card = Console.ReadLine();

                switch (card)
                {
                    case "6": sumTotalCards += 6; break;
                    case "7": sumTotalCards += 7; break;
                    case "8": sumTotalCards += 8; break;
                    case "9": sumTotalCards += 9; break;       
                    case "10": sumTotalCards += 10; break;
                    case "J": sumTotalCards += 10; break;
                    case "Q": sumTotalCards += 10; break;
                    case "K": sumTotalCards += 10; break;
                    case "T": sumTotalCards += 10; break;
                        default:
                        Console.WriteLine("Такой карты не сущетсвует!!!");
                        i--;
                        break;
                }
            }
            Console.WriteLine($"Сумма карт: {sumTotalCards}");
            Console.ReadKey();
        }
    }
}
