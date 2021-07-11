using System;

namespace _03._Painting_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            //• Първи ред – размер на яйцата – текст с възможности "Large", "Medium" или "Small"
            string sizeEggs = Console.ReadLine();
            //• Втори ред – цвят на яйцата – текст с възможности "Red", "Green" или "Yellow"
            string colorEggs = Console.ReadLine();
            //• Трети ред – брой партиди – цяло число в интервала[1… 350]
            int numBatches = int.Parse(Console.ReadLine());
            double priceForBatches = 0;

            switch (sizeEggs)
            {
                case "Large":
                    if (colorEggs == "Red")
                    {
                        priceForBatches = 16;
                    }
                    else if (colorEggs == "Green")
                    {
                        priceForBatches = 12;
                    }
                    else if (colorEggs == "Yellow")
                    {
                        priceForBatches = 9;
                    }
                    break;
                case "Medium":
                    if (colorEggs == "Red")
                    {
                        priceForBatches = 13;
                    }
                    else if (colorEggs == "Green")
                    {
                        priceForBatches = 9;
                    }
                    else if (colorEggs == "Yellow")
                    {
                        priceForBatches = 7;
                    }
                    break;
                case "Small":
                    if (colorEggs == "Red")
                    {
                        priceForBatches = 9;
                    }
                    else if (colorEggs == "Green")
                    {
                        priceForBatches = 8;
                    }
                    else if (colorEggs == "Yellow")
                    {
                        priceForBatches = 5;
                    }
                    break;
            }
            double totalPrice = numBatches * priceForBatches;
            double discount = totalPrice - totalPrice * 0.35;

            Console.WriteLine($"{discount:F2} leva.");


        }
    }
}
