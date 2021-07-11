using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int evenNumbersSum = 0;
            int oddNumbersSum = 0;

            for (int i = 1; i <= number; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenNumbersSum += currNumber;
                }
                else
                {
                    oddNumbersSum += currNumber;
                }
            }
            ;
            if (evenNumbersSum == oddNumbersSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenNumbersSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(evenNumbersSum - oddNumbersSum)}");
            }
        }
    }
}
