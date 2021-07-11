using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchBook = Console.ReadLine();
            string curruntBook = Console.ReadLine();
            int numOfBooks = 0;
            bool isValid = false;
            while (curruntBook != "No More Books")
            {
                if (curruntBook == searchBook)
                {
                    isValid = true;
                    break;
                }
                numOfBooks++;
                curruntBook = Console.ReadLine();
            }
            if (isValid)
            {
                Console.WriteLine($"You checked {numOfBooks} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {numOfBooks} books.");
            }
        }
    }
}
