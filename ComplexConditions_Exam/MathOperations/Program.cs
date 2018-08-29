using System;


namespace MathOperations
{
    class Program
    {
        static void Main()
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string oper = Console.ReadLine();

            double result = 0.0;
            string type = "";


            if (oper == "+" || oper == "-" || oper == "*")
            {
                if (oper == "+")
                {
                    result = n1 + n2;
                }
                else if (oper == "-")
                {
                    result = n1 - n2;
                }
                else if (oper == "*")
                {
                    result = n1 * n2;
                }
                if (result % 2 == 0)
                {
                    type = "even";
                }
                else
                {
                    type = "odd";
                }
                Console.WriteLine($"{n1} {oper} {n2} = {result} - {type}");
            }
            else if (oper == "/" && n2 != 0)
            {
                result = n1 / n2;
                Console.WriteLine($"{n1} {oper} {n2} = {result:f2}");
            }
            else if (oper == "/" && n2 == 0)
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
            else if (oper == "%" && n2 != 0)
            {
                result = n1 % n2;
                Console.WriteLine($"{n1} {oper} {n2} = {result}");
            }
            else if (oper == "%" && n2 == 0)
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
        }
    }
}
