using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int minNum = int.MaxValue;
            while (true)
            {
                string input = Console.ReadLine();
                if (minNum > number)
                {
                    minNum = number;
                }
                if (input == "Stop")
                {
                    break;
                }
                number = int.Parse(input);
            }
            Console.WriteLine(minNum);
        }
    }
}
