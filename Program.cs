using System;

namespace _1_Problem
{
    class Program
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = length * width * height;            // in cm

            double volInL = volume / 1000.0;
            double percSand = percent / 100.0;

            double freeVol = volInL - (volInL * percSand);

            Console.WriteLine($"{freeVol:f3}");
        }
    }
}
