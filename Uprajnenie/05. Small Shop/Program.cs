using System;

namespace _05._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Първи ред - дни за престой -цяло число в интервала[0...365]
            int days = int.Parse(Console.ReadLine());
            // Втори ред - вид помещение - &quot; room for one person&quot;, &quot; apartment & quot; или & quot; president apartment&quot;
            string typoOfRoom = Console.ReadLine();
            // Трети ред - оценка - &quot; positive & quot; или & quot; negative & quot;
            string evaluation = Console.ReadLine();
            double priceForNight = 0;
            double discount = 0;

            switch (typoOfRoom)
            {
                case "room for one person":
                    priceForNight = 18;
                    break;
                case "apartment":
                    priceForNight = 25;
                    if (days < 10)
                    {
                        discount = 0.30;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        discount = 0.35;
                    }
                    else
                    {
                        discount = 0.50;
                    }
                    break;
                case "president apartment":
                    priceForNight = 35;
                    if (days < 10)
                    {
                        discount = 0.10;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        discount = 0.15;
                    }
                    else
                    {
                        discount = 0.20;
                    }
                    break;
                    
            }
            double totalPrice = priceForNight * (days - 1);
            totalPrice = totalPrice - totalPrice * discount;

            if (evaluation == "positive")
            {
                totalPrice = totalPrice + totalPrice * 0.25;
            }
            else
            {
                totalPrice = totalPrice - totalPrice * 0.10;
            }
            Console.WriteLine($"{totalPrice:F2}");



        }
    }
}
