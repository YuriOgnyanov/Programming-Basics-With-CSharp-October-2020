using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalBalance = 0;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "NoMoreMoney")
                {
                    break;
                }
                double paymant = double.Parse(input);
                if (paymant <= 0)
                {
                    Console.WriteLine($"Invalid operation!");
                    break;
                }
                else
                {
                    totalBalance += paymant;
                    Console.WriteLine($"Increase: {paymant:F2}");

                }
            }
            Console.WriteLine($"Total: {totalBalance:F2}");
        }
    }
}
