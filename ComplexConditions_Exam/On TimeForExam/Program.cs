using System;

namespace On_TimeForExam
{
    class Program
    {
        static void Main()
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int diffTotalMins = (arrivalHour * 60 + arrivalMinutes) - (examHour * 60 + examMinutes);    //hours and minutes in Minutes
            int diffInHours = Math.Abs(diffTotalMins / 60);                 // in hours
            int diffInMins = Math.Abs(diffTotalMins % 60);                  // in Minutes

            if (diffTotalMins > 0)
            {
                Console.WriteLine("Late");
            }
            else if (diffTotalMins >= -30)
            {
                Console.WriteLine("On time");
            }
            else
            {
                Console.WriteLine("Early");
            }

            if (diffTotalMins >= 60)
            {
                Console.WriteLine($"{diffInHours}:{diffInMins:d2} hours after the start");
            }
            else if (diffTotalMins > 0)
            {
                Console.WriteLine($"{diffInMins} minutes after the start");
            }

            if (diffTotalMins <= -60)
            {
                Console.WriteLine($"{diffInHours}:{diffInMins:d2}hours before the start");
            }
            else if (diffTotalMins < 0)
            {
                Console.WriteLine($"{diffInMins} minutes before the start");
            }
        }
    }
}