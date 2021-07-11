using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxnum = int.MinValue;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum = sum + num;
                if (num > maxnum)
                {
                    maxnum = num;

                }
            }
            int numWithoutMaxNum = sum - maxnum;
            if (numWithoutMaxNum == maxnum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxnum}");
            }
            else
            {
                int differentNum = Math.Abs(maxnum - numWithoutMaxNum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {differentNum}");
            }
        }
    }
}
