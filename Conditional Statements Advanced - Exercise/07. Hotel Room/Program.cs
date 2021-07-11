using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	На първия ред е месецът – May, June, July, August, September или October
            string mounth = Console.ReadLine();
            //•	На втория ред е броят на нощувките – цяло число в интервала[0... 200]
            int numOfNights = int.Parse(Console.ReadLine());
            double priceForStudio = 0;
            double priceForApartment = 0;

            switch (mounth)
            {
                case "May":
                case "October":
                    priceForStudio = 50;
                    priceForApartment = 65;

                    if (numOfNights > 7 && numOfNights < 14)
                    {
                        priceForStudio -= priceForStudio * 0.05;
                    }
                    else if (numOfNights > 14)
                    {
                        priceForStudio -= priceForStudio * 0.30;
                        priceForApartment -= priceForApartment * 0.10;
                    }
                    break;
                case "June":
                case "September":
                    priceForStudio = 75.20;
                    priceForApartment = 68.70;
                    if (numOfNights > 14)
                    {
                        priceForStudio -= priceForStudio * 0.20;
                        priceForApartment -= priceForApartment * 0.10;
                    }
                    break;
                case "July":
                case "August":
                    priceForStudio = 76;
                    priceForApartment = 77;
                    if (numOfNights > 14)
                    {
                        priceForApartment -= priceForApartment * 0.10;


                    }
                    break;
            }
            double totalPriceStudio = priceForStudio * numOfNights;
            double totalPriceApartment = priceForApartment * numOfNights;



            Console.WriteLine($"Apartment: {totalPriceApartment:F2} lv.");
            Console.WriteLine($"Studio: {totalPriceStudio:F2} lv.");
        }
    }
}
