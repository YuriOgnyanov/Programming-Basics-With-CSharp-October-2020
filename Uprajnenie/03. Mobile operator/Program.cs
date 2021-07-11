using System;

namespace _03._Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Срок на договор – текст – "one", или "two"
            string termYears = Console.ReadLine();
            //2.Тип на договор – текст – "Small", "Middle", "Large"или "ExtraLarge"
            string typeOfTerm = Console.ReadLine();
            //3.Добавен мобилен интернет – текст – "yes" или "no"
            string mobilrInternet = Console.ReadLine();
            //4.Брой месеци за плащане - цяло число в интервала[1 … 24]
            int numOfMonth = int.Parse(Console.ReadLine());
            double priceForYears = 0;


            switch (termYears)
            {
                case "one":
                    if (typeOfTerm == "Small")
                    {
                        priceForYears = 9.98;
                    }
                    else if (typeOfTerm == "Middle")
                    {
                        priceForYears = 18.99;
                    }
                    else if (typeOfTerm == "Large")
                    {
                        priceForYears = 25.98;
                    }
                    else if (typeOfTerm == "ExtraLarge")
                    {
                        priceForYears = 35.99;
                    }
                    break;
                case "two":
                    if (typeOfTerm == "Small")
                    {
                        priceForYears = 8.58;
                    }
                    else if (typeOfTerm == "Middle")
                    {
                        priceForYears = 17.09;
                    }
                    else if (typeOfTerm == "Large")
                    {
                        priceForYears = 23.59;
                    }
                    else if (typeOfTerm == "ExtraLarge")
                    {
                        priceForYears = 31.79;
                    }
                    break;
            }
            if (mobilrInternet == "yes")
            {
                if (priceForYears <= 10)
                {
                    priceForYears += 5.50;
                }
                else if (priceForYears <= 30)
                {
                    priceForYears += 4.35;
                }
                else if (priceForYears > 30)
                {
                    priceForYears += 3.85;
                }
            }
            if (termYears == "two")
            {
                priceForYears = priceForYears - priceForYears * 0.0375;
            }
            double totalPrice = numOfMonth * priceForYears;
            Console.WriteLine($"{totalPrice:F2} lv.");


        }
    }
}
