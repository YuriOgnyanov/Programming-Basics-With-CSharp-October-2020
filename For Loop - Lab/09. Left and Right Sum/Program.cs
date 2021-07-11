using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < number * 2; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());

                if (i < number)
                {
                    leftSum += currNumber;
                }
                else
                {
                    rightSum += currNumber;
                }
            }
            ;
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}
