using System;

namespace Histogram
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int countP1 = 0;
            int countP2 = 0;
            int countP3 = 0;
            int countP4 = 0;
            int countP5 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    countP1 += 1;
                }
                else if (num >= 200 && num < 400)
                {
                    countP2 += 1;
                }
                else if (num >= 400 && num < 600)
                {
                    countP3 += 1;
                }
                else if (num >= 600 && num < 800)
                {
                    countP4 += 1;
                }
                else if (num >= 800)
                {
                    countP5 += 1;
                }
            }

            double percentP1 = (double)countP1 / n * 100;
            double percentP2 = (double)countP2 / n * 100;
            double percentP3 = (double)countP3 / n * 100;
            double percentP4 = (double)countP4 / n * 100;
            double percentP5 = (double)countP5 / n * 100;

            Console.WriteLine("{0:f2}%", percentP1);
            Console.WriteLine("{0:f2}%", percentP2);
            Console.WriteLine("{0:f2}%", percentP3);
            Console.WriteLine("{0:f2}%", percentP4);
            Console.WriteLine("{0:f2}%", percentP5);
        }
    }
}
