using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Цената за наем на кораба през пролетта е  3000 лв.
            const int springPrice = 3000;
            //•	Цената за наем на кораба през лятото и есента е  4200 лв.
            const int summerAndOutumPrice = 4200;
            //•	Цената за наем на кораба през зимата е  2600 лв.
            const int winterPrice = 2600;

            //•	Бюджет на групата – цяло число в интервала[1…8000]
            int budget = int.Parse(Console.ReadLine());
            //•	Сезон –  текст: "Spring", "Summer", "Autumn", "Winter"
            string season = Console.ReadLine();
            //•	Брой рибари – цяло число в интервала[4…18]
            int numOfFishers = int.Parse(Console.ReadLine());

            double totalMoney = 0;

            switch (season)
            {
                case "Spring":
                    totalMoney = springPrice;
                    break;
                case "Summer":
                    totalMoney = summerAndOutumPrice;
                    break;
                case "Autumn":
                    totalMoney = summerAndOutumPrice;
                    break;
                case "Winter":
                    totalMoney = winterPrice;
                    break;
            }
            if (numOfFishers <= 6)
            {
                totalMoney -= totalMoney * 0.10;
            }
            else if (numOfFishers >= 7 && numOfFishers <= 11)
            {
                totalMoney -= totalMoney * 0.15;
            }
            else
            {
                totalMoney -= totalMoney * 0.25;
            }

            if (numOfFishers % 2 == 0 && season != "Autumn")
            {
                totalMoney -= totalMoney * 0.05;
            }
            if (budget < totalMoney)
            {
                double leftMoney = totalMoney - budget;
                Console.WriteLine($"Not enough money! You need {leftMoney:F2} leva.");

            }
            else
            {
                double neededMoney = budget - totalMoney;
                Console.WriteLine($"Yes! You have {neededMoney:F2} leva left.");
            }
        }
    }
}
