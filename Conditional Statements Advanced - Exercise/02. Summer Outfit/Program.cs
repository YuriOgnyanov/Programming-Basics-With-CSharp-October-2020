using System;

namespace _02._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Градусите - цяло число в интервала[10…42]
            int degree = int.Parse(Console.ReadLine());
            //•	Текст, време от денонощието - с възможности - "Morning", "Afternoon", "Evening
            string timeOfDay = Console.ReadLine();
            switch (timeOfDay)
            {
                case "Morning":
                    if (degree >= 10 && degree <= 18)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your Sweatshirt and Sneakers.");
                    }
                    else if (degree > 18 && degree <= 24)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your Shirt and Moccasins.");
                    }
                    else
                    {
                        Console.WriteLine($"It's {degree} degrees, get your T-Shirt and Sandals.");
                    }
                    break;
                case "Afternoon":
                    if (degree >= 10 && degree <= 18)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your Shirt and Moccasins.");
                    }
                    else if (degree > 18 && degree <= 24)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your T-Shirt and Sandals.");
                    }
                    else
                    {
                        Console.WriteLine($"It's {degree} degrees, get your Swim Suit and Barefoot.");
                    }
                    break;
                case "Evening":
                    if (degree >= 10 && degree <= 18)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your Shirt and Moccasins.");
                    }
                    else if (degree > 18 && degree <= 24)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your Shirt and Moccasins.");
                    }
                    else
                    {
                        Console.WriteLine($"It's {degree} degrees, get your Shirt and Moccasins.");
                    }
                    break;
            }
        }
    }
}
