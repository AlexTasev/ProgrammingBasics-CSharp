using System;

namespace TicketForMatch
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            int people = int.Parse(Console.ReadLine());

            double transportCosts = 0;

            if (people >= 1 && people <= 4)
            {
                transportCosts = budget * 0.75;
            }
            else if (people >= 5 && people <= 9)
            {
                transportCosts = budget * 0.60;
            }
            else if (people >= 10 && people <= 24)
            {
                transportCosts = budget * 0.5;
            }
            else if (people >= 25 && people <= 49)
            {
                transportCosts = budget * 0.4;
            }
            else
            {
                transportCosts = budget * 0.25;
            }


            double priceForTicket = 0;

            if (category== "vip")
            {
                priceForTicket = 499.99;
            }
            else if (category == "normal ")
            {
                priceForTicket = 249.99;
            }

            double moneyForTickets = (budget - transportCosts) / people * priceForTicket;

            if (moneyForTickets >= 0)
            {

            }


        }
    }
}
