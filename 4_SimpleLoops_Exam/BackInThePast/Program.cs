using System;

namespace BackInThePast
{
    class Program
    {
        static void Main()
        {
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            double neededMoney = 0;
            int yearsInThePast = year - 1800;

            for (int i = 0; i <= yearsInThePast; i++)
            {
                if (i % 2 == 0)
                {
                    neededMoney += 12000.00;
                }
                else
                {
                    neededMoney += 12000.00 + ((18 + i) * 50);
                }
            }

            double difference = Math.Abs(neededMoney - money);

            if (neededMoney <= money)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {difference:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {difference:f2} dollars to survive.");
            }
        }
    }
}
