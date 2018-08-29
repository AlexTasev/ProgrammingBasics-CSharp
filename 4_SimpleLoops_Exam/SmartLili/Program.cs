using System;

namespace SmartLili
{
    class Program
    {
        static void Main()
        {
            int yearsN = int.Parse(Console.ReadLine());
            double priceWM = double.Parse(Console.ReadLine());
            double priceToyP = double.Parse(Console.ReadLine());

            double savings = 0;
            double increase = 0;
            double countToys = 0;

            for (int i = 1; i <= yearsN; i++)
            {
                if (i % 2 == 0 && i == 2)
                {
                    savings = 10;
                }
                else if (i % 2 == 0 && i != 1)
                {
                    increase += 10;
                    savings += increase + 10;
                }
                else
                {
                    countToys += 1;
                }
            }

            savings = savings + (countToys * priceToyP) - (yearsN/2);

            double result = Math.Abs(savings - priceWM);

            if (savings >= priceWM)
            {
                Console.WriteLine($"Yes! {result:f2}");
            }
            else
            {
                Console.WriteLine($"No! {result:f2}");
            }
        }
    }
}