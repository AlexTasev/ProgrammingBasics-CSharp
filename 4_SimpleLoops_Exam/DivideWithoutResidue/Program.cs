using System;

namespace DivideWithoutResidue
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int countP1 = 0;
            int countP2 = 0;
            int countP3 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    countP1 += 1;
                }
                if (num % 3 == 0)
                {
                    countP2 += 1;
                }
                if (num % 4 == 0)
                {
                    countP3 += 1;
                }
            }

            double resultP1 = (double)countP1 / n * 100;
            double resultP2 = (double)countP2 / n * 100;
            double resultP3 = (double)countP3 / n * 100;

            Console.WriteLine($"{resultP1:f2}%");
            Console.WriteLine($"{resultP2:f2}%");
            Console.WriteLine($"{resultP3:f2}%");
        }
    }
}