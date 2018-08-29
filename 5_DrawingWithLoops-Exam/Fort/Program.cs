using System;

namespace Fort
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            // First Row
            string columnUp = new string('^', n / 2);   //n /2
            string spacesUp = n % 2 == 1 ? new string('_', n- 3) : new string('_', n - 4);
            Console.WriteLine(@"/{0}\{1}/{0}\", columnUp, spacesUp);

            // Middle
            for (int row = 1; row < n - 2; row++)
            {
                string spaces = new string(' ', 2 * n - 2);
                Console.WriteLine($"|{spaces}|");
            }

            // Bottom Part
            string spacesBottom = new string(' ', n / 2 + 1);
            string downDashes = n % 2 == 1 ? new string('_', n - 3) : new string('_', n - 4);
            Console.WriteLine("|{0}{1}{0}|", spacesBottom, downDashes);

            string columnDown = new string('_', n / 2);   //n /2
            string spacesDown = n % 2 == 1 ? new string(' ', n - 3) : new string(' ', n - 4);
            Console.WriteLine(@"\{0}/{1}\{0}/", columnDown, spacesDown);
        }
    }
}