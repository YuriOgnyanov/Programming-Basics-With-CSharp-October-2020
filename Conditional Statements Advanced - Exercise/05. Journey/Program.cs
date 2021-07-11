using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред – Бюджет, реално число в интервала[10.00...5000.00].
            double budget = double.Parse(Console.ReadLine());
            //•	Втори ред –  Един от двата възможни сезона: „summer” или “winter”
            string season = Console.ReadLine();
            double totalMoney = 0;
            if (budget <= 100)
            {
                if (season == "summer")
                {
                    totalMoney = budget * 0.30;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {totalMoney:F2}");
                }
                else
                {
                    totalMoney = budget * 0.70;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {totalMoney:F2}");
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    totalMoney = budget * 0.40;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {totalMoney:F2}");
                }
                else
                {
                    totalMoney = budget * 0.80;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {totalMoney:F2}");
                }
            }
            else
            {
                totalMoney = budget * 0.90;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {totalMoney:F2}");
            }
        }
    }
}
