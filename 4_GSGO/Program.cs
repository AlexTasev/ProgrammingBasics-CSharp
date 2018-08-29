using System;

namespace _4_GSGO
{
    class Program
    {
        static void Main()
        {
            int items = int.Parse(Console.ReadLine());

            int money = int.Parse(Console.ReadLine());

            if (items > 7)
            {
                Console.WriteLine("Sorry, you can't carry so many things!");
            }
            else
            {
                double totalPrice = 0;
                int itemsCount = 0;

                for (int i = 0; i < items; i++)
                {
                    string weapons = Console.ReadLine().ToLower();

                    switch (weapons)
                    {
                        case "ak47": totalPrice += 2700; itemsCount += 1; break;
                        case "awp": totalPrice += 4750; itemsCount += 1; break;
                        case "sg553": totalPrice += 3500; itemsCount += 1; break;
                        case "grenade": totalPrice += 300; itemsCount += 1; break;
                        case "flash": totalPrice += 250; itemsCount += 1; break;
                        case "glock": totalPrice += 500; itemsCount += 1; break;
                        case "bazooka": totalPrice += 5600; itemsCount += 1; break;
                    }
                }

                double difference = Math.Abs(money - totalPrice);

                if (money > totalPrice)
                {
                    Console.WriteLine($"You bought all {itemsCount} items! Get to work and defeat the bomb!");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {difference} more money.");
                }
            }
        }
    }
}