using System;

namespace _08._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int classRoom = 1;
            double gradesSum = 0;
            int excluded = 0;
            bool isExppell = false;
            while (classRoom <= 12)
            {
                double grades = double.Parse(Console.ReadLine());
                if (grades < 4.00)
                {
                    excluded++;
                    if (excluded > 1)
                    {
                        isExppell = true;
                        break;
                    }
                    continue;
                }


                gradesSum += grades;
                classRoom++;

            }
            if (isExppell)
            {
                Console.WriteLine($"{name} has been excluded at {classRoom} grade");
            }
            else
            {
                Console.WriteLine($"{name} graduated. Average grade: {gradesSum / 12:F2}");
            }
        }
    }
}
