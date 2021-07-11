using System;

namespace _13._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред -дни за престой -цяло число в интервала[0...365]
            int daysForStay = int.Parse(Console.ReadLine());
            //•	Втори ред -вид помещение - "room for one person", "apartment" или "president apartment"
            string typeOfRoom = Console.ReadLine();
            //•	Трети ред -оценка - "positive"  или "negative"
            string grade = Console.ReadLine();
            double priceForNight = 0;
            double discount = 0;

            switch (typeOfRoom)
            {
                case "room for one person":
                    priceForNight = 18;
                    break;
                case "apartment":
                    priceForNight = 25;
                    if (daysForStay < 10)
                    {
                        discount = 0.30;
                    }
                    else if (daysForStay >= 10 && daysForStay <= 15)
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
                    if (daysForStay < 10)
                    {
                        discount = 0.10;
                    }
                    else if (daysForStay >= 10 && daysForStay <= 15)
                    {
                        discount = 0.15;
                    }
                    else
                    {
                        discount = 0.20;
                    }
                    break;
            }

            double finalPrice = priceForNight * (daysForStay - 1);
            finalPrice -= finalPrice * discount;

            if (grade == "positive")
            {
                finalPrice += finalPrice * 0.25;
            }
            else
            {
                finalPrice -= finalPrice * 0.10;
            }
            Console.WriteLine($"{finalPrice:F2}");


        }
    }
}
