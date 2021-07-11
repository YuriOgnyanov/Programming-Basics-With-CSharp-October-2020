using System;

namespace _04._Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());
            int number = 1;
            while (number <= target)
            {
                Console.WriteLine(number);
                number = number * 2 + 1;
            }
        }
    }
}
