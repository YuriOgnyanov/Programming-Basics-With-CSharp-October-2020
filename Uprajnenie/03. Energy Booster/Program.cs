using System;

namespace _03._Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Плод - текст с възможности: "Watermelon", "Mango", "Pineapple" или "Raspberry"
           string fruit = Console.ReadLine();
            //2.Размерът на сета -текст с възможности: "small" или "big"
            string sets = Console.ReadLine();
            //3.Брой на поръчаните сетове - цяло число в интервала[1 … 10000]
            int quantity = int.Parse(Console.ReadLine());

            double fruitPrice = 0;
            double sizeNumb = 0;

            if (sets == "small")
            {
                if (fruit == "Watermelon")
                {
                    sizeNumb = 2;
                    fruitPrice = 56;
                }
                else if (fruit == "Mango")
                {
                    sizeNumb = 2;
                    fruitPrice = 36.66;
                }
                else if (fruit == "Pineapple")
                {
                    sizeNumb = 2;
                    fruitPrice = 42.10;
                }
                else if (fruit == "Raspberry")
                {
                    sizeNumb = 2;
                    fruitPrice = 20;
                }
            }
            else if (sets == "big")
            {
                if (fruit == "Watermelon")
                {
                    sizeNumb = 5;
                    fruitPrice = 28.70;
                }
                else if (fruit == "Mango")
                {
                    sizeNumb = 5;
                    fruitPrice = 19.60;
                }
                else if (fruit == "Pineapple")
                {
                    sizeNumb = 5;
                    fruitPrice = 24.80;
                }
                else if (fruit == "Raspberry")
                {
                    sizeNumb = 5;
                    fruitPrice = 15.20;
                }
            }
            double totalPrice = sizeNumb * fruitPrice * quantity;

            if (totalPrice >= 400 && totalPrice <= 1000)
            {
                totalPrice = totalPrice - totalPrice * 0.15;
            }
            else if (totalPrice > 1000)
            {
                totalPrice = totalPrice - totalPrice * 0.50;
            }
            Console.WriteLine($"{totalPrice:F2} lv.");


            
        }
    }
}
