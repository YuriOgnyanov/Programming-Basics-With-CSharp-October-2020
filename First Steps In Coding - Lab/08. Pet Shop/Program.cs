using System;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Броят на кучетата – цяло число в интервала[0… 100]
            int numOfDog = int.Parse(Console.ReadLine());
            //2.Броят на останалите животни - цяло число в интервала[0… 100]
            int numOfDefferentAnimal = int.Parse(Console.ReadLine());

            double foodForDog = numOfDog * 2.50;
            double foodForDifferentAnimal = numOfDefferentAnimal * 4;
            double totalPrice = foodForDog + foodForDifferentAnimal;
            Console.WriteLine($"{totalPrice} lv.");


        }
    }
}
