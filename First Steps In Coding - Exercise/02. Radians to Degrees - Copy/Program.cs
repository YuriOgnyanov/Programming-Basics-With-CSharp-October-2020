using System;

namespace _02._Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());

            double degree = rad * 180 / Math.PI;

            Console.WriteLine(Math.Round(degree));


        }
    }
}
