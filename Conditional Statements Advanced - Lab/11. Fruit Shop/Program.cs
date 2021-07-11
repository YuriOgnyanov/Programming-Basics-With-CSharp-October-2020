using System;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //banana / apple / orange / grapefruit / kiwi / pineapple / grapes
            string fruit = Console.ReadLine();
            //Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;
            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            price = quantity * 2.50;
                            break;
                        case "apple":
                            price = quantity * 1.20;
                            break;
                        case "orange":
                            price = quantity * 0.85;
                            break;
                        case "grapefruit":
                            price = quantity * 1.45;
                            break;
                        case "kiwi":
                            price = quantity * 2.70;
                            break;
                        case "pineapple":
                            price = quantity * 5.50;
                            break;
                        case "grapes":
                            price = quantity * 3.85;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;

                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            price = quantity * 2.70;
                            break;
                        case "apple":
                            price = quantity * 1.25;
                            break;
                        case "orange":
                            price = quantity * 0.90;
                            break;
                        case "grapefruit":
                            price = quantity * 1.60;
                            break;
                        case "kiwi":
                            price = quantity * 3.00;
                            break;
                        case "pineapple":
                            price = quantity * 5.60;
                            break;
                        case "grapes":
                            price = quantity * 4.20;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
