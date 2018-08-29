using System;

namespace _1_Travel
{
    class Program
    {
        static void Main()
        {
            double distanceS = double.Parse(Console.ReadLine());
            double speedOfTruck = double.Parse(Console.ReadLine());
            double diffOfSpeeds = double.Parse(Console.ReadLine());

            double speedOfCar = speedOfTruck + (diffOfSpeeds * 3.6);

            double timeOfTruck = Math.Ceiling(distanceS / speedOfTruck);
            double timeOfCar = Math.Ceiling(distanceS / speedOfCar);

            Console.WriteLine($"The truck arrived after {timeOfTruck} hours");
            Console.WriteLine($"The car arrived after {timeOfCar} hours");
        }
    }
}
