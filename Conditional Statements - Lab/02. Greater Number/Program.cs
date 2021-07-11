using System;

namespace _02._Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());

            int isBigger = Math.Max(num, num1);
            Console.WriteLine(isBigger);
        }
    }
}
