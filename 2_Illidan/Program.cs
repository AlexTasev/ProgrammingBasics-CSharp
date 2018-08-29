using System;

namespace _2_Illidan
{
    class Program
    {
        static void Main()
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int powerOnePerson= int.Parse(Console.ReadLine());
            int healthOfIllidan= int.Parse(Console.ReadLine());

            int powerOfThegroup = peopleCount * powerOnePerson;
            int difference = Math.Abs(powerOfThegroup - healthOfIllidan);

            if (powerOfThegroup > healthOfIllidan)
            {
                Console.WriteLine($"Illidan has been slain! You defeated him with {difference} points.");
            }
            else
            {
                Console.WriteLine($"You are not prepared! You need {difference} more points.");
            }
        }
    }
}
