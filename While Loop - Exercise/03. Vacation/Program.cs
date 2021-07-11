using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double needMoneyForVacation = double.Parse(Console.ReadLine());
            double avalibleMoney = double.Parse(Console.ReadLine());
            int numDays = 0;
            int spendMoney = 0;

            while (avalibleMoney < needMoneyForVacation && spendMoney < 5)
            {

                string action = Console.ReadLine();
                double moneyToSaveOrSpend = double.Parse(Console.ReadLine());
                numDays++;

                if (action == "save")
                {
                    avalibleMoney += moneyToSaveOrSpend;
                    spendMoney = 0;

                }
                else if (action == "spend")
                {
                    avalibleMoney -= moneyToSaveOrSpend;
                    spendMoney++;
                    if (avalibleMoney < 0)
                    {
                        avalibleMoney = 0;
                    }

                }
            }
            if (spendMoney == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{numDays}");


            }
            if (avalibleMoney >= needMoneyForVacation)
            {
                Console.WriteLine($"You saved the money for {numDays} days.");
            }
        }
    }
}
