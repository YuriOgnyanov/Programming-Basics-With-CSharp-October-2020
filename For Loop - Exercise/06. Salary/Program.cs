using System;

namespace _06._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            const int facebookFine = 150;
            const int instagramFine = 100;
            const int redditFine = 50;
            //•	Брой отворени табове в браузъра n -цяло число в интервала[1...10]
            int n = int.Parse(Console.ReadLine());
            //•	Заплата - число в интервала[700...1500]
            int salary = int.Parse(Console.ReadLine());


            for (int i = 0; i <= n; i++)
            {
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
                string webSite = Console.ReadLine();
                if (webSite == "Facebook")
                {
                    salary -= facebookFine;
                }
                else if (webSite == "Instagram")
                {
                    salary -= instagramFine;
                }
                else if (webSite == "Reddit")
                {
                    salary -= redditFine;
                }
            }


            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
