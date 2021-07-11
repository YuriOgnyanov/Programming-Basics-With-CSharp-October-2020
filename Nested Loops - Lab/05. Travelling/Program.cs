using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string country = Console.ReadLine();
                if (country == "End")
                {
                    break;
                }
                double budget = double.Parse(Console.ReadLine());
                double savedMoney = 0;
                while (savedMoney < budget)
                {
                    double money = double.Parse(Console.ReadLine());
                    savedMoney += money;
                }
                Console.WriteLine($"Going to {country}!");

            }
        }
    }
}
