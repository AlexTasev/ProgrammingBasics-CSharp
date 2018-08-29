using System;

namespace _2_PictureInTheWall
{
    class Program
    {
        static void Main()
        {
            int widthHolе= int.Parse(Console.ReadLine());
            int lenghtHolе= int.Parse(Console.ReadLine());
            int sidePictures= int.Parse(Console.ReadLine());
            int countPictures= int.Parse(Console.ReadLine());

            int areaHole = widthHolе * lenghtHolе;
            int areaPictures = (sidePictures * sidePictures) * countPictures;

            int difference = Math.Abs(areaPictures - areaHole);

            if (areaHole >= areaPictures)
            {
                Console.WriteLine($"The pictures fit in the hole. Hole area is {difference} bigger " +
                    $"than pictures area.");
            }
            else
            {
                Console.WriteLine($"The pictures don't fit in the hole. Picture area is {difference} bigger " +
                    $"than hole area.");
            }
        }
    }
}
