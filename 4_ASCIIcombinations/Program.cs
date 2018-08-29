using System;

namespace _4_ASCIIcombinations
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int nextSymbol = 0;
            int maxSum = 0;

            int sumDigits = 0;
            int sumCapsL = 0;
            int sumSmallL = 0;
            int sumOthers = 0;

            string ofChars = "";


            for (int i = 0; i <= n; i++)
            { 
                char currentSymbol = char.Parse(Console.ReadLine());

                nextSymbol = (int)currentSymbol;

                if (currentSymbol >= 'a'&& currentSymbol <= 'z')
                {
                    sumDigits += nextSymbol;

                    if (sumDigits > maxSum)
                    {
                        sumDigits = maxSum;
                        ofChars += currentSymbol;

                    }
                }
                else if (nextSymbol >= 65 && nextSymbol <= 90)
                {
                    sumCapsL += nextSymbol;

                    if (sumCapsL > maxSum)
                    {
                        sumCapsL = maxSum;
                    }
                }
                else if (nextSymbol >= 97 && nextSymbol <= 122)
                {
                    sumSmallL += nextSymbol;

                    if (sumSmallL > maxSum)
                    {
                        sumSmallL = maxSum;
                    }
                }
                else
                {
                    sumOthers += nextSymbol;

                    if (sumOthers > maxSum)
                    {
                        sumOthers = maxSum;
                    }
                }
            }

            Console.WriteLine($"Biggest ASCII sum is:{maxSum}");
        }
    }
}
