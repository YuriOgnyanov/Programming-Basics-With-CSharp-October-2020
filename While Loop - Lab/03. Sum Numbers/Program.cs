using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            while (sum < number)
            {
                int curr = int.Parse(Console.ReadLine());
                sum += curr;
            }
            Console.WriteLine(sum);
        }
    }
}
