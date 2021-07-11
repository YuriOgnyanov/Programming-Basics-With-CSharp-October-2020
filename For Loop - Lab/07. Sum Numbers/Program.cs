using System;

namespace _07._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int curr = int.Parse(Console.ReadLine());
                sum += curr;
            }
            Console.WriteLine(sum);
        }
    }
}
