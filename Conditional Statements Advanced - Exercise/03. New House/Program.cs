using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            const double rosesPrice = 5;
            const double dahliasPrice = 3.80;
            const double tulipsPrice = 2.80;
            const double narcissusPrice = 3;
            const double gladiolus = 2.50;

            //•	Вид цветя -текст с възможности -"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            string flowers = Console.ReadLine();
            //•	Брой цветя -цяло число в интервала[10…1000]
            int numOfFlowers = int.Parse(Console.ReadLine());
            //•	Бюджет - цяло число в интервала[50…2500]
            int budget = int.Parse(Console.ReadLine());

            double totalMoney = 0;

            switch (flowers)
            {
                case "Roses":
                    totalMoney = numOfFlowers * rosesPrice;
                    if (numOfFlowers > 80)
                    {
                        totalMoney = totalMoney - totalMoney * 0.10;
                    }
                    break;
                case "Dahlias":
                    totalMoney = numOfFlowers * dahliasPrice;
                    if (numOfFlowers > 90)
                    {
                        totalMoney -= totalMoney * 0.15;
                    }
                    break;
                case "Tulips":
                    totalMoney = numOfFlowers * tulipsPrice;
                    if (numOfFlowers > 80)
                    {
                        totalMoney -= totalMoney * 0.15;
                    }
                    break;
                case "Narcissus":
                    totalMoney = numOfFlowers * narcissusPrice;
                    if (numOfFlowers < 120)
                    {
                        totalMoney += totalMoney * 0.15;
                    }
                    break;
                case "Gladiolus":
                    totalMoney = numOfFlowers * gladiolus;
                    if (numOfFlowers < 80)
                    {
                        totalMoney += totalMoney * 0.20;
                    }
                    break;

            }
            if (budget < totalMoney)
            {
                double leftmoney = totalMoney - budget;
                Console.WriteLine($"Not enough money, you need {leftmoney:F2} leva more.");
            }
            else
            {
                double neededMOney = budget - totalMoney;
                Console.WriteLine($"Hey, you have a great garden with {numOfFlowers} {flowers} and {neededMOney:F2} leva left.");
            }
        }
    }
}
