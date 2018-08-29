using System;

namespace _1_PCStore
{
    class Program
    {
        static void Main()
        {
            double priceCPU = double.Parse(Console.ReadLine());
            double priceGPU = double.Parse(Console.ReadLine());
            double priceRAM = double.Parse(Console.ReadLine());

            int countRAM = int.Parse(Console.ReadLine());

            double discount= double.Parse(Console.ReadLine());

            double moneyNeededCPUandGPU = (priceCPU + priceGPU) - ((priceCPU + priceGPU) * discount);
            double moneyNeededRAM = priceRAM * countRAM;

            double totalMoneyNeeded = (moneyNeededCPUandGPU + moneyNeededRAM) * 1.57;

            Console.WriteLine($"Money needed - {totalMoneyNeeded:f2} leva.");
        }
    }
}
