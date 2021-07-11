using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Premiere = 12.00;
            const double Normal = 7.50;
            const double Discount = 5.00;

            string typeOfProject = Console.ReadLine();
            int numOfRows = int.Parse(Console.ReadLine());
            int colonums = int.Parse(Console.ReadLine());

            double income = 0;

            switch (typeOfProject)
            {
                case "Premiere":
                    income = numOfRows * colonums * Premiere;
                    break;
                case "Normal":
                    income = numOfRows * colonums * Normal;
                    break;
                case "Discount":
                    income = numOfRows * colonums * Discount;
                    break;
            }
            Console.WriteLine($"{income:f2} leva", income);
        }
    }
}
