using System;

namespace StupidPasswordsGenerator
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            char toL = (char)l;

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    for (toL = 'a'; toL <= 'a' + (l-1); toL++)
                    {
                        for (char toL2 = 'a'; toL2 <= 'a' + (l - 1); toL2++)
                        {
                            for (int k = Math.Max(i,j) + 1; k <= n; k++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", i, j, toL, toL2, k);
                            }
                        }
                    }
                }
            }
        }
    }
}
