using System;

namespace _07._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Името на архитекта -текст
            string name = Console.ReadLine();
            //2.Брой на проектите -цяло число в интервала[0… 100]
            int numOfProject = int.Parse(Console.ReadLine());

            int needHours = numOfProject * 3;
            Console.WriteLine($"The architect {name} will need {needHours} hours to complete {numOfProject} project/s.");

        }
    }
}
