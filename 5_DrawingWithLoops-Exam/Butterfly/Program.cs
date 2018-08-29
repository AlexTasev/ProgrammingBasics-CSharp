using System;

namespace Butterfly
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            // Upper Part
            for (int row = 1; row <= n-2; row++)
            {
                string wings = String.Empty;
                wings = row % 2 == 1 ? new string('*', n - 2) : new string('-', n - 2);
                Console.WriteLine("{0}\\ /{0}", wings);
            }

            // Middle part
            string spaces = new string(' ', n - 1);
            Console.WriteLine($"{spaces}@{spaces}");

            // Down part
            for (int row = 1; row <= n - 2; row++)
            {
                string wings = String.Empty;
                wings = row % 2 == 1 ? new string('*', n - 2) : new string('-', n - 2);
                Console.WriteLine("{0}/ \\{0}", wings);
            }
        }
    }
}
