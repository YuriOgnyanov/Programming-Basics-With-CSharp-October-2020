using System;

namespace _02._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string input = Console.ReadLine();
            while (true)
            {
                if (input == password)
                {
                    Console.WriteLine($"Welcome {username}!");
                    break;
                }
                else
                {
                    input = Console.ReadLine();
                }


            }
        }
    }
}
