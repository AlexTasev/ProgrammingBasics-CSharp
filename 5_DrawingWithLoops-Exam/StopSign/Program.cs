using System;

namespace StopSign
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            // First Row
            string dotsFirstRow = new string('.', n + 1);
            string dashesFirstRow = new string('_', 2 * n + 1);
            Console.WriteLine("{0}{1}{0}", dotsFirstRow, dashesFirstRow);

            int dotsCount = n;
            int dishesCount = 2 * n - 1;

            // Upper Part
            for (int row = 1; row <= n; row++)
            {
                string dots = new string('.', dotsCount);
                string dishes = new string('_', dishesCount);
                Console.WriteLine(@"{0}//{1}\\{0}", dots, dishes);
                dotsCount--;
                dishesCount += 2;
            }

            // Stop Row
            int dishesCountLR = dishesCount / 2 - 2;
            string dishesLR = new string('_', dishesCountLR);
            Console.WriteLine(@"//{0}STOP!{0}\\", dishesLR);

            // Down Part
            for (int row = 1; row <= n; row++)
            {
                string dots = new string('.', dotsCount);
                string dishes = new string('_', dishesCount);
                Console.WriteLine(@"{0}\\{1}//{0}", dots, dishes);
                dotsCount++;
                dishesCount -= 2;
            }
        }
    }
}
