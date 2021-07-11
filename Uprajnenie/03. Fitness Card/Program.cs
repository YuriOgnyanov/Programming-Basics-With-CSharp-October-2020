using System;

namespace _03._Fitness_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            // Сумата, с която разполагаме - реално число в интервала[10.00…1000.00]
            double budget = double.Parse(Console.ReadLine());
            // Пол - символ('m' за мъж и 'f' за жена)
            char gender = char.Parse(Console.ReadLine());
            // Възраст - цяло число в интервала[5…105]
            int age = int.Parse(Console.ReadLine());
            // Спорт - текст(една от възможностите в таблицата)
            string sport = Console.ReadLine();
            double cardPrice = 0;

            switch (gender)
            {
                case 'm':
                    if (sport == "Gym")
                    {
                        cardPrice = 42;
                    }
                    else if (sport == "Boxing")
                    {
                        cardPrice = 41;
                    }
                    else if (sport == "Yoga")
                    {
                        cardPrice = 45;
                    }
                    else if (sport == "Zumba")
                    {
                        cardPrice = 34;
                    }
                    else if (sport == "Dances")
                    {
                        cardPrice = 51;
                    }
                    else if (sport == "Pilates")
                    {
                        cardPrice = 39;
                    }
                    if (age <= 19)
                    {
                        cardPrice *= 0.80;
                    }
                    break;
                case 'f':
                    if (sport == "Gym")
                    {
                        cardPrice = 35;
                    }
                    else if (sport == "Boxing")
                    {
                        cardPrice = 37;
                    }
                    else if (sport == "Yoga")
                    {
                        cardPrice = 42;
                    }
                    else if (sport == "Zumba")
                    {
                        cardPrice = 31;
                    }
                    else if (sport == "Dances")
                    {
                        cardPrice = 53;
                    }
                    else if (sport == "Pilates")
                    {
                        cardPrice = 37;
                    }
                    if (age <= 19)
                    {
                        cardPrice *= 0.80;
                    }
                    break;

            }

            if (cardPrice <= budget)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                double money = cardPrice - budget; 
                Console.WriteLine($"You don't have enough money! You need ${money:F2} more.");
            }








        }
    }
}
