using System;

namespace _03._Easter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {

            //• Първи ред -дестинация - текст с възможности"France", "Italy" или "Germany"
            string destination = Console.ReadLine();
            //• Втори ред -дати, през които си е резервирала екскурзията -текст с възможности "21-23"
            string date = Console.ReadLine();
            //• Трети ред -брой нощувки - цяло число в интервала[1… 100]
            int nights = int.Parse(Console.ReadLine());
            double priceForNight = 0;

            switch (destination)
            {
                case "France":
                    if (date == "21-23")
                    {
                        priceForNight = 30;
                    }
                    else if (date == "24-27")
                    {
                        priceForNight = 35;
                    }
                    else if (date == "28-31")
                    {
                        priceForNight = 40;
                    }
                    break;
                case "Italy":
                    if (date == "21-23")
                    {
                        priceForNight = 28;
                    }
                    else if (date == "24-27")
                    {
                        priceForNight = 32;
                    }
                    else if (date == "28-31")
                    {
                        priceForNight = 39;
                    }
                    break;
                case "Germany":
                    if (date == "21-23")
                    {
                        priceForNight = 32;
                    }
                    else if (date == "24-27")
                    {
                        priceForNight = 37;
                    }
                    else if (date == "28-31")
                    {
                        priceForNight = 43;
                    }
                    break;
            }
            double totalPrice = nights * priceForNight;

            Console.WriteLine($"Easter trip to {destination} : {totalPrice:F2} leva.");
        }
    }
}
