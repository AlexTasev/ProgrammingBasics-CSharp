using System;

namespace Hospital
{
    class Program
    {
        static void Main()
        {
            int daysCount = int.Parse(Console.ReadLine());

            int doctors = 7;
            int treatedPatients = 0;
            int untreatedPatients = 0;

            for (int i = 1; i <= daysCount; i++)
            {
                int patientsPerDay = int.Parse(Console.ReadLine());

                if (i % 3 == 0 && untreatedPatients > treatedPatients)
                {
                    doctors++;
                }

                if (patientsPerDay <= doctors)
                {
                    treatedPatients += patientsPerDay;
                }
                else
                {
                    treatedPatients += doctors;
                    untreatedPatients += patientsPerDay- doctors;
                }
            }

            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
