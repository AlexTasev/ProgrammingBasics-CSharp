using System;

namespace Journey
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            double expenses = 0;
            string type = "";

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season== "summer")
                {
                    expenses = budget * 0.3;
                    type = "Camp";
                }
                else
                {
                    expenses = budget * 0.7;
                    type = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    expenses = budget * 0.4;
                    type = "Camp";
                }
                else
                {
                    expenses = budget * 0.8;
                    type = "Hotel";
                }
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");
                expenses = budget * 0.9;
                type= "Hotel";
            }
            Console.WriteLine($"{type} - {expenses:f2}");
        }
    }
}