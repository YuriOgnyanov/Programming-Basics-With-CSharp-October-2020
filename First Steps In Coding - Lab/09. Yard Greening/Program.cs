using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Кв.метри, които ще бъдат озеленени – реално число в интервала[0.00… 10000.00]
            double meters = double.Parse(Console.ReadLine());
            double priceForMeters = meters * 7.61;
            double discount = priceForMeters * 0.18;
            double totalPrice = priceForMeters - discount;
            Console.WriteLine($"The final price is: {totalPrice} lv.");
            Console.WriteLine($"The final price is: {discount} lv.");
        }
    }
}
