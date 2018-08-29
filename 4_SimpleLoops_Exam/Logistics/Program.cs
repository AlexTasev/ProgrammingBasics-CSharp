using System;

namespace Logistics
{
    class Program
    {
        static void Main()
        {
            int countLoads = int.Parse(Console.ReadLine());

            double price = 0.00;
            double tones = 0; 
            int microbuses = 0;
            int trucks = 0;
            int trains = 0;

            for (int i = 1; i <= countLoads; i++)
            {
                int currentWeight = int.Parse(Console.ReadLine());

                if (currentWeight <= 3)
                {
                    price += currentWeight * 200;
                    tones += currentWeight;
                    microbuses += currentWeight;
                }
                else if (currentWeight <= 11)
                {
                    price += currentWeight * 175;
                    tones += currentWeight;
                    trucks += currentWeight;
                }
                else
                {
                    price += currentWeight * 120;
                    tones += currentWeight;
                    trains += currentWeight;
                }
            }

            double avaragePrice = price / tones;

            double percMicrobuses = (double)microbuses / tones * 100.00;
            double percTrucks = (double)trucks / tones * 100.00;
            double percTrains = (double)trains / tones * 100.00;


            Console.WriteLine("{0:f2}", avaragePrice);

            Console.WriteLine($"{percMicrobuses:f2}%");
            Console.WriteLine($"{percTrucks:f2}%");
            Console.WriteLine($"{percTrains:f2}%");
        }
    }
}
