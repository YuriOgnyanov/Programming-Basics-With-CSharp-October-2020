using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	N1 – цяло число в интервала[0...40 000]
            double number1 = int.Parse(Console.ReadLine());
            //•	N2 – цяло число в интервала[0...40 000]
            double number2 = int.Parse(Console.ReadLine());
            //•	Оператор – един символ измежду: „+“, „-“, „*“, „/“, „%“
            char symbol = char.Parse(Console.ReadLine());
            double result = 0;

            if (symbol == '+')
            {
                result = number1 + number2;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} {symbol} {number2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{number1} {symbol} {number2} = {result} - odd");
                }
            }
            else if (symbol == '-')
            {
                result = number1 - number2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} {symbol} {number2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{number1} {symbol} {number2} = {result} - odd");
                }
            }
            else if (symbol == '*')
            {
                result = number1 * number2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} {symbol} {number2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{number1} {symbol} {number2} = {result} - odd");
                }
            }
            else if (symbol == '/')
            {
                if (number2 != 0)
                {
                    result = number1 / number2;
                    Console.WriteLine($"{number1} {symbol} {number2} = {result:F2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {number1} by zero");
                }
            }
            else if (symbol == '%')
            {
                if (number2 != 0)
                {
                    result = number1 % number2;
                    Console.WriteLine($"{number1} {symbol} {number2} = {result}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {number1} by zero");
                }
            }
        }
    }
}
