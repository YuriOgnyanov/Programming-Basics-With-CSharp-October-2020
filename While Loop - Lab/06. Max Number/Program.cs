using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            while (true)
            {
                string input = Console.ReadLine();

                if (maxNum < number)
                {
                    maxNum = number;
                }

                if (input == "Stop")
                {
                    break;
                }
                number = int.Parse(input);



            }
            Console.WriteLine(maxNum);
        }
    }
}
