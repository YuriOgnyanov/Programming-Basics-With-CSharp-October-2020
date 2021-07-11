using System;

namespace _09._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            //широчина на свободното пространство -цяло число в интервала[1...1000]
            int width = int.Parse(Console.ReadLine());
            //2.Дължина на свободното пространство - цяло число в интервала[1...1000]
            int lenght = int.Parse(Console.ReadLine());
            //3.Височина на свободното пространство - цяло число в интервала[1...1000]
            int height = int.Parse(Console.ReadLine());

            int total = width * lenght * height;
            int cubic = 0;


            string input = Console.ReadLine();
            while (input != "Done")
            {
                int boxed = int.Parse(input);
                cubic += boxed;
                if (total < cubic)
                {
                    int needed = cubic - total;
                    Console.WriteLine($"No more free space! You need {needed} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine();

            }
            if (input == "Done")
            {
                int left = total - cubic;
                Console.WriteLine($"{left} Cubic meters left.");
            }
        }
    }
}
