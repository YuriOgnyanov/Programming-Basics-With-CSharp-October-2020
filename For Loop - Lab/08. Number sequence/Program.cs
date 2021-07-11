using System;

namespace _08._Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int big = int.MinValue;
            int small = int.MaxValue;
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < small)
                {
                    small = number;
                }
                if (number > big)
                {
                    big = number;
                }
            }
            Console.WriteLine($"Max number: {big}");
            Console.WriteLine($"Min number: {small}");
        }
    }
}
